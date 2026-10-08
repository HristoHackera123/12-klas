namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student name:");
            string studentName = Console.ReadLine();
            Console.WriteLine("Student age:");
            int studentAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Student class (ex. 12A):");
            string studentClass = Console.ReadLine();

            Student student = new Student(studentName, studentAge, studentClass);
            student.DisplayInfo();
        }
    }
}
