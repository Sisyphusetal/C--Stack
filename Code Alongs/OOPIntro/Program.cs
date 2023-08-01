// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person personOne = new Person("Kurt", "Clausen");


//Can fetch the invidivdual names without parenthesis; with parenthesis is an error because no method exists
Console.WriteLine(personOne.FirstName);
Console.WriteLine(personOne.LastName);

//Parenthesis used to call the class Method
Console.WriteLine(personOne.FullName());

Student studentOne = new Student("Aaron", "Hsu", "C#", 1);

Console.WriteLine(studentOne.FullName());
Console.WriteLine(studentOne.CurrentStack);
Console.WriteLine(studentOne.StudentId);
