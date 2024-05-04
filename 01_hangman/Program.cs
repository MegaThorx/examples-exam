// See https://aka.ms/new-console-template for more information

using _01_hangman;

Game game = new Game("Tomate");

while (true)
{
    char letter = ReadLetter();
    game.Guess(letter);
}


static char ReadLetter()
{
    while (true)
    {
        Console.Write("Letter: ");
        string input = Console.ReadLine() ?? String.Empty;

        if (input.Length == 1)
            return input[0];
        
        Console.WriteLine("Please input only one letter!");
    }
}
