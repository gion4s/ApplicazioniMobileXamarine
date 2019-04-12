using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MeteoApp.Models;

namespace MeteoApp
{
    public class MeteoListViewModel : BaseViewModel
    {
        ObservableCollection<City> _cities;

        public ObservableCollection<City> Cities
        {
            get { return _cities; }
            set
            {
                _cities = value;
                OnPropertyChanged();
            }
        }

        public MeteoListViewModel()
        {
            Cities = new ObservableCollection<City>();
            var locazioneCorrente = new City
            {
                ID = 0,
                Name = "CurrentLocation"
            };

            AddAsyncLatLon(locazioneCorrente);

            for (var i = 1; i < 10; i++)
            {
                var e = new City
                {
                    ID = i,
                    Name = "Milano"
                };
                AddAsyncName(e);
            }
        }


        public void addCityToList(String city)
        {
            var c = new City
            {
                ID = 15,
                Name = city
            };
            AddAsyncName(c);
        }
        public async void AddAsyncLatLon(City locazioneCorrente)
        {
            await CityHolder.updateCityWithLatLon(locazioneCorrente);
            Cities.Insert(0, locazioneCorrente);
        }
        public async void AddAsyncName(City city)
        {
            await CityHolder.updateCityWithName(city);
            Cities.Add(city);
        }
    }
}
