using System;


namespace Project_2___SalesDataAnalyzer
{
    public class SalesStats
    {
        public string InvoiceID;
        public string Branch;
        public string City;
        public string CustomerType;
        public string Gender;
        public string ProductLine;
        public float UnitPrice;
        public int Quantity;
        public DateTime Date;
        public string Payment;
        public float Rating;


        public SalesStats(string invoiceID, string branch, string city,
                        string customerType, string gender, string productLine,
                        float unitPrice, int quantity, DateTime date,
                        string payment, float rating)
        {
            InvoiceID = invoiceID;
            Branch = branch;
            City = city;
            CustomerType = customerType;
            Gender = gender;
            ProductLine = productLine;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Date = date;
            Payment = payment;
            Rating = rating;
        }

    }
}