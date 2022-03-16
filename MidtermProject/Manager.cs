using System;


namespace MidtermProject
{
    public class Manager : Employee
    {
        private string department;
        private string region;

        public Manager(string firstName, string lastName, string id, string department,
            string region) : base(firstName, lastName, id, EmployeeType.Manager)
        {
            this.department = department;
            this.region = region;
        }

        public string getDepartment()
        {
            return this.department;
        }

        public void setDepartment(string department)
        {
            this.department = department;
        }

        public string getRegion()
        {
            return this.region;
        }

        public void setRegion(string region)
        {
            this.region = region;
        }
    }
}