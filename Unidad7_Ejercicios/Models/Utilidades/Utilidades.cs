using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidad7_Ejercicios.Models.Utilidades
{
    public class Utilidades
    {
        public static String getSaludoHora()
        {
            String saludo="Buenos dias";
            
            if(DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 20)
            {
                saludo = "Buenas tardes";
            }
            else
            if(DateTime.Now.Hour>=20 && DateTime.Now.Hour<6)
            {
                saludo = "Buenas noches";
            }

            return saludo;
        }
    }
}
