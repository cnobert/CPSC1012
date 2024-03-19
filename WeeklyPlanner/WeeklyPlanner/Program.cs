bool displayMainMenu = true;
string mainMenuChoice;
bool quit = false;

const int MaxArraySize = 7;
string[] days = new string[MaxArraySize];
string[] tasks = new string[MaxArraySize];
int[] priorities = new int[MaxArraySize];


DisplayIntro();
while(displayMainMenu)
{
    DisplayMainMenu();
    mainMenuChoice = Prompt("Enter MAIN MENU option ('D' to display menu): ");
    switch(mainMenuChoice)
    {
        case "E":
            EnterTasksForWeek(days, tasks, priorities);
            break;
        case "D":
            break;
        case "Q":
            quit = Prompt("Are you sure you want to quit (y/N)?").ToLower() == "y";
            Console.WriteLine();
            if(quit)
            {
                displayMainMenu = false;
            }
            break;
        default:
            Console.WriteLine("Invalid response. Enter one of the letters to choose a menu option.");
            break;
    }
}

static void DisplayIntro()
{
    Console.WriteLine("-----------------------------------------");
    Console.WriteLine("---- Welcome to the Week Planner App ----");
    Console.WriteLine("-----------------------------------------");
}
static void DisplayMainMenu()
{
    Console.WriteLine(
        "[E]nter your plans for the week\n" +
        "[Q]uit Program");
}
static string Prompt(string promptString)
{
    Console.WriteLine(promptString);
    return Console.ReadLine();
}

//EnterTasksForWeek asks the user what day of the week they want to start on, and then 
//gets them to enter one task and one priority for each day after that
static void EnterTasksForWeek(string[] theDays, string[] theTasks, int[] thePriorities)
{
    //WEEK OF March 17 - have this method return numberOfEntries
    string dayOfTheWeek = "";
    Console.WriteLine("What day of the week do you want your plan to start on?");
    dayOfTheWeek = PromptForWeek();

    int dayOfTheWeekAsInt = ConvertWeekdayToInt(dayOfTheWeek);
    while(dayOfTheWeekAsInt < MaxArraySize && dayOfTheWeek != "BYE")
    {
        Console.WriteLine("Enter the task and priority for " + ConvertIntToWeekday(dayOfTheWeekAsInt));
        theDays[dayOfTheWeekAsInt] = ConvertIntToWeekday(dayOfTheWeekAsInt);
        theTasks[dayOfTheWeekAsInt] = Prompt("Task");
        thePriorities[dayOfTheWeekAsInt] = GetIntAboveZero("Enter a priority [must be a whole number above zero]:");
        dayOfTheWeekAsInt++;
    }
    Console.WriteLine("---Congratulations you've set your priorities for the week!---");
}

static string PromptForWeek()
{
    bool validAnswer = false;
    string theDay = "";
    do
    {
        theDay = Prompt("[SUN, MON, TUE, WED, THU, FRI, SAT, or BYE to quite]").ToUpper();
        if (theDay == "SUN" || theDay == "MON" || theDay == "TUE" || theDay == "WED" || theDay == "THU" ||
            theDay == "FRI" || theDay == "SAT" || theDay == "BYE")
        {
            validAnswer = true;
        }
    } while (!validAnswer);
    return theDay;
}

static int ConvertWeekdayToInt(string theDay)
{
    int returnValue = -1;
    switch (theDay)
    {
        case "SUN":
            returnValue = 0;
            break;
        case "MON":
            returnValue = 1;
            break;
        case "TUE":
            returnValue = 2;
            break;
        case "WED":
            returnValue = 3;
            break;
        case "THU":
            returnValue = 4;
            break;
        case "FRI":
            returnValue = 5;
            break;
        case "SAT":
            returnValue = 6;
            break;
        default:
            break;
    }
    return returnValue;
}

static string ConvertIntToWeekday(int theDayIndex)
{
    string weekday = "";
    switch (theDayIndex)
    {
        case 0:
            weekday = "SUN";
            break;
        case 1:
            weekday = "MON";
            break;
        case 2:
            weekday = "TUE";
            break;
        case 3:
            weekday = "WED";
            break;
        case 4:
            weekday = "THU";
            break;
        case 5:
            weekday = "FRI";
            break;
        case 6:
            weekday = "SAT";
            break;
        default:
            break;
    }
    return weekday;
}

static int GetIntAboveZero(string prompt)
{
    int theInt = -1;
    Console.WriteLine(prompt);
    do
    {
        try
        {
            theInt = int.Parse(Console.ReadLine());
            if (theInt <= 0)
            {
                Console.WriteLine("Please enter a number greater than zero. Try again:");
            }
        }
        catch
        {
            Console.WriteLine("Please enter a valid, whole number. Try again:");
        }
    } while (theInt <= 0);
    return theInt;
}