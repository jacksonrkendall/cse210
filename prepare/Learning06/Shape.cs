public class Shape
{
    private string _color;
    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    public Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        throw new NotImplementedException("Overridden in child classes.");
    }
}