using Core.Singleton;
using Spectre.Console;

// Ask for the user's favorite pattern
var pattern = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("What's your [green]favorite pattern[/]?")
        .PageSize(23)
        //.MoreChoicesText("[grey](Move up and down to reveal more fruits)[/]")
        .AddChoices(new[] {
            "Singleton"
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
    default:
        AnsiConsole.WriteLine("No pattern selected\n");
        break;
}

// Wait for user
Console.ReadKey();