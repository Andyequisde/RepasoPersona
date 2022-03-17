using System;
using Xunit;

namespace RepasoPersona.Test
{
    public class PersonaTest
    {
        //public void Constructor()
        public Persona Andres {get ; set ;}
        public PersonaTest() => Andres = new Persona("Andres","Revollo", 0);
        [Fact]
        public void Constructor()
        {
            //Andres = new Persona ("Andres", "Revollo", 0);
            Assert.Equal("Andres", Andres.Nombre);
            Assert.Equal("Revollo", Andres.Apellido);
            Assert.Equal(0, Andres.Efectivo);
        }
        [Fact]
        public void AcreditarPositivo()
        {
            double esperado = 1000;
            Andres.Acreditar(1000);
            Assert.NotEqual(esperado, Andres.Efectivo, 3);
        }
        
        [Theory]
        [InlineData(0)]
        [InlineData(-157.34)]
        public void AcreditarCeroONegativo(double monto)
        {
            var ex = Assert.Throws<ArgumentException>(() => Pepito.Acreditar(0));
            Assert.Equal("El monto tiene que ser mayor a cero.", ex.Message);
        }

        [Fact]
        public void Debitar()
        {
            double monto = 500.45;
            double debito = 135.45;
            Pepito.Acreditar(monto);
            Pepito.Debitar(debito);

            Assert.Equal(monto - debito, Pepito.Efectivo, 2);
        }

        [Fact]
        public void DebitarInsuficiente()
        {
            var ex = Assert.Throws<InvalidOperationException>(() => Pepito.Debitar(1000));
            Assert.Equal("El monto supera al efectivo.", ex.Message);
    }
}