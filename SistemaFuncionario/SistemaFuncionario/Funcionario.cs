

namespace SistemaFuncionario
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public virtual decimal CalcularSalarioTotal()
        {
            return Salario;
        }
    }
}
