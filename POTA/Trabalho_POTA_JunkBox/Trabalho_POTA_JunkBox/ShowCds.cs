using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_POTA_JukeBox
{
    class ShowCds
    {
        #region Show And Order Cds
        public class CDComparer : IComparer
        {

            int IComparer.Compare(object xx, object yy)
            {
                Cds x = (Cds)xx;
                Cds y = (Cds)yy;
                return x.CdName().CompareTo(y.CdName());
            }
        }

        public static void ShowOrderCd(Cds[] cdsArray)
        {

            //cdsArray.Sort(new CDComparer());
            // Array.Sort<Cds>(cdsArray,(x,y)=>string.Compare(x.CdName(), y.CdName()));
            // Array.Sort(cdsArray, (x, y) => String.Compare(x.CdName(), y.CdName()));
            //Array.Sort(cdsArray, delegate (Cds user1, Cds user2) {return user1.CdName().CompareTo(user2.CdName());});

            int size = cdsArray.Length;
            
            for (int i = 0; i < size; i++)
            {
                if (cdsArray[i] != null)
                {
                    Console.WriteLine(i + " -  CD name: " + cdsArray[i].CdName() + "  Singer: " + cdsArray[i].SingerName());
                }
            }

        }
        #endregion

        #region Show All Cds 
        public static void ShowCd(Cds[] cdsArray)
        {

            int size = cdsArray.Length;
            
            for (int i = 0; i < size; i++)
            {
                if (cdsArray[i] != null)
                {
                    Console.WriteLine(i + " -  CD name: " + cdsArray[i].CdName() +"  Singer: " + cdsArray[i].SingerName());
                }
            }
            
        }
        #endregion

        #region Show Music From Chosen Cd
        public static void ShowMusics(Cds[] cdsArray)
        {
            Console.WriteLine("choose a cd to see the songs: ");
            ShowCd(cdsArray);
            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("You entered an invalid number");
                Console.Write("enter number of conversations ");
            }
            Console.Clear();
            Console.WriteLine("   "+ cdsArray[size].CdName()+"  ");
            cdsArray[size].ReadTracks();
            Console.ReadKey();
        }
        #endregion

    }
}
