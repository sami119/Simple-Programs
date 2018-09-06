using System;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
        
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }


    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * this.radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * this.radius * this.radius;
    }

    public override string Draw()
    {
        return base.Draw() + "Circle";
    }
}
