

class Fraction
{

    private int _numerator;
    private float _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public void SetTop(int numerator)
    {
        _numerator = numerator;
    }

    public string GetTop()
    {
        return $"{_numerator}";
    }

    public void SetBottom(int denominator)
    {
        _denominator = denominator;
    }

    public string GetBottom()
    {
        return $"{_denominator}";
    }




    public string GetFractionString()
    {
        string FractionString = $"{_numerator}/{_denominator}";
        return FractionString;
    }

    public string GetDecimalValue()
    {
        double DecimalValue = _numerator / _denominator;
        return $"{DecimalValue}";
    }





}