namespace MyCompany.OrderEntry.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CanSaveNewOrderHappyPath()
    {
        var service = new OrderService();
        var orderId = service.AddOrder();
        Assert.That(orderId, Is.EqualTo("ORDER-1xx"));
    }

    [Test]
    public void SaveArchiveOrderHappyPath()
    {
        var service = new OrderService();
        var status = service.ArchiveOrder("Order 1234");
        Assert.That(status, Is.Not.Empty);
    }
}