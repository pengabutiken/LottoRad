using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoGenTheo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartaLottoButton_Click(object sender, EventArgs e)
        {
            

            try
            {
                int[] LottoRad = {
                    TestaNummer(LottoBox1.Text),
                    TestaNummer(LottoBox2.Text),
                    TestaNummer(LottoBox3.Text),
                    TestaNummer(LottoBox4.Text),
                    TestaNummer(LottoBox5.Text),
                    TestaNummer(LottoBox6.Text),
                    TestaNummer(LottoBox7.Text)
                };

                if (LottoRad.Distinct().Count() != 7)
                {
                    throw new Exception("Varje nummer måste vara unikt.");
                }



                int antalDragningar = TestaAntalDragningar(AntalDragningarBox.Text);
                SimuleraLotto(LottoRad, antalDragningar);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private int TestaNummer(string input)
        {
            if (int.TryParse(input, out int nummer) && nummer >= 1 && nummer <= 35)
            {

                return nummer;
            }
            else
            {
                throw new Exception("Ange siffta mellan 1 och 35");
            }

        }
        private int TestaAntalDragningar(string input)
        {
            if(int.TryParse(input,out int antal) && antal>=1 && antal <= 999999)
            {
                return antal;
            }
            else
            {
                throw new Exception("Ange ett antal dragningar, MÅSTE vara mellan 1-999999");
            }
        }
        private void SimuleraLotto(int[] spelarRad,int antalDragningar)
        {
            Random rand = new Random();
            int femRatt = 0, sexRatt = 0, sjuRatt = 0;
            for (int i = 0; i < antalDragningar; i++)
            {
                int[] dragning = GenereraLottoRad(rand);
                int antalRatt = spelarRad.Intersect(dragning).Count();

                if (antalRatt == 5)
                {
                    femRatt++;
                }
                else if (antalRatt == 6)
                {
                    sexRatt++;
                }
                else if (antalRatt == 7)
                {
                    sjuRatt++;

                }
            }
            AntalRattBox1.Text = femRatt.ToString();
            AntalRattBox2.Text=sexRatt.ToString();
            AntalRattBox3.Text=sjuRatt.ToString() ;


        }
        private int[] GenereraLottoRad(Random rnd)
        {
            return Enumerable.Range(1, 35).OrderBy(x => rnd.Next()).Take(7).ToArray();
        }
    }
}
