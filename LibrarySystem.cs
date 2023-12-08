// LibrarySystem.cs
class LibrarySystem
{
    static void Main()
    {
        // Create books
        Book book1 = new Book("B001", "The Catcher in the Rye", "J.D. Salinger");
        Book book2 = new Book("B002", "To Kill a Mockingbird", "Harper Lee");

        // Create patrons
        Patron patron1 = new Patron("P001", "John Doe");
        Patron patron2 = new Patron("P002", "Jane Smith");

        // Perform transactions
        Transaction.IssueBook(book1, patron1);
        Transaction.ReturnBook(book1, patron1);
        Transaction.IssueBook(book2, patron2);

        // Display book and patron information
        book1.DisplayInfo();
        patron1.DisplayInfo();
        book2.DisplayInfo();
        patron2.DisplayInfo();
    }
}
