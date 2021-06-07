using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_r_layeh
{
     public abstract class postac
    {
        //statystki - atrybuty
        protected int at_zyw { get; set; } //zywotnosc
        protected int at_s { get; set; } //sila

        //konstruktory
        public postac()
        {
            at_zyw = 0;
            at_s = 0;
        }
    }
}
