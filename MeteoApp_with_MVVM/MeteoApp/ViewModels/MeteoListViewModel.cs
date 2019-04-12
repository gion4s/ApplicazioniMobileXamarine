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

            for (var i = 0; i < 10; i++)
            {
                var e = new City
                {
                    ID = i,
                    Name = "Milano"
                };
                CityHolder.updateCityWithName(e);
                Cities.Add(e);
            }
        }
    }
}
