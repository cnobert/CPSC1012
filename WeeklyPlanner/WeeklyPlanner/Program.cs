bool displayMainMenu = true;
string mainMenuChoice;
bool quit = false;

const int MaxArraySize = 7;
string[] days = new string[MaxArraySize];
string[] tasks = new string[MaxArraySize];
int[] priorities = new int[MaxArraySize];
int numberOfEntries = 0; //logical size of arrays

DisplayIntro();
while(displayMainMenu)
{
    DisplayMainMenu();
    mainMenuChoice = Prompt("Enter MAIN MENU option ('D' to display menu): ").ToUpper();
    switch(mainMenuChoice)
    {
        case "E": //[E]nter your plans for the week
            numberOfEntries = EnterTasksForWeek(days, tasks, priorities);
            break;
        case "S":
            SaveEntriesToFile(days, tasks, priorities, numberOfEntries);
            break;
        case "L":
            numberOfEntries = LoadEntriesFromFile(days, tasks, priorities);
            break;
        case "V":
            ShowEntries(days, tasks, priorities, numberOfEntries);
            break;
        case "D":
            break;
        case "Q": //[Q]uit Program
            quit = Prompt("Are you sure you want to quit (y/N)? ").ToLower().Equals("y");
            Console.WriteLine();
            if (quit)
            {
                displayMainMenu = false;
            }
            break;
        default: //invalid entry. Reprompt.
            Console.WriteLine("Invalid reponse. Enter one of the letters to choose a menu option.");
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
        "[S]ave entries to file\n" +
        "[L]oad entries from file\n" +
        "[V]iew entries\n" +
        "[Q]uit Program");
}
static string Prompt(string promptString)
{
    Console.WriteLine(promptString);
    return Console.ReadLine();
}

//EnterTasksForWeek asks the user what day of the week they want to start on, and then 
//gets them to enter one task and one priority for each day after that
static int EnterTasksForWeek(string[] theDays, string[] theTasks, int[] thePriorities)
{
    int numberOfTasks;
    numberOfTasks = GetIntAboveZero("How many tasks do you want to enter?");

    string theDay = "";
    int c = 0;
    while(c < numberOfTasks)
    {
        Console.WriteLine("Enter the task and priority for " + ConvertIntToWeekday(c));
        theDays[c] = ConvertIntToWeekday(c);
        theTasks[c] = Prompt("Task:");
        thePriorities[c] = GetIntAboveZero("Enter a priority [whole number above zero]");
        c++;
    }
    Console.WriteLine("---Congratulations you've set your priorities for the week!---");
    return numberOfTasks;
}

static void ShowEntries(string[] theDays, string[] theTasks, int[] thePriorities, int numberOfEntries)
{
    if(numberOfEntries <= 0)
    {
        Console.WriteLine("Can't display entries - please make entries or load a file of entries");
    }
    else
    {
        Console.WriteLine("-----DISPLAYING ENTRIES-----");
        Console.WriteLine("The current entries are:");
        for(int c = 0; c < numberOfEntries; c++) 
        {
            Console.WriteLine("---");
            Console.WriteLine($"Day:{theDays[c]}");
            Console.WriteLine($"Task:{theTasks[c]}");
            Console.WriteLine($"Priority:{thePriorities[c]}");
            Console.WriteLine("---");
        }
        Console.WriteLine("----------------------------");
    }

}
static void SaveEntriesToFile(string[] theDays, string[] theTasks, int[] thePriorities, int numberOfEntries)
{
    string fileName = PromptForFilename();
    StreamWriter writer;

    // File write example
    Console.WriteLine("Writing file " + fileName);

    try
    {
        writer = new StreamWriter(fileName);

        writer.WriteLine("Day, Task, Priority");
        int c = 0;
        while (c < numberOfEntries)
        {
            writer.WriteLine($"{theDays[c]},{theTasks[c]},{thePriorities[c]}");
            c++;
        }

        writer.Close();
    }
    catch (Exception e)
    {
        Console.WriteLine($"Something went wrong: {e.Message}");
    }
}
static int LoadEntriesFromFile(string[] theDays, string[] theTasks, int[] thePriorities)
{
    string fileName = PromptForFilename();
    int c = 0;
    StreamReader reader;
    Console.WriteLine("===== Basic File Read =====");
    if (File.Exists(fileName))
    {
        try
        {
            reader = new StreamReader(fileName);
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                theDays[c] = line.Substring(0, line.IndexOf(","));
                string restOfLine = line.Substring(line.IndexOf(",") + 1);
                theTasks[c] = restOfLine.Substring(0, line.IndexOf(","));
                restOfLine = restOfLine.Substring(restOfLine.IndexOf(",") + 1);
                thePriorities[c] = int.Parse(restOfLine);
                c++;
            }

            reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Something went wrong: {e.Message}");
        }
    }
    return c;
}
static string PromptForFilename()
{
    string filename = "";
    bool isValidFilename = true;
    const string CsvFileExtension = ".csv";
    const string TxtFileExtension = ".txt";

    do
    {
        filename = Prompt("Enter name of .csv or .txt file to save to (e.g. JAN-2024-sales.csv): ");
        if (filename == "")
        {
            isValidFilename = false;
            Console.WriteLine("Please try again. The filename cannot be blank or just spaces.");
        }
        else
        {
            if (!filename.EndsWith(CsvFileExtension) && !filename.EndsWith(TxtFileExtension)) //if filename does not end with .txt or .csv.
            {
                filename = filename + CsvFileExtension; //append .csv to filename
                Console.WriteLine("It looks like your filename does not end in .csv or .txt, so it will be treated as a .csv file.");
                isValidFilename = true;
            }
            else
            {
                Console.WriteLine("It looks like your filename ends in .csv or .txt, which is good!");
                isValidFilename = true;
            }
        }
    } while (!isValidFilename);
    return filename;
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