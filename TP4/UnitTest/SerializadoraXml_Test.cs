using System;
using System.Collections.Generic;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serializacion;

namespace UnitTest {
    [TestClass]
    public class SerializadoraXml_Test {

        SerializadoraXml<List<Publicacion>> serializadoraTesting = new SerializadoraXml<List<Publicacion>>();

        private static string rutaPub = AppDomain.CurrentDomain.BaseDirectory + "testPub";

        public List<Publicacion> listaPublicacionesUno = new List<Publicacion>();

        [TestMethod]
        public void SerializarGuardarXML_RutaVacia_Test() {
            Assert.IsFalse(serializadoraTesting.Guardar("", listaPublicacionesUno));
        }

        [TestMethod]
        public void SerializarGuardarXML_RutaCorrecta_Test() {
            Assert.IsTrue(serializadoraTesting.Guardar(rutaPub, listaPublicacionesUno));
        }

        [TestMethod]
        public void SerializarLeerXML_RutaVacia_Test() {
            Assert.ThrowsException<Exception>(() => serializadoraTesting.Leer("", out listaPublicacionesUno));

        }

    }
}