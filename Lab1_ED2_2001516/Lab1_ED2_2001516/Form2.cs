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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //rbName.AutoCheck = true;
            //rbDuration.AutoCheck = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //rbName.AutoCheck = true;
            //rbDuration.AutoCheck = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string auxTextRichBox = "";
            Utilities objUtilities = new Utilities();
            Song objSong = new Song();
            SortByName objSortByName = new SortByName();
            objUtilities.initializingVariables(); // ElIMNAR ESTA LINEA PORQUE SE INCIALIZA EN EL FORM 1 PERO AHORITA NO TENGo ACTIVADO EL FORm 1

            auxTextRichBox = auxTextRichBox + "Todas\n";
            foreach (Song c in objUtilities.listOfAllSongs)
            {
                auxTextRichBox = auxTextRichBox + c.name + " " + c.artist + " " + c.album + " " + c.duration + "\n";
            }
            auxTextRichBox = auxTextRichBox + "\n";
            richTextBox1.Text = auxTextRichBox;

            auxTextRichBox = auxTextRichBox + "Duracion\n";
            objUtilities.listOfAllSongs.Sort(); // por duracion
            foreach (Song c in objUtilities.listOfAllSongs)
            {
                auxTextRichBox = auxTextRichBox + c.name + " " + c.artist + " " + c.album + " " + c.duration + "\n";
            }
            auxTextRichBox = auxTextRichBox + "\n";
            richTextBox1.Text = auxTextRichBox;

            auxTextRichBox = auxTextRichBox + "Nombre\n";

            objUtilities.listOfAllSongs.Sort(objSortByName); // por nombre
            foreach (Song c in objUtilities.listOfAllSongs)
            {
                auxTextRichBox = auxTextRichBox + c.name + " " + c.artist + " " + c.album + " " + c.duration + "\n";
            }

            richTextBox1.Text = auxTextRichBox + "\n";

        }
    }
}
