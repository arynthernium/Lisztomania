namespace Lisztomania.Tests;

public abstract class Test
{
	public enum ReturnTypes
	{
		Success,
		Failed
	}
	public abstract ReturnTypes Run();
}