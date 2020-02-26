using Avaliação.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Avaliação.Controllers
{
    public class AvaliacaoProcessosController : Controller
    {

        IHttpContextAccessor HttpContextAccessor;
        public AvaliacaoProcessosController(IHttpContextAccessor httpContextAccessor)
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
        public IActionResult ValidarUser(AvaliacaoProcessoModel menu)
        {
            bool login = menu.ValidarUser();
            bool log = menu.ValidarUser1();
            bool loger = menu.ValidarUser2();
            bool logers = menu.ValidarUser3();
            bool LogSV = menu.ValidaSV();
            if (LogSV)
            {

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                // HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("AvaliarProcessoGestor", "AvaliacaoProcessos");
            }

            if (login)
            {

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                // HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("AvaliarProcessoGestor", "AvaliacaoProcessos");
            }


            if (log)

            {

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //  HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("AvaliarProcessoEspec", "AvaliacaoProcessos");
            }

            if (loger)
            {

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                //  HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //  HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("AvaliarProcessoGlTl",  "AvaliacaoProcessos");
            }

            if (logers)
            {

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                //  HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //  HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("AvaliarProcessoAssist", "AvaliacaoProcessos");
            }
            else
            {
                TempData["MensagemLoginInvalido"] = "Colaborador não Cadastrado";
                return RedirectToAction("Index", "AvaliacaoProcessos");
            }
        }
        [HttpPost]
        public IActionResult UpdateSenhaUpdate(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox13, string Processos08, string Processos09, string Processos10, string Processos11, string Processos12, string Processos13)
        {
            AvaliacaoProcessoModel objConta = new AvaliacaoProcessoModel(HttpContextAccessor);
            objConta.Questionarios(Processos08,Processos09,Processos10,Processos11,Processos12,Processos13);
            objConta.QuestionariGL(Processos08,Processos09,Processos10,Processos11,Processos13);
            objConta.Assistente(Processos08,Processos09,Processos10,Processos11,Processos12,Processos13);
            return RedirectToAction("Index", "MenuIni");
        }


        [HttpGet]
        public IActionResult AvaliarProcessoAssist()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AvaliarProcessoGestor()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AvaliarProcessoEspec()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AvaliarProcessoGlTl()
        {
            return View();
        }

        public IActionResult Sucesso()
        {
            return View();
        }
    }
}