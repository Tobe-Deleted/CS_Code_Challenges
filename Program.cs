using System.Security.Cryptography;

namespace CS_Code_Challenges;

class Program
{
    static void Main(string[] args)
    {
        //Lager Array for oppgaven med array
        string[] Array = ["fisk", "Øre", "pmax", "rykter"];

        //Bruker random nummer istedenfor input
        Random RNG = new Random();
        int AnyNumber = RNG.Next(-100, 101);
        



        Challenge_one one = new Challenge_one();
        one.PrintNumbers();

        one.PrintStrings(Array);

        Console.WriteLine($"Your number is {AnyNumber}");//info om nummer før sjekk
        one.CheckIfNumberIsPositiveOrNegative(AnyNumber);

        Challenge_two two = new Challenge_two();
        two.GuessNumber();
        two.Fibonacci(10);
        two.CheckIfNumberIsEvenOrOdd(AnyNumber);
        
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

        Console.Write("Type in string to reverse:");
        string? GivenString = Console.ReadLine();//Henter string som skal reverseres
        if(GivenString == null)
        {
            GivenString = "nevig tupni oN";
        }
        
        
        string ReversedString = three.ReverseString(GivenString);
        Console.WriteLine(ReversedString);//skriver ut string som er reversert
        
    }
}
