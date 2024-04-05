// DATA TYPES - data types can be understood as classifications  used in programming to categorize and define different types of data
//VARIABLES - are named memory locations used to store data temporarily during the execution of a program. They have a name, a data type, and a value. The data type of a variable determines the type of data it can hold, such as integers, floating-point numbers, characters, or strings.


//int
int int_number = 1000000000; //32 bit = 4 bytes
Console.WriteLine($"{int_number}: {int_number.GetType()}");
//float 
float float_number = 12.3f; //32 bit = 4 bytes
Console.WriteLine($"{float_number}: {float_number.GetType()}");
//double
double double_number = 191.323; //64 bit = 8 bytes
Console.WriteLine($"{double_number}: {double_number.GetType()}");
//long
long long_number = 1232412031291231231; //64 bit = 8 bytes
Console.WriteLine($"{long_number}: {long_number.GetType()}");
//char
char char_digit = '1'; //16 bit = 2 bytes
char char_letter = 'A';
Console.WriteLine($"{char_digit}: {char_digit.GetType()}");
Console.WriteLine($"{char_letter}: {char_letter.GetType()}");
//boolean
bool is_boolean = true;
Console.WriteLine($"{is_boolean}: {is_boolean.GetType()}");


//substring

var sub_string = "Sponge Bob";

Console.WriteLine(sub_string.Substring(0, sub_string.Length - 3));
Console.WriteLine(sub_string.ToUpper());
Console.WriteLine(sub_string.Replace("o", "a"));
Console.WriteLine(sub_string.Replace("Sponge", "Billy"));