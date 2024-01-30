//formatting strings
//int integer01, integer02;
int integer01;
int integer02;
float float01;
float float02;

Console.Write("Enter floating point number one:");
float01 = float.Parse(Console.ReadLine());
Console.Write("Enter floating point number two:"); 
float02 = float.Parse(Console.ReadLine());

////string concatenation
//Console.WriteLine("You entered the number " + float01);

////substitution parameters (we won't use this)
//Console.WriteLine("You entered the number {0}", float01);

////string interpolation
//Console.WriteLine($"You entered the number {float01}");

//adjust the number precision
Console.WriteLine($"You entered the numbers {float01:0.00} and {float02:0.00}");
Console.WriteLine($"You entered the numbers {float01:#,##0.00} and {float02:#,##0.00}");
Console.WriteLine($"You entered the numbers {float01, 20:#,##0.00} and {float02, 20:#,##0.00}");
