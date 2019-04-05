using System;
using System.Collections.ObjectModel;

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
                var c = new City
                {
                    ID = i,
                    Name = "City " + i
                };

                Cities.Add(c);
            }
        }
    }
}
