using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Funcionario
    {
        public string Id { get; private set;}
        public string Nome { get; set;}
        public double SalarioBruto, Imposto;
        
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        
        public void AumentarSalario(double porcentagem) 
        {
            SalarioBruto = SalarioBruto + (porcentagem / 100 * SalarioBruto);
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
