class Scripture
{
    private Reference _reference { get; }
    private List<Word> _words = new();
    Random r = new Random();

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        string[] separatedWords = text.Split(" ");
        foreach (string wordText in separatedWords)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
    Random random = new Random();

    List<Word> wordsToHide = new List<Word>();

    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            wordsToHide.Add(word);
        }
    }

    for (int i = wordsToHide.Count - 1; i > 0; i--)
    {
        int j = random.Next(0, i + 1);
        Word temp = wordsToHide[i];
        wordsToHide[i] = wordsToHide[j];
        wordsToHide[j] = temp;
    }

    for (int i = 0; i < numberToHide && i < wordsToHide.Count; i++)
    {
        wordsToHide[i].Hide();
    }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }

        return _reference.GetDisplayText() + ": " + scriptureText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false; // A escritura ainda não está completamente oculta
            }
        }

        return true; // Todas as palavras foram ocultadas
    }
}
