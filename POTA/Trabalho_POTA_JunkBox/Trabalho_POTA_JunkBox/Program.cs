using System;
using System.Collections.Generic;

namespace Trabalho_POTA_JukeBox
{
    class Program
    {
        

        #region Variables
        protected static int index = 0;
        protected static bool run = true;
        protected static Cds[] cds = new Cds[10];
        #endregion

        #region Main
        static void Main(string[] args)
        {       
            Execute();
        }

        public static void Execute()
        {
            while (run)
            {
                PrintMainMenu();
            }
        }
        #endregion

        #region Menu
        private static void PrintMainMenu()
        {

            Console.Clear();           
            Console.WriteLine("=============================================");
            Console.WriteLine("1 - Choose CD");
            Console.WriteLine("2 - See musics from the cd");
            Console.WriteLine("3 - Show CDs");
            Console.WriteLine("4 - Show CDs in Alphabetical");
            Console.WriteLine("5 - Insert cd");
            Console.WriteLine("6 - Remove cd");           
            Console.WriteLine("0 - Exit");
            Console.WriteLine("=============================================");
            ExecuteMenuOption();
        }

        private static void ExecuteMenuOption()
        {
            switch (Console.ReadLine())
            {
                case "0":
                    run = false;
                    break;

                case "1":
                    InsertOrDelete.ChooseCd(cds);
                    break;

                case "2":
                    Console.Clear();
                    ShowCds.ShowMusics(cds);
                    break;

                case "3":
                    Console.Clear();
                    ShowCds.ShowCd(cds);
                    Console.ReadKey();
                    break;

                case "4":
                    Console.Clear();
                    ShowCds.ShowOrderCdName(cds);
                    Console.ReadKey();
                    break;

                case "5":
                    Console.Clear();
                    if (ArrayHasFreeSpace(cds))
                    {
                        InsertOrDelete.InsertCd(cds);
                    }
                    else
                    {
                        ShowCdsFullMessage();
                        Console.ReadKey();
                    }
                    break;

                case "6":
                    Console.Clear();
                    if (ArrayHasElements(cds))
                    {
                        InsertOrDelete.RemoveCd(cds);
                    }
                    else
                    {
                        ShowCdsIsEmptyMessage();
                        Console.ReadKey();
                    }
                    break;
            
                default:
                    Console.WriteLine("\nInvalid option.");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
            }
        }
        #endregion

        #region Verify
        public static bool ArrayHasFreeSpace(Cds[] pessoas) => index >= pessoas.Length ? false : true;
        private static void ShowCdsFullMessage() => Console.WriteLine("Machine full.");
        private static void ShowCdsIsEmptyMessage() => Console.WriteLine("Array is empty.");
        public static bool ArrayHasElements(Cds[] pessoas) => index > 0;
        #endregion

    }
}
