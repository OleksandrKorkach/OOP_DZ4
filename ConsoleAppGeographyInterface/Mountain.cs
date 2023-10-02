namespace ConsoleAppGeographyInterface;

public class Mountain : GeographyObject
{
    private int _x;
    private int _y;
    private string _name;
    private string _description;
    private int _highestPoint;

    public Mountain(int x, int y, string name, string description, int highestPoint)
    {
        _x = x;
        _y = y;
        _name = name;
        _description = description;
        _highestPoint = highestPoint;
    }

    public void PrintInfo()
    {
        Console.WriteLine("X: " + _x);
        Console.WriteLine("Y: " + _y);
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Highest Point: " + _highestPoint);
    }
}