using ConsolePuzzles.Interfaces;

namespace ConsolePuzzles.Puzzles
{
    public class Palindrome : IConsolePuzzle
    {
        public void Start()
        {
            Console.WriteLine("Enter a string to check if it is a palindrome: ");
            var input = Console.ReadLine();

            var isPalindrome = input != null && IsPalindrome(input);

            Console.WriteLine("Is Palindrome: " + isPalindrome);
        }

        private bool IsPalindrome(string input)
        {
            // Convert the input to lowercase and remove spaces and punctuation
            string cleanedInput = CleanString(input);

            // Check if the cleaned input reads the same forward and backward
            string reversedInput = ReverseString(cleanedInput);
            return cleanedInput == reversedInput;
        }

        private string CleanString(string input)
        {
            // Remove spaces, punctuation, and convert to lowercase
            input = new string(input.Where(char.IsLetter).ToArray()).ToLower();

            Console.WriteLine($"The cleaned string is {input}");

            return input;
        }

        private string ReverseString(string input)
        {
            // reveres string
            input = new string(input.Reverse().ToArray());
            return input;
        }
    }
}
