namespace Task_3
{
    internal class Author : BookMeta
    {
        public string Text { get; set; } = string.Empty;

        public Author(string author)
        {
            Text = author;
        }

        public void Show()
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Author: {0}.", Text);
            Console.ForegroundColor = color;
        }
    }
}
