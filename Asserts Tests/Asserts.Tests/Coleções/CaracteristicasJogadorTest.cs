using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Asserts.Tests.Coleções
{
    [TestFixture]
    public class CaracteristicasJogadorTest
    {
        [Test]
        public void NaoDevoTerListaDeArmasVazia()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Is.All.Not.Empty);
        }

        [Test]
        public void DeveterArmaEspecifica()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Contains.Item("Katana"));
        }

        //Método responsável por testar se contem uma determinada palavra em uma determinada coleção:
        [Test]
        public void DeveterPeloMenos1TiposDeEspada()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Has.Some.Contains("Espada"));
        }

        [Test]
        public void NaoDeveContarMaisTiposDeArmasNoJogo()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Is.Unique);
        }

        [Test]
        public void NaodeveConterArmaCanhao() 
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Has.None.EqualTo("Canhão"));
        }
        [Test]
        public void DeveConterDuasEspadas()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Has.Exactly(2).StartsWith("Espada"));
        }

        [Test]
        public void DeveConterTodasAsArmas()
        {
            var sut = new CaracteristicasJogador();

            var listaDeArmasEsperadas = new []
           {
               "Lança",
               "Espada",
               "Escudo",
               "Nunchaku",
               "Katana",
               "Espada Medieval"
           };

            Assert.That(sut.Armas, Is.EquivalentTo(listaDeArmasEsperadas));
        }
        [Test]
        public void ArmasDevemEstarEmOrdemAlfabetica()
        {
            var sut = new CaracteristicasJogador();

            Assert.That(sut.Armas, Is.Ordered);
        }
    }
}
