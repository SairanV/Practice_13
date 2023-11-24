using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicCatalog catalog = new MusicCatalog();

            catalog.AddDisk("Disk 1");
            catalog.AddSong("Disk 1", "Song Sunsine", "Artist Arima");
            catalog.AddSong("Disk 1", "Song Killer Drones", "Artist Drones Builder");
            catalog.AddDisk("Disk 2");
            catalog.AddSong("Disk 2", "Song QWERTY2nn", "Artist Unknown");
            catalog.DisplayCatalog();

            catalog.SearchByArtist("Artist Arima");

            catalog.RemoveDisk("Disk 1");
            catalog.DisplayCatalog();
        }
    }
}
