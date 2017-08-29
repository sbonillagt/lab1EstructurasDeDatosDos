using System;
using System.Collections.Generic;
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
        public List<Song> listOfAllSongs = new List<Song>();

        public Playlist objPlaylist = new Playlist();
        public List<Playlist> listOfPL = new List<Playlist>();
        public Song auxSong;
       


        //Lectura De PlayList
        private string[] nameOfPlayListInSistemARRAY = null;
        private string[] auxAtributesSongs = null;
        public List<string> listOfNamesPL = new List<string>();
        public List<Song> listSongsByPlayList = new List<Song>();
        
        public string auxCBox = "";

        public void initializingVariables()
        {
            
            User admin = new User();
            admin.user = "1234";
            admin.password = "1234";
            listUsers.Add(admin);

            //Cacniones
            Song song1 = new Song();
            song1.name = "Rihanna";
            song1.album = "El dorado";
            song1.artist = "Jesse Baez";
            song1.duration = 4.59;
            listOfAllSongs.Add(song1);

            Song song2 = new Song();
            song2.name = "Lluvia";
            song2.album = "Lluvia";
            song2.artist = "Feid";
            song2.duration = 3.58;
            listOfAllSongs.Add(song2);

            Song song3 = new Song();
            song3.name = "Mi mitad";
            song3.album = "Mi mitad";
            song3.artist = "Maikel Delacalle";
            song3.duration = 3.07;
            listOfAllSongs.Add(song3);


        }

        // Lectura de playlist Existentes
        public void readPlayListNames()
        {
            if (!File.Exists("playlistExistentes.txt"))
            {
                StreamWriter objWriter = new StreamWriter("playlistExistentes.txt");
                objWriter.Close();
            }
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

        //Escribe los nuevos nombres de las playlist en su archivo pa que no se le olviden
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
            objWriter.Write(pLnames);
            objWriter.Close();
        }

        public void readPLbyPly(string namePL)
        {
            //Song song1 = new Song();
            //song1.name = "Rihanna";
            //song1.album = "El dorado";
            //song1.artist = "Jesse Baez";
            //song1.duration = 4.59;
            //listOfAllSongs.Add(song1);

            listSongsByPlayList.Clear();
            
            StreamReader objArchivo = new StreamReader(  namePL + ".txt");
            string linea = objArchivo.ReadLine();
            int z = 0;
            while (linea != null)
            {
                //nameOfPlayListInSistemARRAY = strLinea.Split(',');
                
                string[] auxStrLine = null;
                auxStrLine = linea.Split(',');
                auxSong = new Song();
                auxSong.name = auxStrLine[0];
                auxSong.album = auxStrLine[2];
                auxSong.artist = auxStrLine[1];
                auxSong.duration = Convert.ToDouble(auxStrLine[3]);
                auxSong.file = auxStrLine[4];

                listSongsByPlayList.Add(auxSong);
                linea = objArchivo.ReadLine();
            }
           
            objArchivo.Close();
        }

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
