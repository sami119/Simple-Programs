public class Rectangle : Shape
{
    private double sideA;
    private double sideB;

    public Rectangle(double sideA, double sideB)
    {
        this.SideA = sideA;
        this.SideB = sideB;
    }

    public double SideA
    {
        get { return sideA; }
        set { sideA = value; }
    }

    public double SideB
    {
        get { return sideB; }
        set { sideB = value; }
    }


    public override double CalculatePerimeter()
    {
        return 0.0;
    }

    public override double CalculateArea()
    {
        return this.sideA * this.sideB;
    }

    public sealed override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}
