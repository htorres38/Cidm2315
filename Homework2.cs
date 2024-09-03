namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1

       Console.WriteLine("Please input a letter grade: ");
        string grade = Console.ReadLine();

            int gradeLetter = 0; 
            switch (grade)
            {
                case "A":
                gradeLetter = 4;
                break;
                case "B":
                gradeLetter = 3; 
                break;
                case "C":
                gradeLetter = 2;
                break;
                case "D":
                gradeLetter = 1; 
                break;
                case "F":
                gradeLetter = 0;
                break;
                default:
                    Console.WriteLine("Wrong Letter Grade!");
                    return;
            }
            Console.WriteLine($"GPA Point: {gradeLetter}");

        // Code for Q2

        Console.WriteLine("Please input the first num:");
        int firstNumber = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the second num:");
        int secNumber = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Please input the third num:");
        int thirdNumber = Convert.ToInt16(Console.ReadLine());
        int smallest;
        if ((firstNumber <= secNumber) && (firstNumber <= thirdNumber))
        {
            smallest = firstNumber;
        }
        else if ((secNumber <= firstNumber) && (secNumber <= thirdNumber))
        {
            smallest = secNumber;
        }
        else
        {
            smallest = thirdNumber;
        }
        Console.WriteLine($"The smallest value is: {smallest}");

        // Code for Bonus Question

        Console.WriteLine("Please input a Year:");
        int year = Convert.ToInt16(Console.ReadLine());
        bool leapYear = ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0));
        if (leapYear)
        {
            Console.WriteLine($"{year} is a Leap Year.");
        }
        else
        {
            Console.WriteLine($"{year} is not a Leap Year.");
        }

    }
}
