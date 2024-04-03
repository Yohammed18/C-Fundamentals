Console.WriteLine("Hello, World!");



// Creating a linkedlist
// Using LinkedList class
LinkedList<String> my_list = new LinkedList<String>();

// Adding elements in the LinkedList
// Using AddLast() method
my_list.AddLast("Zoya");
my_list.AddLast("Shilpa");
my_list.AddLast("Rohit");
my_list.AddLast("Rohan");
my_list.AddLast("Juhi");
my_list.AddLast("Zoya");


my_list.RemoveFirst();
my_list.RemoveLast();

foreach (var item in my_list)
{
   Console.WriteLine(item);
}


System.Console.WriteLine("\n"+my_list.Contains("Zoya")); //Return False


string name = "Mohammed";

System.Console.WriteLine(name.ToUpper());
string name2 = (string) name.Clone();

// Equal check in content
System.Console.WriteLine(object.Equals(name, name2));
//Equal check in memory
System.Console.WriteLine(object.ReferenceEquals(name, name2));


