using Avaliação.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using static Avaliação.Models.RecursosHumanosModel;

namespace Avaliação.Controllers
{
    public class RecursosHumanosController : Controller
    {

        IHttpContextAccessor HttpContextAccessor;
        public RecursosHumanosController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        public IActionResult IndexCadastro()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexRelatorio()
        {
            return View();
        }
        public IActionResult RelatorioCargos()
        {
            RecursosHumanosModel obj = new RecursosHumanosModel();
            ViewBag.ListaCargo = obj.ListaCargo();
            return View();
        }
        public IActionResult RelatorioMetas()
        {
            RecursosHumanosModel obj = new RecursosHumanosModel();
            ViewBag.ListaMetas = obj.ListaMetas();
            return View();
        }
        public IActionResult LoginRadar()
        {
            return View();
        }
        public IActionResult RelatorioUsuario()
        {
            RecursosHumanosModel obj = new RecursosHumanosModel();
            ViewBag.listaUsuario = obj.ListaUsuario();
            return View();
        }
        public IActionResult Radar()
        {
            RecursosHumanosModel obj = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.RadarSV = obj.RadarSV();
            return View();
        }
        public IActionResult RadarOper()
        {
            RecursosHumanosModel obj = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.RadarOper = obj.RadarOper();
            return View();
        }
        public IActionResult RadarAnalista()
        {
            RecursosHumanosModel obj = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.RadarAnalista = obj.RadarAnalista();
            return View();
        }
        public IActionResult RadarGL()
        {
            RecursosHumanosModel obj = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.RadarGL = obj.RadarGL();
            return View();
        }
        public IActionResult Relatorio()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.ListaCadastro = objConta.ListaCadastro();
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult RelatorioBox()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel();
            ViewBag.ListaNineBox = objConta.ListaNineBox();
            return View();
        }
        public IActionResult nineboxOper()
        {
            return View();
        }
        public IActionResult nineboxEspec()
        {
            RecursosHumanosModel obj = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.NineEspec = obj.NineEspec();
            return View();
        }
        public IActionResult NineboxSv()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.NineSvJunior = objConta.NineSvJunior();
            return View();
        }
        public IActionResult nineboxSvPleno()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.NineSvPleno = objConta.NineSvPleno();
            return View();
        }
        public IActionResult nineboxSvSenior()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.NineSvSenior = objConta.NineSvSenior();
            return View();
        }
        public IActionResult nineboxCoordJunior()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.NineCoordJunior = objConta.NineCoordJunior();
            return View();
        }
        public IActionResult nineboxCoordPleno()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.NineCoordPleno = objConta.NineCoordPleno();
            return View();
        }
        public IActionResult nineboxCoordSenior()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.NineCoordSenior = objConta.NineCoordSenior();
            return View();
        }
        public IActionResult nineboxAnalistaJunior()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.nineboxAnalistaJunior = objConta.NineAnalistaJunior();
            return View();
        }
        public IActionResult nineboxAnalistaPleno()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.nineboxAnalistaPleno = objConta.NineAnalistaPleno();
            return View();
        }
        public IActionResult nineboxAnalistaSenior()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.nineboxAnalistaSenior = objConta.NineAnalistaSenior();
            return View();
        }
        public IActionResult nineboxGLJunior()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.nineboxGLJunior = objConta.NineEncarregadoJunior();
            return View();
        }
        public IActionResult nineboxGLPleno()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.nineboxGLPleno = objConta.NineEncarregadoPleno();
            return View();
        }
        public IActionResult nineboxGLSenior()
        {
            RecursosHumanosModel objConta = new RecursosHumanosModel(HttpContextAccessor);
            ViewBag.nineboxGLSenior = objConta.NineEncarregadoSenior();
            return View();
        }
        public IActionResult nineboxGer()
        {
            return View();
        }
        public IActionResult LoginNineBox()
        {
            return View();
        }

        // Validação e redirecionamento para a ViewNineBox
        public IActionResult ValidarNine(RecursosHumanosModel menu, string txtColaboradorNine)
        {
            bool loginSvJunior = menu.ValidarNIneSvJunior(txtColaboradorNine);
            bool loginSvPleno = menu.ValidarNIneSvPleno(txtColaboradorNine);
            bool loginSvSenior = menu.ValidarNIneSvSenior(txtColaboradorNine);
            bool LoginCoordJunior = menu.ValidarNIneCoordJunior(txtColaboradorNine);
            bool LoginCoordPleno = menu.ValidarNIneCoordPleno(txtColaboradorNine);
            bool LoginCoordSenior = menu.ValidarNIneCoordSenior(txtColaboradorNine);
            bool LoginAnalistaJunior = menu.ValidarNIneBoxAnalistaJunior(txtColaboradorNine);
            bool LoginAnalistaPleno = menu.ValidarNIneBoxAnalistaPleno(txtColaboradorNine);
            bool LoginAnalistaSenior = menu.ValidarNIneBoxAnalistaSenior(txtColaboradorNine);
            bool LoginEncarregadoJunior = menu.ValidarNineEncarregadoJunior(txtColaboradorNine);
            bool LoginEncarregadoPleno = menu.ValidarNIneEncarregadoPleno(txtColaboradorNine);
            bool LoginEncarregadoSenior = menu.ValidarNIneEncarregadoSenior(txtColaboradorNine);
            bool LoginEspec = menu.ValidarNIneBoxEspec(txtColaboradorNine);
            
            if (loginSvJunior)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineBoxSv", "Recursoshumanos");
            }
            if (loginSvPleno)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineBoxSvPleno", "Recursoshumanos");
            }
            if (loginSvSenior)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineBoxSvSenior", "Recursoshumanos");
            }
            if (LoginCoordJunior)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineboxCoordJunior", "Recursoshumanos");
            }
            if (LoginCoordPleno)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineboxCoordPleno", "Recursoshumanos");
            }
            if (LoginCoordSenior)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineboxCoordSenior", "Recursoshumanos");
            }
            if (LoginAnalistaJunior)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineboxAnalistaJunior", "Recursoshumanos");
            }
            if (LoginAnalistaPleno)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineboxAnalistaPleno", "Recursoshumanos");
            }
            if (LoginAnalistaSenior)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineboxAnalistaSenior", "Recursoshumanos");
            }
            if (LoginEncarregadoJunior)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineboxGlJunior", "Recursoshumanos");
            }
            if (LoginEncarregadoPleno)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineboxGlPleno", "Recursoshumanos");
            }
            if (LoginEncarregadoSenior)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineboxGlSenior", "Recursoshumanos");
            }
            if (LoginEspec)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("NineBoxEspec", "Recursoshumanos");
            }
            else
            {
                TempData["MensagemLoginInvalido"] = "Colaborador não Cadastrado";
                return RedirectToAction("LoginNineBox", "Recursoshumanos");
            }

        }

        // Validação e redirecionamento para ViewRadar
        public IActionResult ValidarRadar(RecursosHumanosModel menu, string txtColaboradorRadar)
        {
            bool login = menu.ValidarRadarSv(txtColaboradorRadar);
            bool loginAna = menu.ValidarRadarAnalista(txtColaboradorRadar);
            bool loginGL = menu.ValidarRadarGL(txtColaboradorRadar);
            bool LoginOper = menu.ValidarRadarOper(txtColaboradorRadar);

            if (login)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("Radar", "Recursoshumanos");
            }
            if (loginAna)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("RadarAnalista", "Recursoshumanos");
            }
            if (loginGL)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("RadarGL", "Recursoshumanos");
            }
            if (LoginOper)
            {
                HttpContext.Session.SetString("NomeUsuarioMatricula", menu.Matricula);
                return RedirectToAction("RadarOper", "Recursoshumanos");
            }
            else
            {
                TempData["MensagemLoginInvalido"] = "Colaborador não Cadastrado";
                return RedirectToAction("LoginRadar", "Recursoshumanos");
            }
        }

    }
}
