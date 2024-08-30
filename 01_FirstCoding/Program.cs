// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program Begin!");

int sum = 0;
for (int i = 0; i < 4; i++)
{
    sum = sum + i;
    System.Console.WriteLine($"i = {i}");
    System.Console.WriteLine($"sum = {sum}");

    if (sum == 3)
    {
        System.Console.WriteLine($"We have now the magical sum of {sum}");
    }
    System.Console.WriteLine();
}

MyMethod("Martin");
MyMethod("Severus");
Console.WriteLine("Program End!");


static void MyMethod(string s)
{
    System.Console.WriteLine($"Hello {s}");
}
