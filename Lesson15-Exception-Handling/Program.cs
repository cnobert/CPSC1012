//Write a program that prompts for an integer from the user, and
//prints out whether the number that they entered is between
//16 and 1045
//int userNumber;
//Console.Write("Enter an integer number: ");
//userNumber = int.Parse(Console.ReadLine());

//Solution 01
//if(userNumber >= 16)
//{
//    if(userNumber <= 1045)
//    {
//        Console.WriteLine("The number you entered is between 16 and 1045.");
//    }
//    else
//    {
//        Console.WriteLine("The number you entered is not between 16 and 1045.");
//    }
//}
//else
//{
//    Console.WriteLine("The number you entered is not between 16 and 1045.");
//}

//Solution 02
//string output;
//if (userNumber < 16)
//{
//    output = "The number you entered is not between 16 and 1045.";
//}
//else if (userNumber < 1045)
//{
//    output = "The number you entered is between 16 and 1045.";
//}
//else
//{
//    output = "The number you entered is not between 16 and 1045.";
//}
//Console.WriteLine(output);

//Solution 03 - THE BEST SOLUTION
//string output;
//if(userNumber >= 16 && userNumber <= 1045)
//{
//    output = "The number you entered is between 16 and 1045.";
//}
//else
//{
//    output = "The number you entered is not between 16 and 1045.";
//}
//Console.WriteLine(output);

//Solution 04
//string output;
//if(userNumber < 16 || userNumber > 1045)
//{
//    //it's not between the numbers
//    output = "The number you entered is not between 16 and 1045.";
//}
//else
//{
//    output = "The number you entered is between 16 and 1045.";
//}
//Console.WriteLine(output);

//review of "for loops":
//output the numbers from 1 to 10
//for(int counter = 0; counter < 10; counter++)
//{
//    Console.WriteLine(counter + 1);
//}
////or...
//for (int counter = 1; counter <= 10; counter++)
//{
//    Console.WriteLine(counter);
//}

//EXCEPTIONS AND ERRORS
//01. syntax error
//int theNum!ber = 0;

//02. logic error
//Write a program that prompts for an integer from the user, and
//prints out whether the number that they entered is between
//16 and 1045
//int userNumber;
//Console.Write("Enter an integer number: ");
//userNumber = int.Parse(Console.ReadLine());
//if (userNumber >= 6 && userNumber <= 1045)
//{

//}

//03. Runtime error

//unhandled exception
//int num01 = 5;
//int num02 = 0;
//Console.WriteLine(num01 / num02);

//exception handled using a "roll your own" solution
//int num01 = 5;
//int num02 = 0;
//if (num02 != 0)
//{
//    Console.WriteLine(num01 / num02);
//}
//else
//{
//    Console.Write("Cannot divide by zero, silly.");
//}

//exception handled using C# Exception Handling

//try
//{
//    int num01;
//    int num02;
//    Console.Write("Enter first number:");
//    num01 = int.Parse(Console.ReadLine());
//    Console.Write("Enter second number:");
//    num02 = int.Parse(Console.ReadLine());

//    Console.WriteLine(num01 / num02);
//}
//catch (Exception theException)
//{
//    Console.WriteLine("There was an exception. Here is the message:");
//    Console.WriteLine(theException.Message);
//}

int userAge = 0;
bool validInput = false;

do
{
    Console.Write("How old are you? Please enter a whole number: ");
    try
    {
        userAge = int.Parse(Console.ReadLine());
        validInput = true;
    }
    catch(Exception theException)
    {
        Console.WriteLine(theException.Message);
    }
} while (validInput == false); //while (!validInput)

Console.WriteLine($"You are {userAge} years old");