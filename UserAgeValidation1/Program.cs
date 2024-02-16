// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanus
//kui kasutaja vanus väiksem kui 13:
//"You are too young to use Instagram."
//Muul juhul
//Konsoolis kuvatakse "Welcome to Instagram"

Console.WriteLine("Enter your age:");
string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean- true/false

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);
Console.WriteLine($"Parse result {isAgeNumber}. User is {userAge} years old.");
if (isAgeNumber = true )
{
    if (userAgeNum > 13)
    {

        Console.WriteLine("Welcome to Instagram!");
    }
    else
    { Console.WriteLine("You are too young to use Instagram.")}
}


//int userAge = Int32.Parse(Console.ReadLine());  //"13" - heap; 13- stack

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
} 
else
{
    Console.WriteLine("You are too young to use Instagram");
}

