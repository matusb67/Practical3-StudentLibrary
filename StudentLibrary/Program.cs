using StudentLibrary;

class Program
{
    static void Main(string[] args)
    {
        
        Student student1 = new Student();
        Console.WriteLine("Student 1 details (before getting older):");
        student1.DisplayStudentInfo();
        
        Student student2 = new Student("Jane Doe", 18);
        Console.WriteLine("Student 2 details (before getting older):");
        student2.DisplayStudentInfo();


        student1.GetOlder();
        student2.GetOlder();

        Console.WriteLine("\nStudent 1 details (after getting older):");
        student1.DisplayStudentInfo();
        Console.WriteLine("Student 2 details (after getting older):");
        student2.DisplayStudentInfo();
        Console.WriteLine($"Total Students Created: {Student.StudentCount}");
    }
}