
    class Customer{
    public string customerName {get;set;} = string.Empty;
    public int customerAge {get; set;} = 0;
    public string customerCity {get;set;} = string.Empty;
    public double customerCredit {get;set;} = 0;

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit){
        this.customerName = customerName;
        this.customerAge = customerAge; 
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
    // Q1
     public static void TotalCredits(Customer[] customer_list){
        double totalCredits = 0;
        foreach(Customer creditCount in customer_list){
            totalCredits += creditCount.customerCredit;
        }
        Console.WriteLine($"The total credits: {totalCredits}");
     }
// Q2
public static void AmarilloAverageAge(Customer[] customer_list)
        {
            double averageAge = 0;
            int countAge = 0;

            foreach (var amarilloAge in customer_list)
            {
                if (amarilloAge.customerCity == "Amarillo"){
                    averageAge += amarilloAge.customerAge;
                    countAge++;
                }
            }

            if (countAge > 0){
                double AmarilloAverageAge = averageAge / countAge;
                Console.WriteLine($"The average age of customers in Amarillo: {AmarilloAverageAge}");
                }
            else{
                Console.WriteLine("No customers in Amarillo.");
                }
        }
// Q3     
public static void CanyonAge(Customer[] customer_list){
    string names = "";

    foreach (var customer in customer_list)
    {
        if (customer.customerCity == "Canyon" && customer.customerAge > 30){
            if (names != "")
            {
                names += ", ";
            }
            names += customer.customerName;
        }
    }
    string output = $"Customers who live in Canyon and are over 30 years old: {names}";
    Console.WriteLine(output);
    }

}