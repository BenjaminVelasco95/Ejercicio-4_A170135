using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace AreaFiguras.ServiceA170135
{
    /// <summary>
    /// Descripción breve de AreaFigurasWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class AreaFigurasWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public int AreaCuadrado(int lado)
        {
            return lado * lado;
        }
        [WebMethod]
        public double AreaTriangulo(int @base, int altura)
        {
            return @base * altura /2;
        }
        [WebMethod]
        public double AreaCirculo(double radio)
        {
            const double Pi = 3.14159;
            return Pi * (radio*radio);
        }
    }
}
