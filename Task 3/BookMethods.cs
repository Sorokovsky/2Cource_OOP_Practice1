namespace Task_3
{
    public partial class Book
    {
        public void Show()
        {
            if (_title != null)
            {
                _title.Show();
            }
            if (_author != null)
            {
                _author.Show();
            }
            if (_content != null)
            {
                _content.Show();
            }
        }
    }
}
