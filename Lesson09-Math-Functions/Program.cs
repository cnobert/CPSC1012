//Exercise 01
//Write a program that will prompt the user for three real numbers and computes their mean
//average. Display the average to the user.

double num01, num02, num03, average, averageRounded;

Console.Write("Enter num01:");
num01 = double.Parse(Console.ReadLine());
Console.Write("Enter num02:");
num02 = double.Parse(Console.ReadLine());
Console.Write("Enter num03:");
num03 = double.Parse(Console.ReadLine());
//average = num01 + num02 + num03;
//average = average / 3;
average = (num01 + num02 + num03) / 3;
Console.WriteLine($"The average of the numbers that you entered is:{average:0.000}");

//Exercise 02
//modify the program you wrote for Question 1 so that it
//will round the mean average to two decimal places
averageRounded = Math.Round(average, 2);
Console.WriteLine($"Here is the same average, rounded to two decimals:{averageRounded}");

//Exercise 03
//Write a program that can solve for the hypotenuse once provided with the height
//and base of the right triangle. 

double theHeight, theBase, theHypotenuse;
Console.Write("Enter height:");
theHeight = double.Parse(Console.ReadLine());
Console.Write("Enter base:");
theBase = double.Parse(Console.ReadLine());
//SQRT(Height2 + Base2)

double theHeightSquared;
theHeightSquared = Math.Pow(theHeight, 2);

double theBaseSquared;
theBaseSquared= Math.Pow(theBase, 2);

theHypotenuse = Math.Sqrt(theHeightSquared + theBaseSquared);

Console.WriteLine($"The hypotenuse of the triangle is:{theHypotenuse:0.00}");