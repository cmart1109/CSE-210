public class Circle : Shape
{
    private double _radius;


    public Circle(double radius){
        _radius = radius;
    }
    public override double GetArea()
    {
        return 3.1416*(_radius * _radius);
    }
}