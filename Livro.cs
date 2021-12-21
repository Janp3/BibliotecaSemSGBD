using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFBook
{
    public enum Genero
    {
        Comedia = 1,
        Romance,
        Drama,
        Terror,
        Suspense,
        Aventura,
        FicCientifica

    }
    public class Livro
    {
        public int Id; 
        public Autor NomeAutor; 
        public int Paginas;
        public string Editora;
        public string Titulo;
        public Genero GeneroLivro; 
        public int Ano;

        public Autor ProcurarAutor(string nome)
        {
            foreach (Autor a in FormPrincipal.Autores)
            {
                if (a.Nome.Contains(nome) == true)
                    return a;
            }
            return null;
        }

        public bool Cadastrar(ref List<Livro> livros)
        {
            livros.Add(this);
            return true;
        }
    }
}
