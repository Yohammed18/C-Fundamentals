Console.WriteLine("Enter your name?");
var name = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine($"Welcome to the world of C# {name}.");
Console.ResetColor(); // Reset colors to default

// Clearing the console
Console.WriteLine("Press any key to clear the console...");
Console.ReadKey();
Console.Clear();

// Getting console window size
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Console window width: {Console.WindowWidth}");
Console.WriteLine($"Console window height: {Console.WindowHeight}");

Console.ForegroundColor = ConsoleColor.Yellow;
// Controlling console cursor
Console.SetCursorPosition(10, 5); // Set cursor position to column 10, row 5
Console.WriteLine("Cursor position changed.");
Console.ResetColor();

