using System;
using System.Text;

namespace Entidades {
    [Serializable]
    public class Publicacion : Mercaderia {
        private int tomos;
        public int[] idBarcosPublicaciones;
        public enum Formato {
            Digital,
            Hardbook,
        }
        /// <summary>
        /// Propiedad para el enumerado Formato de lectura y escritura
        /// </summary>
        public Formato eFormato {
            get; set;
        }
        /// <summary>
        /// Propiedad para el atributo tomos de lectura y escritura. En su setter verifica que no tenga un número negativo y lo settea en 1.
        /// </summary>
        public int Tomos {
            get {
                return this.tomos;
            }
            set {
                if (value <= 0) {
                    this.tomos = 1;
                }
            }
        }
        /// <summary>
        /// Constructor de defecto para la clase Publicacion
        /// </summary>
        public Publicacion() {

        }
        /// <summary>
        /// Constructor para la clase Publicación, llamará a su base en Mercadería
        /// </summary>
        /// <param name="tomos"></param>
        /// <param name="formato"></param>
        /// <param name="titulo"></param>
        /// <param name="edicion"></param>
        /// <param name="editor"></param>
        /// <param name="codigo"></param>
        /// <param name="cantidad"></param>
        public Publicacion(int tomos, Formato formato, string titulo, int edicion, string editor, string codigo, int cantidad) : base(titulo, edicion, editor, codigo, cantidad) {
            this.tomos = tomos;
            this.eFormato = formato;
        }

        public override void obtenenerIdBarcos(int[] idBarcos) {
            this.idBarcosPublicaciones = idBarcos;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Titulo: {0}", this.Titulo));
            sb.AppendLine(string.Format("Edición: {0}", this.Edicion));
            sb.AppendLine(string.Format("Código: {0}", this.Codigo));
            sb.AppendLine(string.Format("Editor: {0}", this.Editor));
            sb.AppendLine(string.Format("Formato: {0}", this.eFormato));

            return sb.ToString();
        }
    }
}
