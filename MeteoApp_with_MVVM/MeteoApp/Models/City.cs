using System;

namespace MeteoApp
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double XCoord { get; set; }
        public double YCoord { get; set; }
        public string tempMin { get; set; }
        public string tempMax { get; set; }
        public string actualTemp { get; set; }
        public int weatherID { get; set; }
    }
}
