namespace BIT.Patterns.Singleton
{
	// Bad code! Do not use!
	public sealed class SingletonNotSafeThread
	{
		private static SingletonNotSafeThread instance = null;

		private SingletonNotSafeThread()
		{
		}

		public static SingletonNotSafeThread Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new SingletonNotSafeThread();
				}
				return instance;
			}
		}
	}
}