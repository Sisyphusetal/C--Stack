public class Person
{
    //Access modifier, data-type, then name (anything)
    public string FirstName;

    public string LastName;


    //Constructors are methods that are named after the class itself
    public Person() {}

    public Person(string FirstName, string LastName)
    {
        FirstName = FirstName;
        LastName = LastName;
    }

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }



}