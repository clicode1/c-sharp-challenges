namespace BIT.Patterns.Strategy
{
	/* Interface for Strategy */

	internal interface IOfferStrategy
	{
		string Name { get; }

		double GetDiscountPercentage();
	}
}