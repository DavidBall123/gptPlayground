using ConsolePuzzles.Interfaces;
using ConsolePuzzles.Puzzles;

var puzzles = new Dictionary<string, IConsolePuzzle>
{
    {"1. Palindrome", new Palindrome()},
    {"2. Prime Number", new PrimeNumber()},
    {"3. Word Counter", new WordCounter()}
};

Console.WriteLine("Please select a puzzle to run:");

foreach (var puzzle in puzzles)
{
    Console.WriteLine(puzzle.Key);
}

var input = Console.ReadLine();

if (int.TryParse(input, out var selection))
{
    selection = selection - 1;
    var game = puzzles.ElementAt(selection);

    game.Value.Start();

}
else
{
    Console.WriteLine("Invalid input. Please enter a number.");
}
