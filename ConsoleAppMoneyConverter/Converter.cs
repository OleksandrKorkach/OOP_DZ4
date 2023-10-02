namespace ConsoleAppMoneyConverter;

public class Converter
{
    private double _dollarToHrivniaExchangeRate;
    private double _euroToHrivniaExchangeRate;

    public Converter(double dollarToHrivniaExchangeRate, double euroToHrivniaExchangeRate)
    {
        _dollarToHrivniaExchangeRate = dollarToHrivniaExchangeRate;
        _euroToHrivniaExchangeRate = euroToHrivniaExchangeRate;
    }

    public double HrivniaToDollar(double hrivnias)
    {
        return hrivnias / _dollarToHrivniaExchangeRate;
    }
    
    public double HrivniaToEuro(double hrivnias)
    {
        return hrivnias / _euroToHrivniaExchangeRate;
    }

    public double DollarToHrivnia(double dollars)
    {
        return dollars * _dollarToHrivniaExchangeRate;
    }
    
    public double EuroToHrivnia(double euros)
    {
        return euros * _euroToHrivniaExchangeRate;
    }
}