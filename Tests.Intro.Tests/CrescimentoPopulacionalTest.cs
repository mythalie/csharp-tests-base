using System;
using Xunit;

namespace Tests.Intro.Tests
{
    public class CrescimentoPopulacionalTest
    {
        [Theory]
        [InlineData(-100, 150, 1.0, 1.2)]
        [InlineData(100, -150, 1.0, 1.2)]
        [InlineData(-100, -150, 1.0, 1.2)]
        public void PopulacaoNegativa(int popA, int popB, double porcA, double porcB)
        {
            const string mensagemEsperada = "População não pode ser negativa.";

            var excecao = Assert.Throws<ArgumentException>(
                () => CrescimentoPopulacional.PopulacaoAB(popA, popB, porcA, porcB));

            Assert.Equal(excecao.Message, mensagemEsperada);
        }

        [Theory]
        [InlineData(151, 150, 1.0, 1.2)]
        [InlineData(1100, 150, 1.0, 1.2)]
        [InlineData(100, 0, 1.0, 1.2)]
        public void PopulacaoAMaiorIgualB(int popA, int popB, double porcA, double porcB)
        {
            const string mensagemEsperada = "População da cidade A já é maior ou igual.";

            var excecao = Assert.Throws<ArgumentException>(
                () => CrescimentoPopulacional.PopulacaoAB(popA, popB, porcA, porcB));

            Assert.Equal(excecao.Message, mensagemEsperada);
        }

        [Theory]
        [InlineData(100, 150, 1.0, 1.2)]
        [InlineData(149, 150, 1.0, 1.2)]
        [InlineData(0, 0, 1.0, 1.2)]
        public void PorcentagemAInferiorIgualB(int popA, int popB, double porcA, double porcB)
        {
            const string mensagemEsperada = "Cidade A nunca terá uma população maior que a cidade B";

            var excecao = Assert.Throws<ArgumentException>(
                () => CrescimentoPopulacional.PopulacaoAB(popA, popB, porcA, porcB));

            Assert.Equal(excecao.Message, mensagemEsperada);
        }

        [Theory]
        [InlineData(100, 150, 1.0, 0, "51 anos.")]
        [InlineData(90000, 120000, 5.5, 3.5, "16 anos.")]
        [InlineData(56700, 72000, 5.2, 3.0, "12 anos.")]
        [InlineData(123, 2000, 3.0, 2.0, "Mais de 1 século.")]
        [InlineData(100000, 110000, 1.5, 0.5, "10 anos.")]
        [InlineData(62422, 484317, 3.1, 1.0, "100 anos.")]
        [InlineData(100, 150, 4.5, 4.0, "95 anos.")]
        public void QuantosAnosAPassaraB(int popA, int popB, double porcA, double porcB, string esperado)
        {
            var retorno = CrescimentoPopulacional.PopulacaoAB(popA, popB, porcA, porcB);

            Assert.Equal(retorno, esperado);
        }
    }
}
