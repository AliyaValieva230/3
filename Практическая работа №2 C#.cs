using System;

class Rectangle
{
    private double length;
    private double width;

    public Rectangle()
    {
        this.length = 0;
        this.width = 0;
    }

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double Length
    {
        get { return length; }
        set { length = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double CalculateArea()
    {
        return length * width;
    }

    
    
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(2, 5);

        Console.WriteLine($"Площадь прямоугольника: {rect.CalculateArea()}");

        rect = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.ReadKey();
    }
}
