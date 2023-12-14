namespace Core.Singleton;

/// <summary>
/// The 'Singleton' class
/// </summary>
public sealed class DbConnection
{
    private static readonly DbConnection instance = new DbConnection();

    private DbConnection()
    {

    }

    public static DbConnection GetDbConnection()
    {
        return instance;
    }
}