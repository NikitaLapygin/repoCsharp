// customized greeting
Console.Write("Write your name:");
string? username = Console.ReadLine();
    if (username.ToLower() == "daria" || username.ToLower() == "darya" || username.ToLower() == "dasha")
    {
        Console.WriteLine();
        Console.WriteLine("Finally! DASHEN'KA JOINED US!");
        Console.WriteLine();
    }
    else 
    {
        Console.WriteLine ("Greetings, ");
        Console.WriteLine(username);
    }
