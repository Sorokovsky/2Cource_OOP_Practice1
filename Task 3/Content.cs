namespace Task_3
{
    public class Content : BookMeta
    {
        public string Text { get; set; } = string.Empty;

        public Content(string content)
        {
            Text = content;
        }

        public void Show()
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Content: {0}.", Text);
            Console.ForegroundColor = color;
        }
    }
}
