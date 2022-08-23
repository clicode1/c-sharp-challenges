namespace BIT.Patterns.Factory
{
	public class Platinum : CreditCard
	{
		public override decimal GetAnnualCharge() => 150000;

		public override string GetCardType() => nameof(Platinum);

		public override decimal GetCreditLimit() => 160000;
	}
}