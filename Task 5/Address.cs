namespace Task_5
{
    internal class Address
    {
        public int Index { get; set; }
        public string Country { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string House { get; set; } = string.Empty;
        public string Apartment {  get; set; } = string.Empty;

        public void Show()
        {
            Console.WriteLine("Index: {0}", Index);
            Console.WriteLine("Country: {0}", Country);
            Console.WriteLine("City: {0}", City);
            Console.WriteLine("Street: {0}", Street);
            Console.WriteLine("House: {0}", House);
            Console.WriteLine("Apartment: {0}", Apartment);
        }
    }
}
