namespace BIT.Patterns.Singleton
{
	//This is multithread safe, and is lazy from newers version of net core.
	public sealed class SingletonSafeThreadNoLazy
	{
		private static readonly SingletonSafeThreadNoLazy instance = new SingletonSafeThreadNoLazy();

		// Explicit static constructor to tell C# compiler
		// not to mark type as beforefieldinit
		static SingletonSafeThreadNoLazy()
		{
		}

		private SingletonSafeThreadNoLazy()
		{
		}

		public static SingletonSafeThreadNoLazy Instance
		{
			get
			{
				return instance;
			}
		}
	}
}