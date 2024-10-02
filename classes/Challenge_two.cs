public class Challenge_two
{
    public void GuessNumber()
    {
        Random SecretNumber = new Random();
        int? secret = SecretNumber.Next(1,101); // Assign the secret value
        int? guess = 0;
        while (guess != secret)
        {
            // Todo: Implement the correct conditionals inside the while loop.

            Console.WriteLine("Guess the secret number(1-100): ");
            guess = int.Parse(Console.ReadLine());

            if(guess < secret)
            {
                Console.WriteLine("Nope! Go higher");
            }
            if(guess > secret)
            {
                Console.WriteLine("Nope! Go lower");
            }
            if(guess == secret)
            {
                Console.WriteLine($"Yes! The secret number was indeed {secret}!");
            }
            //break;
        }
    }

    public void Fibonacci(int n)
    {
        // Todo: Write out the Fibonacci sequence, tips: use a for loop.
        
        int a = 0, b = 1, c;
        for (int FibonacciCounter = 0; FibonacciCounter < n; FibonacciCounter++)
        {
            Console.WriteLine(a);
            c = a + b;
            a = b;
            b = c;
        }
    }

    public void CheckIfNumberIsEvenOrOdd(double a, double b)
    {
        // Todo: Check if a number is even or odd
        // if the number is even, write out "even"
        // if the number is odd, write out "odd"
        Console.WriteLine("");
    }
}