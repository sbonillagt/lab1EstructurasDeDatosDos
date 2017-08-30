using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_ED2_2001516
{
    public partial class Form1 : Form
    {
        Utilities objUtilities = new Utilities();
        
        public Form1()
        {
            InitializeComponent();
            objUtilities.initializingVariables();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (objUtilities.chekUserAndPassword(tbUser.Text, tbPassword.Text)==true)
            {
                MessageBox.Show("Pase joven");
                Form2 objForm1 = new Form2();
                Form2 objForm2 = new Form2();
                objForm1.Visible = false;
                objForm2.Visible = true;

            }
            else
            {
                MessageBox.Show("A ingresado de manera incorrecta su usuario y/o contrasena");
                tbUser.Text = "";
                tbPassword.Text = "";
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
