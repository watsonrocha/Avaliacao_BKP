using Avaliação.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avaliação.Controllers
{
    public class AvaliacaoPessoasController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        public AvaliacaoPessoasController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        [HttpGet]
        public IActionResult Index(int? id, int? Matricula)
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
                  
                    AvaliacaoPessoasModel objPlanoContas = new AvaliacaoPessoasModel(HttpContextAccessor);
                    ViewBag.Registro = objPlanoContas.CarregarRegistro(Matricula);
                    
                }
            }

            if (id != null)
            {
                AvaliacaoPessoasModel objPlanoContas = new AvaliacaoPessoasModel();
                 ViewBag.Registro = objPlanoContas.CarregarRegistro(id);
            }
            return View();
        }

        [HttpPost]
        public IActionResult ValidarUser(AvaliacaoPessoasModel menu, string TxtGestor, string TextGestor)
        {
            bool login = menu.ValidarUser(TxtGestor);
            bool LogMatricula = menu.ValidarMatricula(TxtGestor);
            bool log = menu.ValidarUser1(TxtGestor);
            bool loger = menu.ValidarUser2();
            bool logers = menu.ValidarUser3(TxtGestor);
            bool LogerGestor = menu.ValidarGestor(TextGestor);
            bool LogDiretorGesto = menu.ValidarDiretorGestor(TxtGestor);

            if (LogMatricula == true)
            {
                TempData["MensagemLoginInvalido"] = "Colaborador já Avaliado !";
                return RedirectToAction("Index", "AvaliacaoPessoas");
            }

            if (login)
            {
                menu.Insert(TxtGestor);

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                // HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("AvaliarPessoasGestor", "AvaliacaoPessoas");
            }
            if (LogerGestor)
            {
                menu.InsertGestor(TextGestor);

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                // HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("AvaliarPessoasGestor", "AvaliacaoPessoas");
            }
            if (LogDiretorGesto)
            {
                menu.InsertGestor(TxtGestor);

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                // HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("AvaliarPessoasGestor", "AvaliacaoPessoas");
            }

            if (log)

            {
                menu.Insert(TxtGestor);

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //  HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("AvaliarPessoasEspec", "AvaliacaoPessoas");
            }

            if (loger)
            {
                menu.Insert(TxtGestor);

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                //  HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //  HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("AvaliarPessoasGlTl", "AvaliacaoPessoas");
            }
            if (logers)
            {
                menu.Insert(TxtGestor);

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                //  HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //  HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("AvaliarPessoasAssist", "AvaliacaoPessoas");
            }

            else
            {
                TempData["MensagemLoginInvalido"] = "Colaborador não Cadastrado !";
                return RedirectToAction("Index", "AvaliacaoPessoas");
            }
        }

        [HttpPost]
        public IActionResult UpdateSenhaUpdate(string Pessoas14, string Pessoas15, string Pessoas16, string Pessoas17, string Pessoas18, string Pessoas19, string Pessoas20)
        {
            AvaliacaoPessoasModel objConta = new AvaliacaoPessoasModel(HttpContextAccessor);
            objConta.QuestionariosColaborador();
            objConta.Assistente(Pessoas14, Pessoas15, Pessoas16, Pessoas17, Pessoas18, Pessoas19, Pessoas20);
            objConta.Questionarios(Pessoas14, Pessoas15, Pessoas16, Pessoas17, Pessoas18, Pessoas19, Pessoas20);
            return RedirectToAction("Index", "AvaliacaoProcessos");
        }

        [HttpPost]
        public IActionResult ValidarAssist(AvaliacaoPessoasModel menu, string TxtGestor)
        {

            bool logers = menu.ValidarOP();
            bool LogMatricula = menu.ValidarMatricula(TxtGestor);

            if (LogMatricula == true)
            {
                TempData["MensagemLoginInvalido"] = "Colaborador já Avaliado !";
                return RedirectToAction("Index", "AvaliacaoPessoas");
            }
            if (logers)
            {
                menu.InsertAssist(TxtGestor);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);

                return RedirectToAction("AvaliarPessoasAssist", "AvaliacaoPessoas");
            }
            else
            {
                TempData["MensagemLoginInvalido"] = "Colaborador não Cadastrado";
                return RedirectToAction("Index_Assist", "AvaliacaoPessoas");
            }
        }

        [HttpPost]
        public IActionResult ValidarGestor(AvaliacaoPessoasModel menu, string TxtGestor, string TextGestor)
        {

            bool log = menu.ValidarUserGestor1();
            bool logSV = menu.ValidarSV();
            bool LogerGestor = menu.ValidarGestor(TxtGestor);
            bool LogLider = menu.ValidarUserLider();
            bool LogMatricula = menu.ValidarMatriculaGestor(TxtGestor);
            bool LogGl = menu.ValidarUser2();

            if (LogMatricula == true)
            {
                TempData["MensagemLoginInvalido"] = "Colaborador já Avaliado !";
                return RedirectToAction("Index", "AvaliacaoPessoas");
            }
            if (LogGl)

            {
                menu.InsertGestor1(TxtGestor);

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //  HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("AvaliarPessoasGLTL", "AvaliacaoPessoas");
            }
            if (log)

            {
                menu.InsertGestor1(TxtGestor);

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //  HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("AvaliarPessoasEspec", "AvaliacaoPessoas");
            }
            if (LogerGestor)
            {
                menu.InsertGestor1(TextGestor);

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                // HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("AvaliarPessoasGestor", "AvaliacaoPessoas");
            }
            if (logSV)
            {
                menu.InsertGestor1(TxtGestor);

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                // HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("AvaliarPessoasGestor", "AvaliacaoPessoas");
            }
            if (LogLider)
            {
                menu.InsertGestor1(TxtGestor);

                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                // HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                // HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("AvaliarPessoasGestor", "AvaliacaoPessoas");
            }

            else
            {
                TempData["MensagemLoginInvalido"] = "Colaborador não Cadastrado";
                return RedirectToAction("IndexGestor", "AvaliacaoPessoas");
            }
        }

        [HttpGet]
        public IActionResult AvaliarPessoasAssist()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AvaliarPessoasGestor()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AvaliarPessoasEspec()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AvaliarPessoasGlTl()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index_Assist()
        {
            return View();
        }
        public IActionResult IndexGestor()
        {
            return View();
        }
        public IActionResult ListaColaborador(int? id)
        {
            AvaliacaoPessoasModel obj = new AvaliacaoPessoasModel(HttpContextAccessor);
            ViewBag.ListaColaborador = obj.ListaColaborador();
            ViewBag.ListaMatricula = obj.ListaMatricula();
          
            return View();
        }

        public IActionResult Sucesso()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AvaliacaoPessoasModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                ViewBag.Registro = formulario.Matricula;
                return RedirectToAction("Index");
            }

            return View();
        }
       
    }
}