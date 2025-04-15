using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        
        public double ValorTotalEmEstoque() 
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProdutos(int a) 
        {
            Quantidade = Quantidade + a;
            ValorTotalEmEstoque();
        }
        
        public void RemoverProdutos(int a)
        {
            Quantidade = Quantidade - a;
            ValorTotalEmEstoque();
        }
        
    }
}
