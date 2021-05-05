using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_POTA_JukeBox
{
    
    class InsertOrDelete : Program
    {
        #region Insert Logic
        public static void InsertCd(Cds[] cdArray)
        //public static void InsertCd(List<Cds> cdArray)
        {
            InsertCdAtPosition(cdArray, index);
        }

        private static int ReceiveUserPosition()
        {
            Console.WriteLine("Type the number of the CD.");
            int index = int.Parse(Console.ReadLine());
            return index;
        }

        private static void InvalidPosition()
        {
            Console.Clear();
            Console.WriteLine("Invalid position.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public static void InsertCdAtPosition(Cds[] cdArray, int position)
        {
            string singerName, cdName;
            int musics;
            for (int i = index; i > position; i--)
            {
                cdArray[i] = cdArray[i - 1];

            }
            Console.Clear();
            Console.WriteLine("Cd name: ");
            cdName = Console.ReadLine();
            Console.WriteLine("Singer name: ");
            singerName = Console.ReadLine();
            Console.WriteLine("number of musics: ");
            while (!int.TryParse(Console.ReadLine(), out musics))
            {
                Console.WriteLine("You entered an invalid number");
                Console.Write("enter number of conversations ");
            }

            cds[position] = new Cds(cdName, singerName, musics);

            index++;

            Console.ReadKey();
        }
        #endregion

        #region Delete Logic
        public static void RemoveCd(Cds[] cdArray)
        {
            Console.Clear();

            int position = ReceiveUserPosition();

            if (DeleteValidPosition(position))
            {
                RemoveCd(cdArray, position);
            }
        }

        public static void RemoveCd(Cds[] cdArray, int position)
        {
            Console.Clear();
            Console.WriteLine(cdArray[position].CdName() + " removed complete.");

            for (int i = position; i < index; i++)
            {
                cdArray[i] = cdArray[i + 1];
            }

            index--;
            Console.ReadKey();
        }

        private static bool DeleteValidPosition(int position)
        {
            if (position < 0 || position >= index)
            {
                InvalidPosition();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Choose Logic
        static public void ChooseCd(Cds[] cdArray)
       //static public void ChooseCd(List<Cds> cdArray)
        {
            int chosen = ReceiveUserPosition();
            Cds support = cdArray[chosen];
            Console.WriteLine("CD chosen: " + support.CdName());
            cdArray[chosen] = cdArray[0];
            cdArray[0] = support;

            Console.ReadKey();
        }

        #endregion

    }
}
