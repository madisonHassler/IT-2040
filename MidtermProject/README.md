# Midterm Project
**Description:** Create and test Employee, SalesPerson, and Manager classes in C# where SalesPerson and Manager are subclasses of Employee.

**Purpose:** The purpose of this challenge is to test your knowledge with of Object Oriented Programming (OOP) using Inheritance in C#, creating and using classes, subclasses, class methods, enumerated types, and object instances in C#.

**Requirements:**

Project Name: MidtermProject  
Target Platform: .NET Core Console Application  
Programming Language: C#

Create a program in C# called MidtermProject that contains Employee, SalesPerson, and Manager classes where Employee in the base class and SalesPerson, and Manager are subclasses (derived/child) of Employee. The classes are to be tested using the test code provided in this document.

### The Employee Class

The Employee class should be created in a file called Employee.cs.

The Employee class is to have four private properties: firstName, lastName, id, and empType. The empType property is to be an enumerated type named EmployeeType where the fields are Sales, Manager, Production. The firstName, lastName, and id properties are strings that denote the person's name and identification number respectively.

The Employee class is to have a constructor that accepts firstName, lastName, id, and empType to initialize a new instance of an Employee and sets its properties.

The Person class is to have a public method (function) that prints information about the person. So, for example, if employee is “Truman Tiger” with id: 12345, and is a sales person  this method is to return:

“Name: Truman Tiger   
ID: 12345   
Type: Sales"    

The Employee class should also have methods that:

- Gets the employee's first name
- Sets the employee's first name
- Gets the employee's last name
- Sets the employee's last name
- Gets the employee's empType
- Sets the employee's empType (empType should be an enumerated type called EmployeeType where the fields are SalesPerson, Manager, Production)
- Gets the employee's id


### The SalesPerson Class
The SalesPerson class is to be created in a file called SalesPerson.cs and is to be a subclass of the Employee class.

The SalesPerson class will have two additional new properties beyond what the Employee class supplies: a sting called department stating the salesperson's department and an float called total sales stating how much sales the salesperson has.

The SalesPerson class is to have a constructor that accepts firstName, lastName, id, department and, sales to initialize a new instance of a SalesPerson and set its properties. To do this, the SalesPerson class constructor is to call the superclass (Employee) constructor using base() (Links to an external site.). When the superclass constructor is called, the empType is to be automatically set to Sales.

The SalesPerson class inherits all methods and properties from Employee.

The SalesPerson class is also to have the following additional public methods:

- A method that updates the sales property by adding "sales" to it. So, if a salesperson currently has $5000 in sales, and they get an additional $1500 in sales, this function should add 1500 to sales to make sales 6500.
- A method that returns the salesperson's level. SalesLevel is to be an enumerated type with fields: Platinum, Diamond, Gold, Silver, Bronze. If the salesperson has sales less than $10,000 they are Bronze level, $10,000 to $19,999.99 in sales Silver level, $20,000 to $29,999.99 in sales Gold level, $30,000 to $39,999.99 in sales Diamond level, $40,000 or greater in sales Platinum level.



### The Manager Class
The Manager class is to be created in a file called Manager.cs and is to be a subclass of the Employee class.

The Manager class has two additional new properties beyond what the Employee class supplies, a string department and string region to denote the managers's department and region respectively.

The Manager class is to have a constructor that accepts firstName, lastName, id, department and, region to initialize a new instance of a Manager and set its properties. To do this, the Manager class constructor is to call the superclass (Employee) constructor using base() (Links to an external site.). When the superclass constructor is called, the category is to be automatically set to Manager.

The Manager class inherits all properties and methods from the Employee class.

The Manager class is to also have the following public methods:

- A method that gets the manager's department.
- A method that sets the manager's department.
- A method that gets the manager's region.
- A method that sets the manager's region.


### Working on Challenge
The best way to complete this challenge is to first create the Employee class, get it working, and test it. Then, implement the SalesPerson class as a subclass of Employe, get it working, and test it. Finally, implement the Manager class as a subclass of Employee, get it working, and test it. Don’t try to get all three classes implemented, working, and tested at once. Do them one at a time starting with Employee.

You can test your code with the following code in the Program.cs file

```
//Create instances of Employee, SalesPerson, and Manager
Employee employee1 = new Employee("Truman", "Tiger", "12345", EmployeeType.Sales);
SalesPerson salesPerson1 = new SalesPerson("Mickey", "Mouse", "23456", "Sporting Goods", 7500);
Manager manager1 = new Manager("Elmer", "Fudd", "56789", "Electronics", "Midwest");

Console.WriteLine("\n-------Employee 1-------------");
employee1.getEmployeeInfo();

Console.WriteLine("\n-------Sales Person 1-------------");
salesPerson1.getEmployeeInfo();
Console.WriteLine($"Sales Level: {salesPerson1.GetSalesLevel()} | Sales: ${salesPerson1.getSales()}");
salesPerson1.updateSales(5250.70f);
Console.WriteLine($"Updated Sales Level: {salesPerson1.GetSalesLevel()} | Updated Sales: ${salesPerson1.getSales()}");

Console.WriteLine("\n-------Manager 1-------------");
manager1.getEmployeeInfo();
Console.WriteLine($"Dept: {manager1.getDepartment()} | Region: {manager1.getRegion()}");
manager1.setFirstName("Wiley");
manager1.setLastName("Coyote");
manager1.setRegion("Southeast");
manager1.setDepartment("Automotive");
Console.WriteLine($"\nNew Name: {manager1.getFirstName()} {manager1.getlastName()}");
Console.WriteLine($"New Dept: {manager1.getDepartment()} | New Region: {manager1.getRegion()}");
Code Output
-------Employee 1-------------
Name: Truman Tiger
ID: 12345
Type: Sales

-------Sales Person 1-------------
Name: Mickey Mouse
ID: 23456
Type: Sales
Sales Level: Bronze | Sales: $7500
Updated Sales Level: Silver | Updated Sales: $12750.7

-------Manager 1-------------
Name: Elmer Fudd
ID: 56789
Type: Manager
Dept: Electronics | Region: Midwest

New Name: Wiley Coyote
New Dept: Automotive | New Region: Southeast
```
