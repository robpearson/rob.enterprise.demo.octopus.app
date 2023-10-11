namespace MyCompany.OrderEntry;

public class OrderService
{
    public string AddOrder()
    {
        var orderId = string.Empty;
        orderId = "ORDER-1xx";
        
        // TODO: Save Order
        
        return orderId;
    }

    public string ArchiveOrder(string orderId)
    {
        var status = string.Format("Order ({{orderId}}) archived.");
        return status;
    }

}