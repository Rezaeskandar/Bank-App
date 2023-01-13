using System;
using System.Collections.Generic;
using System.Text;

namespace BnakApp
{
    class timer
    {
        public static void timmer()
        {
            int a = 5;
            //sätter timer för hur mycket tid ska man vänta om man försökt 4X fel

            DateTime endTime = DateTime.Now.AddSeconds(a);

            // Loopa tills vi når endtime.
            while (DateTime.Now < endTime)
            {   // räkna tiden som är kvar.
                TimeSpan remaining = endTime - DateTime.Now;

                // skriv tiden som är kvar in line.
                Console.Write($"\r{remaining.Minutes:00}:{remaining.Seconds:00}:{remaining.Milliseconds / 10:00}");

                // Sleep for 100 millisecond.
                System.Threading.Thread.Sleep(100);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nYou can try agin you have 3 new tries!\n");
            Console.ResetColor();
         
        }
    }
}
