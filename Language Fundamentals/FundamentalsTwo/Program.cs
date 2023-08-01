//Three Basic Arryays

int[] arr1 = new int[] {0,1,2,3,4,5,6,7,8,9};

string[] arr2 = new string[] {"Tim", "Martin", "Nikki", "Sara"};

bool[] arr3 = new bool[10];
for(int i=0; i<arr3.Length; i+=2)
{
    if(arr3[i]==false)
    {
        arr3[i]=true;
    }
}


//List of Flavors
List<string> flavors = new List<string>();
flavors.Add("Vanilla");
flavors.Add("Chocolate");
flavors.Add("Red Velvet");
flavors.Add("Macadamia");
flavors.Add("Rainbow Sparkles");
flavors.Add("Cherry");

Console.WriteLine(flavors.Count());
Console.WriteLine(flavors[2]);
flavors.RemoveAt(2);
Console.WriteLine(flavors.Count());


//User Dictionary
Dictionary<string, string> users = new Dictionary<string, string>();
for(int i=0; i<arr2.Length; i++)
{
    users.Add($"{arr2[i]}", $"{flavors[i]}");
}

foreach(KeyValuePair<string, string> user in users)
{
    Console.WriteLine($"{user.Key} - {user.Value}");
}


