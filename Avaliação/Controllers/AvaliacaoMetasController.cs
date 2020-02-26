using Avaliação.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avaliação.Controllers
{
    public class AvaliacaoMetasController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        public AvaliacaoMetasController(IHttpContextAccessor httpContextAccessor)
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
        public IActionResult ValidarUser(AvaliacaoMetasModel menu, string txtNomeGest, string txtmatricula)
        {
            bool login = menu.ValidarUser();
            bool log = menu.ValidarUser1();
            bool loger = menu.ValidarUser2();
            bool logers = menu.ValidarUser3();
            bool logeSV = menu.ValidaSV();
            bool logeRH = menu.ValidaRH();
            bool matricula = menu.ValidaPessoasCargo(txtNomeGest, txtmatricula);
            bool Metasmatricula = menu.ValidarMetasMatricula(txtNomeGest, txtmatricula);

            if (Metasmatricula == true)
            {
                TempData["MensagemLoginInvalido"] = "Colaborador já Avaliado !";
                return RedirectToAction("Index", "AvaliacaoMetas");
            }
            if (matricula != logeRH)
            {
                menu.Insert(txtNomeGest);          
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("Metas", "AvaliacaoMetas");
            }
            if (matricula != logeSV)
            {
                menu.Insert(txtNomeGest);        
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("Metas", "AvaliacaoMetas");
            }
            if (matricula != login)
            {
                menu.Insert(txtNomeGest);            
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("Metas", "AvaliacaoMetas");
            }
            if (matricula != log)
            {
                menu.Insert(txtNomeGest);           
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("Metas", "AvaliacaoMetas");
            }
            if (matricula != loger)
            {
                menu.Insert(txtNomeGest);             
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("Metas", "AvaliacaoMetas");
            }
            if (matricula != logers)
            {
                menu.Insert(txtNomeGest);         
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());
                return RedirectToAction("Metas", "AvaliacaoMetas");
            }
            else
            {
                TempData["MensagemLoginInvalido"] = "Favor Avaliar a Competência !";
                return RedirectToAction("Index", "AvaliacaoMetas");
            }
        }
     
        public IActionResult UpdateRH(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6,  string text1, string text2, string text3, string text4, string text5, string text6)
        {
            AvaliacaoMetasModel objConta = new AvaliacaoMetasModel(HttpContextAccessor);
            objConta.Metas(Checkbox1, Checkbox2, Checkbox3, Checkbox4, Checkbox5, Checkbox6, text1, text2, text3, text4, text5, text6);
            return RedirectToAction("Index", "Competencia");
        }
      
        public IActionResult Index()
        {         
            return View();
        }
       
        public IActionResult Metas()
        {
            return View();
        }
      
        public IActionResult finalizado()
        {
            return View();
        }
    }
}