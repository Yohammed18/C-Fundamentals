using C_Project;

var p1 = new Person("James", "Brown", new DateOnly(1990,1,1));
var p2 = new Person("Serena", "Williams", new DateOnly(1980,2,2));


var people = new List<Person>();
//Hash 


people.Add(p1);
people.Add(p2);

Console.WriteLine(people.Count);

