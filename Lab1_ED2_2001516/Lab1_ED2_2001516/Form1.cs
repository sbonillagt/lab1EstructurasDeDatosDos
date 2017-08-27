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
    }
}
