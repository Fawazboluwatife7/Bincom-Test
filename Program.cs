

//Preliminary Interview Test for .Net C# Developer Trainee (Internship)  for Mustapha Babatunde 

//TASK ONE 
string name = "John Doe";
int age = 25;
bool isAdmin = true;

Console.WriteLine($"{name}  is {age} and it is {isAdmin} that he is an admin");


//TASK TWO


Console.WriteLine("Task two");
Console.WriteLine("Enter your desired number");

var input = Console.ReadLine();

var userinput = Convert.ToInt32(input);

if (userinput == null)
{
    Console.WriteLine("Input cannot be empty");
}

else if (userinput != null)
{
    if (userinput % 2 == 0)
    {
        Console.WriteLine($"Number {input} is an even number ");
    }
    else
    {
        Console.WriteLine($"Number {input} is an odd number ");
    }

}



//Task 3
Console.WriteLine("Task three");
int number = 10;

for (int i = 1; i <= number; i++)
{
    Console.WriteLine(i.ToString());
}




//Task 4
Console.WriteLine("Task four");
int[] integerArray = new int[5] { 2, 4, 6, 8, 10 };
int arraySumTotal = integerArray.Sum(x => x);
Console.WriteLine($"Sum of Numbers in the Integer Array= {arraySumTotal}\n");
Console.WriteLine("Elements of the Integer array are:");
foreach (int numbers in integerArray)
{
    Console.WriteLine(numbers);
}


//Task 5
Console.WriteLine("Task five");
void Greet (string greetings)
{

    Console.WriteLine($"Hello ! {greetings}");
}

Greet("Alice");
