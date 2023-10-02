namespace ConsoleAppGeographyInterface;

public class River : GeographyObject
{
    private int _x;
    private int _y;
    private string _name;
    private string _description;
    private int _totalLength;
    private double _streamSpeed;

    public River(int x, int y, string name, string description, int totalLength, double streamSpeed)
    {
        _x = x;
        _y = y;
        _name = name;
        _description = description;
        _totalLength = totalLength;
        _streamSpeed = streamSpeed;
    }

    public void PrintInfo()
    {
        Console.WriteLine("X: " + _x);
        Console.WriteLine("Y: " + _y);
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Description: " + _description);
        Console.WriteLine("Total length: " + _totalLength);
        Console.WriteLine("Stream speed: " + _streamSpeed);
    }
}