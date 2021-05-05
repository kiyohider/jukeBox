using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_POTA_JukeBox
{
    class Cds
    {
        int songs;
        string[] musics = new string[10];
        string cdName, singerName;
        public Cds(string cdName,string singerName,int songs)
        {
            this.songs = songs;
            this.cdName = cdName;
            this.singerName=singerName;
            tracks();
        }

        public void tracks()
        {
            for (int i = 0; i < songs; i++)
            {
                Console.WriteLine("Music name:  ");
                musics[i] = Console.ReadLine();
            }

        }

        public void ReadTracks()
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

        public string CdName()
        {
            return cdName;

        }
        public string SingerName()
        {
            return singerName;

        }

    }
}
