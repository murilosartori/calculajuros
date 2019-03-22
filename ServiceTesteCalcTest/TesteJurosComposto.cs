using NUnit.Framework;
using ApplicationCalcTest;

namespace ServiceTesteCalcTest
{
    public class TesteJurosComposto
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            AppJurosComposto _AppJurosComposto = new AppJurosComposto();
            Assert.IsTrue(_AppJurosComposto.CalculoJurosComposto(100, 5) == 105.1);
        }
    }
}
