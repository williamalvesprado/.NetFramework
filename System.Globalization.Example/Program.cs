using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Threading;

namespace System.Globalization.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calendar
            DateTime dt1 = DateTime.Now;

         System.Globalization.Calendar cal;
         DateTime dt = new DateTime(2020, 11, 19, new GregorianCalendar());
         dt.AddHours(3);


         DateTime dt2 = DateTime.Now;

         TimeSpan t = dt2.Subtract(dt1);
            #endregion

            #region CultureInfo
            CultureInfo ci = new CultureInfo("en-US");


            #endregion

            #region Cultureinfo - Threading
            CultureInfo cit = System.Threading.Thread.CurrentThread.CurrentCulture;

            CultureInfo ciUI = Thread.CurrentThread.CurrentUICulture;

            System.Threading.Thread.CurrentThread.CurrentUICulture = ci;

            CultureInfo cinv = CultureInfo.InvariantCulture;

            Console.Write(System.Globalization.Example.Main.DESCRICAO);
            Console.ReadKey();
            #endregion















        }
    }
}
