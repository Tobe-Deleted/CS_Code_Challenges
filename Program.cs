using System.Security.Cryptography;

namespace CS_Code_Challenges;

class Program
{
    static void Main(string[] args)
    {
        Random Cointoss = new Random();
        Random RNG = new Random();
        int AnyNumber = RNG.Next();
        if( Cointoss.Next(0, 2)!=0)
        {
            AnyNumber = AnyNumber - AnyNumber - AnyNumber;
        }
        Console.WriteLine($"Your number is {AnyNumber}");


        Challenge_one one = new Challenge_one();
        one.PrintNumbers();
        string[] Array = [];
        one.PrintStrings(Array);
        one.CheckIfNumberIsPositiveOrNegative(AnyNumber);

        Challenge_two two = new Challenge_two();
        
        Challenge_three three = new Challenge_three();

        three.FizzBuzz(AnyNumber);
        
        

        // validate some methods
        void ValidateRecursiveFactorial()
        {
            int n = 5;
            int expected = 120; // 5! = 120
            int result = three.RecursiveFactorial(n);

            if (result == expected)
            {
                Console.WriteLine($"Test passed: RecursiveFactorial({n}) = {expected}");
            }
            else
            {
                Console.WriteLine($"Test failed: RecursiveFactorial({n}) = {result}, expected: {expected}");
            }
        }

        ValidateRecursiveFactorial();
        
        Console.WriteLine("Type in string to reverse:");
        string? GivenString = Console.ReadLine();
        string ReversedString = three.ReverseString(GivenString);
        Console.WriteLine(ReversedString);
    }
}
