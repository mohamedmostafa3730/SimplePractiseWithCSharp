using C__OOB_L2_Demo;

#region Example => 1 Point
Point p1 = new();
//Console.WriteLine($"Point p1: x = {p1.x}, y = {p1.y}");
Console.WriteLine(p1); // Implicitly calls ToString() without needing to call it explicitly
Console.WriteLine(p1.ToString()); // Implicitly calls ToString() after overriding it in the Point struct
#endregion


