//Review
//EXERCISE 01
//Write a program that accepts a string from the user,
//and outputs the index of the first instance of the '$' character 

//string theString;
//Console.Write("Enter any string: ");
//theString = Console.ReadLine();
//int theIndex = theString.IndexOf('$');
//Console.WriteLine($"The '$' is found at this index: " + theIndex);

//EXERCISE 02
//Write a program that asks how much the user owes.
//It will contain a '$'
//Output the first 5 characters after the '$'
//For example: "You owe $10.54"
//string userAnswer;
//Console.Write("How much money do you owe? ");
//userAnswer = Console.ReadLine();
//int theDollarSignIndex = userAnswer.IndexOf('$');
//string moneyOwedAsString = userAnswer.Substring(theDollarSignIndex + 1, 5);
//Console.Write($"You owe ${moneyOwedAsString}.");

//string exampleString = "The snow looks nice out.";
//Console.WriteLine(exampleString[0]);

//string userInput;
//Console.Write("Enter a whole number:");
//userInput = Console.ReadLine();
//int theInteger = int.Parse(userInput);

//string output;
//if(theInteger == 4)
//{
//    output = "You entered the number 4.";
//}
//else
//{
//    output = "You did not enter the number 4.";
//}
//Console.WriteLine(output);

//if (theInteger <= 4)
//{
//    output = "You entered the number smaller than or equal to 4.";
//}
//else
//{
//    output = "You entered a number bigger than 4.";
//}
//Console.WriteLine(output);

//if(theInteger != 4)
//{
//    output = "You did not enter the number 4.";
//}
//else
//{
//    output = "You entered the number 4.";
//}
//Console.WriteLine(output);
//if(true)
//{
//    Console.WriteLine("The sky is blue.");
//}
//else
//{
//    Console.WriteLine("The sky is green.");
//}

//Console.Write("Enter the radius of a circle:");
//double radius = double.Parse(Console.ReadLine());
//if(radius < 0)
//{
//    Console.WriteLine("Invalid input.");
//}
//else
//{
//    //double area = radius * radius * Math.PI;
//    double area = Math.Pow(radius, 2) * Math.PI;
//    Console.WriteLine($"The area of the circle is {area}");
//}
Console.Write("Enter the grade that you achieved: ");
float percentGrade = float.Parse(Console.ReadLine());
string output;
char letterGrade;

if(percentGrade >= 90)
{
    letterGrade = 'A';
}
else if(percentGrade >= 80)
{
    letterGrade = 'B';
}
else if (percentGrade >= 70)
{
    letterGrade = 'C';
}
else if (percentGrade >= 50)
{
    letterGrade = 'D';
}
else
{
    letterGrade = 'F';
}
Console.Write("Your letter grade is: " + letterGrade);