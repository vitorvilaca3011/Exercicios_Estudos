using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Use uma lista de objetos para aceitar vários tipos, mas o ideal é criar uma classe para armazenar os dados do livro.
    // Aqui está um exemplo usando uma lista de Livro para armazenar vários livros, cada um com título, autor e ano.

    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }

        // Lista para armazenar vários livros
        private List<Livro> livros = new List<Livro>();

        public Livro() { }

        public Livro(string titulo, string autor, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
        }

        public void AdicionarLivro(string titulo, string autor, int ano)
        {
            livros.Add(new Livro(titulo, autor, ano));
        }

        public void ImprimirLivros()
        {
            foreach (var livro in livros)
            {
                Console.WriteLine(livro.ToString());
            }
        }

        public override string ToString()
        {
            return $"{Titulo}, {Ano}, {Autor}";
        }
    }
} // namespace ConsoleApp1
