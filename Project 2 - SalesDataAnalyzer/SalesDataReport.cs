using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Project_2___SalesDataAnalyzer
{
    public static class SalesDataReport
    {
        public static string GenerateText(List<SalesStats> salesStatsList)
        {
            string report = "";

            if (salesStatsList.Count() < 1)
            {
                report += "No data is available.\n";

                return report;
            }

            string breaks = "******************************************\n";


            // 1. Calculate the total sales in the data set.
            report += breaks;
            report += "1. Total Sales in Dataset\n";
            report += breaks;

            var totalSales = from sales in salesStatsList select sales;
            if (totalSales.Count() > 0)
            {
                float total = 0;
                foreach (var sales in totalSales)
                {
                    total += (sales.Quantity) * (sales.UnitPrice);
                }
                report += $"Total Sales: {total:C}\n";

            }
            else
            {
                report += "not available\n";
            }


            // 2. Show the unique product lines in the data set.
            report += $"\n{breaks}";
            report += "2. Unique Product Lines\n";
            report += breaks;

            var uniqueProductLine = (from product in salesStatsList select product.ProductLine).Distinct();
            if (uniqueProductLine.Count() > 0)
            {
                foreach (var product in uniqueProductLine)
                {
                    report += product;
                    report += "\n";
                }
            }
            else
            {
                report += "not available\n";
            }


            // 3. Calculate the total sales for each product line.Sales total will be the sum of(Quantity * UnitPrice) for all products sold in the product line.List the product line and total sales.
            report += $"\n{breaks}";
            report += "3. Total Sales per Product Line\n";
            report += breaks;

            var salesByProduct = from sales in salesStatsList
                                 group sales by sales.ProductLine into ProductGroup
                                 select ProductGroup;
            if (salesByProduct.Count() > 0)
            {
                float totalPoductSale = 0;

                foreach (var product in salesByProduct)
                {
                    foreach (var totalPL in product)
                    {
                        totalPoductSale += (totalPL.Quantity) * (totalPL.UnitPrice);
                    }
                    report += $"{product.Key}: {totalPoductSale:C}\n";
                }
            }
            else
            {
                report += "not available\n";
            }


            // 4. Calculate the total Sales per city ? List the city name and total sales.
            report += $"\n{breaks}";
            report += "4. Total Sales per Product Line\n";
            report += breaks;

            var salesByCity = from sales in salesStatsList
                              group sales by sales.City into CityGroup
                              select CityGroup;
            if (salesByCity.Count() > 0)
            {
                float totalCitySale = 0;

                foreach (var city in salesByCity)
                {
                    foreach (var totalCity in city)
                    {
                        totalCitySale += (totalCity.Quantity) * (totalCity.UnitPrice);
                    }
                    report += $"{city.Key}: {totalCitySale:C}\n";
                }
            }
            else
            {
                report += "not available\n";
            }



            // 5. Which product line(s) have the sale with the highest unit price ? List the product line and the price.
            report += $"\n{breaks}";
            report += "5. Product lines with Highest Unit Price\n";
            report += breaks;


            var highestPrice = from sale in salesStatsList
                               where sale.UnitPrice == ((from sales in salesStatsList select sales.UnitPrice).Max())
                               select sale;

            foreach (var sale in highestPrice)
            {
                report += ($"{sale.ProductLine}: {sale.UnitPrice:C}\n");
            }



            // 6. Calculate the total sales per month in the data set.List the city month and total sales.
            report += $"\n{breaks}";
            report += "6. Total Sales per Month\n";
            report += breaks;

            var salesByMonth = from sales in salesStatsList
                               group sales by sales.Date.Month into DateGroup
                               select DateGroup;

            if (salesByMonth.Count() > 0)
            {
                foreach (var month in salesByMonth)
                {
                    float totalMonthSales = 0;
                    foreach (var totalPayment in month)
                    {
                        totalMonthSales += (totalPayment.Quantity) * (totalPayment.UnitPrice);
                    }
                    report += $"{month.Key}: {totalMonthSales:C}\n";
                }
            }
            else
            {
                report += "not available\n";
            }


            // 7. Calculate the total sales per payment type.List the payment type and total sales.
            report += $"\n{breaks}";
            report += "7. Total Sales by Payment Type\n";
            report += breaks;

            var salesByPayment = from sales in salesStatsList
                                 group sales by sales.Payment into PaymentGroup
                                 select PaymentGroup;
            if (salesByPayment.Count() > 0)
            {
                foreach (var payment in salesByPayment)
                {
                    float totalPaymentSales = 0;
                    foreach (var totalPayment in payment)
                    {
                        totalPaymentSales += (totalPayment.Quantity) * (totalPayment.UnitPrice);
                    }
                    report += $"{payment.Key}: {totalPaymentSales:C}\n";
                }
            }
            else
            {
                report += "not available\n";
            }


            // 8. Calculate the number of sales transactions per member type.List the member type and number of transactions.
            report += $"\n{breaks}";
            report += "8. Total Sales by Member Type\n";
            report += breaks;

            var salesByMember = from sales in salesStatsList group sales by sales.CustomerType into SaleTypeGroup orderby SaleTypeGroup.Key descending select SaleTypeGroup;
            if (salesByMember.Count() > 0)
            {
                foreach (var sale in salesByMember)
                {
                    report += $"{sale.Key}: {sale.Count()}\n";
                }
            }
            else
            {
                report += "not available\n";
            }

            // 9. Calculate the average rating per product line.List the product line and the average rating.
            report += $"\n{breaks}";
            report += "9. Average Rating per Product Line\n";
            report += breaks;

            var avgRateByProduct = from sales in salesStatsList
                                   group sales by sales.ProductLine into prodGroup
                                   orderby prodGroup.Key
                                   select new { product = prodGroup.Key, avgRate = prodGroup.Average(sale => sale.Rating) };

            if (avgRateByProduct.Count() > 0)
            {
                foreach (var major in avgRateByProduct)
                {
                    report += ($"{major.product}: {major.avgRate:N2}\n");

                }
            }
            else
            {
                report += "not available\n";
            }





            // 10. Calculate the total number of transactions per payment type.List the payment type and number of transactions.
            report += $"\n{breaks}";
            report += "10. Total Transactions by Payment Type\n";
            report += breaks;

            var salesByPaymentType = from sales in salesStatsList
                                     group sales by sales.Payment into SalePaymentGroup
                                     orderby SalePaymentGroup.Key descending
                                     select SalePaymentGroup;
            if (salesByPaymentType.Count() > 0)
            {
                foreach (var sale in salesByPaymentType)
                {
                    report += $"{sale.Key}: {sale.Count()}\n";
                }
            }
            else
            {
                report += "not available\n";
            }


            // 11. Calculate the total quantity of products sold per city.List the city and number of products sold.
            report += $"\n{breaks}";
            report += "11. Number of Products Sold per City\n";
            report += breaks;

            var productsByCity = from sales in salesStatsList
                                 group sales by sales.City into SaleCityGroup
                                 orderby SaleCityGroup.Key descending
                                 select SaleCityGroup;
            if (productsByCity.Count() > 0)
            {
                foreach (var sale in productsByCity)
                {
                    float totalQuantitySales = 0;
                    foreach (var totalPayment in sale)
                    {
                        totalQuantitySales += (totalPayment.Quantity);
                    }
                    report += $"{sale.Key}: {totalQuantitySales}";
                    report += "\n";
                }
            }
            else
            {
                report += "not available\n";
            }

            // 12. Using a 5 % sales tax, Calculate the tax for each sales transaction in each product line.List the invoice number, total sales for the transaction, and the tax amount for the transaction, ordered by the product line.
            // multiply sales by tax. calculate sales and then muiltipuly by 0.05
            report += $"\n{breaks}";
            report += "12. Tax per Sale per Product Line\n";
            report += breaks;

            var salesTaxPL = from sales in salesStatsList
                             group sales by sales.ProductLine into productLineGroup
                             orderby productLineGroup.Key
                             select productLineGroup;
            if (salesTaxPL.Count() > 0)
            {

                foreach (var productGroup in salesTaxPL)
                {
                    float productSale = 0;
                    double salesTax = 0;

                    report += $"\n**********{productGroup.Key}**********\n";
                    foreach (var product in productGroup)
                    {
                        productSale = +(product.Quantity) * (product.UnitPrice);
                        salesTax = productSale * 0.05;
                        report += $"Invoice: {product.InvoiceID} - Total: {productSale:C} - Tax: {salesTax:C}\n";
                    }

                }
            }
            else
            {
                report += "not available\n";
            }



            return report;
        }
    }
}