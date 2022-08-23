namespace BIT.Patterns.Strategy
{
	/* Concrete implementation of base Strategy */

	internal class NoDiscountStrategy : IOfferStrategy
	{
		public string Name => nameof(NoDiscountStrategy);

		public double GetDiscountPercentage()
		{
			return 0;
		}
	}

	/* Concrete implementation of base Strategy */

	internal class QuarterDiscountStrategy : IOfferStrategy
	{
		public string Name => nameof(QuarterDiscountStrategy);

		public double GetDiscountPercentage()
		{
			return 0.25;
		}
	}
}