using System.Security.Cryptography.X509Certificates;

public class Challenge_one
{
    public void PrintNumbers()
    {
        // Todo: Print out the numbers 1 - 10
       for(int i = 1; i < 11; i++)
       {
        Console.WriteLine(i);
       }
    }

    public void PrintStrings(string[] arr)
    {
        /* Todo: Print out each string that is passed to the array as an argument*/
        
        foreach(string ArrayString in arr)
        {
            Console.WriteLine(ArrayString);
        }
    }

    public void CheckIfNumberIsPositiveOrNegative(int number)
    {
        /*Todo: Check if a number is positive, negative or zero.*/
        
        if(number < 0)
        {
            Console.WriteLine("number is negative");
            
        }
        else if(number > 0) //endret fra vanlig if til else if etter gjennomgang på fredag
        {
            Console.WriteLine("number is positive");
        }
        else if(number == 0) //endret fra vanlig if til else if etter gjennomgang på fredag
        {
            Console.WriteLine("Number is 0");
        }
        
    }



}