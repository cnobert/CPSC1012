//escape characters \" \' \n \t \\
//string sentence01 = "I heard my brother say \"hi\".";
//Console.WriteLine(sentence01);
//Console.WriteLine("And then I said \"hello\" back.");
//Console.WriteLine("Here is a backslash in a string \\.");
//Console.WriteLine("Sometimes we want strings on \ntwo lines.");
//Console.WriteLine("Here \tis inserting a tab into a string.");

string fullName = "Taylor Swift";

//Console.WriteLine($"The number of chars in {fullName} is {fullName.Length}");
//Console.WriteLine($"{fullName} in uppercase is {fullName.ToUpper()}");
//Console.WriteLine($"{fullName} in lowercase is {fullName.ToLower()}");

//string upperFullName = fullName.ToUpper();
//int index = upperFullName.IndexOf('A');
//Console.WriteLine($"The space in {fullName} is at {index}");

//Console.WriteLine($"The \"Swift\" in {fullName} is index {fullName.IndexOf("Swift")}");

//Console.WriteLine($"{fullName} contains the letter 'z'? { fullName.Contains('z')}");
////Exercise: write some code that prints out "True" if "Edmonton" contains the letter 'o'

//string city = "Edmonton";
//Console.Write($"True/False: the word \"Edmonton\" contains the letter 'o': ");
//Console.WriteLine(city.Contains('o'));

Console.WriteLine(fullName.Substring(8));

Console.WriteLine(fullName.Substring(2, 8));

fullName = "Connor McDavid";
string firstName = fullName.Substring(0, fullName.IndexOf(' '));
Console.WriteLine(firstName);

string lastName = fullName.Substring(fullName.IndexOf(" ") + 1);
Console.WriteLine(lastName);