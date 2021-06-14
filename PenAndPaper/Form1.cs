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
        gracz Roman = new gracz();
        int Wynik = 0;
        int currentMyComboBoxIndex=0;
        int currentMyComboBoxIndex2 = 23;
        int Konto1_Id;
        string Konto1_Rodzaj;

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
            int Statystyka = 0;
            Random rand = new Random();
            if (currentMyComboBoxIndex == 0)
            {
                Wynik = rand.Next(0);
            }
            else if (currentMyComboBoxIndex == 1)
            {
                Wynik = rand.Next(1, 3);
            }
            else if (currentMyComboBoxIndex == 2)
            {
                Wynik = rand.Next(1, 5);
            }
            else if (currentMyComboBoxIndex == 3)
            {
                Wynik = rand.Next(1, 7);
            }
            else if (currentMyComboBoxIndex == 4)
            {
                Wynik = rand.Next(1, 11);
            }
            else if (currentMyComboBoxIndex == 5)
            {
                Wynik = rand.Next(1, 21);
            }
            else if (currentMyComboBoxIndex == 6)
            {
                Wynik = rand.Next(1, 51);
            }
            else if (currentMyComboBoxIndex == 7)
            {
                Wynik = rand.Next(1, 101);
            }
            else 
            {
                MessageBox.Show("Nie wybrałeś kości");
            }

//##################### Wybieranie statystyki ##############################

            if (currentMyComboBoxIndex2 == 20)
            {
                Statystyka = Roman.at_ww;

            }
            if (currentMyComboBoxIndex2 == 21)
            {
                Statystyka = Roman.at_us;
            }
            if (currentMyComboBoxIndex2 == 3 || currentMyComboBoxIndex2 == 11 || currentMyComboBoxIndex2 == 15)
            {
                Statystyka = Roman.at_zr;
                Statystyka = Roman.Sprawdzenie_umiejetnosci(Statystyka, currentMyComboBoxIndex2);

            }
            if (currentMyComboBoxIndex2 == 5 || currentMyComboBoxIndex2 == 10 || currentMyComboBoxIndex2 == 12 || currentMyComboBoxIndex2 == 13 || currentMyComboBoxIndex2 == 18)
            {
                Statystyka = Roman.at_int;
                Statystyka = Roman.Sprawdzenie_umiejetnosci(Statystyka,currentMyComboBoxIndex2);


            }
            if (currentMyComboBoxIndex2 == 0 || currentMyComboBoxIndex2 == 1 || currentMyComboBoxIndex2 == 6 || currentMyComboBoxIndex2 == 9 || currentMyComboBoxIndex2 == 14)
            {
                Statystyka = Roman.at_ogd;
                Statystyka = Roman.Sprawdzenie_umiejetnosci(Statystyka, currentMyComboBoxIndex2);

            }
            if (currentMyComboBoxIndex2 == 7 || currentMyComboBoxIndex2 == 8 || currentMyComboBoxIndex2 == 16 || currentMyComboBoxIndex2 == 17 || currentMyComboBoxIndex2 == 19)
            {
                Statystyka = Roman.at_k;
                Statystyka = Roman.Sprawdzenie_umiejetnosci(Statystyka, currentMyComboBoxIndex2);

            }
            if (currentMyComboBoxIndex2 == 22)
            {
                Statystyka = Roman.at_sw;

            }
            if (currentMyComboBoxIndex2 == 4)
            {
                Statystyka = Roman.At_odp();
                Statystyka = Roman.Sprawdzenie_umiejetnosci(Statystyka, currentMyComboBoxIndex2);

            }



            if (checkBox1.Checked)
            {
                Wynik -=20;
            }
            if (checkBox2.Checked)
            {
                Wynik -= 10;
            }
            if (checkBox3.Checked)
            {
                Wynik += 0;
            }
            if (checkBox4.Checked)
            {
                Wynik += 10;
            }
            if (checkBox5.Checked)
            {
                Wynik += 20;
            }
            if (currentMyComboBoxIndex2 == 23)
            {
                MessageBox.Show("Wynik to: " + Wynik.ToString());

            }
            else if (Wynik > Statystyka)
            {
                MessageBox.Show("Nie Wejszło! Wynik to: " + Wynik.ToString());
            }
            else if (Wynik <= Statystyka)
            {
                MessageBox.Show("Wejszło! Wynik to: " + Wynik.ToString());
            }
            else 
            {
                MessageBox.Show("Wynik to: " + Wynik.ToString());
            }

            using (var context = new PPEntities())
            {

                var rows = context.statystyki_pokoju.ToList();
                int len = rows.Count;
                var row = new statystyki_pokoju();
                row.Id = Konto1_Id;
                if (len == 0)
                    row.Nr_rzutu = 1;
                else
                    row.Nr_rzutu = rows[len-1].Nr_rzutu + 1;
                row.Rodzaj_konta = Konto1_Rodzaj;
                row.Rzut_koscia = Wynik;

                context.statystyki_pokoju.Add(row);
                context.SaveChanges();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            currentMyComboBoxIndex = comboBox1.SelectedIndex;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roman.Ustaw_atrybuty("Roman", 11, 3, 41, 33, 36, 37, 34, 28, 44,37);
            Roman.Startowe_umiejetnosci();
            using (var context2 = new PPEntities())
            {
                var rows = context2.Konta.ToList();
                Konto1_Id = rows[0].Id;
                Konto1_Rodzaj = rows[0].Rodzaj_konta;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMyComboBoxIndex2 = comboBox2.SelectedIndex;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            using (var context2 = new PPEntities())
            {
                var rows = context2.statystyki_pokoju.ToList();
                foreach (var row in rows)
                {
                    var text = row.Nr_rzutu.ToString()  + "  " + row.Id.ToString() + "  " + row.Rodzaj_konta + "  " + row.Rzut_koscia.ToString();
                    textBox1.Text += text + Environment.NewLine;
                }
            }
        }
    }
}
