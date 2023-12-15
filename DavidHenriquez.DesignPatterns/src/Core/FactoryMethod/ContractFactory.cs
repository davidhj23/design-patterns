namespace Core.FactoryMethod;

public class ContractFactory : DocumentFactory
{
    public override Document Create()
    {
        return new Contract();
    }
}
