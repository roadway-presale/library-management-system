// Patron.cs
using System;

public class Patron
{
    public string PatronId { get; private set; }
    public string Name { get; private set; }

    public Patron(string patronId, string name)
    {
        PatronId = patronId;
        Name = name;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Patron ID: {PatronId}");
        Console.WriteLine($"Name: {Name}");
    }
}
