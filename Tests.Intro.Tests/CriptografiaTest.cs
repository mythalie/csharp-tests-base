using System;
using Xunit;

namespace Tests.Intro.Tests
{
    public class CriptografiaTest
    {
        [Theory]
        [InlineData("Texto #3", "3# rvzgV")]
        [InlineData("abcABC1", "1FECedc")]
        [InlineData("vxpdylY .ph", "ks. \\n{frzx")]
        [InlineData("vv.xwfxo.fd", "gi.r{hyz-xx")]

        public void Quando_PassadoStringValida_Deve_RetornarValorCriptografado(string entrada, string esperado)
        {
            var retorno = Criptografia.Criptografar(entrada);
            Assert.Equal(retorno, esperado);
        }

        [Theory]
        [InlineData("Tex")]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void Quando_PassadoStringInvalida_Deve_RetornarExcecao(string entrada)
        {
            const string mensagemEsperada = "entrada é nula, vazia ou muito pequena.";
            var exception = Assert.Throws<ArgumentException>(
                () => Criptografia.Criptografar(entrada));
            Assert.Equal(exception.Message, mensagemEsperada);
        }
    }
}
