// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
{
    int a = 100;
    int b = 25;
    int c = 2 * a + 1;
    int d = 4 + a + b - c;
    Console.WriteLine($"We found the answer to {d} by adding 4 plus {a} plus {b} and then subtracting {c}.");
}
{
    var team1 = "Lakers";
    var team2 = "Grizzlies";
    var team3 = "Bucks";
    var team4 = "Heat";
    Console.WriteLine($"Tonight's playoff matchups start with the {team3} facing the {team4}. Followed by my {team1} taking on those {team2}!");
}
var team5 = "lakers";
var team6 = "warriors";
Console.WriteLine($"All basketball fans want and need to see the {team5.ToUpper()} vs. the {team6.ToUpper()} in the second round!");
{
    int a = 5;
    int b = 6;
    if (a + b < 10)
    Console.WriteLine($"We all know this answer is false.");
}
{
    var names = ("Kara", "Hector", "Jesus", "Adam");
    Console.WriteLine($"The first name in the list is {names.Item1} and the second is {names.Item2}!");
}


