using System;
using System.Collections.Generic;
using System.Text;

namespace Per._24_08_20
{
    class OpretArbejderObject
    {

        public static List<Medarbejder> OpretArbejder()
        {

            int nr;
            string navn;
            double løn;
            int timer;
            int arbejdstype;
            List<Medarbejder> ArbejderListe = new List<Medarbejder>();
            
            nr = 1;
            navn = "Jens";
            løn = 31415;
            arbejdstype = 0;
            Medarbejder medarbj = new funktionaer(nr, navn, løn, arbejdstype);
            ArbejderListe.Add(medarbj);
            
            nr = 2;
            navn = "Per";
            løn = 123;
            timer = 32;
            arbejdstype = 1;
            medarbj = new timeLoennet(nr, navn, løn, timer, arbejdstype);
            ArbejderListe.Add(medarbj);

            nr = 3;
            navn = "Tobias";
            løn = 130;
            timer = 51;
            arbejdstype = 1;
            medarbj = new timeLoennet(nr, navn, løn, timer, arbejdstype);
            ArbejderListe.Add(medarbj);

            nr = 4;
            navn = "Ragnar";
            løn = 23214;
            arbejdstype = 0;
            medarbj = new funktionaer(nr, navn, løn, arbejdstype);
            ArbejderListe.Add(medarbj);

            return ArbejderListe;
            

        }
        
        
    }
}
