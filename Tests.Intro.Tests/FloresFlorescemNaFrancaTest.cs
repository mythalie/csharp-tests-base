using System;
using Xunit;

namespace Tests.Intro.Tests
{
    public class FloresFlorescemNaFrancaTest
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("Palavra")]
        public void StringInvalida(string entrada)
        {
            const string mensagemEsperada = "Frase inválida.";

            var excecao = Assert.Throws<ArgumentException>(
                () => FloresFlorescemNaFranca.Tautograma(entrada));

            Assert.Equal(excecao.Message, mensagemEsperada);
        }

        [Theory]
        [InlineData("Flowers Flourish from France", "S")]
        [InlineData("Sam Simmonds speaks softly", "S")]
        [InlineData("Peter pIckEd pePPers", "S")]
        [InlineData("truly tautograms triumph", "S")]
        [InlineData("Isso não é um Tautograma", "N")]
        public void ValidarString(string entrada, string esperado)
        {
            var retorno = FloresFlorescemNaFranca.Tautograma(entrada);

            Assert.Equal(retorno, esperado);
        }
    }
}
