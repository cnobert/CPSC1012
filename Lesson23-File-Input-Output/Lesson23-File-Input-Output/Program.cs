
const int ArrayLength = 5;
string[] studentNames = new string[ArrayLength];
int[] studentMarks = new int[ArrayLength];

int logicalSize = 0;
int c = 0;
string answer = "";
while(answer != "done" && c < ArrayLength)
{
    answer = Prompt("Enter a student name ('done' to quit):");
    if(answer != "done")
    {
        studentNames[c] = answer;
        studentMarks[c] = GetIntAboveZero("Enter " + answer +"'s mark:");
        logicalSize++;
    }
    c++;
}

//FileWrite(studentNames, studentMarks, logicalSize);
logicalSize = FileRead(studentNames, studentMarks, "studentData.txt");

c = 0;
Console.WriteLine("Student, Mark");
while(c < logicalSize)
{
    Console.WriteLine($"{studentNames[c]} {studentMarks[c]}");
    c++;
}

static int FileRead(string[] studentNames, int[] studentMarks, string fileName)
{
    Console.WriteLine("-----Reading from file-----");
    StreamReader reader = null;
    int c = 0;
    if(File.Exists(fileName))
    {
        try
        {
            reader = new StreamReader(fileName);
            //priming read
            reader.ReadLine();
            
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                //"Conrad,68"
                studentNames[c] = line.Substring(0, line.IndexOf(","));
                string restOfLine = line.Substring(line.IndexOf(",") + 1);
                studentMarks[c] = int.Parse(restOfLine);
                c++;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Something went wrong: {e.Message}");
        }
    }
    else
    {
        Console.WriteLine($"File {fileName} does not exist.");
    }
    return c;
}

static void FileWrite(string[] studentNames, int[] studentMarks, int logicalSize)
{
    string fileName = "studentData.txt";
    StreamWriter writer = null;
    Console.WriteLine("-----Writing to file-----");
    try
    {
        writer = new StreamWriter(fileName);
        writer.WriteLine("Name,Mark");
        for (int i = 0; i < logicalSize; i++)
        {
            writer.WriteLine(studentNames[i] + "," + studentMarks[i]);
        }
        writer.Close();
    }
    catch (Exception e)
    {
        Console.WriteLine($"Something went wrong: {e.Message}");
    }
    Console.WriteLine("-----FILE WRITTEN-----");
}

//look for the file here:
//C:\Users\cnobert\Documents\Lesson23-File-Input-Output\Lesson23-File-Input-Output\bin\Debug\net8.0
static string Prompt(string promptString)
{
    Console.WriteLine(promptString);
    return Console.ReadLine();
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