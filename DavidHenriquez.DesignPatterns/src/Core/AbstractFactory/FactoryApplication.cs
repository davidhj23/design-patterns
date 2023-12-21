namespace Core.AbstractFactory;

public class FactoryApplication
{   
    private IGUIFactory _factory;
    private IButton _button;
    private ICheckbox _checkbox;

    public FactoryApplication(IGUIFactory factory)
        => _factory = factory;

    public void CreateUI()
    {
        _button = _factory.CreateButton();
        _checkbox = _factory.CreateCheckbox();
    }

    public string PaintButton()
    {
        return _button.Paint();
    }

    public string PaintCheckbox()
    {
        return _checkbox.Paint();
    }
}
