

using GeneralUtilities;

Console.WriteLine("enter your first name: ");
string firstName = Console.ReadLine();
Console.WriteLine("enter your last name: ");
string lastName  = Console.ReadLine();

string fullName = Formatters.FormatName(firstName, lastName);
Console.WriteLine($"Hello, {lastName}, {firstName}");