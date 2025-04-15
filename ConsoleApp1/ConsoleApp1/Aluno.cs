using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Aluno
    {
        public string Nome;
        public double N1, N2, N3, NotaFinal;

        public void SomaNotas()
        {
            NotaFinal = N1 + N2 + N3;
            
        }
  
    }
}
