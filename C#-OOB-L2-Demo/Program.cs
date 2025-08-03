using C__OOB_L2_Demo;

#region Example => 1 Point
//Point p1 = new();
////Console.WriteLine($"Point p1: x = {p1.x}, y = {p1.y}");
//Console.WriteLine(p1); // Implicitly calls ToString() without needing to call it explicitly
//Console.WriteLine(p1.ToString()); // Implicitly calls ToString() after overriding it in the Point struct
#endregion


#region Example => 2 Point value type assignment
//Point p1 = new(100, 200);
//Point p2 = new(10, 20);
//Console.WriteLine($"Point p1: x = {p1.x}, y = {p1.y}");
//Console.WriteLine($"Point p2: x = {p2.x}, y = {p2.y}");
//p1 = p2; // Copying the value of p2 to p1
//Console.WriteLine("After copying p2 to p1:");
//Console.WriteLine($"Point p1: x = {p1.x}, y = {p1.y}");
//Console.WriteLine($"Point p2: x = {p2.x}, y = {p2.y}");

#endregion


Point p1 = new(100, 200); // Create a new Point instance with x = 100, y = 200 form stract Point

p1.x = 3000; // Modify the x property of p1
p1.y = 1000; // Modify the y property of p1
Console.WriteLine($"Point p1: x = {p1.x}, y = {p1.y}"); // Output the modified values of p1






