using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asserts.Tests.Igualdade
{
    [TestFixture]
    public class DataEspeciaisStoreTest
    {
        [Test]
        public void DeveRetornarCorretamenteAnoNovo()
        {
            var sut = new DatasEspeciaisStore();

            var resultado = sut.Data(DatasEspeciais.AnoNovo);

            Assert.That(resultado, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0, 0)));
        }

        [Test]
        public void DeveRetornarCorretamenteAnoNovo_Within()
        {
            var sut = new DatasEspeciaisStore();

            var resultado = sut.Data(DatasEspeciais.AnoNovo);

            Assert.That(resultado, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0, 1)).Within(1).Milliseconds);

            // outra forma de fazer
            Assert.That(resultado, Is.EqualTo(new DateTime(2017, 1, 1, 0, 0, 0, 1)).Within(TimeSpan.FromMilliseconds(1)));
        }
    }
}
