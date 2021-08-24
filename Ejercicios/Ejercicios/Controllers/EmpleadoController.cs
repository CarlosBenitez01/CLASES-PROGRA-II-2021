using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicios.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Empleado()
        {
            return View();
        }
        //public ActionResult Recibo()
        //{
        //    return View();
        //}
        public ActionResult IrAEmpleado()
        {
            return Redirect("/Empleado/Empleado");
        }
        public ActionResult Recibo(String nombre, String valhora, String antiguedad, String horast)
        {

            String Nombre = nombre;
            Double ValHora = Convert.ToDouble(valhora);
            int Antig = Convert.ToInt32(antiguedad);
            int HorasT = Convert.ToInt32(horast);

            Double TotACobrar = ValHora * HorasT + Antig * 30;
            Double TotDelDesceunto = (ValHora * HorasT + Antig * 30) * 0.13;
            Double ToConDescuento = ((ValHora * HorasT + Antig * 30) - (ValHora * HorasT + Antig * 30) * 0.13);

            ViewBag.nombre = Nombre;
            ViewBag.antique = Antig;
            ViewBag.valhora = ValHora;
            ViewBag.totacobrar = TotACobrar;
            ViewBag.totdeldescuento = TotDelDesceunto;
            ViewBag.totcondescuento = ToConDescuento;

            return View();
        }
    }
}