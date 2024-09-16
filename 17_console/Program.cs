// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int age = 0;
string name = null;

ReadNameAge(out age, out name);

System.Console.WriteLine($"Hello {name}");
System.Console.WriteLine($"Age {age}");

static void ReadNameAge(out int age, out string name)
{
    age = 0;
    name = null;
    bool bOk = false;
    while (!bOk)
    {
        Console.WriteLine("Enter you name;age!");
        string _input = System.Console.ReadLine();

        string[] _inputs = _input.Split(';');
        if (_inputs.Length != 2)
        {
            System.Console.WriteLine("Format error");
        }
        else if (string.IsNullOrEmpty(_inputs[0]))
        {
            System.Console.WriteLine("name Format error");
        }
        else if (!int.TryParse(_inputs[1], out age))
        {
            System.Console.WriteLine("age Format error");
        }
        else
        {
            name = _inputs[0];
            bOk = true;
        }
    }
}