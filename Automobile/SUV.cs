using System;

namespace Automobile
{
    public class SUV : Automobile
    {
        public SUV(string make, string model, int year, string vin, string color, AutoType type) : base(make, model, year, vin, color, AutoType.SUV)
        {

        }
    }
}
