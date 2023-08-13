// customized greeting
Console.Write("Write your name:");
#nullable enable
string? username = Console.ReadLine();
if (username is not null)
{
switch (username.ToLower())
{
    case "daria":
    case "darya":
    case "dasha":
        Console.WriteLine();
        Console.WriteLine("Finally! DASHEN'KA JOINED US!");
        Console.WriteLine();
        break;
    default:
        Console.WriteLine("Greetings, ");
        Console.WriteLine(username);
        break;
}
}