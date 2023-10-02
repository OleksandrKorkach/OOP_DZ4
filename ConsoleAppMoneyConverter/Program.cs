namespace ConsoleAppMoneyConverter;

class Program
{
    public static void Main()
    {
        Converter converter = new Converter(37.12, 39.18);
        Console.WriteLine(converter.HrivniaToDollar(2000));
    }
}