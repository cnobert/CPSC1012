int clientAge = -1;
string clientWantsAnotherTicket = "n";

do
{
    DisplayMenu();
    clientAge = PromptForValidAge();
    Console.WriteLine(TicketPriceMessage(clientAge));

    Console.WriteLine("Do you want another ticket? y/n");
    clientWantsAnotherTicket = Console.ReadLine();
} while (clientWantsAnotherTicket == "y");

static void DisplayMenu()
{
    Console.WriteLine("----- Welcome to the DMIT Theatre -----");
    Console.WriteLine("Here are our prices:");
    Console.WriteLine(" Children 6 and  under = FREE ($0.00)\n" +
                      " Students 7 to 17 = $9.80\n" +
                      " Adults 18 to 54 = $11.35\n" +
                      " Seniors 55+ = $10.00\n");
    Console.WriteLine("How old are you?");
}
static string TicketPriceMessage(int clientAge)
{
    //default to the 55+ message
    string message = "The ticket will be $10 please.";
    if (clientAge <= 6)
    {
        message = "The ticket is free!";
    }
    else if (clientAge < 18)
    {
        message = "The ticket will be $9.80 please.";
    }
    else if (clientAge < 55)
    {
        message = "The ticket will be $11.35 please.";
    }
    return message;
}

static int PromptForValidAge()
{
    int age = -1;
    do
    {
        try
        {
            age = int.Parse(Console.ReadLine());
            if (age < 1)
            {
                Console.WriteLine("Please enter an age that is bigger than 0.");
            }
        }
        catch
        {
            Console.WriteLine("Please enter a valid, whole number.");
        }
    } while (age < 1);
    return age;
}