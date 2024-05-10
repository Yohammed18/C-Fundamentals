using System.Threading;
string message = "You don't know my name. \nTalk to me once you find out. Peace.";

// for (int i = 0; i < message.Length; i++)
// {
//     Console.Write(message[i]);
//     Thread.Sleep(50);
// }

foreach (var item in message)
{
    Console.Write(item);
    Thread.Sleep(25);
}


void printHello(){
System.Console.WriteLine("\nprintHello() function called.");
}


printHello();