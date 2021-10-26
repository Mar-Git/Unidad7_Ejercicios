using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unidad7_Ejercicios.Models.Entity;

namespace Unidad7_Ejercicios.Models.DAL
{
    public class ModelView
    {
        public static List<clsPersona> getListadoPersonas()
        {
            List<clsPersona> listaAlumnos = new List<clsPersona>();

            listaAlumnos.Add(new clsPersona { Nombre = "Mar", Apellido = "Acal" });
            listaAlumnos.Add(new clsPersona { Nombre = "Fernando", Apellido = "Galiana" });
            listaAlumnos.Add(new clsPersona { Nombre = "German", Apellido = "De Bustamante" });
            listaAlumnos.Add(new clsPersona { Nombre = "Juan Jose", Apellido = "Muñoz" });
            listaAlumnos.Add(new clsPersona { Nombre = "Alvaro", Apellido = "Fernandez" });
            listaAlumnos.Add(new clsPersona { Nombre = "Pedro", Apellido = "Pastor" });

            return listaAlumnos;
        }
    }
}
