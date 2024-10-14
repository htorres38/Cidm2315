class Professor{
    // Q1
    public string profName {get;set;}
    public string classTeach {get;set;}
    private double salary;

    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }
    public double GetSalary(){
        return salary;
    }
    // Q2
    public void PrintProfInfo(){
        Console.WriteLine($"Professor {profName} teaches {classTeach}, and the salary is: {salary}");
    }
}