using System;

namespace MidtermProject
{
    public class SalesPerson : Employee
    {
        private string department;
        private float sales;


        public SalesPerson(string firstName, string lastName, string id, string department, float sales) : base(firstName, lastName, id, EmployeeType.Sales)
        {
            this.department = department;
            this.sales = sales;
        }

        public float getSales()
        {
            return this.sales;
        }


        public void updateSales(float newSales)
        {
            this.sales += newSales;
    
        }


        public SalesLevel GetSalesLevel()
        {
            if(this.sales < 10000)
            {
                return SalesLevel.Bronze;
            }else if (this.sales > 10000 && this.sales < 19999.99)
            {
                return SalesLevel.Silver;
            }else if (this.sales > 20000 && this.sales < 29999.99)
            {
                return SalesLevel.Gold;
            }
            else if (this.sales > 30000 && this.sales < 39999.99)
            {
                return SalesLevel.Diamond;
            }else
            {
                return SalesLevel.Platinum;
            }
            
        }


    }
}