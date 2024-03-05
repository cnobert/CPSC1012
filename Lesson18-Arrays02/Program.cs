const int ArraySize = 5;

//int[] ages = new int[ArraySize];
//ages[0] = 19;
//ages[1] = 19;
//ages[2] = 22;
//ages[3] = 18;
//ages[4] = 21;

//for(int c = 0; c <= ArraySize; c++)
//{
//    Console.WriteLine(ages[c]);
//}

//Console.WriteLine(ages[0]);
//Console.WriteLine(ages[1]);
//Console.WriteLine(ages[2]);
//Console.WriteLine(ages[3]);
//Console.WriteLine(ages[4]);

//index 0   1   2   3   4
//value 19  19  22  18  21

//for(int c = ArraySize - 1; c >= 0; c--)
//{
//    Console.WriteLine(ages[c]);
//}

//double[] marks = new double[ArraySize];
//marks[0] = 79;
//marks[1] = 84;
//marks[2] = 65;
//marks[3] = 91;
//marks[4] = 74;

////using a loop, calculate the average of the above marks
//double sumOfMarks = 0;
//for(int c = 0; c < marks.Length; c++)
//{
//    sumOfMarks = sumOfMarks + marks[c];
//}
//double average = sumOfMarks / ArraySize;
//Console.WriteLine($"The average of the marks is {average}");

//const int DaysInWeek = 7;
//string[] daysOfWeek = new string[DaysInWeek];
//daysOfWeek[0] = "Sunday";   //1st element
//daysOfWeek[1] = "Monday";   //2nd element
//daysOfWeek[2] = "Tuesday";  //3rd element
//daysOfWeek[3] = "Wednesday";//4th element
//daysOfWeek[4] = "Thursday"; //5th element
//daysOfWeek[5] = "Friday";   //6th element
//daysOfWeek[6] = "Saturday"; //7th element

//Console.WriteLine(daysOfWeek[4]);

//Exercise: create an array of ints with 10 elements
//fill the array with the following values: 2,4,6,8,10,12,14,16,18,20
//int[] myInts = new int[ArraySize];

//for(int c = 0; c < myInts.Length; c++)
//{
//    myInts[c] = (c * 2) + 2;
//    Console.WriteLine(myInts[c]);
//}

//Exercise: fill an array with 5 marks entered by the user

double[] courseMarks = new double[ArraySize];
int numQuestions = 0;
do
{
    Console.Write($"Enter your mark for exam {numQuestions + 1}: ");
    bool validInput = false;
    do
    {
        try
        {
            courseMarks[numQuestions] = double.Parse(Console.ReadLine());
            if (courseMarks[numQuestions] >= 0 && courseMarks[numQuestions] <= 100)
            {
                validInput = true;
            }
            else
            {
                Console.Write("The mark you entered is not a number between 0 and 100. Try again: ");
            }
        }
        catch
        {
            Console.Write("The mark you entered is not a number between 0 and 100. Try again: ");
        }
    } while (!validInput);
    numQuestions++;
} while(numQuestions < ArraySize); //numQuestions < courseMarks.Length

Array.Sort(courseMarks);
Console.WriteLine("Your marks, in ascending order, are:");
for(int c = 0; c < courseMarks.Length; c++)
{
    Console.WriteLine(courseMarks[c]);
}
