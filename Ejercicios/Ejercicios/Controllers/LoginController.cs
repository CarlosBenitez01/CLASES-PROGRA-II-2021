
using Ejercicios.DAORE;
using Ejercicios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Ejercicios.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(String usu, String dui)
        {
            //try {
            //    ClsDatosUsu cls = new ClsDatosUsu();
            //    Datos_Usu clsDatos = new Datos_Usu();
            //    List<ClsDatosUsu> lista = clsDatos.ObtDatos();
            //    foreach (var i in lista)
            //    {
            //        if (i.Usuario.Equals(usuario) && i.Dui.Equals(dui))
            //        {
            //            return Redirect("/Empleado/Empleado");
            //        }
            //        else
            //        {

            //        }
            //    }
            //}
            //catch (Exception ex) {
            //    MessageBox.Show();
            //}
            String[] lista = new String[2] { "Nombre", "Dui" };
            Datos_Usu clsDatos = new Datos_Usu();
            for (int i = 0; i < clsDatos.lista.Length; i++) {
                if (usu.Equals(clsDatos.lista[0]) && dui.Equals(clsDatos.lista[1])) {
                    return Redirect("/Empleado/Empleado");
                }
            }
            //List<ClsDatosUsu> lista = clsDatos.ObtDatos()
            //foreach (var i in lista)
            //{
            //    if (i.Usuario.Equals(usuario) && i.Dui.Equals(dui))
            //    {
            //        return Redirect("/Empleado/Empleado");
            //    }
            //    else
            //    {

            //    }

            //}
            return View();

        }
    }
}