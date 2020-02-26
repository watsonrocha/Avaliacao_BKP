using Avaliação.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Avaliação.Models
{
    public class AvaliacaoProcessoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o Nome !")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Email !")]
        public string Perfil { get; set; }

        [Required(ErrorMessage = "Preencha a Senha !")]
        public string Senha { get; set; }
        public string Matricula { get; set; }
        public string Cargo { get; set; }
        public string Unidade { get; set; }
        public DateTime Data { get; set; }
        public string NomeGestor { get; set; }
        public string Colaborador { get; set; }
        public int Processos08 { get; set; }
        public int Processos09 { get; set; }
        public int Processos10 { get; set; }
        public int Processos11 { get; set; }
        public int Processos12 { get; set; }
        public int Processos13 { get; set; }
        public int Pessoas14 { get; set; }
        public int Pessoas15 { get; set; }
        public int Pessoas16 { get; set; }
        public int Pessoas17 { get; set; }
        public int Pessoas18 { get; set; }
        public int Pessoas19 { get; set; }
        public int Pessoas20 { get; set; }

        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public AvaliacaoProcessoModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;

        }

        public AvaliacaoProcessoModel()
        {



        }

        public bool ValidaSV()
        {

            string sql = $"SELECT  NOME,MATRICULA,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}' AND PERFIL IN ('5','6')";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {

                    Nome = dt.Rows[0]["Nome"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();


                    return true;

                }


            }

            return false;
        }

        public bool ValidarUser()
        {

            string sql = $"SELECT  NOME,MATRICULA,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}' AND PERFIL= '1'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {

                    Nome = dt.Rows[0]["Nome"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();


                    return true;

                }


            }

            return false;
        }


        public bool ValidarUser1()
        {

            string sql = $"SELECT NOME,MATRICULA,PERFIL FROM USUARIO WHERE  MATRICULA='{Matricula}'  AND PERFIL= '2'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {

                    Nome = dt.Rows[0]["Nome"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();




                    return true;

                }


            }

            return false;
        }


        public bool ValidarUser2()
        {

            string sql = $"SELECT NOME,MATRICULA,PERFIL FROM USUARIO WHERE  MATRICULA='{Matricula}'  AND PERFIL= '3'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {

                    Nome = dt.Rows[0]["Nome"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();




                    return true;

                }


            }

            return false;
        }

        public bool ValidarUser3()
        {

            string sql = $"SELECT NOME,MATRICULA,PERFIL FROM USUARIO WHERE  MATRICULA='{Matricula}'  AND PERFIL= '4'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {

                    Nome = dt.Rows[0]["Nome"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();




                    return true;

                }


            }

            return false;
        }




        public void Questionarios(string Processos08, string Processos09, string Processos10, string Processos11, string Processos12, string Processos13)
        {

            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");

            new DAL().ExecutarComandoSQL($"UPDATE questionario SET Processos08='{Processos08}',Processos09='{Processos09}',Processos10='{Processos10}',Processos11='{Processos11}',Processos12='{Processos12}' ,Processos13='{Processos13}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");



        }

        public void QuestionariGL(string Processos08, string Processos09, string Processos10, string Processos11,  string Processos13)
        {

          //  string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");

            new DAL().ExecutarComandoSQL($"UPDATE questionario SET Processos08='{Processos08}',Processos09='{Processos09}',Processos10='{Processos10}',Processos11='{Processos11}' ,Processos13='{Processos13}' WHERE  Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");



        }

        public void Assistente(string Processos08, string Processos09, string Processos10, string Processos11, string Processos12, string Processos13)
        {

            // string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");

            new DAL().ExecutarComandoSQL($"UPDATE questionario SET Processos08='{Processos08}',Processos09='{Processos09}',Processos10='{Processos10}',Processos11='{Processos11}',Processos12='{Processos12}' ,Processos13='{Processos13}' WHERE  Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");



        }

    }
}