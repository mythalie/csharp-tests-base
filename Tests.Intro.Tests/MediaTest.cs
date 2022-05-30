using System;
using Xunit;

namespace Tests.Intro.Tests
{
    public class MediaTest
    {
        [Theory]
        [InlineData(2, 2, "2,0")]
        [InlineData(2, 4, "3,0")]
        [InlineData(2.5, 5.2, "3,9")]
        public void Quando_PassadoDoisValoresValidos_Deve_RetornarMedia(double entrada1, double entrada2, string esperado)
        {
            var retorno = Media.Simples(entrada1, entrada2);

            Assert.Equal(retorno, esperado);
        }

        [Theory]
        [InlineData(5, 6, 7, "6,0")]
        [InlineData(5, 10, 10, "8,3")]
        [InlineData(10.5, 6.2, 7.8, "8,2")]
        public void Quando_PassadoTresValoresValidos_Deve_RetornarMedia(double entrada1, double entrada2, double entrada3, string esperado)
        {
            var retorno = Media.Simples(entrada1, entrada2, entrada3);

            Assert.Equal(retorno, esperado);
        }

        [Theory]
        [InlineData(2, -2)]
        [InlineData(-2, 4)]
        [InlineData(-2, -4)]
        public void Quando_PassadoQualquerDosDoisValoresInvalidos_Deve_RetornarExcecao(double entrada1, double entrada2)
        {
            const string mensagemEsperada = "Os valores devem ser positivos.";

            var exception = Assert.Throws<ArgumentException>(
                () => Media.Simples(entrada1, entrada2));

            Assert.Equal(exception.Message, mensagemEsperada);
        }

        [Theory]
        [InlineData(-2, 2, 1)]
        [InlineData(2, -4, 1)]
        [InlineData(2, 4, -1)]
        [InlineData(-2, -4, 1)]
        [InlineData(2, -4, -1)]
        [InlineData(-2, 4, -1)]
        [InlineData(-2, -4, -1)]
        public void Quando_PassadoQualquerDosTresValoresInvalidos_Deve_RetornarExcecao(double entrada1, double entrada2, double entrada3)
        {
            const string mensagemEsperada = "Os valores devem ser positivos.";

            var exception = Assert.Throws<ArgumentException>(
                () => Media.Simples(entrada1, entrada2, entrada3));

            Assert.Equal(exception.Message, mensagemEsperada);
        }
    }
}
