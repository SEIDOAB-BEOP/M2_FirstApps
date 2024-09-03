// See https://aka.ms/new-console-template for more information
Console.WriteLine("VALUE TYPE!");
stPerson p1 = new stPerson(){FirstName="Severus",LastName="Snape"};
stPerson p2 = p1;
p2.FirstName = "Sam";
p2.LastName = "Gamgee";

System.Console.WriteLine(p1);
System.Console.WriteLine(p2);


Console.WriteLine("Class is REFERENCE TYPE!");
csPerson p3 = new csPerson(){FirstName="Severus",LastName="Snape"};
csPerson p4 = p3;
p4.FirstName = "Sam";
p4.LastName = "Gamgee";

System.Console.WriteLine(p3);
System.Console.WriteLine(p4);


Console.WriteLine("Array is REFERENCE TYPE!");

int[] array1 = new int[]{1,2,3,4,5,6};
int[] array2 = array1;

array2[0] = 100;
System.Console.WriteLine(array1[0]);
System.Console.WriteLine(array2[0]);


public struct stPerson
{
    public string FirstName;
    public string LastName;

    public override string ToString() => $"Hi, I'm {FirstName} {LastName}";
}

public class csPerson
{
    public string FirstName;
    public string LastName;
    public override string ToString() => $"Hi, I'm {FirstName} {LastName}";
}