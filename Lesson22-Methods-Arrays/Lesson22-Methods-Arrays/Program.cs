const int DaysInWeek = 7;
decimal[] weeklySales = new decimal[DaysInWeek];

////this represents the "logical size" of the array
////ie. the number of elements that actually have values in them
int salesCount = 0;

weeklySales[0] = 210.15m;
salesCount++;
weeklySales[1] = 300.12m;
salesCount++;
weeklySales[2] = 410.00m;
salesCount++;
weeklySales[3] = 50.40m;
salesCount++;

Console.WriteLine("Highest sales:\t$" + HighestSales(weeklySales, salesCount));
Console.WriteLine("Lowest sales: \t$" + LowestSales(weeklySales, salesCount));
ClearArray(weeklySales);
salesCount = 0;

//Parallel arrays: when we use two related arrays that track related data at the same index
string[] dayOfWeek = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT" };

weeklySales[0] = 561.23m;
salesCount++;
weeklySales[1] = 45.12m;
salesCount++;

for(int c = 0; c < salesCount; c++)
{
    Console.WriteLine("The sales on " + dayOfWeek[c] + " were:\t" + weeklySales[c]);
}


//Exercise. Code a method name ClearArray that is passed an array of decimals,
//and sets all data to "0"
static void ClearArray(decimal[] sales)
{
    for(int c = 0; c < sales.Length; c++)
    {
        sales[c] = 0;
    }
}


//Exercise. Code a method name HighestSales that is passed a weeklySales array
//and the logical size of the array, and it returns the value for the highest sales day
static decimal HighestSales(decimal[] sales, int logicalSizeOfArray)
{
    decimal highestSales = 0;
    for (int c = 0; c < logicalSizeOfArray; c++)
    {
        if (sales[c] > highestSales)
        {
            highestSales = sales[c];
        }
    }
    return highestSales;
}

//Exercise: Code a method name LowestSales that is passed a weeklySales array
//and the logical size of the array, and it returns the value for the lowest sales day
static decimal LowestSales(decimal[] sales, int logicalSizeOfArray)
{
    decimal lowestSales = sales[0];
    for (int c = 0; c < logicalSizeOfArray; c++)
    {
        if (sales[c] < lowestSales)
        {
            lowestSales = sales[c];
        }
    }
    return lowestSales;
}


//The two examples below demonstrate how a simple data type (int, float, double) is 
//passed to a method *by value* (a copy of it is made). However, an array is passed to a method
//*by reference* (in the method, you have a reference to the original array).
//int[] a = new int[10];
//a[0] = 21;
//a[1] = 105;
//Clear(a);
//Console.WriteLine(a);

//static void Clear(int[] sales)
//{
//    sales[0] = 111;
//}

//int myNumber = 11;
//ChangeInt(myNumber);
//Console.WriteLine(myNumber);
//static void ChangeInt(int theNumber)
//{
//    theNumber = 99;
//}