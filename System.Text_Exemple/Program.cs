using Devmedia.Estudo.LibraryFrameworkSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;


namespace System.Text_Exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            #region StringBuilder

            StringBuilder sb = new StringBuilder();

            sb.Append("New");
            sb.Append("York");

            Console.Write(sb);
            Console.ReadKey();

            Livro romance = new Livro();
            
            #endregion



        }
    }
}
