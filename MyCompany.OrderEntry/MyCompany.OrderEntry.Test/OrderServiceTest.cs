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
}