using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CrimeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("ERROR: No arguments loaded. Please enter files:");
                Console.WriteLine("CrimeAnalyzer <crime_csv_file_path> <report_file_path>");
                Environment.Exit(0);
            }

            Console.WriteLine($"Number of arguments provided: {args.Length}\n");
            string fileName = args[0];
            string report = args[1];
            Console.WriteLine($"Filename: {fileName}");
            Console.WriteLine($"Report Name: {report}\n");

            string reportText = "";

            List<Crime> crimeList = CrimeDataLoader.loadCrime(fileName);

            reportText += $"Crime Analyzer Report\n\n";

            // What is the range of years included in the data?
            // How many years of data are included?
            var minYear = (from year in crimeList select year.getYear()).Min();
            var maxYear = (from year in crimeList select year.getYear()).Max(); 
            reportText += $"Period: {minYear} - {maxYear} ({maxYear - minYear} years)\n";

        
            // What years is the number of murders per year less than 15000?
            var murderYears = from yearsM in crimeList where yearsM.getMurder() < 15000 select yearsM;
            reportText += $"Years murders per year < 15000: ";
            foreach(var yearsM in murderYears)
            {
                reportText += $"{yearsM.getYear()}, ";
            }
             reportText += $"\n";


            // What are the years and associated robberies per year for years where the number of robberies is greater than 500000?
            var robberiesYears = from years in crimeList where years.getRobbery() > 500000 select years;
            reportText += $"Robberies per year > 500000: ";
            foreach (var years in robberiesYears)
            {
                reportText += $"{years.getYear()} = {years.getRobbery()},"; 
            }
            reportText += $"\n";

            // What is the violent crime per capita rate for 2010? Per capita rate is the number of violent crimes in a year divided by the size of the population that year.
            // var violentCrime2010 = from years in crimeList where (years.getYear() == 2010) select years;
            // var population2010 = from years in crimeList where (years.getYear() == 2010) select years;
            // int vcPerCap = violentCrime2010 / population2010;
            
            var violentCrime2010 = (from crime in crimeList where crime.getYear() == 2010 select crime).First();
            double vcPerCap = (double)violentCrime2010.getViolentCrime()/ (double)violentCrime2010.getPopulation();
            reportText += $"Violent crime per capita rate (2010): {vcPerCap}\n";




            // What is the average number of murders per year across all years?
            var avgMurderAll = (from murder in crimeList select murder.getMurder()).Average();
            reportText += $"Average murder per year (all years): {avgMurderAll}\n";

            // What is the average number of murders per year for 1994 to 1997?
            var avgMurder1994_1997 = (from murder in crimeList where murder.getYear() >= 1994 && murder.getYear() <= 1997 select murder.getMurder()).Average();
            reportText += $"Average murder per year (1994-1997): {avgMurder1994_1997}\n";

            // What is the average number of murders per year for 2010 to 2013?
            var avgMurder2010_2013 = (from murder in crimeList where murder.getYear() >= 2012 && murder.getYear() <= 2013 select murder.getMurder()).Average();
            reportText += $"Average murder per year (2010-2014): {avgMurder2010_2013}\n";
            
            // What is the minimum number of thefts per year for 1999 to 2004?
            var minThefts1999_2004 = (from theft in crimeList where theft.getYear() >= 1999 && theft.getYear() <= 2004 select theft.getTheft()).Min();
            reportText += $"Minimum thefts per year (1999-2004): {minThefts1999_2004}\n";

            // What is the maximum number of thefts per year for 1999 to 2004?
            var maxThefts1999_2004 = (from theft in crimeList where theft.getYear() >= 1999 && theft.getYear() <= 2004 select theft.getTheft()).Max();
            reportText += $"Maximum thefts per year (1999-2004): {maxThefts1999_2004}\n";

            // What year had the highest number of motor vehicle thefts?
            var maxMvTheft = (from mvTheft in crimeList orderby mvTheft.getMotorVehicleTheft() descending select mvTheft).First().getYear();
            reportText += $"Year of highest number of motor vehicle thefts: {maxMvTheft}";
            

            using(var reportWriter = new StreamWriter(report))
            {
                reportWriter.Write(reportText);
            }
        }

            
    }
}
