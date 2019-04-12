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
            CityHolder.updateCityWithLatLon(locazioneCorrente);
            Cities.Add(locazioneCorrente);
            for (var i = 1; i < 10; i++)
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
