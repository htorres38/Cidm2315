namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Q1
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        int largest = LargestInt(a, b);
        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {largest}");
        // Q2
        int c = Convert.ToInt16(Console.ReadLine());
        int d = Convert.ToInt16(Console.ReadLine());
        int e = Convert.ToInt16(Console.ReadLine());
        int f = Convert.ToInt16(Console.ReadLine());
        int max1 = LargestInt(c, d);
        int max2 = LargestInt(e,f);
        int Largest2 = LargestInt(max1, max2);
        Console.WriteLine($"a = {c}; b = {d}; c = {e}; d = {f}");
        Console.WriteLine($"The largest number is: {Largest2}");
        // Q3
        createAccount();

    }
    // Q1&Q2
    static int LargestInt(int num1, int num2){
        int max; 
        if(num1>num2){
            max = num1;
        }
        else{
            max = num2;
        }
        return max;
    }
    // Q3
    static bool checkAge(int birth_year){
        int current_year = 2024;
        int age = current_year - birth_year;
        if(age>=18){
            return true;
        }
        else{
            return false;
        }
    }
    static void createAccount(){
        Console.WriteLine("Enter your username:");
        string username = Console.ReadLine();
        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine();
        Console.WriteLine("Enter your password again:");
        string checkPassword = Console.ReadLine();
        Console.WriteLine("Enter your Birthyear:");
        int birthYear = Convert.ToInt16(Console.ReadLine());

        if (checkAge(birthYear))
        {
            if (password == checkPassword){
                Console.WriteLine("Account is created successfully");
            }
            else{
                Console.WriteLine("Wrong password");
            }
        }
        else{
            Console.WriteLine("Could not create an account");
        }
    }
    
}
