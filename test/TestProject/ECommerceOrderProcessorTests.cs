namespace mutation_testing;

using NUnit.Framework;

public class ECommerceOrderProcessorTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ProcessOrder_ShouldApplyBulkDiscount_WhenOrderAmountExceeds500()
    {
        // Arrange
        var processor = new ECommerceOrderProcessor();
        int quantity = 10;
        decimal pricePerItem = 60;  // 10 * 60 = 600, which exceeds $500 for bulk discount
        decimal itemWeight = 0.5m;  // Arbitrary weight below the highest shipping threshold
        bool isExpressShipping = false;  // Regular shipping, no extra cost

        // Act
        decimal result = processor.ProcessOrder(quantity, pricePerItem, itemWeight, isExpressShipping);

        // Assert
        decimal expectedOrderAmount = 600 * 0.90m;  // 10% bulk discount
        decimal expectedShippingCost = 15;  // For items total < 20 kg
        decimal expectedTotalCost = expectedOrderAmount + expectedShippingCost;

        Assert.That(result, Is.EqualTo(expectedTotalCost));
    }
}
