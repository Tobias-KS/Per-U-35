using System;
using System.Collections.Generic;
using System.Text;

namespace Per._24_08_20
{
   public abstract class Medarbejder
    {
        public int nr;
        public string navn;
        public double loen;
        public int arbejdstype;
        public abstract double BeregnLoen();
 

    }
    class funktionaer : Medarbejder
    {

        public funktionaer (int x, string y, double z, int b)
        {
            nr = x;
            navn = y;
            loen = z;
            arbejdstype = b;
        }
        

        public override double BeregnLoen() => loen;

    }
    class timeLoennet : Medarbejder
    {
int timer;
        public timeLoennet(int x, string y, double z, int v, int b)
        {
            nr = x;
            navn = y;
            loen = z;
            arbejdstype = b;
            timer = v;
        }


        public override double BeregnLoen()
        {
            double x = loen * timer;
            return x;
        }

      


    }
}
