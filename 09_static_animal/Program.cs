// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



public struct stAnimal {
    public string Name;
    public string Kind;
    public int Age;

    public static string Zoo = "Skansen";

    public override string ToString() {
        return $"Hello from {Name}. I'm a {Age} year old {Kind}!";
    }
}


/*
1. Use above Model of an animal, stAnimal.
   Create 5 instances of various animals and print then out
2. Modify stAnimal to have constructors and static fields to keep track of the
   youngest and oldest age (not animal)
3. Print out youngest and oldest age of animals instatiated

Advances:
4. Modify stAnimal with static fields of type stAnimal to keep track of oldest and yougest animal (not only age) 
5. Print out youngest and oldest animals (not only age) instatiated
*/