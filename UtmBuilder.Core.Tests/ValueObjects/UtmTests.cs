using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class UtmTests
    {
        private const string Result = "https://balta.io/?utm_source=src&utm_medium=med&utm_campaign=nme&utm_id=id&utm_term=ter&utm_content=ctn";
        private readonly Url _Url = new ("https://balta.io/");
        private readonly Campaign _Campaign = new ("src", "med", "nme", "id", "ter", "ctn");

        [TestMethod]
        public void DeveRetornarURLDaUtm()
        {
            var utm = new Utm(_Url, _Campaign);

            Assert.AreEqual(Result, utm.ToString());
            Assert.AreEqual(Result, (string)utm);
        }

        [TestMethod]
        public void DeveRetornarUtmDaUrl()
        {
            Utm utm = Result;
            Assert.AreEqual("https://balta.io/", utm.Url.Adress);
            Assert.AreEqual("src", utm.Campaign.Source);
            Assert.AreEqual("med", utm.Campaign.Medium);
            Assert.AreEqual("nme", utm.Campaign.Name);
            Assert.AreEqual("id", utm.Campaign.Id);
            Assert.AreEqual("ter", utm.Campaign.Term);
            Assert.AreEqual("ctn", utm.Campaign.Content);
        }

    }
}
