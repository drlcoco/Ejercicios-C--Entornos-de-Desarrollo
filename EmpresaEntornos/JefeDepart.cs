using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    // La clase JefeDepart hereda de Cualificados
    class JefeDepart : Cualificados
    {
        private int totalTrabCargo;
        private String proyectos;
        private float plusJ;
        // creo al constructor de la clase JefeDepart con los parámetros suyos y los del constructor de su Superclase.
        public JefeDepart(String nombre, String apellidos, String dni, float sueldoBase, String titulacion, String departamento, float plus,
            int totalTrabCargo, String proyectos,float plusJ):base(nombre, apellidos,dni,sueldoBase, titulacion,departamento,plus)
        {
            this.totalTrabCargo = totalTrabCargo;
            this.proyectos = proyectos;
            this.plusJ = plusJ;

        }
        //Creo el método Informacion() propio de la clase JefeDepart
        public new string Informacion()
        {
            return "Titulación: " + this.titulacion + "\r\nDepartamento: " + this.departamento + "\r\nTrabajadores a cargo: " +
                this.totalTrabCargo + "\r\nProyectos: " + this.totalTrabCargo;
        }
        // sobreescribo el método Informacion de la Superclase y lo adecuo a las necesidades de la subclase
        public override float CalculaSueldo()
        {
            return base.CalculaSueldo() + this.plusJ/100;
        }
    }  
}
