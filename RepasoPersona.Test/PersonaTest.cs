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
    }
}