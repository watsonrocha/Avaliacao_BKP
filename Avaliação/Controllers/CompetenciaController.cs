using Avaliação.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avaliação.Controllers
{
    public class CompetenciaController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        public CompetenciaController(IHttpContextAccessor httpContextAccessor)
        {

            HttpContextAccessor = httpContextAccessor;



        }

        public IActionResult Relatorio()
        {
            
            CompetenciaModel objConta = new CompetenciaModel(HttpContextAccessor);
            ViewBag.ListaCadastro = objConta.ListaCadastro();

            return View();

        }

        public IActionResult RelatorioUsuario()
        {

            CompetenciaModel objConta = new CompetenciaModel(HttpContextAccessor);
            ViewBag.ListaUsuario = objConta.ListaUsuario();

            return View();

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index_Relatorio()
        {
            return View();
        }

        public IActionResult Index_Assist()
        {
            return View();
        }

        public IActionResult NegociosGestor()
        {
            return View();
        }

        public IActionResult NegociosAssist()
        {
            return View();
        }

        public IActionResult NegociosEspec()
        {
            return View();
        }

        public IActionResult NegociosGlTl()
        {
            return View();
        }
        public IActionResult Index02()
        {
            return View();
        }

        public IActionResult Index03()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateSenhaUpdate(string Negocios01, string Negocios02, string Negocios03, string Negocios04, string Negocios05, string Negocios06, string Negocios07)
        {
            CompetenciaModel objConta = new CompetenciaModel(HttpContextAccessor);
            objConta.CompetenciaUpdate(Negocios01,Negocios02,Negocios03,Negocios04,Negocios05,Negocios06,Negocios07);

            return RedirectToAction("Index02", "Competencia");


        }

        [HttpPost]
        public IActionResult UpdateAssist(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Negocios01, string Negocios02, string Negocios03, string Negocios04, string Negocios05, string Negocios06, string Negocios07)
        {
            CompetenciaModel objConta = new CompetenciaModel(HttpContextAccessor);
            objConta.CompetenciaUpdate(Checkbox1, Checkbox2, Checkbox3, Checkbox4, Checkbox5, Checkbox6, Checkbox7);
            objConta.CompetenciaOPerador(Negocios01,Negocios02,Negocios03,Negocios04,Negocios05,Negocios06,Negocios07);

            return RedirectToAction("Index02", "Competencia");


        }


    }
}