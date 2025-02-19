using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheoCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string operation;
        long siffra1, siffra2, resultat;
        bool operationPressed= false;



        private void OneB_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + "1";
        }

        private void TwoB_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + "2";
        }

        private void ThreeB_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + "3";
        }

        private void FourB_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + "4";
        }

        private void FiveB_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + "5";
        }

        private void SixB_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + "6";
        }

        private void SevenB_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + "7";
        }

        

        private void EightB_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + "8";
        }

       

        private void NineB_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + "9";
        }

        

        private void ZeroB_Click(object sender, EventArgs e)
        {
            UserInputBox.Text = UserInputBox.Text + "0";
        }

        

        private void AddB_Click(object sender, EventArgs e)
        {
            if (operationPressed) return;
            operationPressed = true;

                operation = "+";

            if (!long.TryParse(UserInputBox.Text, out siffra1))
            {
                MessageBox.Show("Tal är för stort eller så försöker du klicka på plustecken mer än en gång ");
                UserInputBox.Clear();
                return;
            }
           
            
            UserInputBox.Clear();
            UserInputLabel.Text = siffra1 + "+";

        }

        

        private void SubB_Click(object sender, EventArgs e)
        {
            operation = "-";

            if (!long.TryParse(UserInputBox.Text, out siffra1))
            {
                MessageBox.Show("Tal är för stort eller så försöker du klicka på minustecken mer än en gång");
                UserInputBox.Clear();
                return;
            }
            
           
            UserInputBox.Clear();
            UserInputLabel.Text = siffra1 + "-";
        }

        

        private void MultiplyB_Click(object sender, EventArgs e)
        {
            operation = "*";

            if (!long.TryParse(UserInputBox.Text, out siffra1))
            {
                MessageBox.Show("Tal är för stort eller så försöker du klicka på multiplikationstecken mer än en gång");
                UserInputBox.Clear();
                return;
            }
            
           
            UserInputBox.Clear();
            UserInputLabel.Text = siffra1 + "*";
        }

        private void DivideB_Click(object sender, EventArgs e)
        {
            operation = "/";
            if (!long.TryParse(UserInputBox.Text, out siffra1))
            {
                MessageBox.Show("Tal är för stort eller så försöker du klicka på division tecken mer än en gång");
                UserInputBox.Clear();
                return;
            }
            
            
            UserInputBox.Clear();
            UserInputLabel.Text = siffra1 + "/";
        }
        private void EqualsB_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserInputBox.Text))
            {
                MessageBox.Show("Du måste ange ett tal innan du trycker på =");
                return;
            }

            if (!long.TryParse(UserInputBox.Text, out siffra2))
            {
                MessageBox.Show("Tal är för stort eller ogiltigt!");
                UserInputBox.Clear();
                return;
            }

            try
            {
                
                if (operation.Equals("+"))
                    resultat = checked(siffra1 + siffra2);
                else if (operation.Equals("-"))
                    resultat = checked(siffra1 - siffra2);
                else if (operation.Equals("*"))
                    resultat = checked(siffra1 * siffra2);
                else if (operation.Equals("/"))
                {
                    if (siffra2 == 0)
                    {
                        MessageBox.Show("Du får ej dividera med 0");
                        return;
                    }
                    resultat = siffra1 / siffra2;
                }

               
                UserInputLabel.Text = "";
                UserInputBox.Clear();
                UserInputBox.Text = resultat.ToString();

                
                operationPressed = false;

                
                siffra1 = resultat; 
            }
            catch (OverflowException)
            {
                MessageBox.Show("Resultatet är för stort för att hanteras!");
                UserInputBox.Clear();
            }
        }
        
        private void ResetB_Click(object sender, EventArgs e)
        {
            UserInputBox.Clear();
            UserInputLabel.Text=""; 
            siffra1 = (0);
            siffra2 = (0);
            resultat = (0);

        }
    }
}
