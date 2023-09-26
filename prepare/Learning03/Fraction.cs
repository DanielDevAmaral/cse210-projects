public class Fraction
{

    private int _topNumber = 0;
    private int _botNumber = 0;

    public Fraction()
    {
        _topNumber = 1;
        _botNumber = 1;
    }

    public Fraction(int TopNumber)
    {
        _topNumber = TopNumber;
        _botNumber = 1;
    }

    public Fraction(int BotNumber, int TopNumber)
    {
        _topNumber = TopNumber;
        _botNumber = BotNumber;
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }

    public void SetTopNumber(int number)
    {
        _topNumber = number;
    }

    public int GetBotNumber()
    {
        return _botNumber;
    }

    public void SetBotNumber(int number)
    {
        _botNumber = number;
    }

    public string GetFractionString()
    {
        return $"{_topNumber} / {_botNumber}";
    }

    public double GetDecimalValue()
    {
        return (double)_topNumber/(double)_botNumber;
    }


    





}