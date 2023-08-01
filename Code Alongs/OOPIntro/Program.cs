// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person personOne = new Person("Kurt", "Clausen");
Person personTwo = new Person("Ben", "Gomez");
Person personThree = new Person("James", "Watson");


//Can fetch the invidivdual names without parenthesis; with parenthesis is an error because no method exists
Console.WriteLine(personOne.FirstName);
Console.WriteLine(personOne.LastName);

//Parenthesis used to call the class Method
Console.WriteLine(personOne.FullName());

Student studentOne = new Student("Aaron", "Hsu", "C#", 1);
Student studentTwo = new Student("Aleksey", "Kashubin", "C#", 2);
Student studentThree = new Student("Nicholas", "Tangsouvanh", "C#", 3);

Console.WriteLine(studentOne.FullName());
Console.WriteLine(studentOne.CurrentStack);
Console.WriteLine(studentOne.StudentId);

List<Person> personList = new List<Person>()
{
    personOne,
    personTwo,
    personThree,
};

foreach(Person p in personList)
{
    Console.WriteLine(p.FullName());
}

List<Student> studentList = new List<Student>();
studentList.Add(studentOne);
studentList.Add(studentTwo);
studentList.Add(studentThree);

Lecture myLecture = new Lecture("C#: OOP", 4, personOne, studentList);
myLecture.PrintAttendance();
