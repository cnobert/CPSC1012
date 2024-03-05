
const int ArraySize = 5;

//int[] myNumbers;
//myNumbers = new int[ArraySize];
//myNumbers[0] = 12;
//myNumbers[1] = 100;
//myNumbers[2] = 1325;
//myNumbers[3] = 4;
//myNumbers[4] = 20;

//for(int c = 0; c < myNumbers.Length; c++)
//{
//    Console.WriteLine(myNumbers[c]);
//}

//string[] myStrings =
//    {"Guardians 1", "Guardians 2", "Guardians 3", "Deadpool 1", "Deadpool 2", "Deadpool 3"};

//Console.WriteLine(myStrings[3]);

//Methods/functions

//double num01, num02;
//double theSum, theProduct;
////PromptForTwoNumbers();
//PromptUser("Enter two numbers greater than zero:");
//num01 = GetDouble();
//num02 = GetDouble();

//theSum = AddTogether(num01, num02);

////EXERCISE: write a method that multiplies two numbers together and returns them
//theProduct = MultiplyTogether(num01, num02);

////Console.WriteLine("The sum is: " + AddTogether(num01, num02));
//Console.WriteLine("The sum is: " + theSum); 
//Console.WriteLine("The product is: " + theProduct);

//static double MultiplyTogether(double number01, double number02)
//{
//    // return number01 * number02;
//    double product;
//    product = number01 * number02;
//    return product;
//}

//static double AddTogether(double firstNumber, double secondNumber)
//{
//    double theAnswer = firstNumber + secondNumber;
//    return theAnswer;
//}

//static void PromptUser(string thePrompt)
//{
//    Console.WriteLine(thePrompt);
//}

//static double GetDouble()
//{
//    double theDouble;
//    theDouble = double.Parse(Console.ReadLine());
//    return theDouble;
//}


////static void PromptForTwoNumbers()
////{
////    Console.WriteLine("Enter two numbers greater than zero:");
////}
///

double initialInvestment = -1;
Console.Write("Enter the initial investment amount:");
initialInvestment = GetDoubleAboveZero();
Console.WriteLine("Your initial investment amount is: " + initialInvestment);

static double GetDoubleAboveZero()
{
    double investment = -1;
    do
    {
        try
        {
            investment = double.Parse(Console.ReadLine());
            if (investment <= 0)
            {
                Console.WriteLine("Please enter a number greater than zero. Try again:");
            }
        }
        catch
        {
            Console.WriteLine("Please enter a valid number. Try again:");
        }
    } while (investment <= 0);
    return investment;
}