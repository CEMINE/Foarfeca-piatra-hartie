using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Foarfeca__piatra_hartie
{
   
    public partial class frmMain : Form
    {
       
        class Variables
        {
            public static int scor = 0;
            public static string alegere_jucator = "";
            public static string alegere_inamic = "";
        }



        private void frmMain_Load(object sender, EventArgs e)
        {
            



        }

        private void btnFoarfeca_Click(object sender, EventArgs e)
        {
            Variables.alegere_jucator = "foarfeca";
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            if (randomNumber == 1)
                Variables.alegere_inamic = "foarfeca";
            else if (randomNumber == 2)
                Variables.alegere_inamic = "piatra";
            else
                Variables.alegere_inamic = "hartie";





            if (Variables.alegere_jucator == "foarfeca" && Variables.alegere_inamic == "piatra")
                {
                    MessageBox.Show("Ai pierdut, ai ales " + Variables.alegere_jucator + " iar inamicul a ales " + Variables.alegere_inamic + "\n " + "                                   EAT KAKU");
                    Variables.alegere_jucator = "";
                    Variables.alegere_inamic = "";
                    Variables.scor -= 1;
                    lblPunctaj.Text = Convert.ToString(Variables.scor);
            }

            if (Variables.alegere_jucator == "foarfeca" && Variables.alegere_inamic == "hartie")
            {
                MessageBox.Show("Ai castigat, ai ales " + Variables.alegere_jucator + " iar inamicul a ales " + Variables.alegere_inamic);
                Variables.alegere_jucator = "";
                Variables.alegere_inamic = "";
                Variables.scor += 1;
                lblPunctaj.Text = Convert.ToString(Variables.scor);
            }

            else if (Variables.alegere_jucator == "foarfeca" && Variables.alegere_inamic == "foarfeca")
                {
                    MessageBox.Show("Egalitate");
                    Variables.alegere_jucator = "";
                    Variables.alegere_inamic = "";
                    
                }

                
            }

        public frmMain()
        {
            InitializeComponent();


        }

        private void btnPiatra_Click(object sender, EventArgs e)
        {
            Variables.alegere_jucator = "piatra";
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            if (randomNumber == 1)
                Variables.alegere_inamic = "foarfeca";
            else if (randomNumber == 2)
                Variables.alegere_inamic = "piatra";
            else
                Variables.alegere_inamic = "hartie";





            if (Variables.alegere_jucator == "piatra" && Variables.alegere_inamic == "hartie")
            {
                MessageBox.Show("Ai pierdut, ai ales " + Variables.alegere_jucator + " iar inamicul a ales " + Variables.alegere_inamic+"\n " + "                                   EAT KAKU ");
                Variables.alegere_jucator = "";
                Variables.alegere_inamic = "";
                Variables.scor -= 1;
                lblPunctaj.Text = Convert.ToString(Variables.scor);
            }

            if (Variables.alegere_jucator == "piatra" && Variables.alegere_inamic == "foarfeca")
            {
                MessageBox.Show("Ai castigat, ai ales " + Variables.alegere_jucator + " iar inamicul a ales " + Variables.alegere_inamic);
                Variables.alegere_jucator = "";
                Variables.alegere_inamic = "";
                Variables.scor += 1;
                lblPunctaj.Text = Convert.ToString(Variables.scor);
            }

            else if (Variables.alegere_jucator == "piatra" && Variables.alegere_inamic == "piatra")
            {
                MessageBox.Show("Egalitate");
                Variables.alegere_jucator = "";
                Variables.alegere_inamic = "";

            }
        }

        private void btnHartie_Click(object sender, EventArgs e)
        {
            Variables.alegere_jucator = "hartie";
            Random random = new Random();
            int randomNumber = random.Next(1, 4);

            if (randomNumber == 1)
                Variables.alegere_inamic = "foarfeca";
            else if (randomNumber == 2)
                Variables.alegere_inamic = "piatra";
            else
                Variables.alegere_inamic = "hartie";





            if (Variables.alegere_jucator == "hartie" && Variables.alegere_inamic == "foarfeca")
            {
                MessageBox.Show("Ai pierdut, ai ales " + Variables.alegere_jucator + " iar inamicul a ales " + Variables.alegere_inamic + "\n " + "                                   EAT KAKU");
                Variables.alegere_jucator = "";
                Variables.alegere_inamic = "";
                Variables.scor -= 1;
                lblPunctaj.Text = Convert.ToString(Variables.scor);
            }

            if (Variables.alegere_jucator == "hartie" && Variables.alegere_inamic == "piatra")
            {
                MessageBox.Show("Ai castigat, ai ales " + Variables.alegere_jucator + " iar inamicul a ales " + Variables.alegere_inamic);
                Variables.alegere_jucator = "";
                Variables.alegere_inamic = "";
                Variables.scor += 1;
                lblPunctaj.Text = Convert.ToString(Variables.scor);
            }

            else if (Variables.alegere_jucator == "hartie" && Variables.alegere_inamic == "hartie")
            {
                MessageBox.Show("Egalitate");
                Variables.alegere_jucator = "";
                Variables.alegere_inamic = "";

            }
        }

        
    }
























    }


        
   

