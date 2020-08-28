using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Per._24_08_20
{
    public partial class Form1 : Form
    {
        int arbejdeInt = 0;
        void testInt()
        {
            if (arbejdeInt == -1)
            {
                arbejdeInt = 3;
            }
            else if (arbejdeInt == 4)
                {
                    arbejdeInt = 0;
                }
        }
        string checkArbejdstype(int x)
        {
            if (x == 0)
            {
                return "Funktionær";
            }
            else return "Timelønnet";
        }

        List<Medarbejder> ArbejderListe = OpretArbejderObject.OpretArbejder();
        public Form1()
        {
            InitializeComponent();
            int checkType = ArbejderListe[arbejdeInt].arbejdstype;

            textBox1.Text = ArbejderListe[arbejdeInt].BeregnLoen().ToString();
            textBox2.Text = ArbejderListe[arbejdeInt].navn;
            textBox3.Text = ArbejderListe[arbejdeInt].nr.ToString();
            textBox4.Text = checkArbejdstype(checkType);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int checkType = 0;
            try
            {
                checkType = ArbejderListe[arbejdeInt].arbejdstype;
            }
            catch (Exception)
            {
                arbejdeInt = 0;
            }
            textBox1.Text = ArbejderListe[arbejdeInt].BeregnLoen().ToString();
            textBox2.Text = ArbejderListe[arbejdeInt].navn;
            textBox3.Text = ArbejderListe[arbejdeInt].nr.ToString();
            textBox4.Text = checkArbejdstype(checkType);

            arbejdeInt--;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int checkType = 0;
            try
            {
               checkType = ArbejderListe[arbejdeInt].arbejdstype;
            }
            catch (Exception)
            {
                arbejdeInt = 0;
            }
            

            textBox1.Text = ArbejderListe[arbejdeInt].BeregnLoen().ToString();
            textBox2.Text = ArbejderListe[arbejdeInt].navn;
            textBox3.Text = ArbejderListe[arbejdeInt].nr.ToString();
            textBox4.Text = checkArbejdstype(checkType);

            arbejdeInt++;
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
            
        {
            double loenSum = 0;
            string savelocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter sw = new StreamWriter(Path.Combine(savelocation, "test.txt")))  
            {

                foreach (Medarbejder arb in ArbejderListe)
                {
                    sw.WriteLine("Navn Nr Løn Arbejdstype");
                    sw.WriteLine( $"{arb.navn} { arb.nr} { arb.BeregnLoen()} { arb.arbejdstype}");
                    sw.Write(" ");
                    loenSum = loenSum + arb.loen;
                    /* sw.Write(arb.nr);
                     sw.Write(arb.loen);
                     sw.Write(checkArbejdstype(arb.arbejdstype));
                    */
                }
                sw.WriteLine("den samlede sum er " + loenSum);
            }
            }
            
        }
    }

