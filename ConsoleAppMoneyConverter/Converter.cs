namespace ConsoleAppMoneyConverter;

public class Converter
{
    private readonly double _dollarToHrivniaExchangeRate;
    private readonly double _euroToHrivniaExchangeRate;

    public Converter(double dollarToHrivniaExchangeRate, double euroToHrivniaExchangeRate)
    {
        if (dollarToHrivniaExchangeRate <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(dollarToHrivniaExchangeRate));
        }

        if (euroToHrivniaExchangeRate <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(dollarToHrivniaExchangeRate));
        }

        _dollarToHrivniaExchangeRate = dollarToHrivniaExchangeRate;
        _euroToHrivniaExchangeRate = euroToHrivniaExchangeRate;
    }

    private void Validate(double hrivnias)
    {
        if (hrivnias < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(hrivnias));
        }
    }

    public double HrivniaToDollar(double hrivnias)
    {
        Validate(hrivnias);
        return hrivnias / _dollarToHrivniaExchangeRate;
    }

    public double HrivniaToEuro(double hrivnias)
    {
        Validate(hrivnias);
        return hrivnias / _euroToHrivniaExchangeRate;
    }

    public double DollarToHrivnia(double dollars)
    {
        Validate(dollars);
        return dollars * _dollarToHrivniaExchangeRate;
    }

    public double EuroToHrivnia(double euros)
    {
        Validate(euros);
        return euros * _euroToHrivniaExchangeRate;
    }
}