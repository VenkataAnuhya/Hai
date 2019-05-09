using System;

public class Library
{
	public Library()
	{

	}
    public static void main(string[] args)
    {
        Book b = new Book();
        b.bName = "harry potter";
        b.bAuthor = "harry";
        b.no_of_books = 5;
        Book b1 = new Book("baskerville", "sherlockhomes", "10");
        Console.ReadLine();
    }
}
