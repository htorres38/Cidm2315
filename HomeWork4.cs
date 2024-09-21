namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        // Q1
        int return_num = LargeNum(3, 5);
        Console.WriteLine($"The largest number is: {return_num}");
        // Q2 
        Console.WriteLine("Enter a number");
        string input_num = Console.ReadLine();
        int N = Convert.ToInt16(input_num);
        Console.WriteLine("Enter left or right");
        string input_shape = Console.ReadLine();
        Triangle1(N, input_shape);
    }
    // Q1
    static int LargeNum(int a, int b){
        if(a>b){
            Console.WriteLine($"a = {a}; b = {b}");
            return a;
        }
        else{
            Console.WriteLine($"a = {a}; b = {b}");
            return b;
        }
    }
    // Q2
    static void Triangle1(int N, string input_shape){
        if(input_shape=="left"){
            for(int row = 0; row<N; row++){
            for(int col = 0; col<N; col++)
             {
            if(row>=col)
            Console.Write("*");
             }
            Console.WriteLine("");
            }
        }
        else if(input_shape=="right"){
            for(int row = 0; row < N; row++){
                for(int space = 0; space < N - row - 1; space++){
                    Console.Write(" ");
                }
                for(int col = 0; col <= row; col++){
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }
        else{
                Console.WriteLine("Try again, enter \"left\" or \"right\"");
            }
    }

}
