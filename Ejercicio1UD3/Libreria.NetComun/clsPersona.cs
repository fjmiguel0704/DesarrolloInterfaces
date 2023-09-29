using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.NetComun
{
    internal class clsPersona
    {
        #region atributos
        private String nombre;
        private String apellidos;
        #endregion

        #region constructores
        public clsPersona() {
            nombre = "";
            apellidos = "";
        }

        public clsPersona(String nombre, String apellidos) {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        #endregion

        #region propiedades
        public String Nombre { 
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public String Direccion { get; set; }

        public String nombreCompleto { 
            get { return $"Su nombre completo es: {nombre} {apellidos}"; }
        }

        public String FuncionNombreCompleto() {
            return $"Su nombre completo es: {nombre} {apellidos}";
        }
        #endregion
    }
}
