using Ejercicios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicios.DAORE
{
    public class Datos_Usu
    {
        public List<ClsDatosUsu> ObtDatos()
        {
            return new List<ClsDatosUsu>() 
            {
                new ClsDatosUsu()
                {
                   Usuario = "Carlos",
                   Dui = "76347325"

                }
                  //Con el controlador mostramos la lista
            };
        }
        public String[] lista = new String[2] { "Carlos", "435435" };
    }
}