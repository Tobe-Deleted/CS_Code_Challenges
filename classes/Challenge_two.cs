public class Challenge_two
{
    public void GuessNumber()
    {
        Random SecretNumber = new Random();
        int? secret = SecretNumber.Next(1,101); // Assign the secret value
        int? guess = 0;
        int score = 0;
        while (guess != secret)
        {
            // Todo: Implement the correct conditionals inside the while loop.

            Console.Write("Guess the secret number(1-100): ");
            
                guess = Convert.ToInt32(Console.ReadLine());
                
            if(guess < secret)
            {
                Console.WriteLine("Nope! Go higher");
                score++;
            }
            if(guess > secret)
            {
                Console.WriteLine("Nope! Go lower");
                score++;
            }
            if(guess == secret)
            {
                Console.WriteLine($"Yes! The secret number was indeed {secret}!");
                if(score == 1)
                {
                Console.WriteLine($"You made {score} mistake.");
                }
                else Console.WriteLine($"You made {score} mistakes");
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

    public void CheckIfNumberIsEvenOrOdd(int EvenOrOdd)
    {
        // Todo: Check if a number is even or odd
        // if the number is even, write out "even"
        // if the number is odd, write out "odd"
        if(EvenOrOdd % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }
}