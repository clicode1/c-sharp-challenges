namespace BIT.Patterns.Singleton
{
	public sealed class SingletonFullyLazy
	{
		private SingletonFullyLazy()
		{
		}

		public static SingletonFullyLazy Instance
		{ get { return Nested.instance; } }

		private class Nested
		{
			// Explicit static constructor to tell C# compiler
			// not to mark type as beforefieldinit
			static Nested()
			{
			}

			internal static readonly SingletonFullyLazy instance = new SingletonFullyLazy();
		}
	}
}