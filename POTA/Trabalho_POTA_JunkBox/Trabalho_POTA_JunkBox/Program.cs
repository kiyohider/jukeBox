using System;

namespace Trabalho_POTA_JunkeBox
{
    class Program
    {

        #region Variables

        public static int index = 0;
        private static bool run = true;
        static Cds[] cds = new Cds[10];
            
        // static string[] songs = new string[10];

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
            Console.WriteLine("1 - Show CDs");
            Console.WriteLine("2 - See musics from the cd");
            Console.WriteLine("3 - Insert cd");
            Console.WriteLine("4 - Remove cd");
            Console.WriteLine("5 - Oder");
            Console.WriteLine("8 - FillSpaceTest");
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
                    Console.Clear();
                    ShowCds.ShowCd(cds);
                    break;

                case "2":
                    //2 - See musics from the cd
                    break;

                case "3":
                    Console.Clear();

                    if (ArrayHasFreeSpace(cds))
                    {
                        InsertCds();
                    }
                    else
                    {
                        ShowCdsFullMessage();
                        Console.ReadKey();
                    }

                    break;

                case "4":
                    Console.Clear();

                    if (ArrayHasElements(cds))
                    {
                        DeleteMenu();
                    }
                    else
                    {
                        ShowCdsIsEmptyMessage();
                        Console.ReadKey();
                    }

                    break;

                case "5":
                    //5 - Oder
                    break;

                case "8":
                    FillSpaceTest();
                    break;

                default:
                    Console.WriteLine("\nInvalid option.");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
            }
        }

        #endregion

        #region Insert Menu

        private static void InsertCds()
        {
            Console.Clear();
            Console.WriteLine("=============================================");
            Console.WriteLine("2 - Insert at last index");
            Console.WriteLine("=============================================");
            ExecuteInsertCds();
        }

        private static void ExecuteInsertCds()
        {
            switch (Console.ReadLine())
            {
                case "0":
                    break;

                case "1":
                    InsertStringAtEnd(cds);
                    break;

                default:
                    Console.WriteLine("\nInvalid option.");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
            }
        }

        #endregion

        #region Insert Logic
        public static void InsertStringAtEnd(Cds[] cdArray)
        {
            InsertStringAtPosition(cdArray, index);
        }

        private static int ReceiveUserPosition()
        {
            Console.WriteLine("Type the number of the position.");
            int index = int.Parse(Console.ReadLine());
            return index;
        }

        private static bool PositionIsValid(int position)
        {
            if (position < 0 || position > index)
            {
                InvalidPosition();
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void InvalidPosition()
        {
            Console.Clear();
            Console.WriteLine("Invalid position.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public static void InsertStringAtPosition(Cds[] cdArray, int position)
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
            musics = Convert.ToInt32(Console.ReadLine());

            cds[position] = new Cds (cdName,singerName,musics);
            

            index++;

            Console.ReadKey();
        }

        public static bool ArrayHasFreeSpace(Cds[] pessoas) => index >= pessoas.Length ? false : true;

        private static void ShowCdsFullMessage() => Console.WriteLine("Machine full.");

        #endregion

        #region Delete

        private static void DeleteMenu()
        {
            Console.Clear();
            Console.WriteLine("=============================================");
            Console.WriteLine("1 - Remove at first index");
            Console.WriteLine("2 - Remove at last index");
            Console.WriteLine("3 - Remove at position");
            Console.WriteLine("0 - Main menu");
            Console.WriteLine("=============================================");
            ExecuteDeleteMenu();
        }

        private static void ExecuteDeleteMenu()
        {
            switch (Console.ReadLine())
            {
                case "0":
                    break;

                case "1":
                    DeleteStringAtStart(cds);
                    break;

                case "2":
                    DeleteStringAtEnd(cds);
                    break;

                case "3":
                    DeleteStringAtPosition(cds);
                    break;

                default:
                    Console.WriteLine("\nInvalid option.");
                    Console.WriteLine("\nPress any key to continue.");
                    Console.ReadKey();
                    break;
            }
        }

        #endregion

        #region Delete Logic

        public static void DeleteStringAtStart(Cds[] cdArray)
        {
            DeleteStringAtPosition(cds);
        }

        public static void DeleteStringAtPosition(Cds[] cdArray)
        {
            Console.Clear();

            int position = ReceiveUserPosition();

            if (DeleteValidPosition(position))
            {
                DeleteStringAtPosition(cdArray, position);
            }
        }

        public static void DeleteStringAtEnd(Cds[] cdArray)
        {
            DeleteStringAtPosition(cds, index - 1);
        }

        public static void DeleteStringAtPosition(Cds[] cdArray, int position)
        {
            Console.Clear();
            Console.WriteLine(cdArray[position] + " removed complete.");

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

        public static bool ArrayHasElements(Cds[] pessoas) => index > 0;

        private static void ShowCdsIsEmptyMessage() => Console.WriteLine("Array is empty.");

        #endregion

        #region autoFill

        private static void FillSpaceTest()
        {
            //cds[0] = "FillSpaceTest 0";
            //cds[1] = "FillSpaceTest 1";
            //cds[2] = "FillSpaceTest 2";

            index = 3;
        }

        #endregion
    }
}
