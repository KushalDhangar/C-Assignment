using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    private int copiesAvailable;

    public int CopiesAvailable
    {
        get { return copiesAvailable; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Copies cannot be negative.");
            copiesAvailable = value;
        }
    }

    public Book(string title, string author, string isbn, int copiesAvailable)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        CopiesAvailable = copiesAvailable;
    }

    public void IssueBook()
    {
        if (CopiesAvailable > 0)
        {
            CopiesAvailable--;
            Console.WriteLine($"Issued '{Title}'. Copies remaining: {CopiesAvailable}");
        }
        else
        {
            throw new InvalidOperationException("No copies available to issue.");
        }
    }

    public void ReturnBook()
    {
        CopiesAvailable++;
        Console.WriteLine($"Returned '{Title}'. Copies available: {CopiesAvailable}");
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", "123456789", 3);

        while (true)
        {
            Console.WriteLine("1. Issue Book\n2. Return Book\n3. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            try
            {
                switch (choice)
                {
                    case 1:
                        book.IssueBook();
                        break;
                    case 2:
                        book.ReturnBook();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
