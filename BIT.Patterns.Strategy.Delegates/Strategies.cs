namespace BIT.Patterns.Strategy.Delegates
{
    internal static class Strategies
	{
        public static string communicateViaEmail(string destination)
             => "communicating " + destination + " via Email..";
        public static string communicateViaPhone(string destination)
            => "communicating " + destination + " via Phone..";
    }
   
}