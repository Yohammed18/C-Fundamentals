//Conditional statements are used to execute certain blocks of code based on the evaluation of a condition. The most commonly used conditional statements in C# are if, else if, else, and switch

// if else statement
var isBoolean = false;

if(isBoolean == false)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(true);
}


//if/else if/else statement
Console.WriteLine("\nWelcome To Club Shay Shay. How old are you?");
string age = Console.ReadLine();
int ageInt = int.Parse(age);

if(ageInt < 18)
{
    Console.WriteLine($"You are {ageInt} years old. You are too young to enter the club.\nGood Bye!!");
}
else if(ageInt < 21)
{
    Console.WriteLine($"You are {ageInt} years old. You are old enough to enter the club, BUT not old enough to drink.");
}
else
{
    Console.WriteLine("You are {0} years old. You are old enough to enter the club AND drink. Cheers Mate!!", ageInt);
}


//switch
// create an array of days 
string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
//Random number generator
Random random = new Random();
// Generate a random number between 0 and 6
int randomNumber = random.Next(0, days.Length);
string day = days[randomNumber];

switch (day)
{
    case "Monday":
        Console.WriteLine(day);
        break;
    case "Tuesday":
        Console.WriteLine(day);
        break;
    case "Wednesday":
        Console.WriteLine(day);
        break;
    case "Thursday":
        Console.WriteLine(day);
        break;
    case "Friday":
        Console.WriteLine(day);
        break;
    case "Saturday":
        Console.WriteLine(day);
        break;
    case "Sunday":
        Console.WriteLine(day);
        break;
    default:
        Console.WriteLine("No days was selected. ");
        break;
}