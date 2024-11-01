class Student{
    public static List<Student>student_list = new List<Student>();
    private int studentID {get;set;}
    private string studentName {get;set;}
    public Student(int inputID, string inputName){
        studentID = inputID;
        studentName = inputName;
        student_list.Add(this);

    }
    public string GetStudentName(){
        return studentName;
    }
    public void PrintInfo(){
        Console.WriteLine($"Student ID: {studentID}, Student Name: {studentName}");
    }
}