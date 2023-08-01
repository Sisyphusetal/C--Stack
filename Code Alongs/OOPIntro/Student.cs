public class Student : Person
{
    public string CurrentStack;
    public int StudentId;



    //Re-referencing the elements from the the Person class in base, calling all as parameters inside the constructor
    public Student(string firstName, string lastName, string currentStack, int studentId) : base(firstName, lastName)
    {
        CurrentStack = currentStack;
        StudentId = studentId;
    }
}