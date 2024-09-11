namespace Task_9;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a invoice.");
        Invoice invoice = EnterInvoice();
        Console.WriteLine("Salary without pdv: {0}.", invoice.WithoutPdv());
        Console.WriteLine("Salary with pdv: {0}.", invoice.WithPdv());
    }

    public static Invoice EnterInvoice()
    {
        Console.Write("Enter a customer: "); string customer = Console.ReadLine();
        Console.Write("Enter a provider: "); string provider = Console.ReadLine();
        Console.Write("Enter a quantity: "); int quantity = Convert.ToInt32(Console.ReadLine());
        return Invoice.Create(customer, provider, quantity);
    }
}