using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WebApiNom.Model;
using WebApiNom.Repos;

namespace UnitTestProyApi
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            List<NombreDt> nombre = new List<NombreDt>()
                 {
                    new NombreDt() { Id = 1, Nombre = "persona 1" , Apellido = "Apellido 1" },
                    new NombreDt() { Id = 2, Nombre = "persona 2" , Apellido = "Apellido 2" },
                    new NombreDt() { Id = 3, Nombre = "persona 3" , Apellido = "Apellido 3" }
                 };

            //Act
            var actual = RNombres._listaNombre;


            //Assert
            for (int i = 0; i < 2; i++)
            {
                //validacion igualdad
                Assert.AreEqual(nombre[i].Id, actual[i].Id);
                Assert.AreEqual(nombre[i].Nombre, actual[i].Nombre);
                Assert.AreEqual(nombre[i].Apellido, actual[i].Apellido);

            }

            //validacion tipo
            Assert.IsInstanceOfType(actual[0], typeof(NombreDt));
        }
    }
}
