namespace Homework9;

class Program
{
    static void Main(string[] args)
    {
        Student alice = new Student(111, "Alice");
        Student bob = new Student(222,"Bob");
        Student cathy = new Student(333,"Cathy");
        Student david = new Student(444, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if(!gradebook.ContainsKey("Tom")){
            gradebook.Add("Tom", 3.3);
        }
        
        double averageGPA = gradebook.Values.Average();

        Console.WriteLine($"The average GPA is: {averageGPA}");

        foreach (var student in gradebook){
            if(student.Value > averageGPA){
                foreach(var stu in Student.student_list){
                    if(stu.GetStudentName() == student.Key){
                        stu.PrintInfo();
                    }
                }
            }
        }
    }
}
