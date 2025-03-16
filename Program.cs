class Program
{
    static double Area(double radius)
    {
        return Math.PI * radius * radius;
    }
    static void Main()
    {
        double radius = 3;
        Console.WriteLine(Area(radius));
    }
}