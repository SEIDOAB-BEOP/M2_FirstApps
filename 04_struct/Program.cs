
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

stBook favorite1 = new stBook(){ Title = "Lord of the rings", Author = "J.R.R Tolkien", YearPublished = 1959};
stBook favorite2 = new stBook(){ Title = "Harry Potter", Author = "J.K Rowland", YearPublished = 2010};


System.Console.WriteLine(favorite1.Title);
System.Console.WriteLine(favorite2.Title);


int i = 5;
int j = i;
i = 15;

System.Console.WriteLine(i);
System.Console.WriteLine(j);

stBook favorite3 = favorite1;
favorite3.Title = "Bilbo";

System.Console.WriteLine(favorite3.Title);
System.Console.WriteLine(favorite1.Title);



public struct stBook {
    public string Title;
    public string Author;
    public int YearPublished;
}
