namespace mutation_testing;

using NUnit.Framework;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddOneElementToList()
    {
        var list = new FixedSizeArrayList<int>(3);

        Assert.That(list.Count, Is.EqualTo(0));

        list.Add(5);

        Assert.That(list.Count, Is.EqualTo(1));
    }

    [Test]
    public void AddToFullList()
    {
        var list = new FixedSizeArrayList<int>(3);

        list.Add(3);
        list.Add(6);
        list.Add(2);
        Assert.That(list.Count, Is.EqualTo(3));

        Assert.Throws<InvalidOperationException>(() => list.Add(4));

        Assert.That(list.Count, Is.EqualTo(3));
    }
}