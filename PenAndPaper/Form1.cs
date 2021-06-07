using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_r_layeh
{
    public partial class Form1 : Form
    {
        int Wynik = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox3.Checked = true;
        }
        bool changed = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (!changed)
            {
                if (checkBox2.Checked)
                {
                    changed = true;
                    checkBox2.Checked = false;
                }
                if (checkBox3.Checked)
                {
                    changed = true;
                    checkBox3.Checked = false;
                }
                if (checkBox4.Checked)
                {
                    changed = true;
                    checkBox4.Checked = false;
                }
                if (checkBox5.Checked)
                {
                    changed = true;
                    checkBox5.Checked = false;
                }
            }
            if (!checkBox2.Checked && !checkBox1.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked) 
            {
                checkBox3.Checked = true;
            }
            else
            {
                changed = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                if (checkBox1.Checked)
                {
                    changed = true;
                    checkBox1.Checked = false;
                }
                if (checkBox3.Checked)
                {
                    changed = true;
                    checkBox3.Checked = false;
                }
                if (checkBox4.Checked)
                {
                    changed = true;
                    checkBox4.Checked = false;
                }
                if (checkBox5.Checked)
                {
                    changed = true;
                    checkBox5.Checked = false;
                }
            }
            if (!checkBox2.Checked && !checkBox1.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked)
            {
                checkBox3.Checked = true;
            }
            else
            {
                changed = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                if (checkBox1.Checked)
                {
                    changed = true;
                    checkBox1.Checked = false;
                }
                if (checkBox2.Checked)
                {
                    changed = true;
                    checkBox2.Checked = false;
                }
                if (checkBox4.Checked)
                {
                    changed = true;
                    checkBox4.Checked = false;
                }
                if (checkBox5.Checked)
                {
                    changed = true;
                    checkBox5.Checked = false;
                }
            }
            if (!checkBox2.Checked && !checkBox1.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked)
            {
                checkBox3.Checked = true;
            }
            else
            {
                changed = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                if (checkBox1.Checked)
                {
                    changed = true;
                    checkBox1.Checked = false;
                }
                if (checkBox2.Checked)
                {
                    changed = true;
                    checkBox2.Checked = false;
                }
                if (checkBox3.Checked)
                {
                    changed = true;
                    checkBox3.Checked = false;
                }
                if (checkBox5.Checked)
                {
                    changed = true;
                    checkBox5.Checked = false;
                }
            }
            if (!checkBox2.Checked && !checkBox1.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked)
            {
                checkBox3.Checked = true;
            }
            else
            {
                changed = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (!changed)
            {
                if (checkBox1.Checked)
                {
                    changed = true;
                    checkBox1.Checked = false;
                }
                if (checkBox2.Checked)
                {
                    changed = true;
                    checkBox2.Checked = false;
                }
                if (checkBox4.Checked)
                {
                    changed = true;
                    checkBox4.Checked = false;
                }
                if (checkBox3.Checked)
                {
                    changed = true;
                    checkBox3.Checked = false;
                }
            }
            if (!checkBox2.Checked && !checkBox1.Checked && !checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked)
            {
                checkBox3.Checked = true;
            }
            else
            {
                changed = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Wynik = +20;
            }
            if (checkBox2.Checked)
            {
                Wynik = +10;
            }
            if (checkBox3.Checked)
            {
                Wynik = +0;
            }
            if (checkBox4.Checked)
            {
                Wynik = -10;
            }
            if (checkBox5.Checked)
            {
                Wynik = -20;
            }
        }
    }
}
