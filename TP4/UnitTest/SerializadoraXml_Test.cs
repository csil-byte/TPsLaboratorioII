using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Entidades;
using Serializacion;

namespace UnitTest
{
    [TestClass]
    public class SerializadoraXml_Test
    {
        //////////////////////////////////////////////////////////////// USO DE TESTS UNITARIOS

        SerializadoraXml<List<Publicacion>> serializadoraTesting = new SerializadoraXml<List<Publicacion>>();

        private static string rutaPub = AppDomain.CurrentDomain.BaseDirectory + "testPub";

        public List<Publicacion> listaPublicacionesUno = new List<Publicacion>();

        [TestMethod]
        public void SerializarGuardarXML_RutaVacia_Test()
        {
            Assert.IsFalse(serializadoraTesting.Guardar("", listaPublicacionesUno));
        }
        
        [TestMethod]
        public void SerializarGuardarXML_RutaCorrecta_Test()
        {
            Assert.IsTrue(serializadoraTesting.Guardar(rutaPub, listaPublicacionesUno));
        }

        [TestMethod]       
        public void SerializarLeerXML_RutaVacia_Test()
        {
            Assert.ThrowsException<Exception>(() => serializadoraTesting.Leer("", out listaPublicacionesUno));

        }

    }
}