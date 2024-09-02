// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


stBook[] books = new stBook[]{
    new stBook(){ Title = "Lord of the rings", Author = "J.R.R Tolkien", YearPublished = 1959}, 
    new stBook(){ Title = "Harry Potter", Author = "J.K Rowland", YearPublished = 2010}
    };


public struct stBook {
    public string Title;
    public string Author;
    public int YearPublished;
}
