using Avaliação.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Avaliação.Models
{
    public class MenuIniModel
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

        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public MenuIniModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;

        }

        public MenuIniModel()
        {



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


        public bool ValidarSV()
        {

            string sql = $"SELECT NOME,MATRICULA,PERFIL FROM USUARIO WHERE  MATRICULA='{Matricula}'  AND PERFIL IN('5','6')";
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



    }
}