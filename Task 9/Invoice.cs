namespace Task_9
{
    public class Invoice
    {
        private static int _accountNumber = 0;
        private static int _pdv = 2;

        private string _article = Guid.NewGuid().ToString();
        private int _quantity;

        public int Account { get; init; }
        public string Costumer { get; init; } = string.Empty;
        public string Provider {  get; init; } = string.Empty;

        public Invoice(int account, string costumer, string provider, int quantity)
        {
            Account = account;
            Costumer = costumer;
            Provider = provider;
            _quantity = quantity;
        }

        public int WithoutPdv()
        {
            return _quantity;
        }

        public int WithPdv()
        {
            return _quantity * _pdv;
        }

        public static Invoice Create(string costumer, string provider, int quantity)
        {
            return new Invoice(_accountNumber++, costumer, provider, quantity);
        }
    }
}
