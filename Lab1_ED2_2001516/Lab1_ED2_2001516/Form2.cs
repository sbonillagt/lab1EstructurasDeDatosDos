using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Lab1_ED2_2001516
{
    public partial class Form2 : Form
    {
        string auxTextRichBox = "";
        Utilities objUtilities = new Utilities();
        Song objSong = new Song();
        private string auxNamePL = "";
        SortByName objSortByName = new SortByName();
        

        List<string> namePL=new List<string>();
        public string itemSelectedCB = "";
        
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
            objUtilities.initializingVariables(); // ElIMNAR ESTA LINEA PORQUE SE INCIALIZA EN EL FORM 1 PERO AHORITA NO TENGo ACTIVADO EL FORm 1

            auxTextRichBox = auxTextRichBox + "Todas\n";
            foreach (Song c in objUtilities.listOfAllSongs)
            {
                dataGridView1.Rows.Add(c.name,c.artist,c.album,c.duration);
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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (Song c in objUtilities.listOfAllSongs)
            {
                dataGridView1.Rows.Add(c.name, c.artist, c.album, c.duration);        
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            auxNamePL= Microsoft.VisualBasic.Interaction.InputBox("Ingresa el nombre de tu PlayList", "Nombre de Playlist",
                "Nombre de la playlist");
            
            namePL.Add(auxNamePL);
            refreshListOfPlayList();
        }

        public void refreshListOfPlayList()
        {
            cBoxPlayList.Items.Clear();
            foreach (string d in namePL)
            {
                cBoxPlayList.Items.Add(d);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddToPl_Click(object sender, EventArgs e)
        {
            itemSelectedCB = cBoxPlayList.SelectedItem.ToString(); // Obtengo el nombre de la playkist que esta en el combobox
            dataGridView1.Rows.Clear(); // Limpio el datagrid
            objUtilities.objPlaylist.nameOfPlaylist = itemSelectedCB; // le doy un nombre a la pl
            
            //objUtilities.objPlaylist.ListOfSongPlaList.Add(dataGridView1.SelectedRows.ToString());


            objUtilities.listOfPL.Add(objUtilities.objPlaylist);
        }
    }
}
