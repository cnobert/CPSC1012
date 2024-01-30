
float length;
float breadth;
float area;

Console.WriteLine("----Rectangle Area Calculator----");
Console.WriteLine("");
Console.Write("Enter the length of the rectangle: ");

//string lengthAsString = Console.ReadLine();
//length = float.Parse(lengthAsString);

length = float.Parse(Console.ReadLine());

Console.Write("Enter the breadth of the rectangle: ");
breadth = float.Parse(Console.ReadLine());

area = length * breadth;

Console.Write("The area of the rectangle is ");
Console.WriteLine(area);
Console.WriteLine("");
Console.WriteLine("----End of Program---");
Console.WriteLine("----End of Program---");