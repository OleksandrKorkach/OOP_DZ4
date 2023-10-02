namespace ConsoleAppGeography;

class Program
{
    public static void Main()
    {
        GeographyObject mount = new Mountain(12, 12, "Hoverla", "Cool mountain ", 120);
        GeographyObject river = new River(213, 324, "Dnipro", "Cool river", 15, 2000);
        mount.PrintInfo();
        Console.WriteLine("\n \n");
        river.PrintInfo();
    }
}