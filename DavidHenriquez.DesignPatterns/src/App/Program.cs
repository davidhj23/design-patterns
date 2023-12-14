using Core;

var c1 = DbConnection.GetDbConnection();
var c2 = DbConnection.GetDbConnection();

// Confirm these are the same instance
if (c1 == c2)
{
    Console.WriteLine("Same instance\n");
}

// Wait for user
Console.ReadKey();