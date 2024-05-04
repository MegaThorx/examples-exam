namespace _01_hangman;

public class Game
{
    private readonly string _word;

    private List<char> _correctCharacters = new List<char>();

    private List<char> _incorrectCharacters = new List<char>();
    
    public IEnumerable<char> CorrectLetters => _correctCharacters;
    
    public IEnumerable<char> IncorrectLetters => _incorrectCharacters;
    
    public Game(string word)
    {
        _word = word;
    }
    
    public GuessResult Guess(char letter)
    {
        if (_correctCharacters.Contains(letter) ||
            _incorrectCharacters.Contains(letter))
        {
            return GuessResult.AlreadyGuessed;
        }

        if (_word.ToLower().Contains(letter))
        {
            _correctCharacters.Add(letter);

            return GuessResult.CorrectGuess;
        }
        
        _incorrectCharacters.Add(letter);

        return GuessResult.IncorrectGuess;
    }
}