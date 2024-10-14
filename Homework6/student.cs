class Student{
    // Q1
    public string studentName {get;set;}
    public string classEnroll {get;set;}
    private double studentGrade;

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }
    public double GetGrade(){
        return studentGrade;
    }
    // Q2
    public void PrintStudentInfo(){
        Console.WriteLine($"Student {studentName} enrolls in {classEnroll}, and the grade is: {studentGrade}");
    }

}