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
        private int idCliente;
        private int idBarco;
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
        /// Propiedad para atributo idCliente
        /// </summary>
        public int IdCliente
        {
            get
            {
                return this.idCliente;
            }
            set
            {
                if (value < 1)
                {
                    this.idCliente = 1;
                }
                else
                {
                    this.idCliente = value;
                }
            }
        }
        /// <summary>
        /// Propiedad para atributo idBarco
        /// </summary>
        public int IdBarco
        {
            get
            {
                return this.idBarco;
            }
            set
            {
                if (value < 1)
                {
                    this.idBarco = 1;
                }
                else
                {
                    this.idBarco = value;
                }
            }
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
        public Barco(string nombreBarco, tipoBarco tipo, int idCliente, int idBarco ) : this()
        {
            this.NombreBarco = nombreBarco;
            this.TipoBarco = tipo;
            this.idCliente = idCliente;
            this.IdBarco = idBarco;
        }
        public Barco(string nombreBarco, tipoBarco tipo) : this()
        {
            this.NombreBarco = nombreBarco;
            this.TipoBarco = tipo;
        }

    }
}
