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
        public int at_ww { get; protected set; } //walka wrecz
        public int at_us { get; protected set; } //umiejetnosci strzeleckie

        //ekwipunek - atrybuty
        public string typ_bron { get; protected set; } //typ broni
        public int obr_bron { get; protected set; } //obrazenia od broni

        //konstruktory
        public przeciwnik() : base()
        {
            at_ww = 0;
            at_us = 0;
            typ_bron = "Pioro";
            obr_bron = 0;
        }

        public przeciwnik(string nz, int at1, int at2, int at3, int at4, int at5, string typ, int br)
        {
            nazwa = nz;
            at_zyw = at1;
            at_s = at2;
            at_ww = at3;
            at_us = at4;
            at_odp = at5;
            typ_bron = typ;
            obr_bron = br;
        }

    }
}
