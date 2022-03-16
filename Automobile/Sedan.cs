using System;

namespace Automobile
{
    public class Sedan : Automobile
    {
        public Sedan(string make, string model, int year, string vin, string color, AutoType type) : base(make, model, year, vin, color, AutoType.Sedan)
        {

        }
    }
}
