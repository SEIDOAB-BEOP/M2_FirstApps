// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int tal0 = 30;
int tal1 = 40;
int tal2 = 50;

System.Console.WriteLine(tal0);
System.Console.WriteLine(tal1);
System.Console.WriteLine(tal2);

for (int i = 0; i < 3; i++)
{
    System.Console.WriteLine(tal1);
}

int[] tal = {30, 40 ,50};
System.Console.WriteLine(tal[0]);
System.Console.WriteLine(tal[1]);
System.Console.WriteLine(tal[2]);

System.Console.WriteLine("Array loop");
for (int i = 0; i < 3; i++)
{
    System.Console.WriteLine(tal[i]);
}


string[] names = {"Martin", "Adel", "August", "Andre", "Sania", "Rebecka"};
for (int i = names.Length-1; i >0; i--)
{
    System.Console.WriteLine($"Hello {names[i]}. Your position in the array is {i}");
    if (names[i] == "Andre")
    {
        break;
    }
}