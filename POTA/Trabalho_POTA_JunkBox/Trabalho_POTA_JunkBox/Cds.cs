using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_POTA_JukeBox
{
    class Cds
    {
        int songs;
        string[] musics = new string[12];
        string cdName, singerName;

        

        public Cds(string cdName,string singerName,int songs)
        {
            this.songs = songs;
            this.cdName = cdName;
            this.singerName=singerName;
            Songs();
            
        }
        public void Songs()
        {
            for (int i = 0; i < songs; i++)
            {
                Console.WriteLine("Music name:  ");
                musics[i] = Console.ReadLine();
            }

        }
        public void ReadSongs()
        {
            for (int i = 0; i < songs; i++)
            {
                if (musics[i] != null)
                {
                    Console.WriteLine(i + " -  Music name: " + musics[i]);
                }
            }

            Console.ReadKey();
        }
        public void ReadOneSong(int song)
        {
            bool verify = true;
            do {
                if (musics[song] != null)
                {
                    verify = false;
                    Console.WriteLine(song + " -  Music name: " + musics[song]);
                }
                else
                    Console.WriteLine("number invalid Choose again: ");
                    song = Convert.ToInt32(Console.ReadLine());
            } while (verify);
            Console.ReadKey();
        }

        public string CdName1 { get => cdName; set => cdName = value; }
        public string SingerName1 { get => singerName; set => singerName = value; }
    }
}
