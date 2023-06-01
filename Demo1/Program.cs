//Vi börjar med att lägga till en ny metod AddInvoice till vår klass Customer. Om ni inte har skapat klassen Customer så använd följande kod:

public class Customer
{
    public List<Invoice> Invoices = new List<Invoice>();
    public string CustomerNumber = "";
    public string CustomerName = "";

    // En ny metod som lägger till en faktura i systemet
    public void AddInvoice(Invoice invoice)
    {
        // Detta är ett vanligt misstag
        // vi instansierar en ny lista med fakturor...
        Invoices = new List<Invoice>();
        // och lägger till fakturan vi får in via argumentet...
        Invoices.Add(invoice);
    }
}

//I vår Program klass så gör vi följande ändringar...

internal class Program
{
    private static void Main()
    {
        var customer = new Customer
        {
            CustomerName = "Michael",
            CustomerNumber = "ABC123"
        };

        // Vi använder här kund objektets
        // Invoices fält och dess Add metod
        // och lägger till 3 nya fakturor
        customer.Invoices.Add(new Invoice());
        customer.Invoices.Add(new Invoice());
        customer.Invoices.Add(new Invoice());

        Console.WriteLine("Antal fakturor: {0}", customer.Invoices.Count());

        // Här anropar vi den nya metoden AddInvoice
        // och lägger till en ny faktura
        customer.AddInvoice(new Invoice());

        Console.WriteLine("Antal fakturor: {0}", customer.Invoices.Count());

    }
}

