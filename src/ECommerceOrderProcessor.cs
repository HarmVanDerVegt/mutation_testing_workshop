namespace mutation_testing;

public class ECommerceOrderProcessor
{
    public decimal ProcessOrder(int quantity, decimal pricePerItem, decimal itemWeight, bool isExpressShipping)
    {
        if (quantity <= 0)
            throw new ArgumentOutOfRangeException("Quantity must be greater than 0.");
        if (pricePerItem < 0)
            throw new ArgumentOutOfRangeException("Price per item cannot be negative.");
        if (itemWeight <= 0)
            throw new ArgumentOutOfRangeException("Item weight must be positive.");

        decimal orderAmount = quantity * pricePerItem;

        if (orderAmount < 10)
            throw new ArgumentException("Order amount must be at least $10.");

        // Bulk discount
        if (orderAmount > 500)
            orderAmount *= 0.90m;

        decimal shippingCost;
        if (itemWeight * quantity < 1)
            shippingCost = 5;
        else if (itemWeight * quantity <= 20)
            shippingCost = 15;
        else
            shippingCost = 25;

        if (isExpressShipping)
            shippingCost += 10; // Got to pay if you want to get it faster!
	
        return orderAmount + shippingCost;
    }
}
