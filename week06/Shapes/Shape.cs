using System.Drawing;
using System.Dynamic;

public abstract class Shape
{
    private string _color;

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public string GetClassType()
    {
        return this.GetType().Name;
    }
    public abstract double GetArea();
}