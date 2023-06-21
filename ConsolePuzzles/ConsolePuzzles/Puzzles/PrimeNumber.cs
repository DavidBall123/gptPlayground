using ConsolePuzzles.Interfaces;

namespace ConsolePuzzles.Puzzles
{
    internal class PrimeNumber : IConsolePuzzle
    {
        public void Start()
        {
            Console.WriteLine("Enter a number to check if it is a prime number: ");

            var input = Console.ReadLine();
            // Check if is a number
            if (int.TryParse(input, out var number))
            {
                var isPrime = IsPrime(number);
                Console.WriteLine($"Is {number} a prime number: {isPrime}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        private bool IsPrime(int number)
        {
            // check if number is prime
            if (number <= 1)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            return true;
        }
    }
}
