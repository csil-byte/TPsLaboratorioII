using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carta : Mercaderia
    {
        private DateTime fechaCorreccion;        
        /// <summary>
        /// Propiedad FechaCorreccion de lectura y escritura
        /// </summary>
        public DateTime FechaCorreccion
        {
            get
            {
                return this.fechaCorreccion;
            }
            set
            {
                if (value.GetType() == typeof(DateTime))
                {
                    this.fechaCorreccion = value;
                }
            }
        }
        /// <summary>
        /// Constructor de defecto para la clase Carta, permite serializar
        /// </summary>
        public Carta()
        {

        }
        /// <summary>
        /// Constructor de la clase Carta, llamará a la base: Mercadería 
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="edicion"></param>
        /// <param name="editor"></param>
        /// <param name="codigo"></param>
        /// <param name="cantidad"></param>
        /// <param name="fechaCorreccion"></param>
        public Carta(string titulo, int edicion, string editor, string codigo, int cantidad, DateTime fechaCorreccion ) : base (titulo, edicion, editor, codigo, cantidad)
        {
            this.FechaCorreccion = fechaCorreccion;
        }
    }
}
