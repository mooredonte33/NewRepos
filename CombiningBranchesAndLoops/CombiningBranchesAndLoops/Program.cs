﻿// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;
{
    int sum = 0;
    for (int i = 1; i <= 20; i++)
    
        if (i % 3 == 0)
        {
            sum = sum + i;
        }
        Console.WriteLine($"The sum is {sum}");
    
}


