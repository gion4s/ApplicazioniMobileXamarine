using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MeteoApp
{
    public partial class MeteoItemPage : ContentPage
    {
        public MeteoItemPage()
        {
            InitializeComponent();

            var temp = BindingContext as MeteoItemViewModel;
            Console.WriteLine(temp);

            /*switch (temp.City.weatherID / 100)
            {
                case 2:
                    MainImage.Source = "thunderstorm.png";
                    break;
                case 3:
                    MainImage.Source = "rain.png";
                    break;
                case 5:
                    MainImage.Source = "snowerrain.png";
                    break;
                case 6:
                    MainImage.Source = "mist.png";
                    break;
                case 7:
                    MainImage.Source = "snow.png";
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }*/
        }
    }
}
