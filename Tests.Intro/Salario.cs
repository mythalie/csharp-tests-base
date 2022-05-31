
namespace Tests.Intro
{
    public class Salario
    {
        public static string SalarioComBonus(double salario, double vendas)
        {
            if (salario < 500)
            {
                throw new ArgumentException("Salário deve ser válido, acima do piso de 500.");
            }

            if (vendas < 0)
            {
                throw new ArgumentException("Vendas não podem ser negativas.");
            } else if (vendas == 0)
            {
                return Formatar(salario);
            } 

            var bonus = vendas * 0.15;
            var salarioComBonus = salario + bonus;

            return Formatar(salarioComBonus);
        }

        private static string Formatar(double resultado)
        {
            return resultado.ToString("F2");
        }
    }
}
