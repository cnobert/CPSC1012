//Exercise: Write a program that asks for 3 numbers, and then outputs
//the sum of the numbers. Use a loop.

//int sum = 0;
//int numQuestions = 0;
//int counter = 0;

//Console.Write("How many numbers would you like to enter?");
//numQuestions = int.Parse(Console.ReadLine());

//while(counter < numQuestions)
//{
//    Console.Write("Enter an integer:");
//    int answer = int.Parse(Console.ReadLine());
//    sum = sum + answer; //sum += answer;

//    counter++; //counter += 1; counter = counter + 1;
//}
//Console.WriteLine($"The numbers that you entered add up to {sum}");

//for loop (counter-controlled loop)

//for(int c = 0; c < 10; c++)
//{
//    Console.WriteLine(c);
//}

//for(int counter = 1; counter <= 10; counter++)
//{
//    Console.WriteLine(counter);
//}
//for(int c = 10; c > 0; c--)
//{
//    Console.WriteLine(c);
//}
//exercise: Print out the even numbers from 
//100 down to 0

//solution 01
//for (int c = 100; c >= 0; c -= 2)
//{
//    Console.WriteLine(c);
//}
//solution 02
//for(int c = 100; c >= 0; c--)
//{
//    //if variable % 2 equals zero, the number is even
//    if(c % 2 == 0)
//    {
//        Console.WriteLine(c);
//    }
//}
//exercise: Print out the even numbers from 
//2 up to 1000. Do it twice, once with a "for" loop
//and once with a "while" loop

//for (int c = 2; c <= 1000; c += 2)
//{
//    Console.WriteLine(c);
//}
//for (int c = 1; c <= 1000; c++)
//{
//    if(c % 2 == 1)
//    {
//        Console.WriteLine(c);
//    }
//}

//int c = 2;
//while(c <= 1000)
//{
//    Console.WriteLine(c);
//    c += 2;
//}
//int counter = 2;
//while(counter <= 1000)
//{
//    if (counter % 2 == 0)
//    {
//        Console.WriteLine(counter);
//    }
//    counter++;
//}
Console.Write("Enter a number:");
int mySquare = int.Parse(Console.ReadLine());

//int sum = 0;
//int counter = 0;
//while (counter < mySquare)
//{
//    sum += (counter + 1) * (counter + 1);
//    counter++;
//}
int sum = 0;
int counter = 1;
while (counter <= mySquare)
{
    sum += counter * counter;
    counter++;
}
Console.WriteLine($"The sum of the squares is:{sum}");