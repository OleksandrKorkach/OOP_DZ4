namespace ConsoleAppGeography;

public class River: GeographyObject
{
    protected double StreamSpeed;
    protected int Length;

    public River(int x, int y, string name, string description, double streamSpeed, int length) : base(x, y, name, description)
    {
        StreamSpeed = streamSpeed;
        Length = length;
    }

    protected override string GetInformation()
    {
        return base.GetInformation() + "\nStreamSpeed: " + StreamSpeed + "\nLength: " + Length;
    }
}