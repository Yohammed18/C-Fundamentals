using Basic;
using System.Collections;
using System.Net.NetworkInformation;
using System.Text;

public class Program
{
    private static void Main(string[] args)
    {
        //var flaotNumber = 0.3;
        //char charValue = 'r';
        //Console.WriteLine(flaotNumber.ToString());

        //args =
        //[
        //    flaotNumber.ToString(),
        //];
        //Console.WriteLine($"Hello, World! {args.FirstOrDefault()}\n{charValue}");

        ////CREATE READ UPDATE DELETE
        //Console.WriteLine("What is the name of your dog?...");
        //var dog = Console.ReadLine();
        //Console.WriteLine($"Your dog name is {dog}.");

        ////UPDATE
        //var newDog = dog?.Replace(dog.ToString(), "Bulldog");

        //Console.WriteLine(newDog);

        ////DELETE
        ////String Builder
        //StringBuilder sb = new StringBuilder();

        //sb.Append(newDog);
        //Console.WriteLine(sb.Remove(0,2));

        // Arrays
        //Learn LINQ statemnt


        //string[] workout = ["Deadlift", "Squats", "Pushup", "Pullup", "Barbell Curl", "Goble Squat"];


        //var newFavorite = workout.Where((e) => e.StartsWith("p".ToUpper()));

        //foreach (string line in newFavorite)
        //{
        //    Console.WriteLine(line);
        //}

        //List<string> arrayList = ["James", "Michael", "Smith"];

        //for (int i = 0; i < arrayList.Count; i++)
        //{
        //    Console.WriteLine(arrayList[i]);
        //}
        //Console.WriteLine();

        //Array.ForEach(workout, element => Console.WriteLine(element));

        //arrayList.ForEach(element => Console.WriteLine($"element: {element}"));

        //Console.WriteLine();

        //for (var i = 0; i <10; i++)
        //{
        //    Console.Write(i+", ");
        //}

        ////If/else & boolean
        //bool IsLoggedIn = true;

        //Console.WriteLine();

        //if (IsLoggedIn)
        //{
        //    Console.WriteLine("User is logged in.");
        //}
        //else
        //{
        //    Console.WriteLine("User is NOT logged in.");
        //}

        //var x = 1;
        //var y = 2;

        //if(x == y || x < y)
        //{
        //    Console.WriteLine("\nOne of the cases is true");
        //}

        ////ENUM

        //Console.WriteLine((int)Warning.CodeYellow);

        //var status = (int)Warning.CodeBlue;
        //if (status == 1)
        //{
        //    Console.WriteLine("CODE BLUE");
        //}

        ////SWITCH STATEMENT

        //Console.WriteLine("ENTER A NUMBER?....");
        //string? current_status = Console.ReadLine();
        //int? int_status = int.Parse(current_status);

        //switch (int_status)
        //{
        //    case 0: 
        //        Console.WriteLine("CODE RED");
        //        break;
        //    case 1:
        //        Console.WriteLine("CODE BLUE");
        //        break;
        //    case 2:
        //        Console.WriteLine("CODE YELLOW");
        //        break;
        //    case 3:
        //        Console.WriteLine("CODE GREEN");
        //        break;
        //    default: 
        //        Console.WriteLine("No Code is available");
        //        break;
        //}


        //// new switch statement approach
        //string name = "James";

        //var result = int_status switch
        //{
        //    1 => "Smith",
        //    2 => "James", 
        //    _=> "No Matching"
        //};

        //Console.WriteLine($"RESULT: {result}");

        ////While
        //IsLoggedIn = true;
        //int num = 0;
        //while (IsLoggedIn)
        //{
        //    Console.WriteLine(num);

        //    if (num == 7)
        //    {
        //        IsLoggedIn = false;
        //    }
        //    num++;
        //}

        //Ping ping = new();
        //PingReply pingReply = ping.Send("8.8.8.8");

        //while(pingReply.Status.ToString() == "Success")
        //{
        //    Console.WriteLine(pingReply.Status.ToString()+"!");
        //    pingReply = ping.Send("8.8.8.8");
        //    Console.WriteLine("Waiting 10 seconds for next request.");
        //    Thread.Sleep(10000);
        //}


        //Create
        Rat wolfRat = new()
        {
            Name = "Wolf Rat",
            Number = 12,
            IsRadioActive = true
        };


        Console.WriteLine(wolfRat.ToString());

        //REALESTATE
        Console.WriteLine("\nReal Estate App");
        RealEstate elmStreet = new()
        {
            Address = "620 John Paul Jones",
            Price = 300000,
            SquareFootage = 1300
        };

        var result = elmStreet.CalculatePricePerSquareFoot();
        Console.WriteLine(result);

        //TUPLE
        var values = ("a", 5, "James");

        Console.WriteLine(values.Item1);
        Console.WriteLine();


        //NUll Reference Exception/Error

        string? value = null;
        int? IntValue = null;

        Console.WriteLine(value + " "+IntValue);

    }

    public enum Warning
    {
        CodeRed,
        CodeBlue,
        CodeYellow,
        CodeGreen,
    }
}