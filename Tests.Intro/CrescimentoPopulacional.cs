
namespace Tests.Intro
{
    public class CrescimentoPopulacional
    {
        public static string PopulacaoAB(int popA, int popB, double porcA, double porcB)
        {
            if (popA < 0 || popB < 0)
            {
                throw new ArgumentException("População não pode ser negativa.");
            } 
            else if (popA > popB)
            {
                throw new ArgumentException("População da cidade A já é maior ou igual.");
            }
            else if (porcA < porcB)
            {
                throw new ArgumentException("Cidade A nunca terá uma população maior que a cidade B");
            }

            return CalculoAnos(popA, popB, porcA, porcB);
        }

        public static string CalculoAnos(int popA, int popB, double porcA, double porcB)
        {
            int periodo = 0;
            int populacaoA = popA;
            int populacaoB = popB;
            double taxaCrescimentoA = porcA / 100;
            double taxaCrescimentoB = porcB / 100;

            while (populacaoA <= populacaoB)
            {
                double calculoCidadeA = populacaoA + (populacaoA * taxaCrescimentoA);

                populacaoA = (int)calculoCidadeA;

                double calculoCidadeB = populacaoB + (populacaoB * taxaCrescimentoB);

                populacaoB = (int)calculoCidadeB;

                periodo++;
                if (periodo > 100)
                {
                    return "Mais de 1 século.";
                }
            }
            return periodo + " anos.";
        }
    }
}
