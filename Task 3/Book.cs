namespace Task_3
{
    public partial class Book
    {
        private Title _title;
        private Author _author;
        private Content _content;

        public string Title
        {
            get
            {
                return _title.Text;
            }
            set
            {
                _title = new Title(value);
            }
        }

        public string Author
        {
            get
            {
                return _author.Text;
            }
            set
            {
                _author = new Author(value);
            }
        }

        public string Content
        {
            get
            {
                return _content.Text;
            }
            set
            {
                _content = new Content(value);
            }
        }
    }
}
