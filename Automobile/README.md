# Challenge: Automobile

**Description:** Create an Automobile class that contains specified properties and methods. Create instances of Automobile and use its methods.

**Purpose:** This application provides experience with creating classes and instances of objects in C#.

**Requirements:**

Project Name: Automobile

Target Platform: Console 

Programming Language: C#


Create a class called Automobile

Automobile is to have the following private properties:
- make (of type string)
- model (of type string)
- vin (of type string)
- color (of type string)
- year (of type int)
- type (of type autoType)

autoType is a enum type you need to create that contains Sedan, Truck, Van, SUV.

Create a constructor (Links to an external site.) in the class to initialize all of the properties when creating an instance.

Create a get methods for all of the class properties

Create a set method for the color property

Create a method called getAutoAge that takes no parameters and returns the age of the automobile in years. The age of the car is to be calculated by subtracting the current year from the year of the cars make.

In the Main function of the application, test that instances of Automobile can be created and that the methods work. In the following, "Tesla" is the make of the Automobile instance, “Model X” is the model, 2020 is the year,   12345 is the vin, blue is the color and AutoType.Sedan is the type.

**Main Function Code**
```
Console.WriteLine("\nCreating the first Automobile\n---------------");
Automobile auto1 = new Automobile("Tesla", "Model X", 2020, "12345", "blue", AutoType.Sedan);
Console.WriteLine($"Make: {auto1.getMake()} \nModel: {auto1.getModel()}\nYear: {auto1.getYear()}\nType: {auto1.getType()} \nVIN: {auto1.getVin()}");
Console.WriteLine($"Color: {auto1.getColor()}");
Console.WriteLine("\nChanging the Colour\n---------------");
auto1.setColor("black");
Console.WriteLine($"Color: {auto1.getColor()}");

Console.WriteLine("\nCreating the second Automobile\n---------------");
Automobile auto2 = new Automobile("Mercedes", "G-Wagon", 2017, "24578", "silver", AutoType.SUV);
Console.WriteLine($"Make: {auto2.getMake()}\nModel: {auto2.getModel()}\nYear: {auto2.getYear()}\nType: {auto2.getType()}\nVIN: {auto2.getVin()}");

Console.WriteLine("\nPrinting Automobile Ages\n---------------");
Console.WriteLine($"Auto1 Age: {auto1.getAutoAge()} years");
Console.WriteLine($"Auto2 Age: {auto2.getAutoAge()} years");
```
