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
        public int at_ww { get; protected set; } //walka wrecz
        public int at_us { get; protected set; } //umiejetnosci strzeleckie
        public int at_k { get; protected set; } //krzepa
        public int at_zr { get; protected set; } //zrecznosc
        public int at_int { get; protected set; } //inteligencja
        public int at_sw { get; protected set; } //sila woli
        public int at_ogd { get; protected set; } //oglada

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

        public gracz(string nz, int at1, int at2, int at3, int at4, int at5, int at6, int at7, int at8, int at9, int at10)
        {
            nazwa = nz;
            at_zyw = at1;
            at_s = at2;
            at_ww = at3;
            at_us = at4;
            at_k = at5;
            at_zr = at6;
            at_int = at7;
            at_sw = at8;
            at_ogd = at9;
            at_odp = at10;

            for (int i = 0; i < 20; i++)
            {
                tab_umiejetnosci[i] = 0;
            }
        }

        //metody
        public void Ustaw_atrybuty(string nz, int at1, int at2, int at3, int at4, int at5, int at6, int at7, int at8, int at9, int at10)
        {
            nazwa = nz;
            at_zyw = at1;
            at_s = at2;
            at_ww = at3;
            at_us = at4;
            at_k = at5;
            at_zr = at6;
            at_int = at7;
            at_sw = at8;
            at_ogd = at9;
            at_odp = at10;
        }

        public void Startowe_umiejetnosci()
        {
            
        }
    }
}
