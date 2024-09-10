//Deklarera en array av heltal som innehåler värdena 1,2,3,4,5
int[] ints = {1,2,3,4,5};

//en for loop som loopar igenom ints och skriver ut varje tal
System.Console.WriteLine("For");
for (int i = 0; i < ints.Length; i++)
{
    if (ints[i] == 1)
    {
        continue;
    }

    ints[i] = ints[i] * 2;    
    //ints[i] *= 2;
    System.Console.WriteLine(ints[i]);

    if(ints[i] == 6)
    {
        break;
    }
}

System.Console.WriteLine("Foreach");
//en foreach loop som loopar igenom och skiriiver ut varje tal
foreach (var item in ints)
{
    //item *= 2;
    System.Console.WriteLine(item);
    if(item == 6)
    {
        break;
    }
}

System.Console.WriteLine("While1");
int j = 0;
while (j < ints.Length)
{
    System.Console.WriteLine(ints[j]);
    j++;
}

System.Console.WriteLine("While2");
int l = 0;
while (ints[l] != 5)
{
    System.Console.WriteLine(ints[l]);
    l++;
}

System.Console.WriteLine("do while");
int k = 0;
do
{
    System.Console.WriteLine(ints[k]);
    k++;

} while (ints[k] != 5);
