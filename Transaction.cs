// Transaction.cs
using System;

public class Transaction
{
    public static void IssueBook(Book book, Patron patron)
    {
        Console.WriteLine($"Book Issued to {patron.Name}:");
        book.DisplayInfo();
        patron.DisplayInfo();
        Console.WriteLine("Transaction completed successfully.");
    }

    public static void ReturnBook(Book book, Patron patron)
    {
        Console.WriteLine($"Book Returned by {patron.Name}:");
        book.DisplayInfo();
        patron.DisplayInfo();
        Console.WriteLine("Transaction completed successfully.");
    }
}
