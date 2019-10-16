using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MeteoApp.Models
{
    public class CityDatabase
    {
        readonly SQLiteAsyncConnection database;

        public CityDatabase()
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CitiesDB.db3");
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<City>().Wait();
        }

        /*
         * Ritorna una lista con tutti gli items.
         */
        public Task<List<City>> GetItemsAsync()
        {
            return database.Table<City>().ToListAsync();
        }

        /*
         * Query con query SQL.
         */
        public Task<List<City>> GetItemsWithWhere(int id)
        {
            return database.QueryAsync<City>("SELECT * FROM [TestItem] WHERE [Id] =?", id);
        }

        /*
         * Salvataggio o update.
         */
        public Task<int> SaveItemAsync(City city)
        {
            if (city.ID == 0)
                return database.UpdateAsync(city);

            return database.InsertAsync(city);
        }

        public Task<int> DeleteItemAsync(City city)
        {
            return database.DeleteAsync(city);
        }
    }
}
