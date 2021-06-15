using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clientes
    {

        private string nombre;
        public List<Barco> barcos;
        private int cantidadBarcos;

        /// <summary>
        /// Propiedad de lectura y escritura para this.nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura de this.cantidad de barcos
        /// </summary>
        public int CantidadBarcos
        {
            get
            {
                return this.cantidadBarcos;
            }
            set
            {
                this.cantidadBarcos = this.barcos.Count();
            }
        }
        /// <summary>
        /// Constructor privado que instanciará lista de barcos
        /// </summary>
        private Clientes()
        {
            barcos = new List<Barco>();
        }
        /// <summary>
        /// Constructor de clientes, llamará al constructor privado
        /// </summary>
        /// <param name="nombre"></param>
        public Clientes(string nombre) : this()
        {
            this.nombre = nombre;
        }
    }

}

