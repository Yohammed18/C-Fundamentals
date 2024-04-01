using IntroCSharp;

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

Console.WriteLine(stackHeap.addFive(15));

