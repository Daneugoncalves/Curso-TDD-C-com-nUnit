using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asserts.Tests.Igualdade
{
    [TestFixture]
    public class CalculadoraTest
    {
        [Test]
        public void DevoSomarNumerosInteiros()
        {
            var sut = new Calculadora();
            var resultado = sut.SomarNumerosInteiros(4, 2);

            Assert.That(resultado, Is.EqualTo(6));
        }

        [Test]
        public void DevoSomarNumerosDecimais()
        {
            var sut = new Calculadora();
            var resultado = sut.SomarNumerosDecimais(1.1, 2.2);

            Assert.That(resultado, Is.EqualTo(3.3));
        }

        [Test]
        public void DevoSomarNumerosDecimais_UsandoWithin()
        {
            var sut = new Calculadora();
            var resultado = sut.SomarNumerosDecimais(1.1, 2.2);

            Assert.That(resultado, Is.EqualTo(3.3).Within(0.01)); // Se o resultado estiver entre 3,29 e 3,31 - teste passa
        }

        [Test]
        public void DevoSomarNumerosDecimais_UsandoWithinPorcentagem()
        {
            var sut = new Calculadora();
            var resultado = sut.SomarNumerosDecimais(50, 50);

            Assert.That(resultado, Is.EqualTo(101).Within(1).Percent); // tolerancia de até 1%
        }

        [Test]
        public void DevoSomarNumerosDecimais_NaoBomExemploDeWithin()
        {
            var sut = new Calculadora();
            var resultado = sut.SomarNumerosDecimais(1.1, 2.2);
            // como nao usar o within
            Assert.That(resultado, Is.EqualTo(30).Within(100)); // qualquer numero de -70 a 130
        }

        // Alem de usar o Is.EqualTo podemos usar:
        // Is.Positive / Is.Negative / Is.NaN
    }
}
