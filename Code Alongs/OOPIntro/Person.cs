public class Person
{
    //Access modifier, data-type, then name (anything)
    public string FirstName;

    public string LastName;


    //Constructors are methods that are named after the class itself
    public Person() {}

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }



}