namespace Lisztomania.Tests;

public class StackTest : Test
{
	public override ReturnTypes Run()
	{
		ReturnTypes passing = ReturnTypes.Success;
		Stack<Item> stack = new Stack<Item>();
		if (stack.GetType() != typeof(Stack<Item>))
		{
			passing = ReturnTypes.Failed;
		};
		return passing;
	}
}