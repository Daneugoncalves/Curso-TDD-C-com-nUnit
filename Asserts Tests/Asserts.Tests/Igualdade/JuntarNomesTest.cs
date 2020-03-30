using NUnit.Framework;

namespace Asserts.Tests.Igualdade
{
    [TestFixture]
    public class JuntarNomesTest
    {
        [Test]
        public void DevoJuntarDoisNomes()
        {
            var sut = new JuntarNomes();

            var nomeCompleto = sut.Juntar("Daniel", "Gonçalves");

            Assert.That(nomeCompleto, Is.EqualTo("Daniel Gonçalves"));
        }

        [Test]
        public void DevoJuntarDoisNomes_CaseSensetive()
        {
            var sut = new JuntarNomes();

            var nomeCompleto = sut.Juntar("daniel", "gonçalves");

            Assert.That(nomeCompleto, Is.EqualTo("DANIEL GONÇALVES").IgnoreCase);
        }

        [Test]
        public void DevoJuntarDoisNomes_NaoIgual()
        {
            var sut = new JuntarNomes();

            var nomeCompleto = sut.Juntar("Daniel", "Gonçalves");

            Assert.That(nomeCompleto, Is.Not.EqualTo("Danielle Gonçalves"));
        }
    }
}
