namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        // Q1
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTeach = "Java";
        p1.SetSalary(9000);
        // Q2
        p1.PrintProfInfo();
        // Q1
        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTeach = "Math";
        p2.SetSalary(8000);
        // Q2
        p2.PrintProfInfo();
        // Q1
        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.SetGrade(90);
        // Q2
        s1.PrintStudentInfo();
        // Q1
        Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.SetGrade(80);
        // Q2
        s2.PrintStudentInfo();
        
        double salaryDifference = p1.GetSalary() - p2.GetSalary();
        Console.WriteLine($"The salary difference between Alice and Bob is: {salaryDifference}");
        double totalGrade = s1.GetGrade() + s2.GetGrade();
        Console.WriteLine($"The total grade of Lisa and Tom is: {totalGrade}");
    }
}
