using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Singleton
{
    public class Singleton
    {
        // singleton
        private static int counter = 0;
        private static Singleton? instance = null;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value: " + counter.ToString());
        }

        public void PrintDetails(string details)
        {
            Console.WriteLine(details);
        }

        /*
         * why we should use sealed keyword in the singleton class
         * 
         *       public class SingletonDerived : Singleton
         *       {
         *       }
         */
    }
}
