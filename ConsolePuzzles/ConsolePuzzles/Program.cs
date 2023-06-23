using ConsolePuzzles.Interfaces;
using ConsolePuzzles.Puzzles;

var puzzles = new Dictionary<string, IConsolePuzzle>
{
    {"1. Palindrome", new Palindrome()},
    {"2. Prime Number", new PrimeNumber()}
};

Console.WriteLine("Please select a puzzle to run:");

foreach (var puzzle in puzzles)
{
    Console.WriteLine(puzzle.Key);
}

var input = Console.ReadLine();

if (int.TryParse(input, out var selection))
{
    if (puzzles.TryGetValue(input, out var selectedPuzzle))
    {
        selectedPuzzle.Start();
    }
    else
    {
        Console.WriteLine("Please select a valid puzzle.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a number.");
}



var wordCounter = new WordCounter();
wordCounter.Start();
