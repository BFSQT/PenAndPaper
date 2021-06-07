using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_r_layeh
{
    public class gracz: postac
    {
        //statystyki - atrybuty
        protected int at_ww { get; set; } //walka wrecz
        protected int at_us { get; set;} //umiejetnosci strzeleckie
        protected int at_k { get; set; } //krzepa
        protected int at_zr { get; set; } //zrecznosc
        protected int at_int { get; set; } //inteligencja
        protected int at_sw { get; set; } //sila woli
        protected int at_ogd { get; set; } //oglada

        //konstruktory
        public gracz() : base()
        {
            at_ww = 0;
            at_us = 0;
            at_k = 0;
            at_zr = 0;
            at_int = 0;
            at_sw = 0;
            at_ogd = 0;
        }

        public gracz(int at1, int at2, int at3, int at4, int at5, int at6, int at7, int at8, int at9)
        {
            at_zyw = at1;
            at_s = at2;
            at_ww = at3;
            at_us = at4;
            at_k = at5;
            at_zr = at6;
            at_int = at7;
            at_sw = at8;
            at_ogd = at9;
        }
    }
}
