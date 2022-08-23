using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT.Patterns.Strategy.Delegates
{
    public class Service
    {
        private Func<string, string> communcationMeans;

        public Service()
		{
            SetCommuncationMeans(Strategies.communicateViaEmail);
            SetCommuncationMeans(Strategies.communicateViaPhone);

            //Allow to add delegated strategies. Use it on program not here.
            SetCommuncationMeans((string destination)
                => "communicating " + destination + " via Video..");
        }
        
        public void SetCommuncationMeans(Func<string, string> communcationMeans)
        {
            this.communcationMeans = communcationMeans;
        }
        public void Communicate(string destination)
        {
            var communicate = communcationMeans(destination);
            Console.WriteLine(communicate);
        }
    }
}
