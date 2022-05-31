using System;
using Xunit;

namespace Tests.Intro.Tests
{
    public class DDDTest
    {
        [Theory]
        [InlineData(-11)]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(9)]
        [InlineData(100)]
        public void Quando_PassadoNumeroInvalido_Deve_RetornarExcecao(int entrada)
        {
            const string mensagemEsperada = "DDD inválido";

            var excecao = Assert.Throws<ArgumentException>(
                () => DDD.ValidarDDD(entrada));

            Assert.Equal(excecao.Message, mensagemEsperada);
        }

        [Theory]
        [InlineData(11, "São Paulo")]
        [InlineData(19, "Campinas")]
        [InlineData(21, "Rio de Janeiro")]
        [InlineData(27, "Vitória")]
        [InlineData(31, "Belo Horizonte")]
        [InlineData(32, "Juiz de Fora")]
        [InlineData(61, "Brasília")]
        [InlineData(71, "Salvador")]
        public void Quando_PassadoNumeroValido_Deve_RetornarCidade(int entrada, string esperado)
        {
            var retorno = DDD.ValidarDDD(entrada);

            Assert.Equal(retorno, esperado);
        }

        [Theory]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(22)]
        [InlineData(23)]
        [InlineData(54)]
        public void Quando_PassadoNumeroNaoEncontrado_Deve_RetornarExcecao(int entrada)
        {
            const string mensagemEsperada = "DDD não encontrado";

            var excecao = Assert.Throws<ArgumentException>(
                () => DDD.ValidarDDD(entrada));

            Assert.Equal(excecao.Message, mensagemEsperada);
        }
    }
}

