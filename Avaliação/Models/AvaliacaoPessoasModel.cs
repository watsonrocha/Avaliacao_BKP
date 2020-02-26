using Avaliação.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Avaliação.Models
{
    public class AvaliacaoPessoasModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o Nome !")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Email !")]
        public string Perfil { get; set; }

        [Required(ErrorMessage = "Preencha a Senha !")]
        public string Senha { get; set; }
        public string Matricula { get; set; }
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public string Gestor { get; set; }
        public string Unidade { get; set; }
        public DateTime Data { get; set; }
        public string NomeGestor { get; set; }
        public string Colaborador { get; set; }
        public string Status { get; set; }
        public int Pessoas14 { get; set; }
        public int Pessoas15 { get; set; }
        public int Pessoas16 { get; set; }
        public int Pessoas17 { get; set; }
        public int Pessoas18 { get; set; }
        public int Pessoas19 { get; set; }
        public int Pessoas20 { get; set; }

        public string MatriculaPessoa { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public AvaliacaoPessoasModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public AvaliacaoPessoasModel()
        {

        }

        public void Update(int id, string TxtGestor, string txtMatricula)
        {

            new DAL().ExecutarComandoSQL("SELECT  * FROM questionario WHERE Matricula='{Matricular}' AND NomeGESTOR= '{TxtGestor}'  " + id);

        }
     
        public bool ValidarMatricula(string TxtGestor)
        {
            string sql = $"SELECT  * FROM questionario WHERE Matricula='{Matricula}'AND NomeGESTOR= '{TxtGestor}' ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }

            }

            return false;
        }
        public bool ValidarMatriculaGestor(string TxtGestor)
        {

            string sql = $"SELECT  * FROM questionario WHERE  NomeGESTOR= '{TxtGestor}' ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }

            }

            return false;
        }

        public bool ValidarUser(string TxtGestor)
        {
            // string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"SELECT  GESTOR,NOME,MATRICULA,CPF,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}' AND GESTOR= '{TxtGestor}' AND PERFIL= '1'";
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
                    Gestor = dt.Rows[0]["Gestor"].ToString();

                    return true;

                }
            }

            return false;
        }
        public bool ValidarGestor(string TextGestor)
        {
            // string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"SELECT  GESTOR,NOME,MATRICULA,CPF,PERFIL FROM USUARIO WHERE NOME='{TextGestor}' AND GESTOR= '{Gestor}' AND PERFIL= '1'";
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
                    Gestor = dt.Rows[0]["Gestor"].ToString();


                    return true;

                }


            }

            return false;
        }
        public bool ValidarSV()
        {
            // string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"SELECT  GESTOR,NOME,MATRICULA,CPF,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}'  AND PERFIL IN('5','6')";
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
                    Gestor = dt.Rows[0]["Gestor"].ToString();


                    return true;

                }


            }

            return false;
        }



        public bool ValidarUser1(string TxtGestor)
        {
            //  string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"SELECT  GESTOR,NOME,MATRICULA,CPF,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}' AND GESTOR= '{TxtGestor}' AND PERFIL= '2'";
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
                    Gestor = dt.Rows[0]["Gestor"].ToString();



                    return true;

                }


            }

            return false;
        }
        public bool ValidarUserGestor1()
        {
            //  string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"SELECT  GESTOR,NOME,MATRICULA,CPF,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}'  AND PERFIL= '2'";
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
                    Gestor = dt.Rows[0]["Gestor"].ToString();



                    return true;

                }


            }

            return false;
        }

        public bool ValidarUserLider()
        {
            //  string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"SELECT  GESTOR,NOME,MATRICULA,CPF,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}'  AND PERFIL= '1'";
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
                    Gestor = dt.Rows[0]["Gestor"].ToString();



                    return true;

                }


            }

            return false;
        }

        public bool ValidarUser2()
        {

            // string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"SELECT  GESTOR,NOME,MATRICULA,CPF,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}'  AND PERFIL= '3'";
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
                    Gestor = dt.Rows[0]["Gestor"].ToString();

                    return true;


                }


            }

            return false;
        }
        public bool ValidarDiretorGestor(string TxtGestor)
        {

            string sql = $"SELECT  GESTOR,NOME,MATRICULA,CPF,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}'AND GESTOR= '{TxtGestor}' AND PERFIL IN ('5','6')";
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
                    Gestor = dt.Rows[0]["Gestor"].ToString();



                    return true;

                }


            }

            return false;
        }

        public bool ValidarUser3(string TxtGestor)
        {

            string sql = $"SELECT  GESTOR,NOME,MATRICULA,CPF,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}'AND GESTOR= '{TxtGestor}' AND PERFIL= '4'";
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
                    Gestor = dt.Rows[0]["Gestor"].ToString();



                    return true;

                }


            }

            return false;
        }

        public bool ValidarOP()
        {

            string sql = $"SELECT  GESTOR,NOME,MATRICULA,CPF,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}' AND PERFIL= '4'";
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
                    Gestor = dt.Rows[0]["Gestor"].ToString();



                    return true;

                }


            }

            return false;
        }


        public void Questionarios(string Pessoas14, string Pessoas15, string Pessoas16, string Pessoas17, string Pessoas18, string Pessoas19, string Pessoas20)
        {

            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");

            new DAL().ExecutarComandoSQL($"UPDATE questionario SET Pessoas14='{Pessoas14}',Pessoas15='{Pessoas15}',Pessoas16='{Pessoas16}',Pessoas17='{Pessoas17}',Pessoas18='{Pessoas18}',Pessoas19='{Pessoas19}',Pessoas20='{Pessoas20}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");



        }

        public void Assistente(string Pessoas14, string Pessoas15, string Pessoas16, string Pessoas17, string Pessoas18, string Pessoas19, string Pessoas20)
        {

            // string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");

            new DAL().ExecutarComandoSQL($"UPDATE questionario SET Pessoas14='{Pessoas14}',Pessoas15='{Pessoas15}',Pessoas16='{Pessoas16}',Pessoas17='{Pessoas17}',Pessoas18='{Pessoas18}',Pessoas19='{Pessoas19}',Pessoas20='{Pessoas20}' WHERE   Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");



        }



        public void QuestionariosColaborador()
        {

            //string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = @HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");

            new DAL().ExecutarComandoSQL($"UPDATE usuario SET Status='Já Avaliado' WHERE Matricula='{Matricula}' and  Status='NULL'");



        }
        public void Insert(string TxtGestor)
        {

            string sql = $"INSERT INTO questionario (DATA, NOMEGESTOR, MATRICULA, STATUS) VALUES('{(DateTime.Now).ToString("yyyy:MM:dd  HH:mm:ss")}','{TxtGestor}','{Matricula}','Já Avaliado')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }
        public void InsertGestor(string TextGestor)
        {

            string sql = $"INSERT INTO questionario (DATA, NOMEGESTOR, MATRICULA, STATUS) VALUES('{(DateTime.Now).ToString("yyyy:MM:dd  HH:mm:ss")}','{TextGestor}','{Matricula}','Já Avaliado')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }

        public void InsertGestor1(string TxtGestor)
        {
            string sql = $"INSERT INTO questionario (DATA, NOMEGESTOR, MATRICULA, STATUS) VALUES('{(DateTime.Now).ToString("yyyy:MM:dd  HH:mm:ss")}','{TxtGestor}','{Matricula}','Auto Avaliado')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }

        public void InsertAssist(string TextGestor)
        {
            string sql = $"INSERT INTO questionario (DATA, NOMEGESTOR, MATRICULA, STATUS) VALUES('{(DateTime.Now).ToString("yyyy:MM:dd  HH:mm:ss")}','{TextGestor}','{Matricula}','Auto Avaliado')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }


        public List<AvaliacaoPessoasModel> ListaColaborador()
        {

            List<AvaliacaoPessoasModel> Lista = new List<AvaliacaoPessoasModel>();
            AvaliacaoPessoasModel item;

            string Nome = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"select Matricula,Nome,status from usuario where gestor='" + Nome + "'  ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                item = new AvaliacaoPessoasModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Matricula = dt.Rows[i]["Matricula"].ToString();
                item.Status = dt.Rows[i]["status"].ToString();

                Lista.Add(item);

            }

            return Lista;

        }
       
        public AvaliacaoPessoasModel CarregarRegistro(int? Matricula)
        {
            AvaliacaoPessoasModel item = new AvaliacaoPessoasModel( );         
            string sql = $"SELECT ID,MATRICULA FROM USUARIO WHERE  Matricula = '{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            item.Matricula = dt.Rows[0]["Matricula"].ToString();


            return item;
        }

        public List<AvaliacaoPessoasModel> ListaMatricula()
        {
            List<AvaliacaoPessoasModel> Lista = new List<AvaliacaoPessoasModel>();
            AvaliacaoPessoasModel item;

            string Nome = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"select Matricula,Nome,Cargo from usuario where gestor='" + Nome + "' and Status='NULL'  ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                item = new AvaliacaoPessoasModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Matricula = dt.Rows[i]["Matricula"].ToString();
                item.Cargo = dt.Rows[i]["Cargo"].ToString();

                Lista.Add(item);

            }

            return Lista;

        }
        public bool ValidarCola()
        {
            string Nome = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"select * from usuario where gestor='" + Nome + "' and Status='NULL' ";
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
                    Gestor = dt.Rows[0]["Gestor"].ToString();
                    return true;

                }


            }

            return false;
        }


    }
}