namespace CS_Code_Challenges;

class Program
{
    static void Main(string[] args)
    {
        Challenge_one one = new Challenge_one();
        one.PrintNumbers();
        string[] Array = [];
        one.PrintStrings(Array);
        one.CheckIfNumberIsPositiveOrNegative(1);

        Challenge_two two = new Challenge_two();
        
        Challenge_three three = new Challenge_three();
        //int n = Convert.ToInt32(Console.ReadLine());
        
        //three.FizzBuzz(n);

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
    }
}
