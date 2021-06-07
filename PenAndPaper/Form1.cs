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
        int currentMyComboBoxIndex=0;
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
            Random rand = new Random();
            if (currentMyComboBoxIndex == 0)
            {
                Wynik = rand.Next(0);
            }
            if (currentMyComboBoxIndex == 1)
            {
                Wynik = rand.Next(1,3);
            }
            if (currentMyComboBoxIndex == 2)
            {
                Wynik = rand.Next(1,5);
                
            }
            if (currentMyComboBoxIndex == 3)
            {
                Wynik = rand.Next(1,7);
            }
            if (currentMyComboBoxIndex == 4)
            {
                Wynik = rand.Next(1,11);
            }
            if (currentMyComboBoxIndex == 5)
            {
                Wynik = rand.Next(1,21);
            }
            if (currentMyComboBoxIndex == 6)
            {
                Wynik = rand.Next(1,51);
            }
            if (currentMyComboBoxIndex == 7)
            {
                Wynik = rand.Next(1,101);

            }
            if (checkBox1.Checked)
            {
                Wynik +=20;
            }
            if (checkBox2.Checked)
            {
                Wynik += 10;
            }
            if (checkBox3.Checked)
            {
                Wynik += 0;
            }
            if (checkBox4.Checked)
            {
                Wynik -= 10;
            }
            if (checkBox5.Checked)
            {
                Wynik -= 20;
            }
            MessageBox.Show("Wejszło albo nie " + Wynik.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            currentMyComboBoxIndex = comboBox1.SelectedIndex;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Roman = new gracz(11,3,41,33,36,37,34,28,44);
            MessageBox.Show(Roman.at_ww.ToString());


        }
    }
}
