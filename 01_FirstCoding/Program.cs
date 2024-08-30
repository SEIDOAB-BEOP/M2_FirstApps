// See https://aka.ms/new-console-template for more information
Console.WriteLine("Program Begin!");

MyLoop(10);
MyLoop(3);

MyGreeting("Martin");
MyGreeting("Severus");
Console.WriteLine("Program End!");


static void MyGreeting(string s)
{
    System.Console.WriteLine($"Hello {s}");
}

static void MyLoop(int nrIterations)
{
    int sum = 0;
    for (int i = 0; i < nrIterations; i++)
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
}