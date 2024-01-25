using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPOO4
{
    internal class Funcionario
    {
        public String Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double ImpostoPorcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (ImpostoPorcentagem / 100));
        }
        public override string ToString()
        {
            return Nome + ", $" + SalarioBruto.ToString("F2");
        }
    }
}
