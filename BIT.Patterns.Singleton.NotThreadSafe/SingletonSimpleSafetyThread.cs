using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT.Patterns.Singleton
{
    public sealed class SingletonSimpleSafetyThread
    {
        private static SingletonSimpleSafetyThread instance = null;
        private static readonly object padlock = new object();

        SingletonSimpleSafetyThread()
        {
        }

        // use doublelock better
        public static SingletonSimpleSafetyThread Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonSimpleSafetyThread();
                    }
                    return instance;
                }
            }
        }
    }
}
