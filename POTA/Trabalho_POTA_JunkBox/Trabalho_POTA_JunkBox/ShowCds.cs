using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_POTA_JukeBox
{
    class ShowCds
    {
        #region Show And Order Cds
        public static void ShowOrderCdName(Cds[] cdsArray)
        {
            int compare;
            Cds aux;
            int size = cdsArray.Length;

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (cdsArray[i] != null && cdsArray[j] != null)
                    {
                        compare = string.Compare(cdsArray[i].CdName1, cdsArray[j].CdName1);

                        if (compare == 1)
                        {
                            aux = cdsArray[j];
                            cdsArray[j] = cdsArray[i];
                            cdsArray[i] = aux;
                        }
                    }
                }
            }
            Print(cdsArray);
        }
        #endregion

        #region Show All Cds 
        public static void ShowCd(Cds[] cdsArray)
        {           
            Print(cdsArray);
        }
        #endregion

        #region print
        public static void Print(Cds[] cdsArray)
        {
            int size = cdsArray.Length;

            for (int i = 0; i < size; i++)
            {
                if (cdsArray[i] != null)
                {
                    Console.WriteLine(i + " -  CD name: " + cdsArray[i].CdName1 + "  Singer: " + cdsArray[i].SingerName1);
                }
            }
        }
        #endregion

        #region Show Music From Chosen Cd
        public static void ShowMusics(Cds[] cdsArray)
        {
            Console.WriteLine("choose a cd to see the songs: ");
            ShowCd(cdsArray);
            bool ok = true;
            int size;
            while (ok)
            {
                while (!int.TryParse(Console.ReadLine(), out size))
                {
                Console.WriteLine("You entered an invalid number");
                Console.Write("enter number of conversations \n");
                }          
                if (cdsArray[size] != null)
                {
                    ok = false;
                    Console.Clear();

                    Console.WriteLine("   " + cdsArray[size].CdName1 + "  ");

                    Console.WriteLine("\n 1 - select one song");
                    Console.WriteLine("\n 2 - select all songs");
                    int option;
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("Escolha uma musica: ");
                            while (!int.TryParse(Console.ReadLine(), out option))
                            {
                                Console.WriteLine("You entered an invalid number");
                                Console.Write("enter number of conversations \n");
                            }
                            cdsArray[size].ReadOneSong(option);
                            break;

                        case "2":
                            cdsArray[size].ReadSongs();
                            break;

                        default:
                            Console.WriteLine("\nInvalid option.");
                            Console.WriteLine("\nPress any key to continue.");
                            Console.ReadKey();
                            break;
                    }
                }
            }
            Console.ReadKey();
        }
        #endregion
    }
}
