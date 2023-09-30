class Word
{

    private string _text = "";
    private bool _isHidden = false;

    public Word (string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            string hider = "____";
            return _text = hider;

        }
        else
        {
            return _text;
        }
        
    }













}