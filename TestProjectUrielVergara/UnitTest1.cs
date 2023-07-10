using ConsoleAppUrielVergara.Entidades;

namespace TestProjectUrielVergara
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ObtenerArea()
        {
            var radio = 1;
            var altura = 1;
            Cono cono = new Cono(altura,radio);

            Assert.AreNotEqual(7,cono.GetArea() );

        }
        [TestMethod]
        public void ObtenerVolumen()
        {
            Cono cono = new Cono(1, 1);
            Assert.AreEqual(1, cono.GetVolumen());
        }
    }
}