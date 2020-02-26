using Avaliação.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avaliação.Controllers
{
    public class MenuIniController : Controller
    {

        IHttpContextAccessor HttpContextAccessor;
        public MenuIniController(IHttpContextAccessor httpContextAccessor)
        {

            HttpContextAccessor = httpContextAccessor;



        }
        [HttpGet]
        public IActionResult Index(int? id)
        {



            if (id != null)
            {
                if (id == 0)
                {
                    HttpContext.Session.SetString("IdUsuarioLogado", string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioColaborador", string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioSetor", string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioTurno", string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioGestor", string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioEmail", string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioEmailGestor", string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioEmailRh", string.Empty);


                }
            }

            return View();
        }

        [HttpPost]
        public IActionResult ValidarUser(MenuIniModel menu)
        {
            bool login = menu.ValidarUser();
            bool log = menu.ValidarUser1();
            bool loger = menu.ValidarUser2();
            bool logers = menu.ValidarUser3();
            bool logSV = menu.ValidarSV();

            if (login)
            {

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                // HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("NegociosGestor", "Competencia");
            }


            if (log)

            {

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //  HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("NegociosEspec", "Competencia");
            }

            if (loger)
            {

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                //  HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //  HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("NegociosGLTL", "Competencia");
            }
            if (logers)
            {

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                //  HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //  HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("NegociosAssist", "Competencia");
            }
            if (logSV)
            {

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                //  HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //  HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("NegociosGestor", "Competencia");
            }
            else
            {
                TempData["MensagemLoginInvalido"] = "Colaborador não Cadastrado";
                return RedirectToAction("Index", "Menuini");
            }
        }


        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        public IActionResult Sucesso()
        {
            return View();
        }

    }
}