using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_POTA_JunkeBox
{
    class Cds
    {
        int songs;
        string cdName, singerName;

        public Cds(string cdName,string singerName,int songs)
        {
            this.songs = songs;
            this.cdName = cdName;
            this.singerName=singerName;
        }

        public string CdName()
        {
            return cdName;

        }

    }
}
