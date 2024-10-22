class Customer{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public void PrintCusInfo(){
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age:{cus_age}");
    }

    public Customer(int id, string name, int age){
        cus_id = id;
        cus_name = name;
        cus_age = age;
    }

    public void ChangeID(int new_id){
        cus_id = new_id;

    }

    public void CompareAge(Customer objCustomer){
        if(cus_age>objCustomer.cus_age){
            Console.WriteLine($"{cus_name} is older.");
        }
        else if(cus_age<objCustomer.cus_age){
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
        
    }
}