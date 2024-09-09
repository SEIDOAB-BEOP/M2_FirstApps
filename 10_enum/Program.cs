// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


var a1 = new stAnimal() {Name = "Max", Age = 5, Kind = enAnimalKind.dog, Mood= enAnimalMood.hungry};
var a2 = new stAnimal() {Name = "Wanda", Age = 2, Kind = enAnimalKind.fish, Mood= enAnimalMood.sleeeeepy};

System.Console.WriteLine(a1);
System.Console.WriteLine(a2);

public enum enAnimalKind {dog, cat, bird, fish}
public enum enAnimalMood {sleepy, happy, hungry}

public struct stAnimal
{
    public enAnimalKind Kind;
    public enAnimalMood Mood;
    public string Name;
    public int Age;

    public override string ToString() => $"{Name} the {(int)Mood} {(int)Kind} is {Age} years old.";
}



//Excerices:
//1.    Declare a public enum type PlayingCardColor that models Spade, Club, Heart, Diamond 
//2.    Declare a public enum type PlayingCardValue that models Ace, Two..Ten, Knight, Queen, King.
///     Ace should start with constant = 1
//3.    Declare a public struct PlayingCard that models Color and Value of a playing card. 
//4.    Write a ToString() that presents tha card, e.g Queen of Heart, two of Clubs
//5.    Create 3 playing cards and print them out using Console.WriteLine
