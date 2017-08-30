using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_ED2_2001516
{
    class Utilities
    {
   
        User objUser = new User();
        Song objSong = new Song();
        public List<User> listUsers = new List<User>();
        public  List<Song> listOfAllSongs = new List<Song>();

        public Playlist objPlaylist = new Playlist();
        public List<Playlist> listOfPL = new List<Playlist>();
        public Song auxSong;
        int z = 0;

        //Lectura De PlayList
        private string[] nameOfPlayListInSistemARRAY = null;
        private string[] auxAtributesSongs = null;
        public List<string> listOfNamesPL = new List<string>();
        public List<Song> listSongsByPlayList = new List<Song>();
        
        public string auxCBox = "";

        //Inciializacion de variabeles
        public void initializingVariables()
        {
            readPLbyPly("todaslascanciones.txt");
            for (int i = 0; i < listOfAllSongs.Count; i++)
            {
                listSongsByPlayList.Add(listOfAllSongs[i]);
            }
            User admin = new User();
            admin.user = "Admin";
            admin.password = "1234";
            listUsers.Add(admin);
        }

        // Lectura de playlist Existentes de su archivo .txt
        public void readPlayListNames()
        {
            if (!File.Exists("playlistExistentes.txt"))
            {
                StreamWriter objWriter = new StreamWriter("playlistExistentes.txt");
                objWriter.Close();
            }
            nameOfPlayListInSistemARRAY = null;
            listOfNamesPL.Clear();
            StreamReader objArchivo = new StreamReader("playlistExistentes.txt");
            string strLinea;
            strLinea = objArchivo.ReadLine();

            if (strLinea != null)
            {
                nameOfPlayListInSistemARRAY = strLinea.Split(',');
            }
            objArchivo.Close();
            if (nameOfPlayListInSistemARRAY != null)
            {
                for (int i = 0; i < nameOfPlayListInSistemARRAY.Length; i++)
                {
                    listOfNamesPL.Add(nameOfPlayListInSistemARRAY[i]);
                }
            }
            
        }

        //Escribe los nuevos nombres de las playlist en su archivo de tipo .txt
        public void writePlayListNames()
        {

            StreamWriter objWriter = new StreamWriter("playlistExistentes.txt");
            string pLnames = "";
            for (int i = 0; i < listOfNamesPL.Count; i++)
            {

                if (i == listOfNamesPL.Count - 1)
                {
                    pLnames = pLnames + listOfNamesPL[i];
                }
                else
                {
                    pLnames = pLnames + listOfNamesPL[i] + ",";
                }
                
            }
            objWriter.WriteLine(pLnames);

            objWriter.Close();
        }

        //Lee playlist por playlist de su archivo obteniendo el nombre del archivo del combo box
        public void readPLbyPly(string namePL)
        {         

            if (!File.Exists(namePL + ".txt"))
            {
                StreamWriter objWriter = new StreamWriter(namePL + ".txt");
                objWriter.Close();
            }

            listSongsByPlayList.Clear();
            
            StreamReader objArchivo = new StreamReader(  namePL + ".txt");
            string linea = objArchivo.ReadLine();
            
            while (linea != null)
            {
                //nameOfPlayListInSistemARRAY = strLinea.Split(',');
                
                string[] auxStrLine = null;
                auxStrLine = linea.Split(',');
                auxSong = new Song();
                auxSong.name = auxStrLine[0];
                auxSong.artist = auxStrLine[1];
                auxSong.album = auxStrLine[2];
                auxSong.duration = Convert.ToDouble(auxStrLine[3]);
                auxSong.file = auxStrLine[4];

                if (z==0)
                {
                    listOfAllSongs.Add((auxSong));
                }
                else
                {
                    listSongsByPlayList.Add(auxSong);
                }
                
                linea = objArchivo.ReadLine();
            }
           
            objArchivo.Close();
            z++;
        }

        //Escribe las playlist dentro de su archivo de texto. 
        public void writePlayList(string namePL)
        {
            if (!File.Exists(namePL + ".txt"))
            {
                StreamWriter objWriter = new StreamWriter(namePL + ".txt");
                objWriter.Close();
            }
            StreamWriter objWriterSongsInPlayList = new StreamWriter(namePL + ".txt");
            string pLnames = "";
            

            foreach (Song c in listSongsByPlayList)
            {
                pLnames = c.name + "," + c.artist + "," + c.album + "," + c.duration + "," + c.file;
                objWriterSongsInPlayList.WriteLine(pLnames);
            }
            
            objWriterSongsInPlayList.Close();

        }

        //Verifica el usuario y password del usuario
        public bool chekUserAndPassword(string iUser, string iPassword)
        {
            User userVariable =new User();
            userVariable.user = iUser;
            userVariable.password = iPassword;
            if (listUsers.Exists(User=> User.user== iUser && User.password==iPassword ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
