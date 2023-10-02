namespace ConsoleAppGeography;

public class Mountain : GeographyObject
{
    private int _highestPoint;

    public Mountain(int x, int y, string name, string description, int highestPoint) : base(x, y, name, description)
    {
        this._highestPoint = highestPoint;
    }

    protected override string GetInformation()
    {
        return base.GetInformation() + "\n" + "Highest point: " + _highestPoint;
    }
}