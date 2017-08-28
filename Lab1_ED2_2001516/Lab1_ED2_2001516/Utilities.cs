using System;
using System.Collections.Generic;
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
