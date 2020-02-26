using Avaliação.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Avaliação.Controllers
{
    public class AvaliacaoCargoController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        public AvaliacaoCargoController(IHttpContextAccessor httpContextAccessor)
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
        public IActionResult ValidarUser(AvaliacaoCargoModel menu, string txtNomeGest, string txtmatricula)
        {
            bool matricula = menu.ValidaPessoasCargo(txtNomeGest, txtmatricula);
            bool CargoJunior = menu.ValidarCargoJunior(txtNomeGest, txtmatricula);
            bool CargoPleno = menu.ValidarCargoPleno(txtNomeGest, txtmatricula);
            bool CargoSenior = menu.ValidarCargoSenior(txtNomeGest, txtmatricula);
            bool logerSvJunior = menu.ValidarSupervisor_junior();
            bool logerSvPleno = menu.ValidarSupervisor_Pleno();
            bool logerSvSenior = menu.ValidarSupervisor_Senior();
            bool logerCoordJunior = menu.ValidarCoordenador_junior();
            bool logerCoordPleno = menu.ValidarCoordenador_Pleno();
            bool logerCoordSenior = menu.ValidarCoordenador_Senior();
            bool logerAnalistJunior = menu.ValidarAnalista_junior();
            bool logerAnalistPleno = menu.ValidarAnalista_Pleno();
            bool logerAnalistSenior = menu.ValidarAnalista_Senior();
            bool logerEncarregadoJunior = menu.ValidarEncarregado_Junior();
            bool logerEncarregadoPleno = menu.ValidarEncarregado_Pleno();
            bool logerEncarregadoSenior = menu.ValidarEncarregado_Senior();
            bool logerEspecialista = menu.ValidarEspecialista();
            bool logerTecnico = menu.ValidarTecnico();
            bool logerLider = menu.ValidarLider();
            bool logerGerente = menu.ValidarGerente();

            if (matricula == false)
            {
                TempData["MensagemLoginInvalido"] = "Favor Avaliar a Competência !";
                return RedirectToAction("Login", "AvaliacaoCargo");
            }
            if (CargoJunior == true)
            {
                TempData["MensagemLoginInvalido"] = "Colaborador já Avaliado !";
                return RedirectToAction("Login", "AvaliacaoCargo");
            }
            if (CargoPleno == true)
            {
                TempData["MensagemLoginInvalido"] = "Colaborador já Avaliado !";
                return RedirectToAction("Login", "AvaliacaoCargo");
            }
            if (CargoSenior == true)
            {
                TempData["MensagemLoginInvalido"] = "Colaborador já Avaliado !";
                return RedirectToAction("Login", "AvaliacaoCargo");
            }

            if (logerSvJunior)
            {
                menu.InsertSvJunior(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Supervisor_Junior", "AvaliacaoCargo");
            }
            if (logerSvPleno)
            {
                menu.InsertSvPleno(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Supervisor_Pleno", "AvaliacaoCargo");
            }
            if (logerSvSenior)
            {
                menu.InsertSvSenior(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Supervisor_Senior", "AvaliacaoCargo");
            }
            if (logerCoordJunior)
            {
                menu.InsertSvJunior(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Coordenador_Junior", "AvaliacaoCargo");
            }
            if (logerCoordPleno)
            {
                menu.InsertSvPleno(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Coordenador_Pleno", "AvaliacaoCargo");
            }
            if (logerCoordSenior)
            {
                menu.InsertSvSenior(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Coordenador_Senior", "AvaliacaoCargo");
            }
            if (logerAnalistJunior)
            {
                menu.InsertSvJunior(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Analista_Junior", "AvaliacaoCargo");
            }
            if (logerAnalistPleno)
            {
                menu.InsertSvPleno(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Analista_Pleno", "AvaliacaoCargo");
            }
            if (logerAnalistSenior)
            {
                menu.InsertSvSenior(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Analista_Senior", "AvaliacaoCargo");
            }
            if (logerEncarregadoJunior)
            {
                menu.InsertSvJunior(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Encarregado_Junior", "AvaliacaoCargo");
            }
            if (logerEncarregadoPleno)
            {
                menu.InsertSvPleno(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Encarregado_Pleno", "AvaliacaoCargo");
            }
            if (logerEncarregadoSenior)
            {
                menu.InsertSvSenior(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Encarregado_Senior", "AvaliacaoCargo");
            }
            if (logerEspecialista)
            {
                menu.InsertSvJunior(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Especialista", "AvaliacaoCargo");
            }
            if (logerTecnico)
            {
                menu.InsertSvJunior(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Tecnico", "AvaliacaoCargo");
            }
            if (logerLider)
            {
                menu.InsertSvJunior(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Lider", "AvaliacaoCargo");
            }
            if (logerGerente)
            {
                menu.InsertSvSenior(txtNomeGest);
                HttpContext.Session.SetString("NomeUsuarioColaborador", menu.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                HttpContext.Session.SetString("IdUsuarioLogado", menu.Id.ToString());

                return RedirectToAction("Supervisor_Senior", "AvaliacaoCargo");
            }
            else
            {
                TempData["MensagemLoginInvalido"] = "Colaborador não Cadastrado !";
                return RedirectToAction("Login", "AvaliacaoCargo");
            }
        }


        [HttpPost]
        public IActionResult UpdateSupervJunior(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Supervisor_Junior(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }
        [HttpPost]
        public IActionResult UpdateSupervPleno(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Supervisor_Pleno(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }
        [HttpPost]
        public IActionResult UpdateSupervSenior(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9, string checkbox10, string checkbox11, string checkbox12, string checkbox13, string checkbox14, string checkbox15, string checkbox16, string checkbox17, string checkbox18)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Supervisor_Senior(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }
        [HttpPost]
        public IActionResult UpdateCoordJunior(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Coordenador_Junior(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }
        [HttpPost]
        public IActionResult UpdateCoordPleno(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Coordenador_Pleno(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }
        [HttpPost]
        public IActionResult UpdateCoordSenior(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Coordenador_Senior(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }
        [HttpPost]
        public IActionResult UpdateAnalistaJunior(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Analista_Junior(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }
        [HttpPost]
        public IActionResult UpdateAnalistaPleno(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Analista_Pleno(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }
        [HttpPost]
        public IActionResult UpdateAnalistaSenior(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Analista_Senior(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }
        [HttpPost]
        public IActionResult UpdateEncarregadoJunior(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Encarregado_Junior(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }
        [HttpPost]
        public IActionResult UpdateEncarregadoPleno(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Encarregado_Pleno(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }
        [HttpPost]
        public IActionResult UpdateEncarregadoSenior(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Encarregado_Senior(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }
        [HttpPost]
        public IActionResult UpdateEspecialista(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Especialista(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }

        [HttpPost]
        public IActionResult UpdateTecnico(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Tecnico(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }

        [HttpPost]
        public IActionResult UpdateLider(string Checkbox1, string Checkbox2, string checkbox3, string checkbox4, string checkbox5, string checkbox6, string checkbox7, string checkbox8, string checkbox9)
        {
            AvaliacaoCargoModel objConta = new AvaliacaoCargoModel(HttpContextAccessor);
            objConta.Lider(Checkbox1, Checkbox2, checkbox3, checkbox4, checkbox5, checkbox6, checkbox7, checkbox8, checkbox9);
            return RedirectToAction("Index03", "Competencia");
        }



        [HttpGet]
        public IActionResult Supervisor_Junior()
        {
            return View();
        }
        public IActionResult Supervisor_Pleno()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Supervisor_Senior()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Coordenador_Junior()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Coordenador_Pleno()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Coordenador_Senior()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Analista_Junior()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Analista_Pleno()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Analista_Senior()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Encarregado_Junior()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Encarregado_Pleno()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Encarregado_Senior()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Especialista()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Tecnico()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Lider()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}