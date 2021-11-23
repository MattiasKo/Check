// Mattias Kokkonen SUT21
using System;

namespace Labb5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Compare1<string, string> C1 = new Compare1<string, string>();
            C1.Var1 = "";
            C1.Var2 = "";
            C1.toCheck();
            Compare1<int, string> C2 = new Compare1<int, string>();
            C2.Var1 = 0;
            C2.Var2 = "0";
            C2.toCheck();
            Compare2<double, float> CC1 = new Compare2<double, float>();
            CC1.Var1 = 0.10;
            CC1.Var2 = 0.10f;
            CC1.toCheck();
            Compare2<float, float> CC2 = new Compare2<float, float>();
            CC2.Var1 = 1;
            CC2.Var2 = 1;
            CC2.toCheck();



        }
    }
  
}
