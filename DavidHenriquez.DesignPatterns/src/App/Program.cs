using Core.FactoryMethod;
using Core.Singleton;
using Spectre.Console;
using System.Numerics;

// Ask for the user's favorite pattern
var pattern = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("What's your [green]favorite pattern[/]?")
        .PageSize(23)
        //.MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
        .AddChoices(new[] {
            "Singleton", "Factory Method"
        }));

AnsiConsole.WriteLine($"{pattern} example!");

switch (pattern)
{
    case "Singleton":
        var c1 = DbConnection.GetDbConnection();
        var c2 = DbConnection.GetDbConnection();

        // Confirm these are the same instance
        if (c1 == c2)
        {
            AnsiConsole.WriteLine("Same instance\n");
        }        
        break;
    case "Factory Method":
        DocumentFactory[] creators = new DocumentFactory[2];
        creators[0] = new ContractFactory();
        creators[1] = new LetterFactory();

        // Iterate over creators and create products
        foreach (DocumentFactory creator in creators)
        {
            Document document = creator.Create();
            AnsiConsole.WriteLine("Created {0}", document.GetType().Name);
        }
        break;
    default:
        AnsiConsole.WriteLine("No pattern selected\n");
        break;
}

// Wait for user
Console.ReadKey();