using System.ComponentModel;
using OOP_Expert.Class;
public class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine("Hello, World!");
        var temp = new printToScreen();
        temp.printNumber(3);


        var tempChild = new printRandom();
        tempChild.print();
        printRandom.helloWorld();*/

        Car tesla = new Car("Tesla","Y", 2023, 34999.49m);
        Console.WriteLine(tesla.ToString());


    }


    public class printToScreen
    {
        Random myRandom = new Random();
        public void PrintToScreen()
        {
            Console.WriteLine(myRandom.Next(10,20).ToString());
        }

        public int printNumber(int x)
        {

            return (int)(x * 7);
        }
    }


    public class printRandom : printToScreen
    {

        public void print()
        {
            Console.WriteLine("Print Random:");
            PrintToScreen();
        }

        internal static void helloWorld()
        {
            Console.WriteLine("internal Function");
        }
    }
}