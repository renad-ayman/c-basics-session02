using System;
//Question 1
class Book
{
    public string Title { get; set; }
    public int Pages { get; set; }
}

    class Program
{
    static void Main()
    {
        Book book = new Book();
        book.Title = "C# Fundamentals";
        book.Pages = 464;
        object obj = book;
        Console.WriteLine("Title: " + ((Book)obj).Title);

        //Question 2
        Console.WriteLine(book.ToString());
        Console.WriteLine(book.GetHashCode());
        Console.WriteLine(book.GetType());
        Console.WriteLine(book.Equals(obj));

        //Question 3
        //Compiler error: Cannot put "" in int variable. The correct way to declare an integer variable is to use a valid integer value without quotes.
        int pages = 464;
        Console.WriteLine("Page Count: " + pages.ToString());

        //Question 4
        int number = 10;
        try
        {
          int result = number / 0;   
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Done");
        }
    }
}