﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carta : Mercaderia
    {
        private DateTime fechaCorreccion;
        public int[] idBarcosCartas;
        private int idCarta;
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
        ///
        private int IdCarta
        {
            get
            {
                return this.idCarta;
            }
            set
            {
                if (value < 0)
                {
                    this.idCarta = 0;
                }
                else
                {
                    this.idCarta = value;
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
        public Carta(string titulo, int edicion, string editor, string codigo, int cantidad, DateTime fechaCorreccion, int idCarta ) : base (titulo, edicion, editor, codigo, cantidad)
        {
            this.FechaCorreccion = fechaCorreccion;
            this.idCarta = idCarta;
        }

        public override void obtenenerIdBarcos(int[] idBarcos)
        {
            this.idBarcosCartas = idBarcos;
        }
    }
}