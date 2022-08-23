namespace BIT.Patterns.Factory
{
	public class Titanium : CreditCard
	{
		public override decimal GetAnnualCharge() => 250000;

		public override string GetCardType() => nameof(Titanium);

		public override decimal GetCreditLimit() => 260000;
	}
}