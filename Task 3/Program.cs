namespace Task_3;
public static class Program
{
    public static void Main(string[] args)
    {
        Book book = new Book();
        Console.Write("Enter a title: "); book.Title = Console.ReadLine();
        Console.Write("Enter a author: "); book.Author = Console.ReadLine();
        Console.Write("Enter a content: "); book.Content = Console.ReadLine();
        book.Show();
    }
}