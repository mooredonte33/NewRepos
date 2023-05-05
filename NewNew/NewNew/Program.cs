// See https://aka.ms/new-console-template for more information
using System.Security;

Console.WriteLine("Hello, World!");
{
    int a = 12;
    int b = 40;
    int c = 0;
    int d = 4 * a - c + b;
    Console.WriteLine($"The answer to {d} is found by multiplying 4 times {a} and subtracting {c} and adding {b}.");
}
{
    string firstteam = "lakers"; 
    string secondteam = "warriors";
    string thirdteam = "suns";
    string fourthteam = "kings";
    Console.WriteLine($"The playoffs are amazing. {firstteam} won game 1. The {secondteam} lost to {fourthteam} and plays again tonight. The {thirdteam} lost game 1 as well so we will see what happens later this week.");
}
string mvp = "joel embiid";
string dpoy = "jjj";
string clutch = "sga";
Console.WriteLine($"The MVP is clearly {mvp.ToUpper()}, while the DPOY is {dpoy.ToUpper()}, and the clutchest player in the league is {clutch.ToUpper()}");

