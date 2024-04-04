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


System.Console.WriteLine("\n" + my_list.Contains("Zoya")); //Return False


string name = "Mohammed";

System.Console.WriteLine(name.ToUpper());
string name2 = (string)name.Clone();

// Equal check in content
System.Console.WriteLine(object.Equals(name, name2));
//Equal check in memory
System.Console.WriteLine(object.ReferenceEquals(name, name2));


int counter = 0;
System.Console.WriteLine("\n");
while (counter < 5)
{
    System.Console.WriteLine($"Counter: {counter}");
    counter++;
}

int num = 3;
System.Console.WriteLine($"\n{Math.PI.ToString($"F{num}")}");

decimal a = 12.4M; //explicit type
decimal b = 23.2M;
decimal c = a + b;
System.Console.WriteLine("Calculation: {0}", c);

var names = new List<string> { "James", "Brown", "Luca", "Curry", "Tatum" };



names[0] = "Walter";
names.Sort();
foreach (var n in names)
{
    System.Console.WriteLine(n);
}


System.Console.WriteLine(names.Contains("Luca")); //True
System.Console.WriteLine(names.IndexOf("Tatum"));


//LINQ (Language Integrated Query)& IEnumerable

//Declarative programming


// Describe a query (Follows the python syntax )

List<int> scores = [19, 92, 100, 80, 77, 66, 30];

IEnumerable<int> scorequery =
    from score in scores
    where score < 80
    orderby score descending
    select score;

var newQuery = scores
.Where(s => s > 80)
.OrderByDescending(s => s);

List<int> remainingScore = scorequery.ToList();

System.Console.WriteLine("\nDescending.");
//execute query
foreach (var item in newQuery)
{
    Console.WriteLine(item);
}











