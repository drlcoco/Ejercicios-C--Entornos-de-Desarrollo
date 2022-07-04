using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    abstract class Empleados
    {
        // declaro las variables como protected.
        protected String nombre;
        protected String apellidos;
        protected float sueldoBase;
        protected String dni;

        // declaro a los métodos como viertuales para poder sobreescribirlos.
        public virtual String Informacion()
        {
            return this.nombre + this.apellidos + this. dni+ this.sueldoBase;
        }
        // ya que el maskedTextBox devuelve el número como entero, para poder calcular el sueldo correctamente, lo divido por 100.
        public virtual float CalculaSueldo()
        {
            return this.sueldoBase/100;
        }

    }

   
}
