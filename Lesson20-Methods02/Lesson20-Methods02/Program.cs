
//int numDays = 14;
//PrintMessage();
//PrintMessage();
//PrintMessage();


////to declare a method:
////#1)static #2)return type (void, double) #3)method name #4)parameter list in parenthese
////#5) method body, defined by a "code block" - a chunk of code delineated by braces 
//static void PrintMessage()
//{
//    int numDays = 14;
//    Console.WriteLine("This is a message. It is printed.");
//    Console.WriteLine($"In {numDays}, it wil be two weeks from now.");
//}

//EXERCISE: ("Method Problems 2, Question 1):
//Create a helper	function that can be used to prompt the user
//for input.Create a function	
//string Prompt(string	label)
//that will display the Label to the user and return the string
//that they enter.

//string whatTheyAnswered;
//Console.WriteLine("Here is the test of our method, which is called \"Prompt\"");
//whatTheyAnswered = Prompt("Enter any string.");
//Console.WriteLine("The string that you entered is: " +  whatTheyAnswered);
//static = just put that there
//string = return type
//Prompt = name of function/method
//(string label) = parameter list
static string Prompt(string label)
{
    string answer;
    Console.WriteLine(label);
    answer = Console.ReadLine();
    return answer;
}

//EXERCISE: Method Problems 2, Question 2:
//Create a second helper function that can be used to prompt the user for integer input.		
//Create a function
//int PromptForInt(string label)
//that will display the Label to the user and return the integer that they enter.

int theAnswer;
theAnswer = PromptForInt("Please enter an integer:");
Console.WriteLine($"The integer that you entered is {theAnswer}");
theAnswer = PromptForInt("Please enter a second integer:");
Console.WriteLine($"The integer that you entered is {theAnswer}");
theAnswer = PromptForInt("Please enter a third integer:");
Console.WriteLine($"The integer that you entered is {theAnswer}");
static int PromptForInt(string label)
{
    int answer = 0;
    bool validInteger = false;
    Console.WriteLine(label);
    do
    {
        
        try
        {
            answer = int.Parse(Console.ReadLine());
            validInteger = true;
        }
        catch
        {
            Console.WriteLine("Please enter a valid integer. Try again:");
        }
    } while (validInteger == false);

    return answer;
}