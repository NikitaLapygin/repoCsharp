// customized greeting
Console.Write("Write your name:");
string? username = Console.ReadLine();
    if (username.ToLower() == "Daria" || username == "Darya" || username == "Dasha")
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
