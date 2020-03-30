using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asserts.Tests.BoleanosNulos
{
    [TestFixture]
   public class CaracteristicasJogadorTests
    {
        [Test]
        public void DevoGerarnomeRandomicoPorDefault()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Nome, Is.Not.Empty);
        }

        [Test]
        public void DevoVerificarNovojogador()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.NovoJogador, Is.True);
        }

        [Test]
        public void DevoVerificarApelido()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Apelido, Is.Null);
        }
    }
}
