// See https://aka.ms/new-console-template for more information

stBook[] books = new stBook[]{
    new stBook(){ Title = "Lord of the rings", Author = "J.R.R Tolkien", YearPublished = 1959}, 
    new stBook(){ Title = "Harry Potter", Author = "J.K Rowland", YearPublished = 2010},
    new stBook(){ Title = "Alfons", Author = "E. Stuart", YearPublished = 2020}
    };


for (int i = 0; i < books.Length; i++)
{
    System.Console.WriteLine(books[i]);
}


public struct stBook {
    public string Title;
    public string Author;
    public int YearPublished;

    public override string ToString() => $"The book {Title}, written by {Author} was published year {YearPublished}."; 
}
