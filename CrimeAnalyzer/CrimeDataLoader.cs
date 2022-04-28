using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CrimeAnalyzer
{
    public class CrimeDataLoader
    {
        public static List<Crime> loadCrime(string filePath)
        {
            List<Crime> crimeList = new List<Crime>();

            try
            {
                using(var crimeReader = new StreamReader(filePath))
                {
                    int lineNumber = 1;
                    int piecesOfData = 11;
                    string lineOfData = crimeReader.ReadLine();

                    while(!crimeReader.EndOfStream)
                    {
                        lineNumber ++;
                        lineOfData = crimeReader.ReadLine();

                        var values = lineOfData.Split(",");
                        if(values.Length != piecesOfData)
                        {
                            throw new Exception($"Row {lineNumber} contains {values.Length} pieces of data. It should have {piecesOfData}");

                        }

                        try
                        {
                            int year = int.Parse(values[0]);
                            int population = int.Parse(values[1]);
                            int violentCrime = int.Parse(values[2]);
                            int murder = int.Parse(values[3]);
                            int rape = int.Parse(values[4]);
                            int robbery = int.Parse(values[5]);
                            int aggravatedAssault = int.Parse(values[6]);
                            int propertyCrime = int.Parse(values[7]);
                            int burglary = int.Parse(values[8]);
                            int theft = int.Parse(values[9]);
                            int motorVehicleTheft = int.Parse(values[10]);

                            Crime crime = new Crime(year, population, violentCrime, murder, rape, robbery, aggravatedAssault, propertyCrime, burglary, theft, motorVehicleTheft);

                            crimeList.Add(crime);
                        }
                        catch(Exception err)
                        {
                            throw new Exception($"Row {lineNumber} contains invalid data. {err.Message}");
                        }
                        
                    }
                }
            }
            catch(Exception err)
            {
                throw new Exception($"There was an error reading the file: {err.Message}");
            }
            return crimeList;
        }
    }

}