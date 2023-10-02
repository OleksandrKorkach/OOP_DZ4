namespace ConsoleAppGeography;

public abstract class GeographyObject
{
    protected int X;
    protected int Y;
    protected string Name;
    protected string Description;

    protected GeographyObject(int x, int y, string name, string description)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
    }

    protected virtual string GetInformation()
    {
        return "X: " + X + "\nY: " + Y + "\nName: " + Name + "\nDescription: " + Description;
    }

    public void PrintInfo()
    {
        Console.WriteLine(GetInformation());
    }

}