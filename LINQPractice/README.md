## Challenge: LINQ Practice
**Description:** Write non-functional and functional LINQ statements.

**Purpose:** This challenge provides experience writing non-functional and functional LINQ statements.

**Requirements:**

Project Name: LINQPractice    
Target Platform: Console    
Programming Language: C#    
Development Environment: Visual Studio Code

Download the following Visual Studio Code project. You are to do your work in this project and submit a zip file of it when you are done.

LINQPractice.zip Download LINQPractice.zip

In the Program.cs is pre-written code in which LINQ statements are to be placed to make the program function as described.

The data to be queried with LINQ statements is based on the following class and enumeration that are in Product.cs and ProductCategory.cs.

The following is the Product class.

```
using System;

namespace LINQPractice
{
    public class Product
    {
        private int _productID;
        private ProductCategory _productCategory;
        private string _title;
        private double _price;
        private int _stockedQuantity;

        public Product(int id, ProductCategory category, string title, double price, int stockedQuantity)
        {
            ID = id;
            Category = category;
            Title = title;
            Price = price;
            StockedQuantity = stockedQuantity;
        }

        public int ID {
            get { return _productID; }
            set {
                _productID = value;
            }
        }

        public ProductCategory Category {
            get { return _productCategory; }
            set {
                _productCategory = value;
            }
        }

        public string Title {
            get { return _title; }
            set {
                _title = value;
            }
        }

        public double Price {
            get { return _price; }
            set {
                _price = value;
            }
        }

        public int StockedQuantity {
            get { return _stockedQuantity; }
            set {
                _stockedQuantity = value;
            }
        }

        public override string ToString()
        {
            // note: {1:F2} indicates the second variable (first is 0, second is 1) with 2 digits after the decimal point

            return String.Format("ID: {0}, Price: {1:F2}, Stocked Qty: {2}, Category: {3}, Title: {4}", ID, Price, StockedQuantity, Category, Title);
        }
    }
}
```

The following is the ProductCategory enumeration.

```
using System;

namespace LINQPractice
{
    public enum ProductCategory
    {
        Computers,
        Electronics,
        Kitchen,
        Pet
    }
}
```

In Program.cs an array of Product instances are created that serves as the data collection to be queried.

```
Product[] products =
{
    new Product(1252, ProductCategory.Computers, "Logitech M510 Wireless Computer Mouse", 18.49, 25),
    new Product(1343, ProductCategory.Computers, "Redragon K552 KUMARA LED Backlit Mechanical Gaming Keyboard", 29.99, 9),
    new Product(1542, ProductCategory.Computers, "Corsair Vengeance LPX 16GB (2x8GB) DDR4 DRAM 3000MHz", 139.99, 42),
    new Product(1721, ProductCategory.Computers, "USB 3.0 A to A Cable Type A Male to Male, 3 feet", 7.29, 112),
    new Product(2231, ProductCategory.Computers, "USB C to USB A", 10.99, 84),
    new Product(2405, ProductCategory.Computers, "EVGA GeForce GTX 1050 Ti Gaming Video Card, 4GB GDDR5", 169.99, 25),
    new Product(2502, ProductCategory.Computers, "ASUS ROG Strix Z370-E Motherboard LGA1151 ", 209.99, 8),
    new Product(3152, ProductCategory.Electronics, "Tascam DR05 Stereo Portable Digital Recorder", 92.99, 14),
    new Product(3178, ProductCategory.Electronics, "Toshiba 43LF621U19 43-inch 4K Ultra HD Smart LED TV HDR", 319.99, 23),
    new Product(3556, ProductCategory.Electronics, "Crown XLS1502 Two-channel, 525W at 4Ω Power Amplifier", 399.00, 17),
    new Product(4339, ProductCategory.Kitchen, "KitchenAid KSM150PSER Artisan Tilt-Head Stand Mixer", 278.63, 36),
    new Product(4411, ProductCategory.Kitchen, "Hamilton Beach 62682RZ Hand Mixer", 14.99, 67),
    new Product(4523, ProductCategory.Kitchen, "Tovolo Flex-Core All Silicone Spatula", 10.49, 98),
    new Product(5134, ProductCategory.Kitchen, "Circulon Symmetry Hard Anodized Nonstick Skillet", 49.95, 62),
    new Product(5216, ProductCategory.Pet, "Neater Feeder Express Pet Bowls", 22.99, 6),
    new Product(5678, ProductCategory.Pet, "Magic Roller Ball Dog Toy", 10.80, 9),
    new Product(6123, ProductCategory.Pet, "Pillow Pets Signature Cozy Cow Plush Toy", 19.99, 17),
    new Product(6732, ProductCategory.Pet, "Evriholder FURemover Broom with Squeegee ", 15.99, 21),
    new Product(7128, ProductCategory.Pet, "Fabreze Pet Oder Eliminator", 4.94, 33),
    new Product(7231, ProductCategory.Pet, "Professional Pet Slicker Rug Brush for Dogs", 7.59, 17)
};
```

Following the the array of Product instances are a series of LINQ queries that are to be performed and the results displayed. For each LINQ query, write a non-functional LINQ statement and a functional LINQ statement to retrieve the requested data.

The first practice item is already completed in the provided project as a demonstration of what is to be done.

The first practice item has the following comment at the top of it that indicates the query to be performed.

```
/*-------------------------------------------------------*/
/*  Practice Item ID: 1                                  */
/*  Get a list of the products that have prices in range */
/*  between $10.00 and $20.00 (inclusive of endpoints).  */
/*-------------------------------------------------------*/
```

In the block of code for Practice Item ID: 1 are two variables where the two LINQ statements are to be placed. The first one is to be a non-functional LINQ statement and the second one is to be a functional LINQ statement. Both statements yield the same results, they are just two different ways to write LINQ statements.

The following code shows how the two statements are presented before the solution is created.

```
var productsWithPricesInRange10To20 = <write a non-functional LINQ statement here>;

var productsWithPricesInRange10To20Functional = <write a functional LINQ statement here>;
```

Where is says <write a non-functional LINQ statement here>, a non-functional LINQ statement is to be placed. Where is says <write a functional LINQ statement here> a functional LINQ statement is to be placed.

The following code shows the two LINQ statements (the solution) for Practice Item ID: 1.

```
var productsWithPricesInRange10To20 = from product in products where product.Price >= 10.00 & product.Price <= 20.00 select product;

var productsWithPricesInRange10To20Functional = products.Where(product => (product.Price >= 10.00 & product.Price <= 20.00));
```
                                                                                                                            
With the LINQ statements in place, the existing code in the program loops through the results and displays them as shown below.

```
1. List of products with prices in range $10 to $20:
Non-functional:
ID: 1252, Price: 18.49, Stocked Qty: 25, Category: Computers, Title: Logitech M510 Wireless Computer Mouse
ID: 2231, Price: 10.99, Stocked Qty: 84, Category: Computers, Title: USB C to USB A
ID: 4411, Price: 14.99, Stocked Qty: 67, Category: Kitchen, Title: Hamilton Beach 62682RZ Hand Mixer
ID: 4523, Price: 10.49, Stocked Qty: 98, Category: Kitchen, Title: Tovolo Flex-Core All Silicone Spatula
ID: 5678, Price: 10.80, Stocked Qty: 9, Category: Pet, Title: Magic Roller Ball Dog Toy
ID: 6123, Price: 19.99, Stocked Qty: 17, Category: Pet, Title: Pillow Pets Signature Cozy Cow Plush Toy
ID: 6732, Price: 15.99, Stocked Qty: 21, Category: Pet, Title: Evriholder FURemover Broom with Squeegee 
Functional:
ID: 1252, Price: 18.49, Stocked Qty: 25, Category: Computers, Title: Logitech M510 Wireless Computer Mouse
ID: 2231, Price: 10.99, Stocked Qty: 84, Category: Computers, Title: USB C to USB A
ID: 4411, Price: 14.99, Stocked Qty: 67, Category: Kitchen, Title: Hamilton Beach 62682RZ Hand Mixer
ID: 4523, Price: 10.49, Stocked Qty: 98, Category: Kitchen, Title: Tovolo Flex-Core All Silicone Spatula
ID: 5678, Price: 10.80, Stocked Qty: 9, Category: Pet, Title: Magic Roller Ball Dog Toy
ID: 6123, Price: 19.99, Stocked Qty: 17, Category: Pet, Title: Pillow Pets Signature Cozy Cow Plush Toy
ID: 6732, Price: 15.99, Stocked Qty: 21, Category: Pet, Title: Evriholder FURemover Broom with Squeegee 
----------------------------------------------------
```
                                                                                                                            
Notice that the results from the non-functional and functional LINQ statements are the same...as they should be.

The second practice item is the first one you need to work on. There are a total of 14 practice items requiring both non-functional and functional LINQ statements. Since the first one is done, that leaves 13 with two statements each for a total of 26 LINQ statements that need to be written for this challenge.

The second practice item has the following comment at the top of it that indicates the query to be performed.
```
/*-------------------------------------------------------*/
/*  Practice Item ID: 2                                  */
/*  Get a list of the products that have prices in range */
/*  between $10.00 and $20.00 (inclusive of endpoints)   */
/*  ordered by lowest to highest price.                  */
/*-------------------------------------------------------*/
```
The code below it is commented-out. Uncomment statements in the second practice item and write the two LINQ statements. The following is in the code for the second practice item.
```
var productsWithPricesInRange10To20OrderedByPriceAsc = <write a non-functional LINQ statement here>;
var productsWithPricesInRange10To20OrderedByPriceAscFunctional = <write a functional LINQ statement here>;
```

Where it says <write a non-functional LINQ statement here>, a non-functional LINQ statement is to be placed. Where is says <write a functional LINQ statement here> a functional LINQ statement is to be placed.

After writing the statements, test them to see that they work.

How you work through the items is up to you. You could do all the non-functional statements and then do all the functional statements. Or, you could do the non-functional and functional statements for each item as you work through them. Use comments to comment-out code that isn't part of what you are working on as you work through the items. I'd recommend you only try to write and test one LINQ statement at a time.

The solutions for each statement (non-functional and functional) for each practice item is provided in the module on Canvas. Each solution is in a separate document so one at a time can be revealed in Canvas. Do not look at a solution until you have made a valid attempt at a solution yourself. If you truly get stuck and can't get a statement to work, then look at the solution and learn from it...and move on to the next item to try again. Since the solutions to Practice Item ID: 1 are already presented in this document and in the supplied project, check them out on Canvas so you can see how solutions are presented.

The following is the output of the program when all the LINQ statements are in place.

```
1. List of products with prices in range $10 to $20:
Non-functional:
ID: 1252, Price: 18.49, Stocked Qty: 25, Category: Computers, Title: Logitech M510 Wireless Computer Mouse
ID: 2231, Price: 10.99, Stocked Qty: 84, Category: Computers, Title: USB C to USB A
ID: 4411, Price: 14.99, Stocked Qty: 67, Category: Kitchen, Title: Hamilton Beach 62682RZ Hand Mixer
ID: 4523, Price: 10.49, Stocked Qty: 98, Category: Kitchen, Title: Tovolo Flex-Core All Silicone Spatula
ID: 5678, Price: 10.80, Stocked Qty: 9, Category: Pet, Title: Magic Roller Ball Dog Toy
ID: 6123, Price: 19.99, Stocked Qty: 17, Category: Pet, Title: Pillow Pets Signature Cozy Cow Plush Toy
ID: 6732, Price: 15.99, Stocked Qty: 21, Category: Pet, Title: Evriholder FURemover Broom with Squeegee 
Functional:
ID: 1252, Price: 18.49, Stocked Qty: 25, Category: Computers, Title: Logitech M510 Wireless Computer Mouse
ID: 2231, Price: 10.99, Stocked Qty: 84, Category: Computers, Title: USB C to USB A
ID: 4411, Price: 14.99, Stocked Qty: 67, Category: Kitchen, Title: Hamilton Beach 62682RZ Hand Mixer
ID: 4523, Price: 10.49, Stocked Qty: 98, Category: Kitchen, Title: Tovolo Flex-Core All Silicone Spatula
ID: 5678, Price: 10.80, Stocked Qty: 9, Category: Pet, Title: Magic Roller Ball Dog Toy
ID: 6123, Price: 19.99, Stocked Qty: 17, Category: Pet, Title: Pillow Pets Signature Cozy Cow Plush Toy
ID: 6732, Price: 15.99, Stocked Qty: 21, Category: Pet, Title: Evriholder FURemover Broom with Squeegee 
----------------------------------------------------

2. List of products with prices in range $10 to $20 ordered by price ascending:
Non-functional:
ID: 4523, Price: 10.49, Stocked Qty: 98, Category: Kitchen, Title: Tovolo Flex-Core All Silicone Spatula
ID: 5678, Price: 10.80, Stocked Qty: 9, Category: Pet, Title: Magic Roller Ball Dog Toy
ID: 2231, Price: 10.99, Stocked Qty: 84, Category: Computers, Title: USB C to USB A
ID: 4411, Price: 14.99, Stocked Qty: 67, Category: Kitchen, Title: Hamilton Beach 62682RZ Hand Mixer
ID: 6732, Price: 15.99, Stocked Qty: 21, Category: Pet, Title: Evriholder FURemover Broom with Squeegee 
ID: 1252, Price: 18.49, Stocked Qty: 25, Category: Computers, Title: Logitech M510 Wireless Computer Mouse
ID: 6123, Price: 19.99, Stocked Qty: 17, Category: Pet, Title: Pillow Pets Signature Cozy Cow Plush Toy
Functional:
ID: 4523, Price: 10.49, Stocked Qty: 98, Category: Kitchen, Title: Tovolo Flex-Core All Silicone Spatula
ID: 5678, Price: 10.80, Stocked Qty: 9, Category: Pet, Title: Magic Roller Ball Dog Toy
ID: 2231, Price: 10.99, Stocked Qty: 84, Category: Computers, Title: USB C to USB A
ID: 4411, Price: 14.99, Stocked Qty: 67, Category: Kitchen, Title: Hamilton Beach 62682RZ Hand Mixer
ID: 6732, Price: 15.99, Stocked Qty: 21, Category: Pet, Title: Evriholder FURemover Broom with Squeegee 
ID: 1252, Price: 18.49, Stocked Qty: 25, Category: Computers, Title: Logitech M510 Wireless Computer Mouse
ID: 6123, Price: 19.99, Stocked Qty: 17, Category: Pet, Title: Pillow Pets Signature Cozy Cow Plush Toy
----------------------------------------------------

3. List of titles for products with prices in range $10 to $20 ordered by title alphabetically ascending:
Non-functional:
Evriholder FURemover Broom with Squeegee 
Hamilton Beach 62682RZ Hand Mixer
Logitech M510 Wireless Computer Mouse
Magic Roller Ball Dog Toy
Pillow Pets Signature Cozy Cow Plush Toy
Tovolo Flex-Core All Silicone Spatula
USB C to USB A
Functional:
Evriholder FURemover Broom with Squeegee 
Hamilton Beach 62682RZ Hand Mixer
Logitech M510 Wireless Computer Mouse
Magic Roller Ball Dog Toy
Pillow Pets Signature Cozy Cow Plush Toy
Tovolo Flex-Core All Silicone Spatula
USB C to USB A
----------------------------------------------------

4. List of IDs for products with prices in range $10 to $20 ordered by ID descending:
Non-functional:
6732
6123
5678
4523
4411
2231
1252
Functional:
6732
6123
5678
4523
4411
2231
1252
----------------------------------------------------

5. Kitchen products:
Non-functional:
ID: 4339, Price: 278.63, Stocked Qty: 36, Category: Kitchen, Title: KitchenAid KSM150PSER Artisan Tilt-Head Stand Mixer
ID: 4411, Price: 14.99, Stocked Qty: 67, Category: Kitchen, Title: Hamilton Beach 62682RZ Hand Mixer
ID: 4523, Price: 10.49, Stocked Qty: 98, Category: Kitchen, Title: Tovolo Flex-Core All Silicone Spatula
ID: 5134, Price: 49.95, Stocked Qty: 62, Category: Kitchen, Title: Circulon Symmetry Hard Anodized Nonstick Skillet
Functional:
ID: 4339, Price: 278.63, Stocked Qty: 36, Category: Kitchen, Title: KitchenAid KSM150PSER Artisan Tilt-Head Stand Mixer
ID: 4411, Price: 14.99, Stocked Qty: 67, Category: Kitchen, Title: Hamilton Beach 62682RZ Hand Mixer
ID: 4523, Price: 10.49, Stocked Qty: 98, Category: Kitchen, Title: Tovolo Flex-Core All Silicone Spatula
ID: 5134, Price: 49.95, Stocked Qty: 62, Category: Kitchen, Title: Circulon Symmetry Hard Anodized Nonstick Skillet
----------------------------------------------------

6. Kitchen products ordered by quantity in stock descending:
Non-functional:
ID: 4523, Price: 10.49, Stocked Qty: 98, Category: Kitchen, Title: Tovolo Flex-Core All Silicone Spatula
ID: 4411, Price: 14.99, Stocked Qty: 67, Category: Kitchen, Title: Hamilton Beach 62682RZ Hand Mixer
ID: 5134, Price: 49.95, Stocked Qty: 62, Category: Kitchen, Title: Circulon Symmetry Hard Anodized Nonstick Skillet
ID: 4339, Price: 278.63, Stocked Qty: 36, Category: Kitchen, Title: KitchenAid KSM150PSER Artisan Tilt-Head Stand Mixer
Functional:
ID: 4523, Price: 10.49, Stocked Qty: 98, Category: Kitchen, Title: Tovolo Flex-Core All Silicone Spatula
ID: 4411, Price: 14.99, Stocked Qty: 67, Category: Kitchen, Title: Hamilton Beach 62682RZ Hand Mixer
ID: 5134, Price: 49.95, Stocked Qty: 62, Category: Kitchen, Title: Circulon Symmetry Hard Anodized Nonstick Skillet
ID: 4339, Price: 278.63, Stocked Qty: 36, Category: Kitchen, Title: KitchenAid KSM150PSER Artisan Tilt-Head Stand Mixer
----------------------------------------------------

7. Computer products costing more than $100:
Non-functional:
ID: 1542, Price: 139.99, Stocked Qty: 42, Category: Computers, Title: Corsair Vengeance LPX 16GB (2x8GB) DDR4 DRAM 3000MHz
ID: 2405, Price: 169.99, Stocked Qty: 25, Category: Computers, Title: EVGA GeForce GTX 1050 Ti Gaming Video Card, 4GB GDDR5
ID: 2502, Price: 209.99, Stocked Qty: 8, Category: Computers, Title: ASUS ROG Strix Z370-E Motherboard LGA1151 
Functional:
ID: 1542, Price: 139.99, Stocked Qty: 42, Category: Computers, Title: Corsair Vengeance LPX 16GB (2x8GB) DDR4 DRAM 3000MHz
ID: 2405, Price: 169.99, Stocked Qty: 25, Category: Computers, Title: EVGA GeForce GTX 1050 Ti Gaming Video Card, 4GB GDDR5
ID: 2502, Price: 209.99, Stocked Qty: 8, Category: Computers, Title: ASUS ROG Strix Z370-E Motherboard LGA1151 
----------------------------------------------------

8. Title of product with an ID of 3152:
Non-functional:
Tascam DR05 Stereo Portable Digital Recorder
Functional:
Tascam DR05 Stereo Portable Digital Recorder
----------------------------------------------------

9. List of products with titles longer than 50 characters:
Non-functional:
ID: 1343, Price: 29.99, Stocked Qty: 9, Category: Computers, Title: Redragon K552 KUMARA LED Backlit Mechanical Gaming Keyboard
ID: 1542, Price: 139.99, Stocked Qty: 42, Category: Computers, Title: Corsair Vengeance LPX 16GB (2x8GB) DDR4 DRAM 3000MHz
ID: 2405, Price: 169.99, Stocked Qty: 25, Category: Computers, Title: EVGA GeForce GTX 1050 Ti Gaming Video Card, 4GB GDDR5
ID: 3178, Price: 319.99, Stocked Qty: 23, Category: Electronics, Title: Toshiba 43LF621U19 43-inch 4K Ultra HD Smart LED TV HDR
ID: 3556, Price: 399.00, Stocked Qty: 17, Category: Electronics, Title: Crown XLS1502 Two-channel, 525W at 4Ω Power Amplifier
ID: 4339, Price: 278.63, Stocked Qty: 36, Category: Kitchen, Title: KitchenAid KSM150PSER Artisan Tilt-Head Stand Mixer
Functional:
ID: 1343, Price: 29.99, Stocked Qty: 9, Category: Computers, Title: Redragon K552 KUMARA LED Backlit Mechanical Gaming Keyboard
ID: 1542, Price: 139.99, Stocked Qty: 42, Category: Computers, Title: Corsair Vengeance LPX 16GB (2x8GB) DDR4 DRAM 3000MHz
ID: 2405, Price: 169.99, Stocked Qty: 25, Category: Computers, Title: EVGA GeForce GTX 1050 Ti Gaming Video Card, 4GB GDDR5
ID: 3178, Price: 319.99, Stocked Qty: 23, Category: Electronics, Title: Toshiba 43LF621U19 43-inch 4K Ultra HD Smart LED TV HDR
ID: 3556, Price: 399.00, Stocked Qty: 17, Category: Electronics, Title: Crown XLS1502 Two-channel, 525W at 4Ω Power Amplifier
ID: 4339, Price: 278.63, Stocked Qty: 36, Category: Kitchen, Title: KitchenAid KSM150PSER Artisan Tilt-Head Stand Mixer
----------------------------------------------------

10. List of Pet products ordered by price from lowest to highest:
Non-functional:
ID: 7128, Price: 4.94, Stocked Qty: 33, Category: Pet, Title: Fabreze Pet Oder Eliminator
ID: 7231, Price: 7.59, Stocked Qty: 17, Category: Pet, Title: Professional Pet Slicker Rug Brush for Dogs
ID: 5678, Price: 10.80, Stocked Qty: 9, Category: Pet, Title: Magic Roller Ball Dog Toy
ID: 6732, Price: 15.99, Stocked Qty: 21, Category: Pet, Title: Evriholder FURemover Broom with Squeegee 
ID: 6123, Price: 19.99, Stocked Qty: 17, Category: Pet, Title: Pillow Pets Signature Cozy Cow Plush Toy
ID: 5216, Price: 22.99, Stocked Qty: 6, Category: Pet, Title: Neater Feeder Express Pet Bowls
Functional:
ID: 7128, Price: 4.94, Stocked Qty: 33, Category: Pet, Title: Fabreze Pet Oder Eliminator
ID: 7231, Price: 7.59, Stocked Qty: 17, Category: Pet, Title: Professional Pet Slicker Rug Brush for Dogs
ID: 5678, Price: 10.80, Stocked Qty: 9, Category: Pet, Title: Magic Roller Ball Dog Toy
ID: 6732, Price: 15.99, Stocked Qty: 21, Category: Pet, Title: Evriholder FURemover Broom with Squeegee 
ID: 6123, Price: 19.99, Stocked Qty: 17, Category: Pet, Title: Pillow Pets Signature Cozy Cow Plush Toy
ID: 5216, Price: 22.99, Stocked Qty: 6, Category: Pet, Title: Neater Feeder Express Pet Bowls
----------------------------------------------------

11. List of products with IDs in range 2000 to 2999 ordered by ID:
Non-functional:
ID: 2231, Price: 10.99, Stocked Qty: 84, Category: Computers, Title: USB C to USB A
ID: 2405, Price: 169.99, Stocked Qty: 25, Category: Computers, Title: EVGA GeForce GTX 1050 Ti Gaming Video Card, 4GB GDDR5
ID: 2502, Price: 209.99, Stocked Qty: 8, Category: Computers, Title: ASUS ROG Strix Z370-E Motherboard LGA1151 
Functional:
ID: 2231, Price: 10.99, Stocked Qty: 84, Category: Computers, Title: USB C to USB A
ID: 2405, Price: 169.99, Stocked Qty: 25, Category: Computers, Title: EVGA GeForce GTX 1050 Ti Gaming Video Card, 4GB GDDR5
ID: 2502, Price: 209.99, Stocked Qty: 8, Category: Computers, Title: ASUS ROG Strix Z370-E Motherboard LGA1151 
----------------------------------------------------

12. List of titles for products with IDs in range 2000 to 2999 ordered by title length:
Non-functional:
USB C to USB A
ASUS ROG Strix Z370-E Motherboard LGA1151 
EVGA GeForce GTX 1050 Ti Gaming Video Card, 4GB GDDR5
Functional:
USB C to USB A
ASUS ROG Strix Z370-E Motherboard LGA1151 
EVGA GeForce GTX 1050 Ti Gaming Video Card, 4GB GDDR5
----------------------------------------------------

13. Titles and stocked quantity for products with less than 20 in stock:
Non-functional:
{ Title = Redragon K552 KUMARA LED Backlit Mechanical Gaming Keyboard, StockedQuantity = 9 }
{ Title = ASUS ROG Strix Z370-E Motherboard LGA1151 , StockedQuantity = 8 }
{ Title = Tascam DR05 Stereo Portable Digital Recorder, StockedQuantity = 14 }
{ Title = Crown XLS1502 Two-channel, 525W at 4Ω Power Amplifier, StockedQuantity = 17 }
{ Title = Neater Feeder Express Pet Bowls, StockedQuantity = 6 }
{ Title = Magic Roller Ball Dog Toy, StockedQuantity = 9 }
{ Title = Pillow Pets Signature Cozy Cow Plush Toy, StockedQuantity = 17 }
{ Title = Professional Pet Slicker Rug Brush for Dogs, StockedQuantity = 17 }
Functional:
{ Title = Redragon K552 KUMARA LED Backlit Mechanical Gaming Keyboard, StockedQuantity = 9 }
{ Title = ASUS ROG Strix Z370-E Motherboard LGA1151 , StockedQuantity = 8 }
{ Title = Tascam DR05 Stereo Portable Digital Recorder, StockedQuantity = 14 }
{ Title = Crown XLS1502 Two-channel, 525W at 4Ω Power Amplifier, StockedQuantity = 17 }
{ Title = Neater Feeder Express Pet Bowls, StockedQuantity = 6 }
{ Title = Magic Roller Ball Dog Toy, StockedQuantity = 9 }
{ Title = Pillow Pets Signature Cozy Cow Plush Toy, StockedQuantity = 17 }
{ Title = Professional Pet Slicker Rug Brush for Dogs, StockedQuantity = 17 }
----------------------------------------------------

14. Titles and stocked quantity for products with less than 20 in stock ordered by stock ascending:
Non-functional:
{ Title = Neater Feeder Express Pet Bowls, StockedQuantity = 6 }
{ Title = ASUS ROG Strix Z370-E Motherboard LGA1151 , StockedQuantity = 8 }
{ Title = Redragon K552 KUMARA LED Backlit Mechanical Gaming Keyboard, StockedQuantity = 9 }
{ Title = Magic Roller Ball Dog Toy, StockedQuantity = 9 }
{ Title = Tascam DR05 Stereo Portable Digital Recorder, StockedQuantity = 14 }
{ Title = Crown XLS1502 Two-channel, 525W at 4Ω Power Amplifier, StockedQuantity = 17 }
{ Title = Pillow Pets Signature Cozy Cow Plush Toy, StockedQuantity = 17 }
{ Title = Professional Pet Slicker Rug Brush for Dogs, StockedQuantity = 17 }
Functional:
{ Title = Neater Feeder Express Pet Bowls, StockedQuantity = 6 }
{ Title = ASUS ROG Strix Z370-E Motherboard LGA1151 , StockedQuantity = 8 }
{ Title = Redragon K552 KUMARA LED Backlit Mechanical Gaming Keyboard, StockedQuantity = 9 }
{ Title = Magic Roller Ball Dog Toy, StockedQuantity = 9 }
{ Title = Tascam DR05 Stereo Portable Digital Recorder, StockedQuantity = 14 }
{ Title = Crown XLS1502 Two-channel, 525W at 4Ω Power Amplifier, StockedQuantity = 17 }
{ Title = Pillow Pets Signature Cozy Cow Plush Toy, StockedQuantity = 17 }
{ Title = Professional Pet Slicker Rug Brush for Dogs, StockedQuantity = 17 }
----------------------------------------------------

Press any key to continue...
```
The following screen capture shows the LINQPractice program with the solution to the first question (which is included with the code)  being run.

LINQPractice being run

