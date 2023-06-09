namespace Lisztomania.Tests;

public class InventoryTest : Test
{
	public override ReturnTypes Run()
	{
		ReturnTypes passing = ReturnTypes.Success;
		Inventory inventory = new Inventory();
		if (inventory.GetType() != typeof(Inventory))
		{
			passing = ReturnTypes.Failed;
		};
		return passing;
	}
}