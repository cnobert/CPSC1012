//int someNumber = 3;
//if(someNumber <= 4 && (someNumber % 2 == 0))
//{
//    Console.WriteLine("It's smaller than or equal to 4 and an even number.");
//}
//else
//{
//    Console.WriteLine("It's greater than 4 and/or an odd number.");
//}

//answer to PDF "Decision Making Exercies 2", question 4
//int taxableIncome = 110000;
//float incomeTaxDue = 0;

//if(taxableIncome <= 50000)
//{
//    incomeTaxDue = 0 + taxableIncome * 0.05f;
//}
//else if(taxableIncome <= 100000)
//{
//    float amountOver50Thousand = taxableIncome - 50000;
//    incomeTaxDue = 2500 + (0.07f * amountOver50Thousand);
//}
//else
//{
//    float amountOver100Thousand = taxableIncome - 100000;
//    incomeTaxDue = 6000 + (0.09f * amountOver100Thousand);
//}

//Console.WriteLine($"The income tax due is {incomeTaxDue:$0.00}");

//char grade = 'C';
//string output = "";
//switch(grade)
//{
//    case 'A':
//        output = "Congratulations!";
//        break;
//    case 'B':
//        output = "Very good!";
//        break;
//    case 'C':
//        output = "So so!";
//        break;
//    case 'D':
//        output = "You're not very good at this.";
//        break;
//    case 'F':
//        output = "Sorry, you fail.";
//        break;
//    default:
//        output = "Invalid grade";
//        break;
//}
//Console.WriteLine(output);



//while(loopCounter <= 1000)
//{
//    Console.Write(loopCounter);
//    //loopCounter = loopCounter + 1;
//    //loopCounter += 1;
//    loopCounter++;
//}

//while(loopCounter > 0)
//{
//    Console.WriteLine(loopCounter);
//    //loopCounter = loopCounter - 1;
//    //loopCounter -= 1;
//    loopCounter--;
//}
//exercise: write a loop that outputs
//the multiples of 5 from 5 to 100
//int loopCounter = 5;
//while (loopCounter <= 100)
//{
//    Console.WriteLine(loopCounter);
//    loopCounter += 5;
//}
char menuSelection = 'q';
do
{
    Console.WriteLine("Choose a menu item:");
    Console.WriteLine("\t'j' to hear a joke");
    Console.WriteLine("\t'a' to find out how old I am");
    Console.WriteLine("\t'q' to quit");
    menuSelection = Console.ReadLine()[0];
    switch(menuSelection)
    {
        case 'j':
            Console.Write("What do you call a pony with a cough?\n");
            Console.WriteLine("A little horse.");
            break;
        case 'a':
            Console.WriteLine("I am 49 years old.");
            break;
        default:
            Console.WriteLine("Buh Bye");
            break;
    }

} while (menuSelection != 'q');