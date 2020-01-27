using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_JsonResult.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetDados()
        {
            var resultado = new
            {
                Nome = "Linha de Código",
                URL = "www.linhadecodigo.com.br"
            };

            /* Json(): Converte o objeto para o formato JSON antes de retornar
             * Não é permitido acessar essa action através do método GET. 
             * Trata-se de uma medida de segurança para prevenir que dados sensíveis sejam expostos para sites de terceiros. 
             * Para permitir que essa action seja acessada diretamente via GET, é preciso adicionar o parâmetro JsonRequestBehavior.AllowGet
             */
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetListaDados()
        {
            List<object> resultado = new List<object>();

            resultado.Add(new
            {
                Nome = "Linha de Código",
                URL = "www.linhadecodigo.com.br"
            });

            resultado.Add(new
            {
                Nome = "DevMedia",
                URL = "www.devmedia.com.br"
            });

            resultado.Add(new
            {
                Nome = "Mr. Bool",
                URL = "www.mrbool.com.br"
            });

            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetItens(int quantidade)
        {
            List<object> resultado = new List<object>();

            for (int i = 0; i < quantidade; i++)
                resultado.Add(new { Item = i.ToString("000")});

            return Json(resultado);
        }
    }
}