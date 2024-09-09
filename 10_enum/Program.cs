// See https://aka.ms/new-console-template for more information
Console.WriteLine("Animals!");


var a1 = new stAnimal() {Name = "Max", Age = 5, Kind = enAnimalKind.dog, Mood= enAnimalMood.hungry};
var a2 = new stAnimal() {Name = "Wanda", Age = 2, Kind = enAnimalKind.fish, Mood= enAnimalMood.sleepy};

System.Console.WriteLine(a1);
System.Console.WriteLine(a2);


Console.WriteLine("Playing Cards!");
var c1 = new stPlayingCard(enPlayingCardColor.Spade, enPlayingCardValue.Knight); //{Color = enPlayingCardColor.Spade, Value= enPlayingCardValue.Knight} ;
var c2 = new stPlayingCard(enPlayingCardColor.Heart, enPlayingCardValue.Ace); //{Color = enPlayingCardColor.Heart, Value= enPlayingCardValue.Ace} ;
var c3 = new stPlayingCard(enPlayingCardColor.Club, enPlayingCardValue.Two); //{Color = enPlayingCardColor.Club, Value= enPlayingCardValue.Two} ;

//c1.Value = enPlayingCardValue.Ace;

System.Console.WriteLine(c1);
System.Console.WriteLine(c2);
System.Console.WriteLine(c3);

System.Console.WriteLine("Deck of cards");
stPlayingCard[] deck = new stPlayingCard[52];

int i = 0;
for (enPlayingCardColor c = enPlayingCardColor.Spade; c <= enPlayingCardColor.Diamond; c++)
{
    for (enPlayingCardValue v = enPlayingCardValue.Ace; v <= enPlayingCardValue.King; v++)
    {
        var card = new stPlayingCard(){Color = c, Value = v};
        deck[i] = card;
        i++;
    }
}

for (int j = 0; j < deck.Length; j++)
{
    System.Console.WriteLine(deck[j]);
}

System.Console.WriteLine("Random Card");
var rnd = new Random();
for (int k = 0; k < 10; k++)
{
    var idx = rnd.Next(deck.Length);
    System.Console.WriteLine(deck[idx]);
}



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

public enum enPlayingCardColor {Spade, Club, Heart, Diamond}
public enum enPlayingCardValue {Ace=1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Knight, Queen, King}

public struct stPlayingCard {
    public enPlayingCardColor Color {get; init;}
    public enPlayingCardValue Value {get; init;}

    //public override string ToString() => $"{Value} of {Color}. {((Color == enPlayingCardColor.Heart || Color == enPlayingCardColor.Diamond) ? "Its a red card" :"Its a black card" )}";
    public override string ToString()
    { 
        var s =  $"{Value} of {Color}.";
        
        if (Color == enPlayingCardColor.Heart || Color == enPlayingCardColor.Diamond)
        {
            s = $"{s}. Its a red card";
        }
        else
        {
            s = $"{s}. Its a black card";
        }
        
        return s;
    }
    public stPlayingCard(enPlayingCardColor _color, enPlayingCardValue _value)
    {
        Value = _value;
        Color = _color;
        
    }
}

//Excerices:
//1.    Declare a public enum type PlayingCardColor that models Spade, Club, Heart, Diamond 
//2.    Declare a public enum type PlayingCardValue that models Ace, Two..Ten, Knight, Queen, King.
///     Ace should start with constant = 1
//3.    Declare a public struct PlayingCard that models Color and Value of a playing card. 
//4.    Write a ToString() that presents tha card, e.g Queen of Heart, two of Clubs
//5.    Create 3 playing cards and print them out using Console.WriteLine
