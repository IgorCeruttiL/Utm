
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        private const string InvalidUrl = "banana";
        private const string ValidUrl = "https://balta.io";

        [TestMethod]
        [ExpectedException(typeof(InvalidUrlException))]
        [TestCategory("Teste da URL")]
        public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
        {
            new Url(InvalidUrl);
        }

        [TestMethod]
        [TestCategory("Teste da URL")]
        public void Dado_uma_url_valida_nao_deve_retorna_excecao()
        {
            var url = new Url(ValidUrl);
            Assert.IsTrue(true);
        }

    }
}
