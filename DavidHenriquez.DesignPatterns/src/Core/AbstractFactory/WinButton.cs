namespace Core.AbstractFactory;

public class WinButton : IButton
{
    public string Paint()
    {
        return "This is a win button";
    }
}
