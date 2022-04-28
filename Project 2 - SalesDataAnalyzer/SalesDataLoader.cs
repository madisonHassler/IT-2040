using System;
using System.Collections.Generic;
using System.IO;

namespace Project_2___SalesDataAnalyzer
{
    public static class SalesDataLoader
    {
        private static int NumItemsInRow = 11;

        public static List<SalesStats> Load(string salesDataFilePath) {
            List<SalesStats> salesStatsList = new List<SalesStats>();

            try
            {
                using (var reader = new StreamReader(salesDataFilePath))
                {
                    int lineNumber = 0;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        lineNumber++;
                        if (lineNumber == 1) continue;

                        var values = line.Split(',');

                        if (values.Length != NumItemsInRow)
                        {
                            throw new Exception($"Row {lineNumber} contains {values.Length} values. It should contain {NumItemsInRow}.");
                        }
                        try
                        {
                           
                            string invoiceID = values[0];
                            string branch = values[1];
                            string city = values[2];
                            string customerType = values[3];
                            string gender = values[4];
                            string productLine = values[5];
                            float unitPrice = Single.Parse(values[6]);
                            int quantity = Int32.Parse(values[7]);
                            DateTime date = DateTime.Parse(values[8]);
                            string payment = values[9];
                            float rating = Single.Parse(values[10]);


                            SalesStats salesStats = new SalesStats(invoiceID, branch, city, customerType, gender, productLine,
                                                                    unitPrice, quantity, date, payment, rating);
                            salesStatsList.Add(salesStats);
                        }
                        catch (FormatException e)
                        {
                            throw new Exception($"Row {lineNumber} contains invalid data. ({e.Message})");
                        }
                    }
                }
            } catch (Exception e){
                throw new Exception($"Unable to open {salesDataFilePath} ({e.Message}).");
            }

            return salesStatsList;
        }
    }
}