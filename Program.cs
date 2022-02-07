



Console.WriteLine("Enter your name:");
    string name = Console.ReadLine();

string yn = "y";
do
{
   

Console.WriteLine(" Hello, " + name + " Enter an Integer from 1 to 100");
    int num = Convert.ToInt32(Console.ReadLine());

    int remainder = num % 2;






    if (remainder == 0 && num >= 2&& num < 25);
    {
        Console.WriteLine( "OK, " + name +   "  Your number is " + num +  " & is even and less than 25.");
    }
    if (remainder == 0 && num > 25 && num <= 60)
    {
        Console.WriteLine("Alright, " + name +  "Your number is  " + num  +  " Even and between 26 and 60 inclusive.");
    }
    else if (remainder == 0 && num > 60)
    {
        Console.WriteLine("Great, " + name +  "Your number is "   + num +    " Even and larger than 60 ");
    }
    else if (remainder != 0 && num < 60)
    {
        Console.WriteLine( name + "Your number is  " + num +  " Odd and less than 60");
    }
    else if (remainder != 0 && num > 60)
    {
        Console.WriteLine("awesome " + name +  "Your number is " + num  +  " Odd and Greater than 60");
    }
    Console.WriteLine();
    Console.WriteLine(" Do you wish to continue? y -or- n");
    yn = Console.ReadLine().ToLower();

} while ( yn == "y");

Console.WriteLine("Goodbye!");
