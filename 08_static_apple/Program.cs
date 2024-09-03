// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

csApple a1 = new csApple(20){ kind = "Pink Lady" };
csApple a2 = new csApple(10){ kind = "Royal Gala" };
csApple a3 = new csApple(53){ kind = "Fuji" };
csApple a4 = new csApple(60){ kind = "Granny Smith" };
csApple a5 = new csApple(35){ kind = "Golden delicious" };

System.Console.WriteLine(a1);
System.Console.WriteLine(a2);
System.Console.WriteLine(a3);
System.Console.WriteLine(a4);
System.Console.WriteLine(a5);

System.Console.WriteLine($"I have created {csApple.NrOfApples} apples");
System.Console.WriteLine($"My heaviest apple weigths {csApple.HeavyApple} grams");

public class csApple
{
   public int weight = 0;
   public string kind = null;

   private static int nrOfApples = 0;
   private static int maxWeight = 0;

   public static int HeavyApple => maxWeight;
   public static int NrOfApples => nrOfApples;
   public override string ToString() => $"My {kind} apple weights {weight} grams";

   private csApple()
   {
      nrOfApples++;
   }
   public csApple(int _weight)
   {
      if (_weight > maxWeight)
      {
         maxWeight = _weight;
      }

      weight = _weight;
      nrOfApples++;
   }
}


/*
1. Model an apple in a class, csApple.
   An Apple has a weight in gram (e.g. 83) and a kind (e.g. "Granny Smith")
2. Make a ToString() => $"" that presents an apple
3. Create 5 instances of various apples and print then out
4. Modify csApple to have a static field nrOfApples and a constructor that automatically increments nrOfApples
5. Print out Nr of apples instanstiated.
*/