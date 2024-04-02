// OOP (object oriented programming)
using OOP;

// Create a car 
Car tesla = new("Tesla", "Y", 2020, "Black");

//print the to string
Console.WriteLine(tesla.ToString());

tesla.drive();

User james = new Person("James");
User michael = new Person("Michael");
User john = new Person("John");

List<User> users = new List<User>();


users.Add(james);
users.Add(michael);
users.Add(john);
//An example of Polymorphisms also known as "runtime polymorphism" 
foreach (User user in users)
{
    user.talk();
}
