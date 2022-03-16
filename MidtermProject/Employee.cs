using System;

namespace MidtermProject
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string id;
        private EmployeeType empType;

        public Employee(string firstName, string lastName, string id, EmployeeType empType)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.empType = empType;
        }



        public string getFirstName()
        {
            return this.firstName;
        }
        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public EmployeeType getEmpType()
        {
            return this.empType;
        }
        public void setEmpType(EmployeeType empType)
        {
            this.empType = empType;
        }

        public string getId()
        {
            return this.id;
        }

        public void getEmployeeInfo()
        {
            Console.WriteLine($"Name: {this.firstName} {this.lastName}");
            Console.WriteLine($"ID: {this.id}");
            Console.WriteLine($"Type: {this.empType}");
        }
    }
}