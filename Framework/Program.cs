using System;
using System.Design;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devmedia.Estudo.LibraryFrameworkSample;


namespace Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly
            Console.WriteLine("Hello World");
            Console.ReadKey();

            List<Livro> Livros = new List<Livro>();
        
            Livro L1 = new Livro();
            L1.Titulo  = "Livro1";


            Livros.Add(L1);

            Console.WriteLine("Total de Livros : " + Livros.Count());

            Livro L2 = new Livro();
            L2.Titulo  = "Livro2";

            Livros.Add(L2);

            Console.WriteLine("Total de Livros : " + Livros.Count());

            foreach (Livro vlivro in Livros)
            {
                Console.WriteLine(vlivro.Titulo);
            }

            Console.ReadKey();
            





        }
    }
}
