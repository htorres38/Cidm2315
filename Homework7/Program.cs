namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        Customer Alice = new Customer(110, "Alice", 28);
        Alice.PrintCusInfo();
        
        Customer Bob = new Customer(111, "Bob", 30);
        Bob.PrintCusInfo();

        Alice.ChangeID(220);
        Bob.ChangeID(221);
        Alice.PrintCusInfo();
        Bob.PrintCusInfo();

        Alice.CompareAge(Bob);

    }
}
