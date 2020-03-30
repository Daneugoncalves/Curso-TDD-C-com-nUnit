using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asserts.Tests.Referencias
{
    [TestFixture]
    public class CaracteristicasJogadorTests
    {
        [Test]
        public void CompararReferenciaDeObjeto()
        {
            var jogador1 = new CaracteristicasJogador();
            var jogador2 = new CaracteristicasJogador();

            Assert.That(jogador1, Is.SameAs(jogador2));
        }
        [Test]
        public void CompararReferenciaDeObjetoComVariavelSameAs()
        {
            var jogador1 = new CaracteristicasJogador();
            var jogador = jogador1;

            Assert.That(jogador, Is.SameAs(jogador1));
        }
        [Test]
        public void CompararReferenciaDeObjetoComVariavelNotSameAs()
        {
            var jogador1 = new CaracteristicasJogador();
            var jogador2 = new CaracteristicasJogador();

            Assert.That(jogador1, Is.Not.SameAs(jogador2));

        }
    }
}
