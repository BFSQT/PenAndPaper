using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_r_layeh
{
    public class przeciwnik: postac
    {
        //statystyki - atrybuty
        protected int at_ww { get; set; } //walka wrecz
        protected int at_us { get; set; } //umiejetnosci strzeleckie

        //konstruktory
        public przeciwnik() : base()
        {
            at_ww = 0;
            at_us = 0;
        }

        public przeciwnik(int at1, int at2, int at3, int at4)
        {
            at_zyw = at1;
            at_s = at2;
            at_ww = at3;
            at_us = at4;
        }

    }
}
