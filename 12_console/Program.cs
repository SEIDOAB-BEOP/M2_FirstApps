// See https://aka.ms/new-console-template for more information


string _input = null;
bool bOk = false;
while (!bOk)
{
    Console.WriteLine("Enter you name!");
    _input = System.Console.ReadLine();
    if (!string.IsNullOrEmpty(_input))
    {
        bOk = true;
    }
    else
    {
        System.Console.WriteLine("Whaat?...try again");
    }
}

string _name = _input;
System.Console.WriteLine($"Hello {_name}");

int _age = 0;
bOk = false;
while (!bOk)
{
    Console.WriteLine("How old are you?");
    _input = System.Console.ReadLine();
    if (int.TryParse(_input, out _age))
    {
        bOk = true;
    }
    else
    {
        System.Console.WriteLine("Whaat?...try again");
    }
}


if (_age >30)
{
    System.Console.WriteLine($"{_name}, you are {_age} years old!");
}
else
{
    System.Console.WriteLine($"{_name}, you are {_age} years young!");
}