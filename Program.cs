using System.Security.Cryptography;
/*
    Jeg har brukt kommentar til å forklare ting som kanskje er litt utenfor 
    det oppgaven spør om
*/
namespace CS_Code_Challenges;

class Program
{
    static void Main(string[] args)
    {

        string[] Array = ["fisk", "øre", "pmax", "rykter"];//Lager Array med strings for PrintStrings oppgaven

        /*
        Bruker random nummer istedenfor input for PositiveOrNegative oppgaven,
        OddOrEven oppgaven og FizzBuzz oppgaven
        */
        Random RNG = new Random();
        int AnyNumber = RNG.Next(-100, 101);
        



        Challenge_one one = new Challenge_one();
        one.PrintNumbers();

        one.PrintStrings(Array);

        Console.WriteLine($"Your number is {AnyNumber}");//info om hva nummer brukes før sjekk
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


        //reverse string oppgaven:
        Console.Write("Type in string to reverse:");
        string? GivenString = Console.ReadLine();//input for string som skal reverseres

        if(GivenString == null)//Lagt til for å bli kvitt null reference error
        {
            GivenString = "nevig tupni oN";
        }
        
        string ReversedString = three.ReverseString(GivenString);

        Console.WriteLine(ReversedString);//skriver ut string som er reversert
        
    }
}
