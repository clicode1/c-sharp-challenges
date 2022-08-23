namespace BIT.Patterns.Factory
{
	public abstract class CreditCardFactory
	{
		protected abstract CreditCard MakeProduct();

		public CreditCard CreateProduct() => MakeProduct();
	}

	public class TitaniumFactory : CreditCardFactory
	{
		protected override CreditCard MakeProduct()
			=> new Titanium();
	}

	public class PlatinumFactory : CreditCardFactory
	{
		protected override CreditCard MakeProduct()
			=> new Platinum();
	}
}