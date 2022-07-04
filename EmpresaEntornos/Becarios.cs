using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    //clase Becarios hereda de Empleados e implementa a la interfaz Estudiantes
    class Becarios: Empleados,Estudiantes
    {
        private int nota1, nota2, nota3;
        private String carrera;
        private String curso;
        private String departamento;
        private String universidad;

        //el constructor usa como parámetros todos los campos. Los de la clase base y los suyos.
        public Becarios(String nombre, String apellidos, String dni, float sueldoBase, String carrera, String curso, String departamento, String universidad, int nota1, int nota2, int nota3 )
        {
            base.nombre = nombre;
            base.apellidos = apellidos;
            base.dni = dni;
            this.carrera = carrera;
            this.curso = curso;
            this.departamento = departamento;
            base.sueldoBase = sueldoBase;
            this.universidad = universidad;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;          
        }

        //método Examenes comprueba las notas y devuelve un String con las notas
        public String Examenes()
        {
            String s = "";
            if(this.nota1<0||this.nota1>10|| this.nota2 < 0 || this.nota2 > 10|| this.nota3 < 0 || this.nota3 > 10)
            {
                System.Windows.Forms.MessageBox.Show("Las notas son entre 0 y 10");
            }
            else
            {
                s= this.nota1 + "," + this.nota2 + "," + this.nota3;
            }
            return s; 
        }
        // el método Universidad() devuelve el nombre de la universidad.
        public String Universidad()
        {
          
            return this.universidad;
        }
        /* el método NotaMedia() llama al método Examenes() y divide el valor en un array de notas.
         * Calculo la suma de las notas, convirtiendolas en float.
         * Le pongo el formato con Math.Round()
         */
        public float NotaMedia()
        {
            float suma = 0;
           
            String [] notas = Examenes().Split(",");
            for (int i = 0; i<notas.Length; i++){
                suma = suma + Convert.ToSingle(notas[i]);
            }
            double nota = suma / notas.Length;
            float notaMedia = (float)Math.Round(nota, 1);
            return notaMedia; 
        }
        //Sobreescribo el método Informacion(). También podría declararlo como new, para lo que lo uso no importa.
        public override string Informacion()
        {
            return "Departamento: "+this.departamento+"\r\nCarrera: "+ this.carrera+ "\r\nUniversidad: "+Universidad()+"\r\nCurso: "+this.curso+"\r\nNota media: "+NotaMedia();
        }
    }
}
