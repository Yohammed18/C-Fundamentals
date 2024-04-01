using IntroCSharp;
using System.Text;

Console.WriteLine("Hello, World!\n");
string sentence = "This is a sentence written in C-Sharp.";
int age = 35;
char letter = 'A';
Boolean isTrue = false;
double valueDouble = 7 / 2;
float valueFloat = 14.3f;
var value = 13 % 5;


Console.WriteLine(sentence);
Console.WriteLine(age);
Console.WriteLine(letter);
Console.WriteLine(value);
Console.WriteLine(valueFloat);
//Output only the last 2 digits after the point.
Console.WriteLine($"{valueDouble:F2}");
Console.WriteLine(isTrue);

int increment = 1;

Console.WriteLine(increment=+1);
Console.WriteLine(++increment);

//TYPE CASTING
//implicit casting
int i = 123123;
long bigNum = i;
Console.WriteLine(bigNum);

//explicit casting
double x = 123.312;
int a = (int)x;

Console.WriteLine(a);

// String to int
string stringValue = "123214";
int _ = 0;
if(int.TryParse(stringValue, out _))
{
    Console.WriteLine("Success: "+_+"\n");
}
else
{
    Console.WriteLine("Failure.\n");
}

// Stack and Heap. Stack is for value type and a Heap is for reference types.
int intValue = 4;
byte byteValue = 12;
bool boolValue = false;
string valueString = "New Value";

Console.WriteLine(intValue);
Console.WriteLine(byteValue);
Console.WriteLine(boolValue);
Console.WriteLine(valueString);

//import a class
StackHeap stackHeap = new StackHeap();

Console.WriteLine(stackHeap.addFive(15
    ));


//Arrays - a fix collection of variable once created.
int[] num = { -2,6,10,192,-3,2,1,0 };
string[] string_array = new string[num.Length];

string_array[0] = "james";
string_array[1] = "michael";
string_array[2] = "kobe";
string_array[3] = "Smith";

foreach (var item in string_array)
{
    Console.WriteLine(item); 
}
num[4] = 12;
Console.WriteLine("Array Length: "+num.Length);
Console.WriteLine("["+string.Join(", ", num)+"]");


// Learn Linq framework -  a feature in C# that provides a uniform way to query data from different data sources. LINQ allows you to query collections, databases, XML documents, and other data sources using a syntax similar to SQL.
var numAverage = num.Average();

Console.WriteLine(numAverage);

// sort array
Array.Sort(num);
Console.WriteLine("[" + string.Join(", ", num) + "]");

String string_name = "mohammed";

Console.WriteLine(string_name.ToUpper());

//Value types CANNOT BE NULL

//literal vs Verbatim
string fileLiteral = "c:\\ProgramFiles";

string fileVerbatim = @"c:\ProgramFiles";

//String are immutabile (Read Only)

//String Interpolation + Composite Formating
string firstName = "Luca";
string lastName = "Smith";
//String Interpolation
Console.WriteLine($"My name is {firstName} {lastName}");
//Composite Formating (unlike python you need to be explicit and label the bracket with the index
Console.WriteLine("Name: {0}\nSurname: {1}\n", firstName, lastName);

//StringBuilder (mutable unlike String)
var sb = new StringBuilder("Hello World");

Console.WriteLine(sb.ToString());

