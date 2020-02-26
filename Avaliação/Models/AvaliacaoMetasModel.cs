using Avaliação.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Avaliação.Models
{
    public class AvaliacaoMetasModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o Nome !")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Email !")]
        public string Perfil { get; set; }
        public string NomeGestor { get; set; }
        public string Obs_Estrategico_01 { get; set; }
        public string Meta_futura_1 { get; set; }
        public string Obs_Estrategico_02 { get; set; }
        public string Meta_futura_2 { get; set; }
        public string Obs_Estrategico_03 { get; set; }
        public string Meta_futura_3 { get; set; }

        public string Obs_Execucao_01 { get; set; }
        public string Obs_Execucao_02 { get; set; }
        public string Obs_Execucao_03 { get; set; }

        public string Obs_Tatico_01 { get; set; }
        public string Obs_Tatico_02 { get; set; }
        public string Obs_Tatico_03 { get; set; }

        public string Matricula { get; set; }

        public int Nivel_Estrategico_01 { get; set; }
        public int Nivel_Estrategico_02 { get; set; }
        public int Nivel_Estrategico_03 { get; set; }

        public int Nivel_Tatico_01 { get; set; }
        public int Nivel_Tatico_02 { get; set; }
        public int Nivel_Tatico_03 { get; set; }

        public int Nivel_Execucao_01 { get; set; }
        public int Nivel_Execucao_02 { get; set; }
        public int Nivel_Execucao_03 { get; set; }

        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public AvaliacaoMetasModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;

        }

        public AvaliacaoMetasModel()
        {



        }

        public bool ValidarMetasMatricula(string txtNomeGest, string txtmatricula)
        {
            string sql = $"SELECT  * FROM metas WHERE Matricula='{txtmatricula}'AND NomeGESTOR= '{txtNomeGest}' ";
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
        public bool ValidaPessoasCargo(string txtNomeGest, string txtmatricula)
        {
            string sql = $"SELECT  * FROM questionario WHERE Matricula='{txtmatricula}'AND NomeGESTOR= '{txtNomeGest}' ";
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
        public bool ValidarMatriculaGestor(string txtNomeGest)
        {
            string sql = $"SELECT  * FROM metas WHERE  NomeGESTOR= '{txtNomeGest}' ";
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
        public bool ValidaSV()
        {
            string sql = $"SELECT  NOME,MATRICULA,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}' AND PERFIL='5'";
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
        public bool ValidaRH()
        {
            string sql = $"SELECT  NOME,MATRICULA,PERFIL FROM USUARIO WHERE MATRICULA='{Matricula}' AND PERFIL ='6'";
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

        public void Metas(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string text1, string text2, string text3, string text4, string text5, string text6)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE Metas SET Nivel_Estrategico_01='{Checkbox1}',Avaliador = (SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),Obs_Estrategico_01='{text1}',Meta_futura_1='{text2}',Nivel_Estrategico_02 ='{Checkbox2}',Obs_Estrategico_02='{text3}',Meta_futura_2='{text4}',Nivel_Estrategico_03='{Checkbox3}',Nivel_Estrategico_03='{Checkbox4}',Nivel_Estrategico_03='{Checkbox5}',Nivel_Estrategico_03='{Checkbox6}',Obs_Estrategico_03='{text5}',Meta_Futura_3='{text6}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }
        public void Insert(string txtNomeGest)
        {
            //  string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"INSERT INTO Metas (DATA, NOMEGESTOR, MATRICULA) VALUES('{(DateTime.Now).ToString("yyyy:MM:dd  HH:mm:ss")}','{txtNomeGest}','{Matricula}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }

    }
}