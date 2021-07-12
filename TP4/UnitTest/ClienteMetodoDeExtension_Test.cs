using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class ClienteMetodoDeExtension_Test
    {
        Clientes cliente1 = new Clientes("Navigation Supplies");
        Barco barco1 = new Barco("Lagoona", Barco.tipoBarco.Bulker);
        Barco barco2 = new Barco("Serra", Barco.tipoBarco.Cargo);
        Barco barco3 = new Barco("Riviera", Barco.tipoBarco.Dredger);
        Barco barco4 = new Barco("Aqua", Barco.tipoBarco.Dredger);


        [TestMethod]
        public void ObtenerBarcosPorCadaCliente_Test()
        {
            Carta carta1 = new Carta("Río de la Plata Interior", 2018, "SHN", "ARH118", 1, DateTime.Parse("22/02/2018"));
            Carta carta2 = new Carta("Puerto de Buenos Aires", 2018, "SHN", "ARH156", 1, DateTime.Parse("15/03/2018"));
            Carta carta3 = new Carta("Rada y Puerto La Plata", 2016, "SHN", "ARH157", 1, DateTime.Parse("15/05/2016"));
            Carta carta4 = new Carta("Desde Arroyo Chuy hasta Mar del Plata", 2010, "SOHMA", "UY1", 1, DateTime.Parse("01/01/2010"));

            cliente1.barcos.Add(barco1);
            barco1.cartas.Add(carta1);
            cliente1.barcos.Add(barco2);
            barco1.cartas.Add(carta2);
            cliente1.barcos.Add(barco3);
            barco1.cartas.Add(carta3);           
            cliente1.barcos.Add(barco4);
            barco1.cartas.Add(carta4);

            Assert.AreEqual(4, cliente1.CantidadCartasPorCliente());

        }

        [TestMethod]
        public void ObtenerPublicacionesPorCadaCliente_Test()
        {
            Publicacion publicacion1 = new Publicacion(1, Publicacion.Formato.Digital, "Waste Assessment Guidelines", 2012, "IMO", "KB531E", 1);
            Publicacion publicacion2 = new Publicacion(2, Publicacion.Formato.Hardbook, "IMDG Code Supplement", 2008, "IMO", "KK210F", 1);
            Publicacion publicacion3 = new Publicacion(2, Publicacion.Formato.Digital, "IMDG Code Supplement", 2008, "IMO", "KK210M", 1);
            Publicacion publicacion4 = new Publicacion(1, Publicacion.Formato.Hardbook, "2011 ESP Code, 2020", 2020, "IMO", "KC265F", 1);

            cliente1.barcos.Add(barco1);
            barco1.publicaciones.Add(publicacion1);
            cliente1.barcos.Add(barco2);
            barco1.publicaciones.Add(publicacion2);
            cliente1.barcos.Add(barco3);
            barco1.publicaciones.Add(publicacion3);
            cliente1.barcos.Add(barco4);
            barco1.publicaciones.Add(publicacion4);

            Assert.AreEqual(4, cliente1.CantidadPublicacionesPorCliente());

        }
    }
}
