using System;
using MeteoApp.Models;
using System.Diagnostics;

namespace MeteoApp
{
    public class MeteoItemViewModel : BaseViewModel
    {
        City _city;

        public City City
        {
            get { return _city;  }
            set
            {
                _city = value;
                OnPropertyChanged();
            }
        }

        public MeteoItemViewModel(City city)
        {
            City = city;
        }
    }
}