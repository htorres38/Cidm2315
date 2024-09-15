namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Q1
        Console.WriteLine("Input an integer:");
        int N = Convert.ToInt16(Console.ReadLine());
        bool isPrime = true;
        for(int i = 2; i < N; i++)
        {
            if(N % i == 0)
            {
            isPrime = false;
            break;
            }

        }
        if(isPrime && N > 1)
        {
            Console.WriteLine($"{N} is prime");
        }
        else
        {
            Console.WriteLine($"{N} is non-prime");
        }
        // Q2
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row<N; row++)
        {
            for(int col = 0; col<N; col++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
        } 
        // Q3
        Console.WriteLine("Assign an int value to N:");
        int N = Convert.ToInt16(Console.ReadLine());
        for(int row = 0; row<N; row ++)
        {
            for(int col = 0; col<N; col++)
            {
                if(row>=col)
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }
}
