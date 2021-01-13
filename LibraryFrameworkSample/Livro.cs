using Devmedia.Estudo.Library.FrameworkSample.Library;
using System;




namespace Devmedia.Estudo.LibraryFrameworkSample
{
    public class Livro
    {
        string titulo;
        public string Titulo

        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Teste { get => teste; set => teste = value; }


        string autor;

        public string Autor
        {
            get { return autor; }
            set { autor = value; }

        }

        int anoPublicacao;

        public int AnoPublicacao
        {
            get { return anoPublicacao;  }
            set { anoPublicacao = value; }
        }
        Biblioteca _biblioteca;
        private string teste;

        public Biblioteca _Biblioteca
        {
            get { return _biblioteca; }
            set { _biblioteca = value; }

        }

    }
}
