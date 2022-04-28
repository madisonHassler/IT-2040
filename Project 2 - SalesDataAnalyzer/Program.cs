using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace Project_2___SalesDataAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
             if (args.Length != 2) {
                Console.WriteLine("SalesDataAnalyzer <sales_data_file_path> <report_file_path>");
                Environment.Exit(1);
            }

            string salesDataFilePath = args[0];
            string reportFilePath = args[1];

            List<SalesStats> salesStatsList = null;
            try
            {
                salesStatsList = SalesDataLoader.Load(salesDataFilePath);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Environment.Exit(2);
            }

            var report = SalesDataReport.GenerateText(salesStatsList);

            try
            {
                System.IO.File.WriteAllText(reportFilePath, report);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Environment.Exit(3);
            }
        }
    }
}