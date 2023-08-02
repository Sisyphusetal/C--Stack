//Iterate and print values
static void PrintList(List<string> MyList)
{
    // foreach(string value in MyList)
    // {
    //     Console.WriteLine(value);
    // }

    // for(int i=0; i<MyList.Count; i++)
    // {
    //     Console.WriteLine(MyList[i]);
    // }

    MyList.ForEach(delegate(string name)
    {
        Console.WriteLine(name);
    });
    //Found at https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.foreach?view=net-7.0
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);



//Print Sum
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    foreach(int num in IntList)
    {
        sum += num;
    }

    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);


//Find Max
static int FindMax(List<int> IntList)
{
    int highNum = 0;
    foreach(int num in IntList)
    {
        if(num > highNum)
        {
            highNum = num;
        }
    }

    return highNum;
}
List<int> TestIntList2 = new List<int>() {-9,12,10,3,17,5};
// You should get back 17 in this example
Console.WriteLine(FindMax(TestIntList2));


//Square the Values
static List<int> SquareValues(List<int> IntList)
{
    for(int i=0; i<IntList.Count; i++)
    {
        IntList[i] = IntList[i]*IntList[i];
    }

    return IntList;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
Console.WriteLine(SquareValues(TestIntList3));



//Replace Negative Numbers with 0
static int[] NonNegatives(int[] IntArray)
{
    for(int i=0; i<IntArray.Length; i++)
    {
        if(IntArray[i] < 0 )
        {
            IntArray[i] = 0;
        }
    }

    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
Console.WriteLine(NonNegatives(TestIntArray));



//Print Dictionary
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    foreach(KeyValuePair<string, string> element in MyDictionary)
    {
        Console.WriteLine($"{element.Key} {element.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);



//Find Key
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    bool present = false;
    foreach(KeyValuePair<string, string> element in MyDictionary)
    {
        if(element.Key == SearchTerm)
        {
            present = true;
        }
    }

    return present;
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Superman");
TestDict.Add("RealName", "Clark Kent");
TestDict.Add("Powers", "All of them");
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));



//Generate a Dictionary
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    int shorterListLength = 0;
    if(Names.Count > Numbers.Count)
    {
        shorterListLength = Numbers.Count;
    }
    else {
        shorterListLength = Names.Count;
    }

    Dictionary<string, int> dict = new Dictionary<string, int>();

    for(int i=0; i<shorterListLength; i++)
    {
        dict.Add($"{Names[i]}", Numbers[i]);
    }

    return dict;
}
List<string> people = new List<string>() {"Julie", "Harold", "James", "Monica"};
List<int> age = new List<int>() {6, 12, 7, 10};
Console.WriteLine(GenerateDictionary(people, age));