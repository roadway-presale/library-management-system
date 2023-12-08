// Book.cs
using System;

public class Book
{
    public string BookId { get; private set; }
    public string Title { get; private set; }
    public string Author { get; private set; }

    public Book(string bookId, string title, string author)
    {
        BookId = bookId;
        Title = title;
        Author = author;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book ID: {BookId}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
    }
}
