using NUnit.Framework;
using WebNumeroLetra.Controllers;

namespace NUnitTestNumeroLetra
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGet()
        {
            //Arrange=preparacion
            string num = "148002";

            string esperado = "CIENTO CUARENTA Y OCHO MIL DOS";

            NumeroLetraController Letra = new NumeroLetraController();

            //Act=ejecution
            string resultado = Letra.enletras(num);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestPost()
        {
            //Arrange=preparacion
            string num = "80000";

            string esperado = "OCHENTA MIL";

            NumeroLetraController Letra = new NumeroLetraController();

            //Act=ejecution
            string resultado = Letra.letras(num);

            //Assert=Verification
            Assert.AreEqual(esperado, resultado);

        }
    }
}