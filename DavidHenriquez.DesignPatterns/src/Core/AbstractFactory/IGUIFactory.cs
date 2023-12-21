namespace Core.AbstractFactory;

public interface IGUIFactory
{
    IButton CreateButton();

    ICheckbox CreateCheckbox();
}
