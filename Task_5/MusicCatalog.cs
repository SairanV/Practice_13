using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class MusicCatalog
    {
        private Hashtable catalog;

        public MusicCatalog()
        {
            catalog = new Hashtable();
        }

        public void AddDisk(string diskTitle)
        {
            if (!catalog.ContainsKey(diskTitle))
            {
                catalog[diskTitle] = new ArrayList();
                Console.WriteLine($"Добавлен диск: {diskTitle}");
            }
            else
            {
                Console.WriteLine($"Диск с названием {diskTitle} уже существует.");
            }
        }

        public void RemoveDisk(string diskTitle)
        {
            if (catalog.ContainsKey(diskTitle))
            {
                catalog.Remove(diskTitle);
                Console.WriteLine($"Диск {diskTitle} удален.");
            }
            else
            {
                Console.WriteLine($"Диск с названием {diskTitle} не найден.");
            }
        }

        public void AddSong(string diskTitle, string songTitle, string artist)
        {
            if (catalog.ContainsKey(diskTitle))
            {
                var songs = (ArrayList)catalog[diskTitle];
                Song newSong = new Song { Title = songTitle, Artist = artist };
                songs.Add(newSong);
                Console.WriteLine($"Добавлена песня: {songTitle} - {artist} на диск {diskTitle}");
            }
            else
            {
                Console.WriteLine($"Диск с названием {diskTitle} не найден.");
            }
        }

        public void RemoveSong(string diskTitle, string songTitle, string artist)
        {
            if (catalog.ContainsKey(diskTitle))
            {
                var songs = (ArrayList)catalog[diskTitle];
                var songToRemove = songs.Cast<Song>().FirstOrDefault(s => s.Title == songTitle && s.Artist == artist);

                if (songToRemove != null)
                {
                    songs.Remove(songToRemove);
                    Console.WriteLine($"Песня {songTitle} - {artist} удалена с диска {diskTitle}");
                }
                else
                {
                    Console.WriteLine($"Песня {songTitle} - {artist} не найдена на диске {diskTitle}");
                }
            }
            else
            {
                Console.WriteLine($"Диск с названием {diskTitle} не найден.");
            }
        }

        public void DisplayCatalog()
        {
            if (catalog.Count == 0)
            {
                Console.WriteLine("Каталог пуст.");
            }
            else
            {
                Console.WriteLine("Содержимое каталога:");
                foreach (var diskTitle in catalog.Keys)
                {
                    Console.WriteLine($"Диск: {diskTitle}");

                    var songs = (ArrayList)catalog[diskTitle];
                    foreach (Song song in songs)
                    {
                        Console.WriteLine($"  Песня: {song.Title} - {song.Artist}");
                    }
                }
            }
        }

        public void DisplayDisk(string diskTitle)
        {
            if (catalog.ContainsKey(diskTitle))
            {
                Console.WriteLine($"Содержимое диска {diskTitle}:");
                var songs = (ArrayList)catalog[diskTitle];
                foreach (Song song in songs)
                {
                    Console.WriteLine($"  Песня: {song.Title} - {song.Artist}");
                }
            }
            else
            {
                Console.WriteLine($"Диск с названием {diskTitle} не найден.");
            }
        }

        public void SearchByArtist(string artist)
        {
            Console.WriteLine($"Поиск записей исполнителя {artist}:");

            foreach (var diskTitle in catalog.Keys)
            {
                var songs = (ArrayList)catalog[diskTitle];
                foreach (Song song in songs)
                {
                    if (song.Artist == artist)
                    {
                        Console.WriteLine($"  На диске {diskTitle}: {song.Title} - {song.Artist}");
                    }
                }
            }
        }
    }
}
