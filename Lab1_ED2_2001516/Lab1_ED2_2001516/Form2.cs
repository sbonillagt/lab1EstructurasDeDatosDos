﻿using System;
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
        private int selectedRow = 0;


        List<string> namePL = new List<string>();
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
            objUtilities
                .initializingVariables(); // ElIMNAR ESTA LINEA PORQUE SE INCIALIZA EN EL FORM 1 PERO AHORITA NO TENGo ACTIVADO EL FORm 1
            objUtilities.readPlayListNames();
            for (int i = 0; i < objUtilities.listOfNamesPL.Count; i++)
            {
                cBoxPlayList.Items.Add(objUtilities.listOfNamesPL[i]);
            }


            auxTextRichBox = auxTextRichBox + "Todas\n";
            foreach (Song c in objUtilities.listOfAllSongs)
            {
                dataGridView1.Rows.Add(c.name, c.artist, c.album, c.duration);
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

            objUtilities.listSongsByPlayList.Clear();
            for (int i = 0; i < objUtilities.listOfAllSongs.Count; i++)
            {
                objUtilities.listSongsByPlayList.Add(objUtilities.listOfAllSongs[i]);
            }
            // objUtilities.listSongsByPlayList= objUtilities.listOfAllSongs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            auxNamePL = Microsoft.VisualBasic.Interaction.InputBox("Ingresa el nombre de tu PlayList",
                "Nombre de Playlist",
                "Nombre de la playlist");
            objUtilities.readPlayListNames();
            objUtilities.listOfNamesPL.Add(auxNamePL);
            refreshListOfPlayList();
            objUtilities.writePlayListNames();
        }

        public void refreshListOfPlayList()
        {
            cBoxPlayList.Items.Clear();
            for (int i = 0; i < objUtilities.listOfNamesPL.Count; i++)
            {
                cBoxPlayList.Items.Add(objUtilities.listOfNamesPL[i]);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // objUtilities.auxCBox = cBoxPlayList.Text.ToString();

            if (cBoxPlayList.Text == "")
            {
                MessageBox.Show("No tiene seleccioanada la playList a la que mostrar");
            }
            else
            {
                objUtilities.readPLbyPly(cBoxPlayList.Text);

                dataGridView1.Rows.Clear();
                foreach (Song c in objUtilities.listSongsByPlayList)
                {
                    dataGridView1.Rows.Add(c.name, c.artist, c.album, c.duration);
                }

            }
            
        }

        private void btnAddToPl_Click(object sender, EventArgs e)
        {
            //itemSelectedCB = cBoxPlayList.SelectedItem.ToString(); // Obtengo el nombre de la playkist que esta en el combobox
            //dataGridView1.Rows.Clear(); // Limpio el datagrid

            //int selectedRow = Convert.ToInt32(dataGridView1.CurrentRow);
            //objSong.name = dataGridView1.Rows[selectedRow].Cells[0].ToString();
            //objSong.album = dataGridView1.Rows[selectedRow].Cells[2].ToString();
            //objSong.artist = dataGridView1.Rows[selectedRow].Cells[1].ToString();
            //objSong.duration =Convert.ToInt32(dataGridView1.Rows[selectedRow].Cells[3].ToString());


            //objUtilities.objPlaylist.nameOfPlaylist = itemSelectedCB; // le doy un nombre a la pl
            //objUtilities.objPlaylist.ListOfSongPlaList.Add(objSong); // le doy las cansiones

            //objUtilities.listOfPL.Add(objUtilities.objPlaylist);
            ////objUtilities.objPlaylist.ListOfSongPlaList.Add(dataGridView1.SelectedRows.ToString());


            //objUtilities.listOfPL.Add(objUtilities.objPlaylist);
            int posicion = dataGridView1.CurrentRow.Index;
            string nameOfSong = dataGridView1.Rows[posicion].Cells[0].Value.ToString();
            int indice = objUtilities.listOfAllSongs.FindIndex(x => x.name == nameOfSong);

            Song objSongAddPL = new Song();
            objSongAddPL = objUtilities.listOfAllSongs[indice];
            objUtilities.listSongsByPlayList.Add(objSongAddPL);

            if (cBoxPlayList.Text == "")
            {
                MessageBox.Show("No tiene seleccioanada la playList a la que desea agregar");
            }
            else
            {
                objUtilities.writePlayList(cBoxPlayList.Text);
            }
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string auxName = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre a buscar", "Buscar",
                "Buscar");
            int indice = objUtilities.listOfAllSongs.FindIndex(x => x.name.ToLower() == auxName.ToLower());
            if (indice ==-1)
            {
                MessageBox.Show("No existe esa cancion o la esta escribiendo mal");
            }
            else
            {
                Song isong = objUtilities.listOfAllSongs[indice];
                string iname = isong.name;
                string iartist = isong.artist;
                string ialmbum = isong.album;
                double iduration = isong.duration;
                dataGridView1.Rows.Add(iname, iartist, ialmbum, iduration);
            }
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (rbName.Checked)
            {
                objUtilities.listSongsByPlayList.Sort(objSortByName); // por nombre
                showInDataGridPL();
            }
            else if (rbDuration.Checked)
            {
                objUtilities.listSongsByPlayList.Sort(); // por duracion
                showInDataGridPL();
            }
            else
            {
                MessageBox.Show("no a seleccionado si desea ordenar por nombre o duracion");
            }

        }

        public void showInDataGridPL()
        {
            dataGridView1.Rows.Clear();
            foreach (Song c in objUtilities.listSongsByPlayList)
            {
                dataGridView1.Rows.Add(c.name, c.artist, c.album, c.duration);    
            }  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (rbName.Checked)
            {
                objUtilities.listSongsByPlayList.Sort(objSortByName); // por nombre
                objUtilities.listSongsByPlayList.Reverse();
                showInDataGridPL();
            }
            else if (rbDuration.Checked)
            {
                objUtilities.listSongsByPlayList.Sort(); // por duracion
                objUtilities.listSongsByPlayList.Reverse();
                showInDataGridPL();
            }
            else
            {
                MessageBox.Show("no a seleccionado si desea ordenar por nombre o duracion");
            }
        }
    }
}

