using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    interface Estudiantes
    {
        //declaro la interfaz Estudiante y sus 3 métodos a sobreescribir en las clases que la implementan.
        public abstract String Examenes();
        public abstract String Universidad();
        public abstract float NotaMedia();
    }
}
