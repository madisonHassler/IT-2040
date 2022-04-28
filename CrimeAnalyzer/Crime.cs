using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CrimeAnalyzer
{
    public class Crime
    {
       int year, population, violentCrime, murder, rape, robbery, aggravatedAssault, propertyCrime, burglary, theft, motorVehicleTheft; 

        public Crime(int year, int population, int violentCrime, int murder, int rape, int robbery, int aggravatedAssault, int propertyCrime, int burglary, int theft, int motorVehicleTheft)
        {
            this.year = year;
            this.population = population;
            this.violentCrime = violentCrime;
            this.murder = murder;
            this.rape = rape;
            this.robbery = robbery;
            this.aggravatedAssault = aggravatedAssault;
            this.propertyCrime = propertyCrime;
            this.burglary = burglary;
            this.theft = theft;
            this.motorVehicleTheft = motorVehicleTheft;
        }

        public int getYear()
        {
            return this.year;
        }

        public int getPopulation()
        {
            return this.population;
        }

        public int getViolentCrime()
        {
            return this.violentCrime;
        }

        public int getMurder()
        {
            return this.murder;
        }

        public int getRape()
        {
            return this.rape;
        }

        public int getRobbery()
        {
            return this.robbery;
        }

        public int getAggravatedAssault()
        {
            return this.aggravatedAssault;
        }

        public int getPropertyCrime()
        {
            return this.propertyCrime;
        }

        public int getBurglary()
        {
            return this.burglary;
        }

        public int getTheft()
        {
            return this.theft;
        }

        public int getMotorVehicleTheft()
        {
            return this.motorVehicleTheft;
        }
    }
}