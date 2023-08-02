// Challenge 1
bool amProgrammer = true;
//defined the variable as a boolean but gave it a string value

double age = 27.9;
//defined the variable as an intenger but gave it a double value
//this can be solved by changing int to double (done here) or rounding 27.9 up to 30
//also, best practices speaking variables names should start lowercase and camelcase for each additional word

List<string> names = new List<string>();
//List instantiated correctly, though same best practices issue with single word capitalization
names.Add = "Monica";
//Incorrectly attempted to set names equal to "Monica", did not use .Add method available for that purpose

Dictionary<string, string> myDictionary = new Dictionary<string, string>();
//Dictionary instantiated correctly, once again best practices issue with naming convention
myDictionary.Add("Hello", "0");
//No issues.
myDictionary.Add("Hi there", "0");
//Attempts to add an int as a value when the dictionary only takes strings (declared during instantiation) for it's keys and values

// This is a tricky one! Hint: look up what a char is in C#
string myName = "MyName";
//Best practices naming conventions again, though the primary issue is the use of single quotes,
//which are reserved for char's; single letters



// Challenge 2
List<int> numbers = new List<int>() {2,3,6,7,1,5};
//I'm just going to stop bringing up naming conventions and fix them in sullen silence
for(int i = numbers.Count-1; i >= 0; i--) 
{
    Console.WriteLine(numbers[i]);
}
//For loop attempts to iterate backwards but starts it's index (i) equal to the length of the list.
//The length of the list (6), will not work as an index (i), because lists and arrays are zero-indexed in C#
//This is fixed by adding-1 to numbers.Count, so now the index begins at 5 and decrements until it reaches 0,
//which it will still print due to the i>=0 statement.




// Challenge 3
List<int> moreNumbers = new List<int>() {12,7,10,-3,9};
//Instantiated a list but attempted to populate it using an Array method instead of using .Add
//The resulting list will be empty
foreach(int i in moreNumbers)
{
    Console.WriteLine(moreNumbers[i]);
}




// Challenge 4
List<int> evenMoreNumbers = new List<int> {3,6,9,12,14};
//Same issue as from Challenge three
foreach(int num in evenMoreNumbers)
{
    if(num % 3 == 0)
    {
        num = 0;
    }
}



// Challenge 5
// What can we learn from this error message?
string myString = "superduberawesome";
myString[7] = "p";
//Use of double quotes is reserved for strings, single characters (or chars) use single quotes ''



// Challenge 6
// Hint: some bugs don't come with error messages
Random rand = new Random();
int randomNum = rand.Next(12);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}
//If statement will fail to execute, as the random method is exclusive to it's high end
//meaning that 12 will never occur, only 1-11


