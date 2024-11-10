namespace mutation_testing;

public class MainFile
{
    static void Main(string[] args)
    {
	var list = new FixedSizeArrayList<int>(3);

	list.Add(3);
	list.Add(5);

	Console.WriteLine(list.Count);

	Console.WriteLine(list.Get(1));

	list.RemoveAt(1);

	Console.WriteLine(list.Count);
    }
}
