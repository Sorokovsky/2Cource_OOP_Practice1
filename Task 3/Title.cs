namespace Task_3
{
    public class Title : BookMeta
    {
        public string Text { get; set; } = string.Empty;

        public Title(string title)
        {
            Text = title;
        }

        public void Show()
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Title: {0}.", Text);
            Console.ForegroundColor = color;
        }
    }
}
