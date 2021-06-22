using System;

abstract class Figure  //creating an abstract class called figure...
{
    protected int Dimension;
    public Figure()
    { }
    public Figure(int dimension)
    {
        Dimension = dimension;  //dimension assignment... 
    }

    public abstract double Area();
    public abstract double Perimeter();
}
class Circle: Figure  //creating a cricle figure... 
{
        public Circle()
        {}
        public Circle(int Radius)
        :base(Radius)
        { }
        public override double Area()
    {
        return Math.PI * Dimension * Dimension;
    }
public override double Perimeter()
    {
        return 2*Math.PI* Dimension;
    }
} 
class Square: Figure
{
        public Square()
        {
        }
        public Square(int side)
         :base(side)
        { }
        public override double Area()
    {
        return Dimension * Dimension;
    }
    public override double Perimeter()
    {
        return 4 * Dimension;
    }
}

class program
{
    static void Main(string[] args)
    {
        Figure fig;
        if (args[0] == "C")
            fig = new Circle(10);
        else
            fig = new Square(10);
        Console.WriteLine(fig.Area());
        Console.WriteLine(fig.Perimeter());
    }
}