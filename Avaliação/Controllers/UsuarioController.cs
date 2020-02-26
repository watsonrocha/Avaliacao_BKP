using Avaliação.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Avaliação.Controllers
{
    public class UsuarioController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        public UsuarioController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        [HttpPost]
        public IActionResult Cadastro(UsuarioModel formulario,string txtmatricula)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Update(txtmatricula);
                return RedirectToAction("Cadastro","Usuario");
            }

            return View();
        }
        [HttpGet]
        public IActionResult NovoCadastro()
        {                      
           return View();
        }
        [HttpPost]
        public IActionResult NovoCadastro(UsuarioModel formulario, string txtmatricula, string txtCPF, string txtNome, string txtCargo, string txtUnidade, string txtGestor, string txtPerfil, string txtSenha)
        {
            formulario.InsertNovoUser(txtmatricula, txtCPF, txtNome, txtCargo, txtUnidade, txtGestor, txtPerfil, txtSenha);
            TempData["MensagemLoginInvalido"] = "Usuário Cadastrado com Sucesso !! ";
            return View();
        }

        [HttpGet]
        public IActionResult Cadastro(int? id, int? Matricula)
        {
            UsuarioModel objEditar = new UsuarioModel(HttpContextAccessor);
            ViewBag.Registro = objEditar.CarregarRegistroEditar(Matricula);
            ViewBag.Unidades = objEditar.CarregarUnidade();

            if (id != null)
            {
                UsuarioModel objPlanoContas = new UsuarioModel(HttpContextAccessor);
                ViewBag.Registro = objPlanoContas.CarregarRegistro(id);
                ViewBag.Unidades = objPlanoContas.CarregarUnidade();
            }
         
            return View();
        }

        [HttpGet]
        public IActionResult Login(int? id)
        {
            if (id != null)
            {
                if (id == 0)
                {

                    HttpContext.Session.SetString("IdUsuarioLogado", string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioLogado", string.Empty);
                    HttpContext.Session.SetString("NomeUsuarioMatricula", string.Empty);
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
        public IActionResult ValidarLogin(UsuarioModel usuario)
        {
            bool login = usuario.ValidarLogin();
            bool loginSV = usuario.ValidarSV();
            bool log = usuario.ValidarUser();
            bool loger = usuario.ValidarGestor();
            bool logers = usuario.ValidarRH();
            bool logerAssist = usuario.ValidarAssist();

            if (logers)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", usuario.Matricula);
                HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("NomeUsuarioGestor", usuario.Gestor);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.Id.ToString());
                return RedirectToAction("Index", "RecursosHumanos");
            }
           else if (loginSV)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", usuario.Matricula);
                HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("NomeUsuarioGestor", usuario.Gestor);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.Id.ToString());
                return RedirectToAction("Index", "Competencia");
            }

            else if (login)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", usuario.Matricula);
                HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("NomeUsuarioGestor", usuario.Gestor);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.Id.ToString());
                return RedirectToAction("Index", "Competencia");
            }


            else if (log)

            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", usuario.Matricula);
                HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("NomeUsuarioGestor", usuario.Gestor);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.Id.ToString());
                return RedirectToAction("Index", "Competencia");
            }

            else if (loger)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", usuario.Matricula);
                HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("NomeUsuarioGestor", usuario.Gestor);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.Id.ToString());
                return RedirectToAction("Index", "Competencia");
            }

            else if (logerAssist)
            {
                HttpContext.Session.SetString("NomeUsuarioLogado", usuario.Nome);
                HttpContext.Session.SetString("NomeUsuarioMatricula", usuario.Matricula);
                HttpContext.Session.SetString("NomeUsuarioGestor", usuario.Gestor);
                //   HttpContext.Session.SetString("NomeUsuarioCargo", usuario.Cargo);
                //   HttpContext.Session.SetString("NomeUsuarioUnidade", usuario.Unidade);
                HttpContext.Session.SetString("IdUsuarioLogado", usuario.Id.ToString());
                return RedirectToAction("Index_Assist", "Competencia");
            }
         
            else
            {
                TempData["MensagemLoginInvalido"] = "Dados de Login Invalido";
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public IActionResult Registrar(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                //Registrar o usuário
                usuario.RegistrarUsuario();
                return RedirectToAction("Sucesso");
            }
            return View();
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

        [HttpGet]
        public IActionResult AlterarSenha()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateSenhaUpdate(string TextSenha)
        {
            UsuarioModel objConta = new UsuarioModel(HttpContextAccessor);
            objConta.UpdateSenha(TextSenha);
            return RedirectToAction("Login", "Usuario");
        }

        [HttpPost]
        public IActionResult UpdateEditar(string txtmatricula, string txtCPF, string txtNome, string txtCargo, string txtUnidade, string txtGestor, string txtNivel, string txtCategoria)
        {
            UsuarioModel objConta = new UsuarioModel(HttpContextAccessor);
            objConta.UpdateEditar(txtmatricula, txtCPF,txtNome, txtCargo, txtUnidade, txtGestor, txtCategoria, txtNivel);
            TempData["MensagemLoginInvalido"] = "Registro Atualizado com Sucesso !!";
            return RedirectToAction("Cadastro", "Usuario");
        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            UsuarioModel objTransacao = new UsuarioModel(HttpContextAccessor);
            objTransacao.Excluir(id);
            return View();
        }

    }

}