using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Carta))]
    [XmlInclude(typeof(Publicacion))]

    public abstract class Mercaderia
    {
        private string titulo;
        private int edicion;
        private string editor;
        private string codigo;
        private int cantidad;

        /// <summary>
        ///  Propiedad para el atributo edicion de lectura y escritura
        /// </summary>
        public int Edicion
        {
            get
            {
                return this.edicion;
            }
            set
            {
                this.edicion = value;
            }
        }
        /// <summary>
        /// Propiedad para el atributo titulo de lectura y escritura
        /// </summary>
        public string Titulo
        {
            get
            {
                return this.titulo;
            } 
            set
            {
                this.titulo = value;
            }
        }
        /// <summary>
        /// Propiedad para el atributo editor de lectura y escritura
        /// </summary>
        public string Editor
        {
            get
            {
                return this.editor;
            }
            set
            {
                this.editor = value;
            }
        }
        /// <summary>
        /// Propiedad para el atributo código de lectura y escritura
        /// </summary>
        public string Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }
        /// <summary>
        /// Propiedad para el atributo cantidad de lectura y escritura
        /// </summary>
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                if (value < 0)
                    this.cantidad = 0;
                else
                    this.cantidad = value;
            }
        }
        /// <summary>
        ///  Constructor de mercadería, establecerá los valores pasados por parámetro.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="edicion"></param>
        /// <param name="editor"></param>
        /// <param name="codigo"></param>
        public Mercaderia(string titulo, int edicion, string editor, string codigo, int cantidad)
        {
            this.titulo = titulo;
            this.edicion = edicion;
            this.editor = editor;
            this.codigo = codigo;
            this.cantidad = cantidad;
        }
        /// <summary>
        /// Constructor de defecto para la clase Mercadería
        /// </summary>
        public Mercaderia()
        {
        }
    }
}
