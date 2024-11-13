namespace mutation_testing;

using NUnit.Framework;

public class FixedSizeArrayListTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddItem_ShouldIncreaseCountByOne_WhenItemIsAdded()
    {
        // Arrange
        var list = new FixedSizeArrayList<int>(5);
        int initialCount = list.Count;

        // Act
        list.Add(0);

        // Assert
        Assert.That(list.Count, Is.EqualTo(initialCount + 1), 
            "Adding an item did not correctly increase the count by one.");
    }
}
