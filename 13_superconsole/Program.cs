using Seido.Utilities.ConsoleInput;

string _name = null;
int _age = 0;
enAnimalKind _animalKind = enAnimalKind.dog;

if (csConsoleInput.TryReadString("Enter you name!", out _name) &&
    csConsoleInput.TryReadInt32("How old are you?", 0, 100, out _age) &&
    csConsoleInput.TryReadEnum<enAnimalKind>("What is you favirote animal?", out _animalKind))
{
    System.Console.WriteLine($"Hello {_name}");
    if (_age >30)
    {
        System.Console.WriteLine($"{_name}, you are {_age} years old!");
    }
    else
    {
        System.Console.WriteLine($"{_name}, you are {_age} years young!");
    }
    System.Console.WriteLine($"You like an animal of type {_animalKind}");
}


public enum enAnimalKind {dog, cat, bird, fish}