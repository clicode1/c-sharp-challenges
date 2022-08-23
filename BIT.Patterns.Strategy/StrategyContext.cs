namespace BIT.Patterns.Strategy
{
	internal class StrategyContext
	{
		private double price; // price for some item or air ticket etc.

		private Dictionary<string, IOfferStrategy> strategyContext
			= new Dictionary<string, IOfferStrategy>();

		public StrategyContext(double price)
		{
			this.price = price;
			strategyContext.Add(nameof(NoDiscountStrategy),
					new NoDiscountStrategy());
			strategyContext.Add(nameof(QuarterDiscountStrategy),
					new QuarterDiscountStrategy());

		}

		public void ApplyStrategy(IOfferStrategy strategy)
		{
			/*
            Currently applyStrategy has simple implementation.
            You can Context for populating some more information,
            which is required to call a particular operation
            */
			Console.WriteLine("Price before offer :" + price);
			double finalPrice
				= price - (price * strategy.GetDiscountPercentage());
			Console.WriteLine("Price after offer:" + finalPrice);
		}

		public IOfferStrategy GetStrategy(int monthNo)
		{
			/*
            In absence of this Context method, client has to import
            relevant concrete Strategies everywhere.
            Context acts as single point of contact for the Client
            to get relevant Strategy
            */
			if (monthNo < 6)
			{
				return strategyContext[nameof(NoDiscountStrategy)];
			}
			else
			{
				return strategyContext[nameof(QuarterDiscountStrategy)];
			}
		}

		//GetStrategy but as index.
		public IOfferStrategy this[int monthNo]
		{
			get => GetStrategy(monthNo);
		}
	}

	internal class async
	{
	}
}