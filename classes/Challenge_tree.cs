/*
These are very difficult.
*/
public class Challenge_three
{
    public void FizzBuzz(int n)
    {
        // Todo: Implement fizzbuzz, if a number is divisible by 3: Fizz, if a number is divisible by 5: Buzz, if the number is divisible by both 3 and 5, FizzBuzz
        // https://www.geeksforgeeks.org/fizz-buzz-implementation/
        
        string FizzBuzzString = "";
        if(n % 3 == 0)
        {
            FizzBuzzString = "Fizz";
        }
        if(n % 5 == 0)
        {
            FizzBuzzString = FizzBuzzString + "Buzz";
        }
        if(n % 3 == 0 || n % 5 == 0) //Kunne egentlig skippet if sjekken her, men da blir det en tom line.
        {
            Console.WriteLine(FizzBuzzString);
        }
    }

    public int RecursiveFactorial(int n)
    {
        // Todo: Implement a recursive method(a method that calls itself within its own function scope)
        // To Check the factorial of a number(norsk: Fakultet) we look at n!, where n = n * 1 * 2 * 3...
        if (n == 0)
        {
            return 1;
        }
        // n * Method(n - 1);
        return n * RecursiveFactorial(n-1);
    }

    public string ReverseString(string str)
    {
        // Todo: reverse the given string

        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return string.Join("", charArray);
        
    }
}