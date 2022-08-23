using BIT.Patterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ManualTest
{
	internal static class FactoryRun
	{
		public static void CreditCardTest()
		{
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Executing {MethodBase.GetCurrentMethod().Name}");
            Console.WriteLine("__________________________________________________________");

            CreditCard creditCard = new PlatinumFactory().CreateProduct();
            WriteCard(creditCard);

            Console.WriteLine("--------------");

            creditCard = new TitaniumFactory().CreateProduct();
            WriteCard(creditCard);

            Console.WriteLine();
        }

        private static void WriteCard(CreditCard card)
		{
            if (card != null)
            {
                Console.WriteLine("Card Type : " + card.GetCardType());
                Console.WriteLine("Credit Limit : " + card.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + card.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
        }
	}
}
