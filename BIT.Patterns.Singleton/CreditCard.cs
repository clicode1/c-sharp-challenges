namespace BIT.Patterns.Factory
{
	public abstract class CreditCard
	{
		public abstract string GetCardType();
		public abstract decimal GetCreditLimit();
		public abstract decimal GetAnnualCharge();
	}
}