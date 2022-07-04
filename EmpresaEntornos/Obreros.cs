using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Obreros : Empleados
    {

        /*Declaro las variables necesarias y creo al constructor con todos los campos como parámetros.
         */
        private String destinoTrabajo;
        private float horasExtra;
        private float precioHE;

        public Obreros(String nombre, String apellidos, String dni, float sueldoBase, String destinoTrabajo, float horasExtra, float precioHE)
        {
            base.nombre = nombre;
            base.apellidos = apellidos;
            base.dni = dni;
            base.sueldoBase = sueldoBase;
            this.destinoTrabajo = destinoTrabajo;
            this.horasExtra = horasExtra;
            this.precioHE = precioHE;
        }
        // Declaro el método Informacion() como new, ya que es un método propio de la clase Obreros
        public new string Informacion()
        {
            return "Destino: "+this.destinoTrabajo+"\r\nPrecio horas extra: " + this.precioHE;
        }
        // sobreescribo el método CalculaSueldo(), añadiendole las horas extra

        public override float CalculaSueldo()
        {
            return base.CalculaSueldo()+ this.horasExtra*this.precioHE/100;
        }
    }

       

    
}
