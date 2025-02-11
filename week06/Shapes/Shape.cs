public class Shape
{
    private string _color;
    private float _area;

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public virtual double GetArea()
    {
        return _area;
    }
}