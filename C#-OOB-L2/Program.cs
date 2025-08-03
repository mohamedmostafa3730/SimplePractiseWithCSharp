using C__OOB_L2;
using System.Drawing;
using Rectangle = C__OOB_L2.Rectangle;

#region Solution 1
/* 1. Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person"
    objects and populate it with data. Then,
    write a C# program to display the details of all the persons in the array. */

//Person[] persons = new Person[5]; // Create an array of Person structs
//string[] names = { "Ahmed", "Ali", "Mostafa", "Fawzi", "Ramy" }; // Names of the persons
//short[] ages = { 25, 30, 22, 28, 35 }; // Ages of the persons
//for (int i = 0; i < persons.Length; i++)
//{
//    persons[i] = new Person(names[i], ages[i]);
//} // populate it with data
//foreach (Person person in persons)
//{
//    Console.WriteLine(person);
//}  //Display the details of all the persons in the array, with implicit call to ToString(), after overriding it in the Person struct


#endregion

#region Solution 2
/* 2. Create a struct called "Point" to represent a 2D point with properties "X" and "Y".
      Write a C# program that takes two points as input from the user and calculates
      the distance between them.*/
// d = √((x₂ - x₁)² + (y₂ - y₁)² )

//Point point1 = new Point(5,6,4,8);
//Console.WriteLine(point1.calculateDistance()); //Calculate the distance using the instance method
//Console.WriteLine(point1.ToString()); // Implicitly calls ToString() after overriding it in the Point struct
//Point.calculateDistance(5, 6, 4, 8); // Static method to calculate the distance between two points


#endregion

#region Solution 3
/* 3. Create a struct called "Person" with properties "Name" and "Age".
      Write a C# program that takes details of 3 persons as input from 
      the user and displays the name and age of the oldest person.*/
//for (int i =1; i <= 3; i++)
//{
//    Console.WriteLine($"Welcome Persone {{{i}}}");
//    Console.WriteLine("Please, Enter your Name: ");
//    string? name = Console.ReadLine();
//    Console.WriteLine("Please, Enter your Age: ");
//    short age;
//    short.TryParse( Console.ReadLine() , out age);
//    Person person = new Person(name, age);
//    person.AddToPeopleArray(person);
//    Console.Clear();
//    Console.WriteLine("The number of persons is: " + Person.GetCountOfPeople());
//    Console.WriteLine("================================");
//}
//Console.WriteLine("==========================");
//Console.WriteLine($"Data for oldest person: {{{Person.GetOldestPerson()}}} ");
//Console.WriteLine("==========================");




#endregion

#region Solution 4
/*4.Create a struct named Rectangle that represents a rectangle with the following fields:
    width(type: double)
    height(type: double) */

//Rectangle rectangle = new Rectangle(5.0, 10.0);
//Console.WriteLine($"Rectangle Length: {rectangle.GetLength()}");
//Console.WriteLine($"Rectangle Width: {rectangle.GetWidth()}");
//Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

#endregion


