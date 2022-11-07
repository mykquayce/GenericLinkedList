namespace GenericLinkedList.Tests;

public class Tests
{
	[Theory]
	[InlineData(1, 2, 3, 4, 5, 6, 7)]
	[InlineData(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)]
	public void Ints(params int[] values)
	{
		var first = Node<int>.Generate(values);

		Assert.NotNull(first);
		Assert.Equal(values[0], first.Value);
		Assert.NotNull(first.Next);
		Assert.Equal(values[1], first.Next.Value);

		var enumerated = first.ToArray();
		Assert.NotEmpty(enumerated);
		Assert.Equal(values, enumerated);
	}

	[Theory]
	[InlineData('1', '2', '3', '4', '5', '6', '7')]
	[InlineData('1', '2', '3', '4', '5', '6', '7', '8', '9', 'a')]
	public void Chars(params char[] values)
	{
		var first = Node<char>.Generate(values);

		Assert.NotNull(first);
		Assert.Equal(values[0], first.Value);
		Assert.NotNull(first.Next);
		Assert.Equal(values[1], first.Next.Value);

		var enumerated = first.ToArray();
		Assert.NotEmpty(enumerated);
		Assert.Equal(values, enumerated);
	}

	[Theory]
	[InlineData("1", "2", "3", "4", "5", "6", "7")]
	[InlineData("1", "2", "3", "4", "5", "6", "7", "8", "9", "10")]
	public void Strings(params string[] values)
	{
		var first = Node<string>.Generate(values);

		Assert.NotNull(first);
		Assert.Equal(values[0], first.Value);
		Assert.NotNull(first.Next);
		Assert.Equal(values[1], first.Next.Value);

		var enumerated = first.ToArray();
		Assert.NotEmpty(enumerated);
		Assert.Equal(values, enumerated);
	}
}
