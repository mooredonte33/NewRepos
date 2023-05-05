// See https://aka.ms/new-console-template for more information
var names = new List<string> { "Donte", "Ana", "Felipe" };
foreach (var name in names)
{
    var index = names.IndexOf("Felipe");
    Console.WriteLine($"The name of Felipe is at {index}");
}

{ 
    var index = names.IndexOf("Donte");
    Console.WriteLine($"The name of Donte is at {index}");
}

{ var index = names.IndexOf("Marcy");
    Console.WriteLine($"Marcy is at {index}");
}
