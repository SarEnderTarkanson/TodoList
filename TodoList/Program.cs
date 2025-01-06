Console.WriteLine("Hello, World!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOS");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();

Console.WriteLine("user input: " + userChoice);

Console.ReadKey();