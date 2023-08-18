using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class CampaignTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidCampaignException))]
        [DataRow(null, "med", "nme")]
        [DataRow("src", null, "nme")]
        [DataRow("src", "med", null)]
        [DataRow("", "med", "nme")]
        [DataRow("src", "", "nme")]
        [DataRow("src", "med", "")]
        public void DadoUmaUrlInvalidaDeveDarExcecao(string source, string medium, string name)
        {
            var CampaignInvalid = new Campaign(source, medium, name);
        }
        [TestMethod]
        public void DadoUmaCampanhaValidaNaoDeveLancarExcecao()
        {
            var campaignValid = new Campaign("Src", "med", "nme");
        }
    }
}
