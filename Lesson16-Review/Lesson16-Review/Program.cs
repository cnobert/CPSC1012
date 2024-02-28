//Quiz 2 covers the following:
//Boolean type
//Relational operators (">", "<", "<=", ">=", "!=", "==")
//Boolean (logical" operators ("&&", "||", "==")
//Decision structures - if/else, switch statements (otherwise
//known as "case decision structures"), 
//Loop structures (while, do-while, for)
// otherwise known as pre-condition, post-condition, counter-controlled

//Exercise #1:
//declare an integer
//ask the user for a number
//output whether the number is between 1 and 100
//int numberEntered;
//Console.Write("Enter a number between 1 and 100:");
//numberEntered = int.Parse(Console.ReadLine());
//THIS WORKS BUT ISN'T IDEAL
//if(numberEntered >= 1)
//{
//    if(numberEntered <= 100)
//    {
//        Console.WriteLine("The number is between 10 and 100.");
//    }
//    else
//    {
//        Console.WriteLine("The number is NOT between 10 and 100.");
//    }
//}
//else
//{
//    Console.WriteLine("The number is NOT between 10 and 100.");
//}
//THIS IS A BETTER SOLUTION
//if (numberEntered >= 1 && numberEntered <= 100)
//{
//    Console.WriteLine("The number is between 10 and 100.");
//}
//else
//{
//    Console.WriteLine("The number is NOT between 10 and 100.");
//}
//Exercise #2:
//Ask for a number. Output whether it is smaller than 20 or greater than 120
//int numberEntered;
//Console.Write("Enter a number between 1 and 100:");
//numberEntered = int.Parse(Console.ReadLine());

////The "!" operator flips a Boolean value to its opposite

//if(!(numberEntered <= 20 || numberEntered >= 120))
//{
//    Console.WriteLine("The number is smaller than 20 or greater than 120");
//}
//else
//{
//    Console.WriteLine("The number is not smaller than 20 or greater than 120");
//}
//Exercise #3
//prompt the user for a letter, output a string based on which letter was chosen
//for example, "Type A, B, or C"
//"You typed B"

//char charEntered;
//Console.Write("Type A, B, or C:");
//charEntered = char.Parse(Console.ReadLine());//Console.ReadLine()[0];
//Solution #1
//if(charEntered == 'A')
//{
//    Console.WriteLine("You entered 'A'");
//}
//else if (charEntered == 'B')
//{
//    Console.WriteLine("You entered 'B'");
//}
//else if (charEntered == 'C')
//{
//    Console.WriteLine("You entered 'C'");
//}
//else
//{
//    Console.WriteLine("You entered an invalid response.");
//}
//Solution #2
//switch(charEntered)
//{
//    case 'A':
//        Console.WriteLine("You entered 'A'");
//        break;
//    case 'B':
//        Console.WriteLine("You entered 'B'");
//        break;
//    case 'C':
//        Console.WriteLine("You entered 'C'");
//        break;
//    default:
//        Console.WriteLine("You entered an invalid response.");
//        break;
//}

//Exercise 4
//Prompt the user for a number. Keep asking them until they enter a valid number.

//int integerEntered = 0;
//bool validInput = false;

//do
//{
//    Console.Write("Enter any whole number: ");
//    try //"try this dangerous thing"
//    {
//        integerEntered = int.Parse(Console.ReadLine());
//        validInput = true; //will not run if there's an exception thrown
//    }
//    catch
//    {
//        Console.WriteLine("YOU ENTERED AN INVALID NUMBER");
//    }
//} while (validInput == false); 

//Exercise 5
//Generate a random number between 1 and 100
//Prompt the user to guess a number between 1 and 100.
//Tell them if their guess is lower or higher than the random number.

//returns a random double between 10.24 and 36.22
//double randomDouble = Random.Shared.Next(1024, 3622) / 100.00;

int randomInt = Random.Shared.Next(1, 101);
int userGuess = 0;
do
{
    Console.WriteLine("I have a number in mind.");
    Console.Write("Enter a number between 1 and 100:");
    //make sure this is a valid int
    bool inputIsGood = false;
    do
    {
        try
        {
            userGuess = int.Parse(Console.ReadLine());
            inputIsGood = true;
        }
        catch
        {
            Console.WriteLine("Please enter a valid integer.");
        }
    while(inputIsGood == false)

    if(userGuess < randomInt)
    {
        Console.WriteLine("Your number is LESS than mine.");
    }
    else if (userGuess > randomInt)
    {
        Console.WriteLine("Your number is MORE than mine.");
    }
    else
    {
        Console.WriteLine($"YOU GUESSED IT, THE NUMBER IS {userGuess}");
    }
} while (userGuess != randomInt);
