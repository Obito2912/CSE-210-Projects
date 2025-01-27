public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        _words = new List<Word>();
        foreach (var word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        var visibleWords = _words.Where(word => !word.isHidden()).ToList();
        int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }
    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (var word in _words)
        {
            scriptureText += $"{word.GetDisplayText()} ";
        }
        return $"{_reference.GetDisplayText()} {scriptureText.Trim()}";
    }
    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }
}