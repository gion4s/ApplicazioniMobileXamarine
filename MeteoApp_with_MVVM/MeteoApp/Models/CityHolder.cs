using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace MeteoApp.Models
{
    public static class CityHolder
    {
        const string APIKEY = "cc3c629069bce6858e29dedf0f73213a";


        private static List<City> cities = new List<City>();

        private static HttpClient httpClient= new HttpClient();



        public static async void updateCityWithName(City c)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=" + c.Name + "&units=metric&appid=" + APIKEY;

            var hTTPClient = new HttpClient();

            var response = await hTTPClient.GetAsync(new Uri(url));

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();


                Debug.WriteLine(content);


                string min = JObject.Parse(content)["main"]["temp_min"].ToObject<string>();
                string max = JObject.Parse(content)["main"]["temp_max"].ToObject<string>();
                string temp = JObject.Parse(content)["main"]["temp"].ToObject<string>();
                int weatherID= JObject.Parse(content)["weather"][0]["id"].ToObject<int>();
                c.tempMin = min;
                c.tempMax = max;
                c.actualTemp = temp;
                c.weatherID = weatherID;
                Debug.WriteLine("Min: " + min);
                Debug.WriteLine("Max: " + max);
                Debug.WriteLine("Temp: " + temp);
                Debug.WriteLine("ID: " + weatherID);

                Debug.WriteLine("City: " + c.Name);

            }

            // Use one of the following lines

            await Task.Delay(1);
        }

        public static async void updateCityWithLatLon(City c)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?lat=" + c.XCoord + "&lon=" + c.YCoord + "&units=metric&appid=" + APIKEY;

            var hTTPClient = new HttpClient();

            var response = await hTTPClient.GetAsync(new Uri(url));

            if (response.IsSuccessStatusCode)
            {
                string content = await response.Content.ReadAsStringAsync();


                Debug.WriteLine(content);


                string min = JObject.Parse(content)["main"]["temp_min"].ToObject<string>();
                string max = JObject.Parse(content)["main"]["temp_max"].ToObject<string>();
                string temp = JObject.Parse(content)["main"]["temp"].ToObject<string>();
                int weatherID = JObject.Parse(content)["weather"][0]["id"].ToObject<int>();
                c.tempMin = min;
                c.tempMax = max;
                c.actualTemp = temp;
                c.weatherID = weatherID;
                Debug.WriteLine("Min: " + min);
                Debug.WriteLine("Max: " + max);
                Debug.WriteLine("Temp: " + temp);
                Debug.WriteLine("ID: " + weatherID);

                Debug.WriteLine("City: " + c.Name);

            }

            // Use one of the following lines

            await Task.Delay(1);
        }
    }
}
