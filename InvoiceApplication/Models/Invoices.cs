namespace InvoiceApplication.Models;

public class Invoices
{
    public int InvoiceId { get; set; }
    public string CustomerName { get; set; }

    List<InvoicesItems> Items { get; set; }
}