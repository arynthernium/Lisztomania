namespace Lisztomania.Tests;

public class ItemTest : Test
{
	public override ReturnTypes Run()
	{
		ReturnTypes passing = ReturnTypes.Success;
		Item item = new Item();
		if (item.GetType() != typeof(Item))
		{
			passing = ReturnTypes.Failed;
		};
		return passing;
	}
}