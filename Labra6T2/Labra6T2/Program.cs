using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6T2
{
    class Song
    {
        public string Name { get; set; }
        public double Length { get; set; }

        public Song(string name, double length)
        {
            Name = name;
            Length = length;
        }

        public override string ToString()
        {
            return Name + ", " + Length;
        }
    }
    class CD
    {
        private List<Song> songs;

        public string Artist { get; set; }
        public string Name { get; set; }

        public CD()
        {
            songs = new List<Song>();
        }
        public CD(string artist, string name)
        {
            Artist = artist;
            Name = name;
            songs = new List<Song>();
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

        public override string ToString()
        {
            string temp = "";
            foreach (Song song in songs)
            {
                temp += song + "\n";
            }
            return "CD data:\nName: " + Name + "\nArtist: " + Artist + "\nSongs:\n" + temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Song a = new Song("Shudder before the beautiful", 6.29);
            Song b = new Song("Weak fantasy", 5.23);
            Song c = new Song("Elan", 4.45);
            Song d = new Song("Yours is an empty hope", 5.34);
            Song e = new Song("Our decades in the sun", 6.37);

            CD one = new CD("Nightwish", "Endless forms most beautiful");
            one.AddSong(a);
            one.AddSong(b);
            one.AddSong(c);
            one.AddSong(d);
            one.AddSong(e);

            Console.WriteLine(one.ToString());
        }
    }
}
