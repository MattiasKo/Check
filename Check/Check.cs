using System;
using System.Collections.Generic;
using System.Text;

namespace Labb5
{

        public class Check<T0,T1>
        {
        public T0 Var1 { get; set; }
        public T1 Var2 { get; set; }
        public virtual void toCheck()
        {
            if (Var1.Equals(Var2))
            {
                Console.WriteLine("var1 and var2 is equal");
            }
            else
            {
                Console.WriteLine("var1 and var2 is not equal");
            }
        }
           
            
        }
}
