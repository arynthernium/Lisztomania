using System.Reflection;
namespace Lisztomania.Tests;

class Run
{
	static void Main()
	{
		IEnumerable<Test> list = GetEnumerableOfType<Test>();
		foreach (Test test in list)
		{
			Log(test.Run(), test.GetType());
		}
	}
	public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class
	{
		List<T> objects = new List<T>();
		foreach (Type type in
			Assembly.GetAssembly(typeof(T))!.GetTypes()
			.Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
		{
			objects.Add((T)Activator.CreateInstance(type, constructorArgs)!);
		}
		return objects;
	}
	static void Log(Test.ReturnTypes passing, Type type)
	{
		switch (passing)
		{
			case Test.ReturnTypes.Success:
				Console.ForegroundColor = ConsoleColor.Green;
				break;
			case Test.ReturnTypes.Failed:
				Console.ForegroundColor = ConsoleColor.Red;
				break;
			default:
				break;
		}
		Console.WriteLine($"{passing.ToString()}: {type.Name}");
		Console.ResetColor();
	}
}