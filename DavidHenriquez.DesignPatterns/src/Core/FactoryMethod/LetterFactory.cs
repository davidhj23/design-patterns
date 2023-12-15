namespace Core.FactoryMethod;

public class LetterFactory : DocumentFactory
{
    public override Document Create()
    {
        return new Letter();
    }
}
