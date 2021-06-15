using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Barco
    {

        private string nombreBarco;
        public List<Publicacion> publicaciones;
        public List<Carta> cartas;

        public enum tipoBarco
        {
            Tanker,
            Bulker,
            Cargo,
            Dredger,
            Livestock,
            Fishing,
        }

        /// <summary>
        /// Propiedad de lectura y escritura de nombreBarco
        /// </summary>
        public string NombreBarco
        {
            get
            {
                return this.nombreBarco;
            }
            set
            {
                this.nombreBarco = value;
            }


        }
        /// <summary>
        /// Propiedad para el enum TipoBarco
        /// </summary>
        public tipoBarco TipoBarco
        {
            get; set;
        }
        /// <summary>
        /// Constructor donde se instancian las listas
        /// </summary>
        private Barco()
        {
            publicaciones = new List<Publicacion>();
            cartas = new List<Carta>();
        } 
        /// <summary>
        /// Constructor de la clase Barco, llama al constructor privado
        /// </summary>
        /// <param name="nombreBarco"></param>
        /// <param name="tipo"></param>
        public Barco(string nombreBarco, tipoBarco tipo ) : this()
        {
            this.NombreBarco = nombreBarco;
            this.TipoBarco = tipo;
        }
            
    }
}
