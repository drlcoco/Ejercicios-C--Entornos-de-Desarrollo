using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Cualificados:Empleados
    {
        //declaro la clase Cualificados que hereda de la clase Empleados y declaro las variables
        protected String titulacion;
        protected float plus;
        protected String departamento;
        // declaro al constructor con todas las variables como parámetros.
        public Cualificados(String nombre, String apellidos, String dni, float sueldoBase, String titulacion, String departamento,  float plus)
        {
            base.nombre = nombre;
            base.apellidos = apellidos;
            base.dni = dni;
            base.sueldoBase = sueldoBase;
            this.titulacion = titulacion;
            this.departamento = departamento;
            this.plus = plus;
        }
        //Sobreescribo al método Informacion()
        public override string Informacion()
        {
            return "Titulación: "+ this.titulacion+ "\r\nDepartamento: "+this.departamento;
        }
        //sobreescribo el método CalculaSueldo y le añado el plus de la clase Cualificados
        public override float CalculaSueldo()
        {
            return base.CalculaSueldo()+ this.plus/100;
        }
    }
}
