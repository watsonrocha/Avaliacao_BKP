using Avaliação.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Avaliação.Models
{
    public class AvaliacaoCargoModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }     
        public string Veiculo_proprio { get; set; }
        public string CNH_Valida { get; set; }
        public string habilidade_em_dirigir { get; set; }
        public string Operador_de_Empilhadeira { get; set; }
        public string Tecnico_completo { get; set; }
        public string Superior_completo { get; set; }
        public string Pos_graduação_completo { get; set; }
        public string Pos_graduacao_MBA_COMPLETO { get; set; }
        public string Pos_graduacao_MBA_CURSANDO { get; set; }
        public string Ingles_basico { get; set; }
        public string Ingles_basico_CURSANDO { get; set; }
        public string Ingles_intermediario { get; set; }
        public string Ingles_Avancado_CURSANDO { get; set; }
        public string Ingles_Avancado_COMPLETO { get; set; }
        public string Ingles_intermediario_CURSANDO { get; set; }
        public string Flexibilidade_horario { get; set; }
        public string Mudanca_residencia { get; set; }
        public string Job_Rotation { get; set; }
        public string Pacote_Office_basico { get; set; }
        public string Pacote_Office_Avancado { get; set; }
        public string Pacote_Office_intermediario { get; set; }
        public string Nome { get; set; }
        public string NomeGestor { get; set; }
        public string Colaborador { get; set; }
        public string Perfil { get; set; }
        public string Matricula { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public AvaliacaoCargoModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public AvaliacaoCargoModel()
        {
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

        public bool ValidarCargoJunior(string txtNomeGest, string txtmatricula)
        {
            string sql = $"SELECT  * FROM requisitocargo WHERE Matricula='{txtmatricula}'AND NomeGESTOR= '{txtNomeGest}' ";
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
        public bool ValidarCargoPleno(string txtNomeGest, string txtmatricula)
        {
            string sql = $"SELECT  * FROM requisitocargo_pleno WHERE Matricula='{txtmatricula}'AND NomeGESTOR= '{txtNomeGest}' ";
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
        public bool ValidarCargoSenior(string txtNomeGest, string txtmatricula)
        {
            string sql = $"SELECT  * FROM requisitocargo_senior WHERE Matricula='{txtmatricula}'AND NomeGESTOR= '{txtNomeGest}' ";
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
            string sql = $"SELECT  * FROM requisitocargo WHERE  NomeGESTOR= '{txtNomeGest}' ";
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
                  
        public bool ValidarSupervisor_junior()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Supervisor' AND Nivel='Junior' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }

        public bool ValidarSupervisor_Pleno()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Supervisor' AND Nivel='Pleno' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }

        public bool ValidarSupervisor_Senior()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Supervisor' AND Nivel='Senior' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }


        public bool ValidarGerente()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Gerente'  AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }

        public bool ValidarCoordenador_junior()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Coordenador' AND Nivel='Junior' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }
        public bool ValidarCoordenador_Pleno()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Coordenador' AND Nivel='Pleno' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }

        public bool ValidarCoordenador_Senior()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Coordenador' AND Nivel='Senior' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }
        public bool ValidarAnalista_junior()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Analista' AND Nivel='Junior' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }
        public bool ValidarAnalista_Pleno()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Analista' AND Nivel='Pleno' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }
        public bool ValidarAnalista_Senior()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Analista' AND Nivel='Senior' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }

        public bool ValidarEncarregado_Junior()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Encarregado' AND Nivel='Junior' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }
        public bool ValidarEncarregado_Pleno()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Encarregado' AND Nivel='Pleno' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }
        public bool ValidarEncarregado_Senior()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Encarregado' AND Nivel='Senior' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }


        public bool ValidarEspecialista()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Especialista' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }

        public bool ValidarTecnico()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Tecnico' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }
        public bool ValidarLider()
        {
            string sql = $"SELECT  NOME,MATRICULA FROM USUARIO WHERE Categoria = 'Lider' AND  MATRICULA='{Matricula}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Nome = dt.Rows[0]["Nome"].ToString();
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    return true;
                }
            }
            return false;
        }


















        public void Supervisor_Junior(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduacao_MBA_CURSANDO='{Checkbox4}',Ingles_intermediario='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacotte_Office_intermediario='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }
        public void Supervisor_Pleno(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo_Pleno SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduacao_MBA_COMPLETO='{Checkbox4}',Ingles_Avancado_CURSANDO='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacote_Office_Avancado='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }
        public void Supervisor_Senior(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo_senior SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduacao_MBA_COMPLETO='{Checkbox4}',Ingles_Avancado_COMPLETO='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacote_Office_Avancado='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }

        public void Coordenador_Junior(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduação_completo='{Checkbox4}',Ingles_intermediario_CURSANDO='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacotte_Office_intermediario='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }

        public void Coordenador_Pleno(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo_Pleno SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduação_completo='{Checkbox4}',Ingles_intermediario='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacote_Office_intermediario='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }
        public void Coordenador_Senior(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo_senior SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduacao_MBA_CURSANDO='{Checkbox4}',Ingles_intermediario='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacotte_Office_intermediario='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }

        public void Analista_Junior(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduação_completo='{Checkbox4}',Ingles_basico='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacotte_Office_intermediario='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }
        public void Analista_Pleno(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo_Pleno SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduação_completo='{Checkbox4}',Ingles_basico_CURSANDO='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacote_Office_Avancado='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }
        public void Analista_Senior(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo_Senior SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduação_completo='{Checkbox4}',Ingles_intermediario_CURSANDO='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacote_Office_intermediario='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }

        public void Encarregado_Junior(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduação_completo='{Checkbox4}',Ingles_basico_CURSANDO='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacotte_Office_intermediario='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }

        public void Encarregado_Pleno(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo_Pleno SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduação_completo='{Checkbox4}',Ingles_basico_CURSANDO='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacote_Office_intermediario='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }

        public void Encarregado_Senior(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo_Senior SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduação_completo='{Checkbox4}',Ingles_intermediario_CURSANDO='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacote_Office_intermediario='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }
        public void Especialista(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',Pos_graduação_completo='{Checkbox4}',Ingles_intermediario='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacote_Office_basico='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }
        public void Tecnico(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Tecnico_completo='{Checkbox4}',Superior_completo='{Checkbox4}',Pos_graduação_completo='{Checkbox4}',Ingles_basico='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacote_Office_intermediario='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }

        public void Lider(string Checkbox1, string Checkbox2, string Checkbox3, string Checkbox4, string Checkbox5, string Checkbox6, string Checkbox7, string Checkbox8, string Checkbox9)
        {
            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            new DAL().ExecutarComandoSQL($"UPDATE requisitocargo SET Veiculo_proprio='{Checkbox1}',Avaliador = ( SELECT NomeGestor FROM questionario WHERE NomeGestor = '{NomeGestor}'),CNH_Valida='{Checkbox2}',habilidade_em_dirigir='{Checkbox3}',Superior_completo='{Checkbox4}',,Pos_graduação_completo='{Checkbox4}',Ingles_basico='{Checkbox5}',Flexibilidade_horario='{Checkbox6}',Mudanca_residencia='{Checkbox7}',Job_Rotation='{Checkbox8}',Pacotte_Office_intermediario='{Checkbox9}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");
        }

        public void InsertSvJunior(string txtNomeGest)
        {
            string sql = $"INSERT INTO requisitocargo (DATA, NOMEGESTOR, MATRICULA) VALUES('{(DateTime.Now).ToString("yyyy:MM:dd  HH:mm:ss")}','{txtNomeGest}','{Matricula}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }
        public void InsertSvPleno(string txtNomeGest)
        {
            string sql = $"INSERT INTO requisitocargo_pleno (DATA, NOMEGESTOR, MATRICULA) VALUES('{(DateTime.Now).ToString("yyyy:MM:dd  HH:mm:ss")}','{txtNomeGest}','{Matricula}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }
        public void InsertSvSenior(string txtNomeGest)
        {
            string sql = $"INSERT INTO requisitocargo_Senior (DATA, NOMEGESTOR, MATRICULA) VALUES('{(DateTime.Now).ToString("yyyy:MM:dd  HH:mm:ss")}','{txtNomeGest}','{Matricula}')";
            DAL objDAL = new DAL();
            objDAL.ExecutarComandoSQL(sql);
        }







    }
}
