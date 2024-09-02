stAnimal animal1 = new stAnimal(){ Name = "Wanda", Kind = "Fish", Age = 4};
System.Console.WriteLine(animal1);
stAnimal animal2 = new stAnimal(){ Name = "Simba", Kind = "Lion", Age = 5};
System.Console.WriteLine(animal2);



stAnimal[] animals = new stAnimal[]{
    animal1, animal2,
    new stAnimal(){ Name = "Max", Kind = "Dog", Age = 2},
    new stAnimal(){ Name = "Woffie", Kind = "Cat", Age = 5},
    new stAnimal(){ Name = "Dumbo", Kind = "Elephant", Age = 15}
    };

stAnimal.Zoo = "Kalmaarden";
int sum = 0;
for (int i = 0; i < animals.Length; i++)
{
    System.Console.WriteLine(animals[i]);

    //System.Console.WriteLine($"Hi from {animals[i].Name}. I'm {animals[i].Age} years old!");
    System.Console.WriteLine(stAnimal.Zoo);
    sum = sum + animals[i].Age;
}
System.Console.WriteLine($"Total age: {sum}");


public struct stAnimal {
    public string Name;
    public string Kind;
    public int Age;

    public static string Zoo = "Skansen";

    public override string ToString() {
        return $"Hello from {Name}. I'm a {Age} year old {Kind}!";
    }
}
