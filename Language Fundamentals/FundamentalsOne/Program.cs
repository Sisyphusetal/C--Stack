//Print all numbers from 1 to 255
int i = 1;

while(i<256)
{
    Console.WriteLine(i);
    i++;
}
// Optional For Loop alternate solution:
for(int i=1; i<256; i++)
{
    Console.WriteLine(i);
}

//Generate 5 random numbers between 10 and 20
Random rand = new Random();

for(int i=1; i<6; i++)
{
    Console.WriteLine(rand.Next(10,21));
}
// Alternate While Loop solution:
Random rand = new Random();
int i=1;

while(i<6)
{
    Console.WriteLine(rand.Next(10,21));
    i++;
}

//Modifying previous loop to add the random values together and prin the sum after loop completion
Random rand = new Random();
int sum = 0;

for(int i=1; i<6; i++)
{
    int num = rand.Next(10,21);
    Console.WriteLine(num);
    sum += num;
}

Console.WriteLine(sum);
//Alternate While Loop solution:
Random rand = new Random();
int sum = 0;
int i = 1;

while(i<6)
{
    int num = rand.Next(10,21);
    Console.WriteLine(num);
    sum += num;
    i++;
}

Console.WriteLine(sum);

//Create a loop that prints all value from 1 to 100 that are divisible by 3 or 5, but not both.
for(int i=1; i<101; i++)
{
    if(i%3==0)
    {
        Console.WriteLine($"{i} is divisible by three.");
    }

    if(i%5==0)
    {
        Console.WriteLine($"{i} is divisible by five.");
    }
    //Alternatively this can be written within a single if statement using the || operator,
    //but I wanted to verify my work by adding in the string text so that I could visually check
    //that the code worked as intended.
}
//Alternate While Loop solution:
int i=1;

while(i<101)
{
        if(i%3==0)
    {
        Console.WriteLine($"{i} is divisible by three.");
    }

    if(i%5==0)
    {
        Console.WriteLine($"{i} is divisible by five.");
    }

    i++;
}

//Modify the previous loop to print Fizz for multiples of three and Buzz for multiples of 5.
for(int i=1; i<101; i++)
{
    if(i%3==0)
    {
        Console.WriteLine("Fizz");
    }

    if(i%5==0)
    {
        Console.WriteLine("Buzz");
    }
}
//Alternate While Loop solution:
int i=1;

while(i<101)
{
    if(i%3==0)
    {
        Console.WriteLine("Fizz");
    }

    if(i%5==0)
    {
        Console.WriteLine("Buzz");
    }

    i++;
}

//Modify the previous loop again to now also print FizzBuzz for numbers that are divisible by both 3 AND 5.
for(int i=1; i<101; i++)
{
    if(i%3==0)
    {
        Console.WriteLine("Fizz");
    }

    if(i%5==0)
    {
        Console.WriteLine("Buzz");
    }

    if(i%3==00 && i%5==0)
    {
        Console.WriteLine("FizzBuzz");
    }
}
//Alternate While Loop solution:
int i=1;

while(i<101)
{
    if(i%3==0)
    {
        Console.WriteLine("Fizz");
    }

    if(i%5==0)
    {
        Console.WriteLine("Buzz");
    }

    if(i%3==00 && i%5==0)
    {
        Console.WriteLine("FizzBuzz");
    }

    i++;
}