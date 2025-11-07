using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaFuncionario
{
    internal class Gerente : Funcionario
    {
        public decimal Bonus { get; set; }


        public override decimal CalcularSalarioTotal()
        {
            return Salario + Bonus;
        }
    }

}