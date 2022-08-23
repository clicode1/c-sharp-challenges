namespace BIT.Patterns.Singleton
{
	public sealed class SingletonDoubleSafetyThread
	{
																								#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
		private static SingletonDoubleSafetyThread instance = default;
																								#pragma warning restore CS8625
		private static readonly object padlock = new object();

		private SingletonDoubleSafetyThread()
		{
		}

		public static SingletonDoubleSafetyThread Instance
		{
			get
			{
				if (instance == null)
				{
					lock (padlock)
					{
						if (instance == null)
						{
							instance = new SingletonDoubleSafetyThread();
						}
					}
				}
				return instance;
			}
		}
	}
}