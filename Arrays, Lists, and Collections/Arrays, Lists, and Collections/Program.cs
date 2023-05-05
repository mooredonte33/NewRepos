// See https://aka.ms/new-console-template for more information
var names = new List<string> { "Donte", "Mikele", "Charlotte" };
foreach (var name in names)
{
    Console.WriteLine($"The list of names is {names.ToUpper()}!");

    Console.WriteLine($"The names when they were growing up was {names.ToLower()}!");

}
