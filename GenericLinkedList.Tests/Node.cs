using System.Collections;

namespace GenericLinkedList.Tests;

public class Node<T> : IEnumerable<T>
{
	public Node(T value)
	{
		ArgumentNullException.ThrowIfNull(value);
		Value = value;
	}

	public Node<T>? Next { get; set; }
	public T Value { get; }

	#region ienumerable implementation
	public IEnumerator<T> GetEnumerator()
	{
		yield return Value;
		if (Next is not null)
		{
			foreach (var current in Next)
			{
				yield return current;
			}
		}
	}

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	#endregion ienumerable implementation

	public static Node<T> Generate(IEnumerable<T> values)
	{
		ArgumentNullException.ThrowIfNull(values);
		Node<T>? first = null, previous = null;

		foreach (var value in values)
		{
			var current = new Node<T>(value);
			first ??= current;

			if (previous is not null)
			{
				previous.Next = current;
			}

			previous = current;
		}

		return first!;
	}
}