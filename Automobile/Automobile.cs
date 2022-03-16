using System;

namespace Automobile
{
    public class Automobile
    {
        private string make;
        private string model;
        private string vin;
        private string color;
        private int year;
        private AutoType type;

        public Automobile(string make, string model, int year, string vin, string color, AutoType type)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.vin = vin;
            this.color = color;
            this.type = type;
        }

        public string getMake()
        {
            return this.make;
        }

        public string getModel()
        {
            return this.model;
        }

        public int getYear()
        {
            return this.year;
        }
        public string getVin()
        {
            return this.vin;
        }

        public string getColor()
        {
            return this.color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }

        public AutoType getType()
        {
            return this.type;
        }

        public int getAutoAge()
        {
            DateTime date = DateTime.Now;
            int year = date.Year;
            int carYear = this.getYear();
            int autoAge = year - carYear;
            return autoAge;
        }
    }
}


