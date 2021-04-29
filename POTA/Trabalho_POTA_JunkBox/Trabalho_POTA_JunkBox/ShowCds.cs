using System;
using System.Collections.Generic;
using System.Text;

namespace Trabalho_POTA_JunkeBox
{
    class ShowCds
    {
        public static void ShowCd(Cds[] cdsArray)
        {
            int size = cdsArray.Length;

            for (int i = 0; i < size; i++)
            {
                if (cdsArray[i] != null)
                {
                    Console.WriteLine(i + " - " + cdsArray[i].CdName());
                }
            }

            Console.ReadKey();
        }
    }
}
