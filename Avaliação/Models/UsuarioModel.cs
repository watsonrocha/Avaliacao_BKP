using Avaliação.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Avaliação.Models
{
    public class UsuarioModel
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o Nome !")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Email !")]
        public string Perfil { get; set; }
        public string Perfil2 { get; set; }

        [Required(ErrorMessage = "Preencha a Senha !")]
        public string Senha { get; set; }
        public string Matricula { get; set; }
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public string Categoria { get; set; }
        public string Nivel { get; set; }
        public string Unidade { get; set; }
        public string EmailGestor { get; set; }
        public string Gestor { get; set; }
        public string EmailRh { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public UsuarioModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;

        }

        public UsuarioModel()
        {

        }

        public UsuarioModel CarregarRegistroEditar(int? Matricula)
        {
            UsuarioModel item = new UsuarioModel();
            string sql = $"SELECT ID,MATRICULA FROM USUARIO WHERE  Matricula = '{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            return item;
        }

       
        public UsuarioModel CarregarUnidade()
        {
            UsuarioModel item = new UsuarioModel();
            string sql = $"SELECT unidade FROM USUARIO GROUP BY unidade";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            item.Unidade = dt.Rows[0]["unidade"].ToString();

            return item;
        }
    
        public UsuarioModel CarregarRegistro(int? Matricula)
        {
            UsuarioModel item = new UsuarioModel();
            string sql = $"SELECT ID, MATRICULA, CPF, NOME, CARGO, CATEGORIA, NIVEL, UNIDADE, GESTOR, PERFIL, SENHA FROM USUARIO WHERE MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            item.Id = int.Parse(dt.Rows[0]["ID"].ToString());
            item.Matricula = dt.Rows[0]["MATRICULA"].ToString();
            item.CPF = dt.Rows[0]["CPF"].ToString();
            item.Nome = dt.Rows[0]["NOME"].ToString();
            item.Cargo = dt.Rows[0]["CARGO"].ToString();
            item.Categoria= dt.Rows[0]["CATEGORIA"].ToString();
            item.Nivel = dt.Rows[0]["NIVEL"].ToString();
            item.Unidade = dt.Rows[0]["UNIDADE"].ToString();
            item.Gestor = dt.Rows[0]["GESTOR"].ToString();
            item.Perfil = dt.Rows[0]["PERFIL"].ToString();
            item.Senha = dt.Rows[0]["SENHA"].ToString();

            return item;
        }
        public void InsertNovoUser(string txtmatricula, string txtCPF, string txtNome, string txtCargo, string txtUnidade, string txtGestor, string txtPerfil, string txtSenha)
        {
            string sql = $"INSERT INTO USUARIO (MATRICULA, CPF, NOME, CARGO, UNIDADE,GESTOR, PERFIL, SENHA) VALUES('{txtmatricula}','{txtCPF}','{txtNome}','{txtCargo}','{txtUnidade}','{txtGestor}','{txtPerfil}','{txtSenha}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);           
        }

        public void Update(string txtmatricula)
        {
            string  sql = $"UPDATE USUARIO SET  CPF='{CPF}', NOME='{Nome}', CARGO='{Cargo}', UNIDADE='{Unidade}', GESTOR='{Gestor}',PERFIL='{Perfil}',SENHA='{Senha}' WHERE  MATRICULA='{txtmatricula}'";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }

        //=== TIPO DE PERFIL==//
        //   Gerente/Supervisor - perfil -> 1
        //   Analista/Especialista - perfil -> 2
        //   Lider- perfil -> 3
        //   Assistente Perfil -> 4
        //   RH Perfil -> 5

        public bool ValidarLogin()
        {
            string sql = $"SELECT NOME,PERFIL,MATRICULA,GESTOR,CPF,CARGO,UNIDADE FROM USUARIO WHERE CPF='{CPF}' AND SENHA='{Senha}' AND PERFIL= '1'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    CPF = dt.Rows[0]["CPF"].ToString();
                    Cargo = dt.Rows[0]["Cargo"].ToString();
                    Unidade = dt.Rows[0]["Unidade"].ToString();
                    Gestor = dt.Rows[0]["Gestor"].ToString();

                    return true;

                }

            }

            return false;
        }
      
        public bool ValidarSV()
        {
            string sql = $"SELECT NOME,PERFIL,MATRICULA,GESTOR,CPF,CARGO,UNIDADE FROM USUARIO WHERE CPF='{CPF}' AND SENHA='{Senha}' AND PERFIL= '5'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    CPF = dt.Rows[0]["CPF"].ToString();
                    Cargo = dt.Rows[0]["Cargo"].ToString();
                    Unidade = dt.Rows[0]["Unidade"].ToString();
                    Gestor = dt.Rows[0]["Gestor"].ToString();

                    return true;

                }


            }

            return false;
        }


        public bool ValidarUser()
        {

            string sql = $"SELECT NOME,PERFIL,MATRICULA,GESTOR,CPF,CARGO,UNIDADE FROM USUARIO WHERE CPF='{CPF}' AND SENHA='{Senha}' AND PERFIL= '2'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {

                    Nome = dt.Rows[0]["Nome"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    CPF = dt.Rows[0]["CPF"].ToString();
                    Cargo = dt.Rows[0]["Cargo"].ToString();
                    Unidade = dt.Rows[0]["Unidade"].ToString();
                    Gestor = dt.Rows[0]["Gestor"].ToString();

                    return true;

                }
            }

            return false;
        }

        public bool ValidarGestor()
        {
            string sql = $"SELECT NOME,PERFIL,MATRICULA,GESTOR,CPF,CARGO,UNIDADE FROM USUARIO WHERE CPF='{CPF}' AND SENHA='{Senha}' AND PERFIL= '3'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    CPF = dt.Rows[0]["CPF"].ToString();
                    Cargo = dt.Rows[0]["Cargo"].ToString();
                    Unidade = dt.Rows[0]["Unidade"].ToString();
                    Gestor = dt.Rows[0]["Gestor"].ToString();

                    return true;

                }

            }

            return false;
        }


        public bool ValidarAssist()
        {
            string sql = $"SELECT NOME,PERFIL,MATRICULA,GESTOR,CPF,CARGO,UNIDADE FROM USUARIO WHERE CPF='{CPF}' AND SENHA='{Senha}' AND PERFIL= '4'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    CPF = dt.Rows[0]["CPF"].ToString();
                    Cargo = dt.Rows[0]["Cargo"].ToString();
                    Unidade = dt.Rows[0]["Unidade"].ToString();
                    Gestor = dt.Rows[0]["Gestor"].ToString();

                    return true;

                }

            }

            return false;
        }


        public bool ValidarRH()
        {
            string sql = $"SELECT NOME,PERFIL2,MATRICULA,GESTOR,CPF,CARGO,UNIDADE FROM USUARIO WHERE CPF='{CPF}' AND SENHA='{Senha}' AND PERFIL2= '{Perfil2}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Perfil2 = dt.Rows[0]["Perfil2"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    CPF = dt.Rows[0]["CPF"].ToString();
                    Cargo = dt.Rows[0]["Cargo"].ToString();
                    Unidade = dt.Rows[0]["Unidade"].ToString();
                    Gestor = dt.Rows[0]["Gestor"].ToString();

                    return true;
                }

            }

            return false;
        }

       
        public void RegistrarUsuario()
        {
            string sql = $"INSERT INTO LOGIN (NOME, PERFIL, SENHA) VALUES('{Nome}','{Perfil}','{Senha}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }
        public void UpdateSenha(string TextSenha)
        {
            string Nome = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            new DAL().ExecutarComandoSQL($"UPDATE usuario SET Senha = '{TextSenha}' WHERE  nome= '{Nome}' ");
        }

        public void UpdateEditar(string txtmatricula,string txtCPF, string txtNome, string txtCargo, string txtCategoria, string txtNivel, string txtUnidade, string txtGestor)
        {           
            new DAL().ExecutarComandoSQL($"UPDATE USUARIO SET  CPF='{txtCPF}', NOME='{txtNome}', CARGO='{txtCargo}', CATEGORIA='{txtCategoria}' NIVEL='{txtNivel}',UNIDADE='{txtUnidade}', GESTOR='{txtGestor}' WHERE  MATRICULA='{txtmatricula}' ");
        }
        public void Excluir(int? id)
        {          
            new DAL().ExecutarComandoSQL("DELETE FROM USUARIO WHERE ID = " + id);
        }
    }
}
