using NUnit.Framework;
using System;

namespace Asserts.Tests.Intervalos
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        [Test]
        public void DevoAumentarVidaJogadorDepoisDeDormir()
        {
            var sut = new CaracteristicasJogador { Vida = 100};
            sut.Dormir();
            Assert.That(sut.Vida, Is.GreaterThan(100));
        }

       [Test]
        public void DevoAumentarVidaJogadorDepoisDeDormir_Intervalo()
        {
            var sut = new CaracteristicasJogador { Vida = 100 };
            sut.Dormir();
            Assert.That(sut.Vida, Is.InRange(101, 200));
        }
        /*
         Podemos usar tambem:
         1) Is.GreaterThanOrEqualTo();
         2) Is.LessThen
         3) Is.LessThanOrEqualTo()
        */
    }
}
