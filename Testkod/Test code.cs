namespace downcasting;

public class Customer
{
  public int Id { get; set; }
  public string Name { get; set; } = "";
}

namespace downcasting;

public class Invoice
{
  // Privata fält...
  private readonly Customer _customer;

  // Publika egenskaper...
  public string InvoiceNumber { get; set; } = "";
  public DateTime InvoiceDate { get; set; }
  public Double Total { get; set; }
// Skapa en constructor metod som tar in en kund referens...
  public Invoice(Customer customer)
  {
    _customer = customer;
  }

  // Publika metoder...
  public void RenderInvoice()
  {
    var freight = CalculateFreight();
  }
  // Privata metoder för intern hantering i klassen...
  private int CalculateFreight()
  {
    return 0;
  }
}

namespace downcasting;

public class ReminderInvoice : Invoice
{
  private readonly int _fee;

  public ReminderInvoice(Customer customer) : base(customer)
  {

  }
}

namespace downcasting;
public class Vehicle
{
  public string RegistrationNumber { get; set; } = "";

  public Vehicle(string registrationNumber) { }
}

using System.Collections;
namespace downcasting;
internal class Program
{
  private static void Main(string[] args)
  {
    // Deklarera en lista som tar allt möjligt...
    var listOfStuff = new ArrayList();
    // Deklarera en lista som enbart tar typen Invoice och dess barn...
    var invoices = new List<Invoice>();

    listOfStuff.Add(new Invoice(new Customer()));
    listOfStuff.Add(new Invoice(new Customer()));
    listOfStuff.Add(new Invoice(new Customer()));
    listOfStuff.Add(new ReminderInvoice(new Customer()));
    // Hoppsan här kom något konstigt in i listan.
    listOfStuff.Add(new Vehicle("ABC123"));
    listOfStuff.Add(new ReminderInvoice(new Customer()));

    foreach (var item in listOfStuff)
    {
      invoices.Add((Invoice)item);
    }
  }
}
