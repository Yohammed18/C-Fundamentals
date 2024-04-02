// All Conditional Statement
using Miscellaneous;
var test = 1;
var test2 = 2;

if (test == 1)
{
    Console.WriteLine("Test 1 was executed.");
}
else if (test2 == 2)
{
    Console.WriteLine("Test 2 was executed.");
}
else
{
    Console.WriteLine("No test was executed.");
}

// logic check
bool isEqual = 5 == 5;
Console.WriteLine(isEqual); //true
Console.WriteLine(5 == 1); //false
Console.WriteLine(3 < 4); //True
Console.WriteLine(2 > 3); //False

//AND - OR
bool and = 5 == 5 && 3 != 7;
bool or = 5 == 5 || 3 == 7;

Console.WriteLine(and);//true
Console.WriteLine(or);//true

//Ternary operator - inline condition 
//condition ? expression1 : expression2 - expression1 will ONLY print if the condition is True.
var inlineCondition = 3 < 2 ? 10 : 5;

Console.WriteLine(inlineCondition);

//SWITCH STATEMENT
Console.WriteLine("\n");

void DisplayMeasurement(double measurement)
{
    switch (measurement)
    {
        case < 0.0:
            Console.WriteLine($"Measured value is {measurement}; too low.");
            break;
        case > 15.0:
            Console.WriteLine($"Measured value is {measurement}; too high.");
            break;
        case double.NaN:
            Console.WriteLine("Failed measurements.");
            break;
        default:
            Console.WriteLine($"Measure value is {measurement}");
            break;
    }
}

DisplayMeasurement(30);

State state = State.Active;

switch (state)
{
    case State.Active:
        Console.WriteLine("Active: {0}");
        break;
    case State.Inactive:
        Console.WriteLine("Inactive");
        break;
    default:
        Console.WriteLine("No State Defined.");
        break;
}

Console.WriteLine("\n");
//For Loop

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Iteration: {i}");
}

List<string> weekdays = new List<string>();

weekdays.Add("Monday");
weekdays.Add("Tuesday");
weekdays.Add("Wednesday");
weekdays.Add("Thursday");
weekdays.Add("Friday");
weekdays.Add("Saturday");
weekdays.Add("Sunday");
Console.WriteLine("\n");
foreach (string day in weekdays)
{
    Console.WriteLine(day);
}