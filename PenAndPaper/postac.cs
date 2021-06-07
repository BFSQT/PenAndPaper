using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_r_layeh
{
     public abstract class postac
    {
        //nazwa postaci - atrybuty
        protected string nazwa { get; set; }
        //statystki - atrybuty
        protected int at_zyw { get; set; } //zywotnosc
        protected int at_s { get; set; } //sila
        protected int at_odp { get; set; } //odpornosc

        //umiejetnosci(20) - atrybuty 
        /*
        (0 -> brak wykupionej umiejetnosci /2) 
        (1 -> wykupiona umiejetnosc +0)
        (2 -> wykupiona umiejetnosc +10 do statystyki ) 
        (3 -> wykupiona umiejetnosc +20 do statystyki) 
        0 - charakteryzacja, 1 - dowodzenie, 2 - hazard, 3 - jezdziectwo, 4 - mocna glowa, 5 - opieka nad zwierzetami
        6 - plotkowanie, 7 - plywanie, 8 - powozenie, 9 - przekonywanie, 10 - przeszukiwanie, 11 - skradanie sie
        12 - spostrzegawczosc, 13 - sztuka przetrwania, 14 - targowanie, 15 - ukrywanie sie, 16 - wioslarstwo
        17 - wspinaczka, 18 - wycena, 19 - zastraszanie
        */
        protected int[] tab_umiejetnosci = new int[20];

        //konstruktory
        public postac()
        {
            nazwa = "Wojtus";
            at_zyw = 0;
            at_s = 0;
            at_odp = 0;

            for (int i = 0; i < 20; i++)
            {
                tab_umiejetnosci[i] = 0;
            }
        }
    }
}
