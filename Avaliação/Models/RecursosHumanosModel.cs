using Avaliação.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;

namespace Avaliação.Models
{
    public class RecursosHumanosModel
    {
        public string Data { get; set; }
        public int Id { get; set; }
        public string NomeGestor { get; set; }
        public string Setor { get; set; }
        public string Nomes { get; set; }
        public string Avaliador { get; set; }
        public string Unidade { get; set; }
        public string Matricula { get; set; }
        public string Total { get; set; }
        public string Negocios01 { get; set; }
        public string Negocios02 { get; set; }
        public string Negocios03 { get; set; }
        public string Negocios04 { get; set; }
        public string Negocios05 { get; set; }
        public string Negocios06 { get; set; }
        public string Negocios07 { get; set; }
        public string Processos08 { get; set; }
        public string Processos09 { get; set; }
        public string Processos10 { get; set; }
        public string Processos11 { get; set; }
        public string Processos12 { get; set; }
        public string Processos13 { get; set; }
        public string Pessoas14 { get; set; }
        public string Pessoas15 { get; set; }
        public string Pessoas16 { get; set; }
        public string Pessoas17 { get; set; }
        public string Pessoas18 { get; set; }
        public string Pessoas19 { get; set; }
        public string Pessoas20 { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Status { get; set; }
        public string Perfil { get; set; }
        public string Negocio { get; set; }
        public string Processos { get; set; }
        public string Pessoas { get; set; }
        public string Total_Competencias { get; set; }
        public string Nivel_Estrategico_01 { get; set; }
        public string Nivel_Estrategico_02 { get; set; }
        public string Nivel_Estrategico_03 { get; set; }
        public string Pos_graduação_MBA_CURSANDO { get; set; }
        public string Pos_graduação_MBA_COMPLETO { get; set; }
        public string Ingles_basico_CURSANDO { get; set; }
        public string Ingles_intermediario_CURSANDO { get; set; }
        public string Ingles_Avancado_CURSANDO { get; set; }
        public string Ingles_Avancado_COMPLETO { get; set; }
        public string flexibilidade_horario { get; set; }
        public string Mudanca_residencia { get; set; }
        public string Job_rotation { get; set; }
        public string Veiculo_proprio { get; set; }
        public string CNH_Valida { get; set; }
        public string habilidade_em_dirigir { get; set; }
        public string tecnico_completo { get; set; }
        public string Superior_completo { get; set; }
        public string Pos_graduação_completo { get; set; }
        public string Ingles_intermediario { get; set; }
        public string Excel_intermediario { get; set; }
        public string Ingles_basico { get; set; }
        public string Excel_basico { get; set; }
        public string Excel_Avancado { get; set; }
        public string Operador_de_Empilhadeira { get; set; }
        public string Superior_cursando { get; set; }
        public string Conhecimento_Pacote_Office { get; set; }
        public string Pacote_Office_basico { get; set; }
        public string Pacote_Office_intermediario { get; set; }
        public string Pacote_Office_Avancado { get; set; }
        public string Credenciamento_da_atividade { get; set; }
        public string Ensino_medio_completo { get; set; }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public string P4 { get; set; }
        public string P5 { get; set; }
        public string P6 { get; set; }
        public string P7 { get; set; }
        public string P8 { get; set; }
        public string P9 { get; set; }
        public string P10 { get; set; }
        public string P11 { get; set; }
        public string P12 { get; set; }
        public string P13 { get; set; }
        public string P14 { get; set; }
        public string P15 { get; set; }
        public string P16 { get; set; }
        public string P17 { get; set; }
        public IHttpContextAccessor HttpContextAccessor { get; set; }
        public RecursosHumanosModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }
        public RecursosHumanosModel()
        {
        }
        //Recebe o contexto para acesso ás variaveis de sessão
        public bool ValidarRadarSv(string txtColaboradorRadar)
        {
            string sql = $"SELECT  * FROM questionario a, usuario b WHERE a.Matricula = b.Matricula and  b.Matricula='{txtColaboradorRadar}' and b.Perfil in('5','6') and a.Status='Já Avaliado'";
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
        public bool ValidarRadarAnalista(string txtColaboradorRadar)
        {
            string sql = $"SELECT  * FROM questionario a, usuario b WHERE a.Matricula = b.Matricula and  b.Matricula='{txtColaboradorRadar}' and b.Perfil= '2' and a.Status='Já Avaliado'";
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

        public bool ValidarRadarGL(string txtColaboradorRadar)
        {
            string sql = $"SELECT  * FROM questionario a, usuario b WHERE a.Matricula = b.Matricula and  b.Matricula='{txtColaboradorRadar}' and b.Perfil= '1' and a.Status='Já Avaliado'";
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

        public bool ValidarRadarOper(string txtColaboradorRadar)
        {
            string sql = $"SELECT  * FROM questionario a, usuario b WHERE a.Matricula = b.Matricula and  b.Matricula='{txtColaboradorRadar}' and b.Perfil= '4' and a.Status='Já Avaliado'";
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
       
        public bool ValidarNIneBoxGL(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}'AND cargo IN('Encarregado de Operações Logistica Júnior','Encarregado de Operações Logísticas Pleno','Encarregado de Operações Logísticas Sênior') and Perfil ='1'  ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }

            }

            return false;
        }

        public bool ValidarNIneBoxEspec(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}' and Perfil ='2'  ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }
            }

            return false;
        }


        // Valida Analista Junior
        public bool ValidarNIneBoxAnalistaJunior(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}' and Categoria= 'Analista' AND NIvel='Junior'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }
            }

            return false;
        }

        // Valida Analista Pleno
        public bool ValidarNIneBoxAnalistaPleno(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}' and Categoria= 'Analista' AND NIvel='Pleno'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }
            }

            return false;
        }

        // Valida Analista Senior
        public bool ValidarNIneBoxAnalistaSenior(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}' and Categoria= 'Analista' AND NIvel='Senior'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }
            }

            return false;
        }


        // Valida o usuario Supervisor nivel Junior
        public bool ValidarNIneSvJunior(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}'  AND  Categoria= 'Supervisor' AND NIvel='Junior'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }

            }

            return false;
        }

        // Valida o usuario Supervisor nivel Pleno
        public bool ValidarNIneSvPleno(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}'  AND  Categoria= 'Supervisor' AND NIvel='Pleno'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }

            }

            return false;
        }

        // Valida o usuario Supervisor nivel Senior
        public bool ValidarNIneSvSenior(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}'  AND  Categoria= 'Supervisor' AND NIvel='Senior'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }

            }

            return false;
        }

        // Valida o usuario Coordenador nivel Junior
        public bool ValidarNIneCoordJunior(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}'  AND  Categoria= 'Coordenador' AND NIvel='Junior'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }

            }

            return false;
        }

        // Valida o usuario Coordenador nivel Pleno
        public bool ValidarNIneCoordPleno(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}'  AND  Categoria= 'Coordenador' AND NIvel='Pleno'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }

            }

            return false;
        }

        // Valida o usuario Coordenador nivel Senior
        public bool ValidarNIneCoordSenior(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}'  AND  Categoria= 'Coordenador' AND NIvel='Senior'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }

            }

            return false;
        }
        // Valida o usuario Encarregado nivel Junior
        public bool ValidarNineEncarregadoJunior(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}'  AND  Categoria= 'Encarregado' AND NIvel='Junior'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }

            }

            return false;
        }
        // Valida o usuario Encarregado nivel Pleno
        public bool ValidarNIneEncarregadoPleno(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}'  AND  Categoria= 'Encarregado' AND NIvel='Pleno'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }

            }

            return false;
        }

        // Valida o usuario Encarregado nivel Senior
        public bool ValidarNIneEncarregadoSenior(string txtColaboradorNine)
        {
            string sql = $"SELECT  * FROM usuario WHERE Matricula='{txtColaboradorNine}'  AND  Categoria= 'Encarregado' AND NIvel='Senior'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            if (dt != null)
            {
                if (dt.Rows.Count == 1)
                {
                    Matricula = dt.Rows[0]["Matricula"].ToString();
                    Perfil = dt.Rows[0]["Perfil"].ToString();
                    return true;
                }

            }

            return false;
        }


        public List<RecursosHumanosModel> ListaCadastro()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            // string Nome = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"SELECT  a.ID, a.`Data`,a.NomeGestor,b.Nome AS Avaliado ,b.Cargo, a.Matricula,a.Negocios01,a.Negocios02,a.Negocios03,a.Negocios04,a.Negocios05,a.Negocios06, a.Processos08,a.Processos09,a.Processos10,a.Processos10,a.Processos11,a.Processos12,a.Processos13, a.Pessoas14,a.Pessoas15,a.Pessoas16,a.Pessoas17,a.Pessoas18,a.Pessoas19,a.Pessoas20,a.`Status` FROM questionario a, usuario b WHERE a.Matricula = b.Matricula";              
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Id = int.Parse(dt.Rows[i]["Id"].ToString());
                item.Data = dt.Rows[i]["Data"].ToString();
                item.NomeGestor = dt.Rows[i]["NomeGestor"].ToString();
                item.Nome = dt.Rows[i]["Avaliado"].ToString();
                item.Cargo = dt.Rows[i]["Cargo"].ToString();
                item.Status = dt.Rows[i]["Status"].ToString();
                item.Matricula = dt.Rows[i]["Matricula"].ToString();
                item.Negocios01 = dt.Rows[i]["Negocios01"].ToString();
                item.Negocios02 = dt.Rows[i]["Negocios02"].ToString();
                item.Negocios03 = dt.Rows[i]["Negocios03"].ToString();
                item.Negocios04 = dt.Rows[i]["Negocios04"].ToString();
                item.Negocios05 = dt.Rows[i]["Negocios05"].ToString();
                item.Negocios06 = dt.Rows[i]["Negocios06"].ToString();
                item.Processos08 = dt.Rows[i]["Processos08"].ToString();
                item.Processos09 = dt.Rows[i]["Processos09"].ToString();
                item.Processos10 = dt.Rows[i]["Processos10"].ToString();
                item.Processos11 = dt.Rows[i]["Processos11"].ToString();
                item.Processos12 = dt.Rows[i]["Processos12"].ToString();
                item.Processos13 = dt.Rows[i]["Processos13"].ToString();
                item.Pessoas14 = dt.Rows[i]["Pessoas14"].ToString();
                item.Pessoas15 = dt.Rows[i]["Pessoas15"].ToString();
                item.Pessoas16 = dt.Rows[i]["Pessoas16"].ToString();
                item.Pessoas17 = dt.Rows[i]["Pessoas17"].ToString();
                item.Pessoas18 = dt.Rows[i]["Pessoas18"].ToString();
                item.Pessoas19 = dt.Rows[i]["Pessoas19"].ToString();
                item.Pessoas20 = dt.Rows[i]["Pessoas20"].ToString();
               
             
                Lista.Add(item);
                //parte 1 especialista

                if (item.Negocios01 == "0,769230769")
                {
                    item.Negocios01 = "1";
                }
                else if (item.Negocios01 == "1,923076923")
                {
                    item.Negocios01 = "2";
                }
                else if (item.Negocios01 == "3,846153846")
                {
                    item.Negocios01 = "3";
                }
                else if (item.Negocios01 == "5,384615385")
                {
                    item.Negocios01 = "4";
                }

                // parte 2 especialista

                if (item.Negocios02 == "0,769230769")
                {
                    item.Negocios02 = "1";
                }
                else if (item.Negocios02 == "1,923076923")
                {
                    item.Negocios02 = "2";
                }
                else if (item.Negocios02 == "3,846153846")
                {
                    item.Negocios02 = "3";
                }
                else if (item.Negocios02 == "5,384615385")
                {
                    item.Negocios02 = "4";
                }

                // parte 3 especialista

                if (item.Negocios03 == "0,769230769")
                {
                    item.Negocios03 = "1";
                }
                else if (item.Negocios03 == "1,923076923")
                {
                    item.Negocios03 = "2";
                }
                else if (item.Negocios03 == "3,846153846")
                {
                    item.Negocios03 = "3";
                }
                else if (item.Negocios03 == "5,384615385")
                {
                    item.Negocios03 = "4";
                }

                // parte4 especialista
                if (item.Negocios04 == "0,769230769")
                {
                    item.Negocios04 = "1";
                }
                else if (item.Negocios04 == "1,923076923")
                {
                    item.Negocios04 = "2";
                }
                else if (item.Negocios04 == "3,846153846")
                {
                    item.Negocios04 = "3";
                }
                else if (item.Negocios04 == "5,384615385")
                {
                    item.Negocios04 = "4";
                }
                //parte5 especialista
                if (item.Negocios05 == "0,769230769")
                {
                    item.Negocios05 = "1";
                }
                else if (item.Negocios05 == "1,923076923")
                {
                    item.Negocios05 = "2";
                }
                else if (item.Negocios05 == "3,846153846")
                {
                    item.Negocios05 = "3";
                }
                else if (item.Negocios05 == "5,384615385")
                {
                    item.Negocios05 = "4";
                }

                //parte6 especialista
                if (item.Negocios06 == "0,769230769")
                {
                    item.Negocios06 = "1";
                }
                else if (item.Negocios06 == "1,923076923")
                {
                    item.Negocios06 = "2";
                }
                else if (item.Negocios06 == "3,846153846")
                {
                    item.Negocios06 = "3";
                }
                else if (item.Negocios06 == "5,384615385")
                {
                    item.Negocios06 = "4";
                }
                //parte7 especialista
                if (item.Negocios07 == "0,769230769")
                {
                    item.Negocios07 = "1";
                }
                else if (item.Negocios07 == "1,923076923")
                {
                    item.Negocios07 = "2";
                }
                else if (item.Negocios07 == "3,846153846")
                {
                    item.Negocios07 = "3";
                }
                else if (item.Negocios07 == "5,384615385")
                {
                    item.Negocios07 = "4";
                }

                //parte 1 Operador

                if (item.Negocios01 == "1")
                {
                    item.Negocios01 = "1";
                }
                else if (item.Negocios01 == "2,5")
                {
                    item.Negocios01 = "2";
                }
                else if (item.Negocios01 == "5")
                {
                    item.Negocios01 = "3";
                }
                else if (item.Negocios01 == "7")
                {
                    item.Negocios01 = "4";
                }

                // parte 2 Operador

                if (item.Negocios02 == "1")
                {
                    item.Negocios02 = "1";
                }
                else if (item.Negocios02 == "2,5")
                {
                    item.Negocios02 = "2";
                }
                else if (item.Negocios02 == "5")
                {
                    item.Negocios02 = "3";
                }
                else if (item.Negocios02 == "7")
                {
                    item.Negocios02 = "4";
                }

                // parte 3 Operador

                if (item.Negocios03 == "1")
                {
                    item.Negocios03 = "1";
                }
                else if (item.Negocios03 == "2,5")
                {
                    item.Negocios03 = "2";
                }
                else if (item.Negocios03 == "5")
                {
                    item.Negocios03 = "3";
                }
                else if (item.Negocios03 == "7")
                {
                    item.Negocios03 = "4";
                }

                // parte4 Operador
                if (item.Negocios04 == "1")
                {
                    item.Negocios04 = "1";
                }
                else if (item.Negocios04 == "2,5")
                {
                    item.Negocios04 = "2";
                }
                else if (item.Negocios04 == "5")
                {
                    item.Negocios04 = "3";
                }
                else if (item.Negocios04 == "7")
                {
                    item.Negocios04 = "4";
                }
                //parte5 Operador
                if (item.Negocios05 == "1")
                {
                    item.Negocios05 = "1";
                }
                else if (item.Negocios05 == "2,5")
                {
                    item.Negocios05 = "2";
                }
                else if (item.Negocios05 == "5")
                {
                    item.Negocios05 = "3";
                }
                else if (item.Negocios05 == "7")
                {
                    item.Negocios05 = "4";
                }

                //parte6 Operador
                if (item.Negocios06 == "1")
                {
                    item.Negocios06 = "1";
                }
                else if (item.Negocios06 == "2,5")
                {
                    item.Negocios06 = "2";
                }
                else if (item.Negocios06 == "5")
                {
                    item.Negocios06 = "3";
                }
                else if (item.Negocios06 == "7")
                {
                    item.Negocios06 = "4";
                }
                //parte7 Operador
                if (item.Negocios07 == "1")
                {
                    item.Negocios07 = "1";
                }
                else if (item.Negocios07 == "2,5")
                {
                    item.Negocios07 = "2";
                }
                else if (item.Negocios07 == "5")
                {
                    item.Negocios07 = "3";
                }
                else if (item.Negocios07 == "7")
                {
                    item.Negocios07 = "4";
                }

                //parte 1 Gestor

                if (item.Negocios01 == "0,588235294")
                {
                    item.Negocios01 = "1";
                }
                else if (item.Negocios01 == "1,470588235")
                {
                    item.Negocios01 = "2";
                }
                else if (item.Negocios01 == "2,941176471")
                {
                    item.Negocios01 = "3";
                }
                else if (item.Negocios01 == "4,117647059")
                {
                    item.Negocios01 = "4";
                }

                // parte 2 Gestor

                if (item.Negocios02 == "0,588235294")
                {
                    item.Negocios02 = "1";
                }
                else if (item.Negocios02 == "1,470588235")
                {
                    item.Negocios02 = "2";
                }
                else if (item.Negocios02 == "2,941176471")
                {
                    item.Negocios02 = "3";
                }
                else if (item.Negocios02 == "4,117647059")
                {
                    item.Negocios02 = "4";
                }

                // parte 3 Gestor

                if (item.Negocios03 == "0,588235294")
                {
                    item.Negocios03 = "1";
                }
                else if (item.Negocios03 == "1,470588235")
                {
                    item.Negocios03 = "2";
                }
                else if (item.Negocios03 == "2,941176471")
                {
                    item.Negocios03 = "3";
                }
                else if (item.Negocios03 == "4,117647059")
                {
                    item.Negocios03 = "4";
                }

                // parte4 Gestor
                if (item.Negocios04 == "0,588235294")
                {
                    item.Negocios04 = "1";
                }
                else if (item.Negocios04 == "1,470588235")
                {
                    item.Negocios04 = "2";
                }
                else if (item.Negocios04 == "2,941176471")
                {
                    item.Negocios04 = "3";
                }
                else if (item.Negocios04 == "4,117647059")
                {
                    item.Negocios04 = "4";
                }
                //parte5 Gestor
                if (item.Negocios05 == "0,588235294")
                {
                    item.Negocios05 = "1";
                }
                else if (item.Negocios05 == "1,470588235")
                {
                    item.Negocios05 = "2";
                }
                else if (item.Negocios05 == "2,941176471")
                {
                    item.Negocios05 = "3";
                }
                else if (item.Negocios05 == "4,117647059")
                {
                    item.Negocios05 = "4";
                }

                //parte6 Gestor
                if (item.Negocios06 == "0,588235294")
                {
                    item.Negocios06 = "1";
                }
                else if (item.Negocios06 == "1,470588235")
                {
                    item.Negocios06 = "2";
                }
                else if (item.Negocios06 == "2,941176471")
                {
                    item.Negocios06 = "3";
                }
                else if (item.Negocios06 == "4,117647059")
                {
                    item.Negocios06 = "4";
                }
                //parte7 Gestor
                if (item.Negocios07 == "0,588235294")
                {
                    item.Negocios07 = "1";
                }
                else if (item.Negocios07 == "1,470588235")
                {
                    item.Negocios07 = "2";
                }
                else if (item.Negocios07 == "2,941176471")
                {
                    item.Negocios07 = "3";
                }
                else if (item.Negocios07 == "4,117647059")
                {
                    item.Negocios07 = "4";
                }

                //parte1 GL
                if (item.Negocios01 == "0,714285714")
                {
                    item.Negocios01 = "1";
                }
                else if (item.Negocios01 == "1,785714286")
                {
                    item.Negocios01 = "2";
                }
                else if (item.Negocios01 == "3,571428571")
                {
                    item.Negocios01 = "3";
                }
                else if (item.Negocios01 == "5")
                {
                    item.Negocios01 = "4";
                }

                // parte 2 GL

                if (item.Negocios02 == "0,714285714")
                {
                    item.Negocios02 = "1";
                }
                else if (item.Negocios02 == "1,785714286")
                {
                    item.Negocios02 = "2";
                }
                else if (item.Negocios02 == "3,571428571")
                {
                    item.Negocios02 = "3";
                }
                else if (item.Negocios02 == "5")
                {
                    item.Negocios02 = "4";
                }

                // parte 3 GL

                if (item.Negocios03 == "0,714285714")
                {
                    item.Negocios03 = "1";
                }
                else if (item.Negocios03 == "1,785714286")
                {
                    item.Negocios03 = "2";
                }
                else if (item.Negocios03 == "3,571428571")
                {
                    item.Negocios03 = "3";
                }
                else if (item.Negocios03 == "5")
                {
                    item.Negocios03 = "4";
                }

                // parte4 GL
                if (item.Negocios04 == "0,714285714")
                {
                    item.Negocios04 = "1";
                }
                else if (item.Negocios04 == "1,785714286")
                {
                    item.Negocios04 = "2";
                }
                else if (item.Negocios04 == "3,571428571")
                {
                    item.Negocios04 = "3";
                }
                else if (item.Negocios04 == "5")
                {
                    item.Negocios04 = "4";
                }
                //parte5 GL
                if (item.Negocios05 == "0,714285714")
                {
                    item.Negocios05 = "1";
                }
                else if (item.Negocios05 == "1,785714286")
                {
                    item.Negocios05 = "2";
                }
                else if (item.Negocios05 == "3,571428571")
                {
                    item.Negocios05 = "3";
                }
                else if (item.Negocios05 == "5")
                {
                    item.Negocios05 = "4";
                }

                //parte6 GL
                if (item.Negocios06 == "0,714285714")
                {
                    item.Negocios06 = "1";
                }
                else if (item.Negocios06 == "1,785714286")
                {
                    item.Negocios06 = "2";
                }
                else if (item.Negocios06 == "3,571428571")
                {
                    item.Negocios06 = "3";
                }
                else if (item.Negocios06 == "5")
                {
                    item.Negocios06 = "4";
                }
                //parte7 GL
                if (item.Negocios07 == "0,714285714")
                {
                    item.Negocios07 = "1";
                }
                else if (item.Negocios07 == "1,785714286")
                {
                    item.Negocios07 = "2";
                }
                else if (item.Negocios07 == "3,571428571")
                {
                    item.Negocios07 = "3";
                }
                else if (item.Negocios07 == "5")
                {
                    item.Negocios07 = "4";
                }

                // Parte1 Assist Processos
                if (item.Processos08 == "1")
                {
                    item.Processos08 = "1";
                }               
                else if (item.Processos08 == "2,5")
                {
                    item.Processos08 = "2";
                }
                else if (item.Processos08 == "5")
                {
                    item.Processos08 = "3";
                }
                else if (item.Processos08 == "7")
                {
                    item.Processos08 = "4";
                }

                // Parte2 Assist Processos
                if (item.Processos09 == "1")
                {
                    item.Processos09 = "1";
                }
                else if (item.Processos09 == "2,5")
                {
                    item.Processos09 = "2";
                }
                else if (item.Processos09 == "5")
                {
                    item.Processos09 = "3";
                }
                else if (item.Processos09 == "7")
                {
                    item.Processos09 = "4";
                }
                // Parte3 Assist Processos
                if (item.Processos10 == "1")
                {
                    item.Processos10 = "1";
                }
                else if (item.Processos10 == "2,5")
                {
                    item.Processos10 = "2";
                }
                else if (item.Processos10 == "5")
                {
                    item.Processos10 = "3";
                }
                else if (item.Processos10 == "7")
                {
                    item.Processos10 = "4";
                }
                // Parte4 Assist Processos
                if (item.Processos11 == "1")
                {
                    item.Processos11 = "1";
                }
                else if (item.Processos11 == "2,5")
                {
                    item.Processos11 = "2";
                }
                else if (item.Processos11 == "5")
                {
                    item.Processos11 = "3";
                }
                else if (item.Processos11 == "7")
                {
                    item.Processos11 = "4";
                }
                // Parte5 Assist Processos
                if (item.Processos12 == "1")
                {
                    item.Processos12 = "1";
                }
                else if (item.Processos12 == "2,5")
                {
                    item.Processos12 = "2";
                }
                else if (item.Processos12 == "5")
                {
                    item.Processos12 = "3";
                }
                else if (item.Processos12 == "7")
                {
                    item.Processos12 = "4";
                }
                // Parte6 Assist Processos
                if (item.Processos13 == "1")
                {
                    item.Processos13 = "1";
                }
                else if (item.Processos13 == "2,5")
                {
                    item.Processos13 = "2";
                }
                else if (item.Processos13 == "5")
                {
                    item.Processos13 = "3";
                }
                else if (item.Processos13 == "7")
                {
                    item.Processos13 = "4";
                }

                // Parte1 Espec Processos
                if (item.Processos08 == "0,769230769")
                {
                    item.Processos08 = "1";
                }
                else if (item.Processos08 == "1,923076923")
                {
                    item.Processos08 = "2";
                }
                else if (item.Processos08 == "3,846153846")
                {
                    item.Processos08 = "3";
                }
                else if (item.Processos08 == "5,384615385")
                {
                    item.Processos08 = "4";
                }

                // Parte2 Espec Processos
                if (item.Processos09 == "0,769230769")
                {
                    item.Processos09 = "1";
                }
                else if (item.Processos09 == "1,923076923")
                {
                    item.Processos09 = "2";
                }
                else if (item.Processos09 == "3,846153846")
                {
                    item.Processos09 = "3";
                }
                else if (item.Processos09 == "5,384615385")
                {
                    item.Processos09 = "4";
                }
                // Parte3 Espec Processos
                if (item.Processos10 == "0,769230769")
                {
                    item.Processos10 = "1";
                }
                else if (item.Processos10 == "1,923076923")
                {
                    item.Processos10 = "2";
                }
                else if (item.Processos10 == "3,846153846")
                {
                    item.Processos10 = "3";
                }
                else if (item.Processos10 == "5,384615385")
                {
                    item.Processos10 = "4";
                }
                // Parte4 Espec Processos
                if (item.Processos11 == "0,769230769")
                {
                    item.Processos11 = "1";
                }
                else if (item.Processos11 == "1,923076923")
                {
                    item.Processos11 = "2";
                }
                else if (item.Processos11 == "3,846153846")
                {
                    item.Processos11 = "3";
                }
                else if (item.Processos11 == "5,384615385")
                {
                    item.Processos11 = "4";
                }
                // Parte5 Espec Processos
                if (item.Processos12 == "0,769230769")
                {
                    item.Processos12 = "1";
                }
                else if (item.Processos12 == "1,923076923")
                {
                    item.Processos12 = "2";
                }
                else if (item.Processos12 == "3,846153846")
                {
                    item.Processos12 = "3";
                }
                else if (item.Processos12 == "5,384615385")
                {
                    item.Processos12 = "4";
                }
                // Parte6 Espec Processos
                if (item.Processos13 == "0,769230769")
                {
                    item.Processos13 = "1";
                }
                else if (item.Processos13 == "1,923076923")
                {
                    item.Processos13 = "2";
                }
                else if (item.Processos13 == "3,846153846")
                {
                    item.Processos13 = "3";
                }
                else if (item.Processos13 == "5,384615385")
                {
                    item.Processos13 = "4";
                }

                // Parte1 Gestor Processos
                if (item.Processos08 == "0,588235294")
                {
                    item.Processos08 = "1";
                }
                else if (item.Processos08 == "1,470588235")
                {
                    item.Processos08 = "2";
                }
                else if (item.Processos08 == "2,941176471")
                {
                    item.Processos08 = "3";
                }
                else if (item.Processos08 == "4,117647059")
                {
                    item.Processos08 = "4";
                }

                // Parte2 Gestor Processos
                if (item.Processos09 == "0,588235294")
                {
                    item.Processos09 = "1";
                }
                else if (item.Processos09 == "1,470588235")
                {
                    item.Processos09 = "2";
                }
                else if (item.Processos09 == "2,941176471")
                {
                    item.Processos09 = "3";
                }
                else if (item.Processos09 == "4,117647059")
                {
                    item.Processos09 = "4";
                }
                // Parte3 Gestor Processos
                if (item.Processos10 == "0,588235294")
                {
                    item.Processos10 = "1";
                }
                else if (item.Processos10 == "1,470588235")
                {
                    item.Processos10 = "2";
                }
                else if (item.Processos10 == "2,941176471")
                {
                    item.Processos10 = "3";
                }
                else if (item.Processos10 == "4,117647059")
                {
                    item.Processos10 = "4";
                }
                // Parte4 Gestor Processos
                if (item.Processos11 == "0,588235294")
                {
                    item.Processos11 = "1";
                }
                else if (item.Processos11 == "1,470588235")
                {
                    item.Processos11 = "2";
                }
                else if (item.Processos11 == "2,941176471")
                {
                    item.Processos11 = "3";
                }
                else if (item.Processos11 == "4,117647059")
                {
                    item.Processos11 = "4";
                }
                // Parte5 Gestor Processos
                if (item.Processos12 == "0,588235294")
                {
                    item.Processos12 = "1";
                }
                else if (item.Processos12 == "1,470588235")
                {
                    item.Processos12 = "2";
                }
                else if (item.Processos12 == "2,941176471")
                {
                    item.Processos12 = "3";
                }
                else if (item.Processos12 == "4,117647059")
                {
                    item.Processos12 = "4";
                }
                // Parte6 Gestor Processos
                if (item.Processos13 == "0,588235294")
                {
                    item.Processos13 = "1";
                }
                else if (item.Processos13 == "1,470588235")
                {
                    item.Processos13 = "2";
                }
                else if (item.Processos13 == "2,941176471")
                {
                    item.Processos13 = "3";
                }
                else if (item.Processos13 == "4,117647059")
                {
                    item.Processos13 = "4";
                }

                // Parte1 GL Processos
                if (item.Processos08 == "0,714285714")
                {
                    item.Processos08 = "1";
                }
                else if (item.Processos08 == "1,785714286")
                {
                    item.Processos08 = "2";
                }
                else if (item.Processos08 == "3,571428571")
                {
                    item.Processos08 = "3";
                }
                else if (item.Processos08 == "5")
                {
                    item.Processos08 = "4";
                }

                // Parte2 GL Processos
                if (item.Processos09 == "0,714285714")
                {
                    item.Processos09 = "1";
                }
                else if (item.Processos09 == "1,785714286")
                {
                    item.Processos09 = "2";
                }
                else if (item.Processos09 == "3,571428571")
                {
                    item.Processos09 = "3";
                }
                else if (item.Processos09 == "5")
                {
                    item.Processos09 = "4";
                }
                // Parte3 GL Processos
                if (item.Processos10 == "0,714285714")
                {
                    item.Processos10 = "1";
                }
                else if (item.Processos10 == "1,785714286")
                {
                    item.Processos10 = "2";
                }
                else if (item.Processos10 == "3,571428571")
                {
                    item.Processos10 = "3";
                }
                else if (item.Processos10 == "5")
                {
                    item.Processos10 = "4";
                }
                // Parte4 GL Processos
                if (item.Processos11 == "0,714285714")
                {
                    item.Processos11 = "1";
                }
                else if (item.Processos11 == "1,785714286")
                {
                    item.Processos11 = "2";
                }
                else if (item.Processos11 == "3,571428571")
                {
                    item.Processos11 = "3";
                }
                else if (item.Processos11 == "5")
                {
                    item.Processos11 = "4";
                }
                // Parte5 GL Processos
                if (item.Processos12 == "0,714285714")
                {
                    item.Processos12 = "1";
                }
                else if (item.Processos12 == "1,785714286")
                {
                    item.Processos12 = "2";
                }
                else if (item.Processos12 == "3,571428571")
                {
                    item.Processos12 = "3";
                }
                else if (item.Processos12 == "5")
                {
                    item.Processos12 = "4";
                }
                // Parte6 GL Processos
                if (item.Processos13 == "0,714285714")
                {
                    item.Processos13 = "1";
                }
                else if (item.Processos13 == "1,785714286")
                {
                    item.Processos13 = "2";
                }
                else if (item.Processos13 == "3,571428571")
                {
                    item.Processos13 = "3";
                }
                else if (item.Processos13 == "5")
                {
                    item.Processos13 = "4";
                }

                //parte 1 Pessoas Operador

                if (item.Pessoas14 == "1")
                {
                    item.Pessoas14 = "1";
                }
                else if (item.Pessoas14 == "2,5")
                {
                    item.Pessoas14 = "2";
                }
                else if (item.Pessoas14 == "5")
                {
                    item.Pessoas14 = "3";
                }
                else if (item.Pessoas14 == "7")
                {
                    item.Pessoas14 = "4";
                }

                // parte 2 Pessoas Operador

                if (item.Pessoas15 == "1")
                {
                    item.Pessoas15 = "1";
                }
                else if (item.Pessoas15 == "2,5")
                {
                    item.Pessoas15 = "2";
                }
                else if (item.Pessoas15 == "5")
                {
                    item.Pessoas15 = "3";
                }
                else if (item.Pessoas15 == "7")
                {
                    item.Pessoas15 = "4";
                }

                // parte 3 Pessoas Operador

                if (item.Pessoas16 == "1")
                {
                    item.Pessoas16 = "1";
                }
                else if (item.Pessoas16 == "2,5")
                {
                    item.Pessoas16 = "2";
                }
                else if (item.Pessoas16 == "5")
                {
                    item.Pessoas16 = "3";
                }
                else if (item.Pessoas16 == "7")
                {
                    item.Pessoas16 = "4";
                }

                // parte4 Pessoas Operador
                if (item.Pessoas17 == "1")
                {
                    item.Pessoas17 = "1";
                }
                else if (item.Pessoas17 == "2,5")
                {
                    item.Pessoas17 = "2";
                }
                else if (item.Pessoas17 == "5")
                {
                    item.Pessoas17 = "3";
                }
                else if (item.Pessoas17 == "7")
                {
                    item.Pessoas17 = "4";
                }
                //parte5 Pessoas Operador
                if (item.Pessoas18 == "1")
                {
                    item.Pessoas18 = "1";
                }
                else if (item.Pessoas18 == "2,5")
                {
                    item.Pessoas18 = "2";
                }
                else if (item.Pessoas18 == "5")
                {
                    item.Pessoas18 = "3";
                }
                else if (item.Pessoas18 == "7")
                {
                    item.Pessoas18 = "4";
                }
                //parte6 Pessoas Operador
                if (item.Pessoas19 == "1")
                {
                    item.Pessoas19 = "1";
                }
                else if (item.Pessoas19 == "2,5")
                {
                    item.Pessoas19 = "2";
                }
                else if (item.Pessoas19 == "5")
                {
                    item.Pessoas19 = "3";
                }
                else if (item.Pessoas19 == "7")
                {
                    item.Pessoas19 = "4";
                }
                //parte7 Pessoas Operador
                if (item.Pessoas20 == "1")
                {
                    item.Pessoas20 = "1";
                }
                else if (item.Pessoas20 == "2,5")
                {
                    item.Pessoas20 = "2";
                }
                else if (item.Pessoas20 == "5")
                {
                    item.Pessoas20 = "3";
                }
                else if (item.Pessoas20 == "7")
                {
                    item.Pessoas20 = "4";
                }
                //parte 1 Pessoas Espec

                if (item.Pessoas14 == "0,769230769")
                {
                    item.Pessoas14 = "1";
                }
                else if (item.Pessoas14 == "1,923076923")
                {
                    item.Pessoas14 = "2";
                }
                else if (item.Pessoas14 == "3,846153846")
                {
                    item.Pessoas14 = "3";
                }
                else if (item.Pessoas14 == "5,384615385")
                {
                    item.Pessoas14 = "4";
                }

                // parte 2 Pessoas Espec

                if (item.Pessoas15 == "0,769230769")
                {
                    item.Pessoas15 = "1";
                }
                else if (item.Pessoas15 == "1,923076923")
                {
                    item.Pessoas15 = "2";
                }
                else if (item.Pessoas15 == "3,846153846")
                {
                    item.Pessoas15 = "3";
                }
                else if (item.Pessoas15 == "5,384615385")
                {
                    item.Pessoas15 = "4";
                }

                // parte 3 Pessoas Espec

                if (item.Pessoas16 == "0,769230769")
                {
                    item.Pessoas16 = "1";
                }
                else if (item.Pessoas16 == "1,923076923")
                {
                    item.Pessoas16 = "2";
                }
                else if (item.Pessoas16 == "3,846153846")
                {
                    item.Pessoas16 = "3";
                }
                else if (item.Pessoas16 == "5,384615385")
                {
                    item.Pessoas16 = "4";
                }
                // parte4 Pessoas Espec
                if (item.Pessoas17 == "0,769230769")
                {
                    item.Pessoas17 = "1";
                }
                else if (item.Pessoas17 == "1,923076923")
                {
                    item.Pessoas17 = "2";
                }
                else if (item.Pessoas17 == "3,846153846")
                {
                    item.Pessoas17 = "3";
                }
                else if (item.Pessoas17 == "5,384615385")
                {
                    item.Pessoas17 = "4";
                }
                //parte5 Pessoas Espec
                if (item.Pessoas18 == "0,769230769")
                {
                    item.Pessoas18 = "1";
                }
                else if (item.Pessoas18 == "1,923076923")
                {
                    item.Pessoas18 = "2";
                }
                else if (item.Pessoas18 == "3,846153846")
                {
                    item.Pessoas18 = "3";
                }
                else if (item.Pessoas18 == "5,384615385")
                {
                    item.Pessoas18 = "4";
                }
                //parte6 Pessoas Espec
                if (item.Pessoas19 == "0,769230769")
                {
                    item.Pessoas19 = "1";
                }
                else if (item.Pessoas19 == "1,923076923")
                {
                    item.Pessoas19 = "2";
                }
                else if (item.Pessoas19 == "3,846153846")
                {
                    item.Pessoas19 = "3";
                }
                else if (item.Pessoas19 == "5,384615385")
                {
                    item.Pessoas19 = "4";
                }
                //parte7 Pessoas Espec
                if (item.Pessoas20 == "0,769230769")
                {
                    item.Pessoas20 = "1";
                }
                else if (item.Pessoas20 == "1,923076923")
                {
                    item.Pessoas20 = "2";
                }
                else if (item.Pessoas20 == "3,846153846")
                {
                    item.Pessoas20 = "3";
                }
                else if (item.Pessoas20 == "5,384615385")
                {
                    item.Pessoas20 = "4";
                }
                //parte 1 Pessoas Gestor
                if (item.Pessoas14 == "0,588235294")
                {
                    item.Pessoas14 = "1";
                }
                else if (item.Pessoas14 == "1,470588235")
                {
                    item.Pessoas14 = "2";
                }
                else if (item.Pessoas14 == "2,941176471")
                {
                    item.Pessoas14 = "3";
                }
                else if (item.Pessoas14 == "4,117647059")
                {
                    item.Pessoas14 = "4";
                }
                // parte 2 Pessoas Gestor
                if (item.Pessoas15 == "0,588235294")
                {
                    item.Pessoas15 = "1";
                }
                else if (item.Pessoas15 == "1,470588235")
                {
                    item.Pessoas15 = "2";
                }
                else if (item.Pessoas15 == "2,941176471")
                {
                    item.Pessoas15 = "3";
                }
                else if (item.Pessoas15 == "4,117647059")
                {
                    item.Pessoas15 = "4";
                }
                // parte 3 Pessoas Gestor
                if (item.Pessoas16 == "0,588235294")
                {
                    item.Pessoas16 = "1";
                }
                else if (item.Pessoas16 == "1,470588235")
                {
                    item.Pessoas16 = "2";
                }
                else if (item.Pessoas16 == "2,941176471")
                {
                    item.Pessoas16 = "3";
                }
                else if (item.Pessoas16 == "4,117647059")
                {
                    item.Pessoas16 = "4";
                }
                // parte4 Pessoas Gestor
                if (item.Pessoas17 == "0,588235294")
                {
                    item.Pessoas17 = "1";
                }
                else if (item.Pessoas17 == "1,470588235")
                {
                    item.Pessoas17 = "2";
                }
                else if (item.Pessoas17 == "2,941176471")
                {
                    item.Pessoas17 = "3";
                }
                else if (item.Pessoas17 == "4,117647059")
                {
                    item.Pessoas17 = "4";
                }
                //parte5 Pessoas Gestor
                if (item.Pessoas18 == "0,588235294")
                {
                    item.Pessoas18 = "1";
                }
                else if (item.Pessoas18 == "1,470588235")
                {
                    item.Pessoas18 = "2";
                }
                else if (item.Pessoas18 == "2,941176471")
                {
                    item.Pessoas18 = "3";
                }
                else if (item.Pessoas18 == "4,117647059")
                {
                    item.Pessoas18 = "4";
                }
                //parte6 Pessoas Gestor
                if (item.Pessoas19 == "0,588235294")
                {
                    item.Pessoas19 = "1";
                }
                else if (item.Pessoas19 == "1,470588235")
                {
                    item.Pessoas19 = "2";
                }
                else if (item.Pessoas19 == "2,941176471")
                {
                    item.Pessoas19 = "3";
                }
                else if (item.Pessoas19 == "4,117647059")
                {
                    item.Pessoas19 = "4";
                }
                //parte7 Pessoas Gestor
                if (item.Pessoas20 == "0,588235294")
                {
                    item.Pessoas20 = "1";
                }
                else if (item.Pessoas20 == "1,470588235")
                {
                    item.Pessoas20 = "2";
                }
                else if (item.Pessoas20 == "2,941176471")
                {
                    item.Pessoas20 = "3";
                }
                else if (item.Pessoas20 == "4,117647059")
                {
                    item.Pessoas20 = "4";
                }
                //parte 1 Pessoas GL
                if (item.Pessoas14 == "0,714285714")
                {
                    item.Pessoas14 = "1";
                }
                else if (item.Pessoas14 == "1,785714286")
                {
                    item.Pessoas14 = "2";
                }
                else if (item.Pessoas14 == "3,571428571")
                {
                    item.Pessoas14 = "3";
                }
                else if (item.Pessoas14 == "5")
                {
                    item.Pessoas14 = "4";
                }

                // parte 2 Pessoas GL

                if (item.Pessoas15 == "0,714285714")
                {
                    item.Pessoas15 = "1";
                }
                else if (item.Pessoas15 == "1,785714286")
                {
                    item.Pessoas15 = "2";
                }
                else if (item.Pessoas15 == "3,571428571")
                {
                    item.Pessoas15 = "3";
                }
                else if (item.Pessoas15 == "5")
                {
                    item.Pessoas15 = "4";
                }
                // parte 3 Pessoas GL
                if (item.Pessoas16 == "0,714285714")
                {
                    item.Pessoas16 = "1";
                }
                else if (item.Pessoas16 == "1,785714286")
                {
                    item.Pessoas16 = "2";
                }
                else if (item.Pessoas16 == "3,571428571")
                {
                    item.Pessoas16 = "3";
                }
                else if (item.Pessoas16 == "5")
                {
                    item.Pessoas16 = "4";
                }
                // parte4 Pessoas GL
                if (item.Pessoas17 == "0,714285714")
                {
                    item.Pessoas17 = "1";
                }
                else if (item.Pessoas17 == "1,785714286")
                {
                    item.Pessoas17 = "2";
                }
                else if (item.Pessoas17 == "3,571428571")
                {
                    item.Pessoas17 = "3";
                }
                else if (item.Pessoas17 == "5")
                {
                    item.Pessoas17 = "4";
                }
                //parte5 Pessoas GL
                if (item.Pessoas18 == "0,714285714")
                {
                    item.Pessoas18 = "1";
                }
                else if (item.Pessoas18 == "1,785714286")
                {
                    item.Pessoas18 = "2";
                }
                else if (item.Pessoas18 == "3,571428571")
                {
                    item.Pessoas18 = "3";
                }
                else if (item.Pessoas18 == "5")
                {
                    item.Pessoas18 = "4";
                }
                //parte6 Pessoas GL
                if (item.Pessoas19 == "0,714285714")
                {
                    item.Pessoas19 = "1";
                }
                else if (item.Pessoas19 == "1,785714286")
                {
                    item.Pessoas19 = "2";
                }
                else if (item.Pessoas19 == "3,571428571")
                {
                    item.Pessoas19 = "3";
                }
                else if (item.Pessoas19 == "5")
                {
                    item.Pessoas19 = "4";
                }
                //parte7 Pessoas GL
                if (item.Pessoas20 == "0,714285714")
                {
                    item.Pessoas20 = "1";
                }
                else if (item.Pessoas20 == "1,785714286")
                {
                    item.Pessoas20 = "2";
                }
                else if (item.Pessoas20 == "3,571428571")
                {
                    item.Pessoas20 = "3";
                }
                else if (item.Pessoas20 == "5")
                {
                    item.Pessoas20 = "4";
                }
                                      
                // parte1 Metas Estrategico
                if (item.Nivel_Estrategico_01 == "8,333333333")
                {
                    item.Nivel_Estrategico_01 = "1";
                }
                else if (item.Nivel_Estrategico_01 == "16,66666667")
                {
                    item.Nivel_Estrategico_01 = "2";
                }
                else if (item.Nivel_Estrategico_01 == "25")
                {
                    item.Nivel_Estrategico_01 = "3";
                }
                else if (item.Nivel_Estrategico_01 == "33,33333333")
                {
                    item.Nivel_Estrategico_01 = "4";
                }
                // parte2 Metas Assist
                if (item.Nivel_Estrategico_02 == "8,333333333")
                {
                    item.Nivel_Estrategico_02 = "1";
                }
                else if (item.Nivel_Estrategico_02 == "16,66666667")
                {
                    item.Nivel_Estrategico_02 = "2";
                }
                else if (item.Nivel_Estrategico_02 == "25")
                {
                    item.Nivel_Estrategico_02 = "3";
                }
                else if (item.Nivel_Estrategico_02 == "33,33333333")
                {
                    item.Nivel_Estrategico_02 = "4";
                }
                // parte3 Metas Assist
                if (item.Nivel_Estrategico_03 == "8,333333333")
                {
                    item.Nivel_Estrategico_03 = "1";
                }
                else if (item.Nivel_Estrategico_03 == "16,66666667")
                {
                    item.Nivel_Estrategico_03 = "2";
                }
                else if (item.Nivel_Estrategico_03 == "25")
                {
                    item.Nivel_Estrategico_03 = "3";
                }
                else if (item.Nivel_Estrategico_03 == "33,33333333")
                {
                    item.Nivel_Estrategico_03 = "4";
                }

               

            }

            return Lista;

        }

        public List<RecursosHumanosModel> ListaCargo()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            // string Nome = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"SELECT b.Data AS Cargo_Junior,b.NomeGestor ,b.Matricula,b.Avaliador,b.Veiculo_proprio,b.CNH_Valida,b.habilidade_em_dirigir,b.Operador_de_Empilhadeira,b.Tecnico_completo, b.Superior_completo,b.Pos_graduação_completo as Pos_Graduacao,b.Pos_graduacao_MBA_CURSANDO as Pos_MBA,b.Ingles_basico,b.Ingles_basico_CURSANDO,b.Ingles_intermediario, b.Ingles_intermediario_CURSANDO,b.Flexibilidade_horario,b.Job_Rotation,b.Pacote_Office_basico,b.Pacotte_Office_intermediario, c.`Data`AS Cargo_Pleno, c.NomeGestor,c.Matricula,c.Avaliador,c.Veiculo_proprio,c.CNH_Valida,c.habilidade_em_dirigir,c.Operador_de_Empilhadeira,c.Tecnico_completo,c.Superior_completo, c.Superior_completo,c.`Pos_graduação_completo`,c.Pos_graduacao_MBA_COMPLETO,c.Ingles_basico,c.Ingles_basico_CURSANDO,c.Ingles_intermediario,c.Ingles_Avancado_CURSANDO, c.Flexibilidade_horario,c.Mudanca_residencia,c.Job_Rotation,c.Pacote_Office_basico,c.Pacote_Office_Avancado,c.Pacote_Office_intermediario, d.`Data`AS Cargo_Senior, d.NomeGestor,d.Matricula,d.Avaliador,d.Veiculo_proprio,d.CNH_Valida,d.habilidade_em_dirigir,d.Operador_de_Empilhadeira,d.Tecnico_completo,d.Superior_completo, d.`Pos_graduação_completo`,d.Pos_graduacao_MBA_COMPLETO,d.Pos_graduacao_MBA_CURSANDO as Pos_MBA_CURSANDO, d.Ingles_basico,d.Ingles_basico_CURSANDO,d.Ingles_intermediario,d.Ingles_intermediario_CURSANDO, d.Ingles_Avancado_COMPLETO,d.Flexibilidade_horario,d.Mudanca_residencia,d.Job_Rotation,d.Pacote_Office_basico,d.Pacote_Office_Avancado,d.Pacote_Office_intermediario FROM usuario a left JOIN requisitocargo b ON b.Matricula = a.Matricula left JOIN requisitocargo_pleno c ON c.Matricula = a.Matricula left JOIN requisitocargo_senior d ON d.Matricula = .a.Matricula WHERE a.`Status` = 'Já Avaliado' ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Cargo Junior
                item = new RecursosHumanosModel();
                item.Data = dt.Rows[i]["Cargo_Junior"].ToString();
                item.NomeGestor = dt.Rows[i]["NomeGestor"].ToString();
                item.Matricula = dt.Rows[i]["Matricula"].ToString();
                item.Avaliador = dt.Rows[i]["Avaliador"].ToString();
                item.Veiculo_proprio = dt.Rows[i]["Veiculo_proprio"].ToString();
                item.CNH_Valida = dt.Rows[i]["CNH_Valida"].ToString();
                item.habilidade_em_dirigir = dt.Rows[i]["habilidade_em_dirigir"].ToString();
                item.Operador_de_Empilhadeira = dt.Rows[i]["Operador_de_Empilhadeira"].ToString();
                item.tecnico_completo = dt.Rows[i]["tecnico_completo"].ToString();
                item.Superior_completo = dt.Rows[i]["Superior_completo"].ToString();
                item.Pos_graduação_completo = dt.Rows[i]["Pos_Graduacao"].ToString();
                item.Pos_graduação_MBA_CURSANDO = dt.Rows[i]["Pos_MBA"].ToString();
                item.Ingles_basico = dt.Rows[i]["Ingles_basico"].ToString();
                item.Ingles_basico_CURSANDO = dt.Rows[i]["Ingles_basico_CURSANDO"].ToString();
                item.Ingles_intermediario = dt.Rows[i]["Ingles_intermediario"].ToString();
                item.Ingles_intermediario_CURSANDO = dt.Rows[i]["Ingles_intermediario_CURSANDO"].ToString();
                item.flexibilidade_horario = dt.Rows[i]["flexibilidade_horario"].ToString();
                item.Mudanca_residencia = dt.Rows[i]["Mudanca_residencia"].ToString();
                item.Job_rotation = dt.Rows[i]["Job_rotation"].ToString();
                item.Pacote_Office_basico = dt.Rows[i]["Pacote_Office_basico"].ToString();
                item.Pacote_Office_intermediario = dt.Rows[i]["Pacote_Office_intermediario"].ToString();

                // Cargo Pleno

                item = new RecursosHumanosModel();
                item.Data = dt.Rows[i]["Cargo_Pleno"].ToString();
                item.NomeGestor = dt.Rows[i]["NomeGestor"].ToString();
                item.Matricula = dt.Rows[i]["Matricula"].ToString();
                item.Avaliador = dt.Rows[i]["Avaliador"].ToString();
                item.Veiculo_proprio = dt.Rows[i]["Veiculo_proprio"].ToString();
                item.CNH_Valida = dt.Rows[i]["CNH_Valida"].ToString();
                item.habilidade_em_dirigir = dt.Rows[i]["habilidade_em_dirigir"].ToString();
                item.Operador_de_Empilhadeira = dt.Rows[i]["Operador_de_Empilhadeira"].ToString();
                item.tecnico_completo = dt.Rows[i]["tecnico_completo"].ToString();
                item.Superior_completo = dt.Rows[i]["Superior_completo"].ToString();
                item.Pos_graduação_completo = dt.Rows[i]["Pos_Graduacao"].ToString();
                item.Pos_graduação_MBA_COMPLETO = dt.Rows[i]["Pos_MBA"].ToString();
                item.Ingles_basico = dt.Rows[i]["Ingles_basico"].ToString();
                item.Ingles_basico_CURSANDO = dt.Rows[i]["Ingles_basico_CURSANDO"].ToString();
                item.Ingles_intermediario = dt.Rows[i]["Ingles_intermediario"].ToString();
                item.Ingles_Avancado_CURSANDO = dt.Rows[i]["Ingles_Avancado_CURSANDO"].ToString();
                item.flexibilidade_horario = dt.Rows[i]["flexibilidade_horario"].ToString();
                item.Mudanca_residencia = dt.Rows[i]["Mudanca_residencia"].ToString();
                item.Job_rotation = dt.Rows[i]["Job_rotation"].ToString();
                item.Pacote_Office_basico = dt.Rows[i]["Pacote_Office_basico"].ToString();
                item.Pacote_Office_intermediario = dt.Rows[i]["Pacote_Office_intermediario"].ToString();
                item.Pacote_Office_Avancado = dt.Rows[i]["Pacote_Office_Avancado"].ToString();

                // Cargo Senior
                item = new RecursosHumanosModel();
                item.Data = dt.Rows[i]["Cargo_Senior"].ToString();
                item.NomeGestor = dt.Rows[i]["NomeGestor"].ToString();
                item.Matricula = dt.Rows[i]["Matricula"].ToString();
                item.Avaliador = dt.Rows[i]["Avaliador"].ToString();
                item.Veiculo_proprio = dt.Rows[i]["Veiculo_proprio"].ToString();
                item.CNH_Valida = dt.Rows[i]["CNH_Valida"].ToString();
                item.habilidade_em_dirigir = dt.Rows[i]["habilidade_em_dirigir"].ToString();
                item.Operador_de_Empilhadeira = dt.Rows[i]["Operador_de_Empilhadeira"].ToString();
                item.tecnico_completo = dt.Rows[i]["tecnico_completo"].ToString();
                item.Superior_completo = dt.Rows[i]["Superior_completo"].ToString();
                item.Pos_graduação_completo = dt.Rows[i]["Pos_Graduacao"].ToString();
                item.Pos_graduação_MBA_COMPLETO = dt.Rows[i]["Pos_MBA"].ToString();
                item.Pos_graduação_MBA_CURSANDO = dt.Rows[i]["Pos_MBA_CURSANDO"].ToString();
                item.Ingles_basico = dt.Rows[i]["Ingles_basico"].ToString();
                item.Ingles_basico_CURSANDO = dt.Rows[i]["Ingles_basico_CURSANDO"].ToString();
                item.Ingles_intermediario = dt.Rows[i]["Ingles_intermediario"].ToString();
                item.Ingles_intermediario_CURSANDO = dt.Rows[i]["Ingles_intermediario_CURSANDO"].ToString();
                item.Ingles_Avancado_COMPLETO = dt.Rows[i]["Ingles_Avancado_COMPLETO"].ToString();
                item.flexibilidade_horario = dt.Rows[i]["flexibilidade_horario"].ToString();
                item.Mudanca_residencia = dt.Rows[i]["Mudanca_residencia"].ToString();
                item.Job_rotation = dt.Rows[i]["Job_rotation"].ToString();
                item.Pacote_Office_basico = dt.Rows[i]["Pacote_Office_basico"].ToString();
                item.Pacote_Office_intermediario = dt.Rows[i]["Pacote_Office_intermediario"].ToString();
                item.Pacote_Office_Avancado = dt.Rows[i]["Pacote_Office_Avancado"].ToString();



            }

            return Lista;

        }
        public List<RecursosHumanosModel> ListaMetas()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            // string Nome = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"SELECT Data,NomeGestor,Matricula,Avaliador,Nivel_Estrategico_01,Nivel_Estrategico_02,Nivel_Estrategico_03 FROM metas";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Data = dt.Rows[i]["Data"].ToString();
                item.NomeGestor = dt.Rows[i]["NomeGestor"].ToString();
                item.Matricula = dt.Rows[i]["Matricula"].ToString();
                item.Avaliador = dt.Rows[i]["Avaliador"].ToString();
                item.Nivel_Estrategico_01 = dt.Rows[i]["Nivel_Estrategico_01"].ToString();
                item.Nivel_Estrategico_02 = dt.Rows[i]["Nivel_Estrategico_02"].ToString();
                item.Nivel_Estrategico_03 = dt.Rows[i]["Nivel_Estrategico_03"].ToString();
            
            }

            return Lista;

        }

        public List<RecursosHumanosModel> ListaUsuario()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            // string Nome = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"select Matricula,Nome, Gestor,Unidade from usuario ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Matricula = dt.Rows[i]["Matricula"].ToString();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.NomeGestor = dt.Rows[i]["Gestor"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                Lista.Add(item);
            }

            return Lista;

        }

        public List<RecursosHumanosModel> ListaNineBox()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            // string id_usuario_logado = HttpContextAccessor.HttpContext.Session.GetString("IdUsuarioLogado");
            string sql = $"select a.Matricula,b.Nome, round( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios04 + a.Negocios05) / 52 * 40 as Total_Competencias from questionario a , usuario b where a.Matricula = b.Matricula";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                Lista.Add(item);
            }

            return Lista;

        }

     
        public List<RecursosHumanosModel> NineGl(string txtColaboradorNine)
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            // string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"select b.Nome,b.Unidade,b.NomeGestor,b.Cargo, round( a.pessoas15 + a.pessoas16 + a.pessoas17 + a.pessoas19 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 +  a.Negocios06 +  a.Negocios07 + c.Carro_proprio + c.CNH + c.Pos_graduacao_MBA + c.Ingles_basico + c.Excel_basico, -1) as Total_Competencias from questionario a , usuario b,requisitocargo c where a.Matricula = b.Matricula  and a.Matricula='{txtColaboradorNine}' and a.status='Já Avaliado' AND a.NomeGestor = c.Avaliador ";
            string sqsl = $"SELECT b.Nome, round(a.Nivel_Tatico_01 + a.Nivel_Tatico_02 + a.Nivel_Tatico_03, -1) as Total  from metas a , usuario b,requisitocargo c where a.Matricula = b.Matricula  and a.Matricula='{txtColaboradorNine}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;

        }


        // NineBox para o Cargo de Supervisor Junior
        public List<RecursosHumanosModel> NineSvJunior()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir + c.Pos_graduacao_MBA_CURSANDO + c.Ingles_intermediario + c.Flexibilidade_horario + c.Mudanca_residencia + c.Job_Rotation + c.Pacote_Office_intermediario, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo c where a.Matricula = '{Nomes}' and b.Matricula='{Nomes}'  AND c.Matricula='{Nomes}' AND a.`Status`= 'Já Avaliado' AND a.NomeGestor = c.Avaliador ";
            string sqsl = $"SELECT b.Nome, round(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }

        // NineBox para o Cargo de Supervisor Pleno
        public List<RecursosHumanosModel> NineSvPleno()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir + c.Superior_completo + c.Pos_graduacao_MBA_COMPLETO + c.Ingles_Avancado_CURSANDO + c.Flexibilidade_horario + c.Mudanca_residencia + c.Job_Rotation + c.Pacote_Office_Avancado, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo_pleno c where a.Matricula = '{Nomes}' and b.Matricula='{Nomes}'  AND c.Matricula='{Nomes}' AND a.`Status`= 'Já Avaliado' AND a.NomeGestor = c.Avaliador";
            string sqsl = $"SELECT b.Nome, round(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo_pleno c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }

        // NineBox para o Cargo de Supervisor Senior
        public List<RecursosHumanosModel> NineSvSenior()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir + c.Superior_completo + c.Pos_graduacao_MBA_COMPLETO + c.Ingles_Avancado_COMPLETO + c.Flexibilidade_horario + c.Mudanca_residencia + c.Job_Rotation + c.Pacote_Office_Avancado, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo_senior c where a.Matricula = '{Nomes}' and b.Matricula='{Nomes}'  AND c.Matricula='{Nomes}' AND a.`Status`= 'Já Avaliado' AND a.NomeGestor = c.Avaliador";
            string sqsl = $"SELECT b.Nome, round(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo_senior c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }

        // NineBox para o Cargo de Coordenador Junior
        public List<RecursosHumanosModel> NineCoordJunior()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir + c.Superior_completo  + c.`Ingles_intermediario_CURSANDO` + c.Flexibilidade_horario + c.Mudanca_residencia + c.Job_Rotation + c.Pacote_Office_intermediario, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo c where a.Matricula = '{Nomes}' and b.Matricula='{Nomes}'  AND c.Matricula='{Nomes}' AND a.`Status`= 'Já Avaliado' AND a.NomeGestor = c.Avaliador ";
            string sqsl = $"SELECT b.Nome, round(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }


        // NineBox para o Cargo de Coordenador Pleno
        public List<RecursosHumanosModel> NineCoordPleno()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir + c.Superior_completo  + c.Ingles_intermediario + c.Flexibilidade_horario + c.Mudanca_residencia + c.Job_Rotation + c.Pacote_Office_intermediario, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo_pleno c where a.Matricula = '{Nomes}' and b.Matricula='{Nomes}'  AND c.Matricula='{Nomes}' AND a.`Status`= 'Já Avaliado' AND a.NomeGestor = c.Avaliador";
            string sqsl = $"SELECT b.Nome, round(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo_pleno c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }

        // NineBox para o Cargo de Coordenador Senior
        public List<RecursosHumanosModel> NineCoordSenior()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir + c.Superior_completo  + c.Pos_graduacao_MBA_CURSANDO + c.Ingles_intermediario + c.Flexibilidade_horario + c.Mudanca_residencia + c.Job_Rotation + c.Pacote_Office_intermediario, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo_senior c where a.Matricula = '{Nomes}' and b.Matricula='{Nomes}'  AND c.Matricula='{Nomes}' AND a.`Status`= 'Já Avaliado' AND a.NomeGestor = c.Avaliador";
            string sqsl = $"SELECT b.Nome, round(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo_senior c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }

        // NineBox para o Cargo de Analista Junior
        public List<RecursosHumanosModel> NineAnalistaJunior()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir  + c.Superior_completo + c.Pacote_Office_intermediario + c.Flexibilidade_horario + c.Mudanca_residencia +  c.Job_Rotation   + c.Ingles_basico, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' and a.status='Já Avaliado'  AND a.NomeGestor = c.Avaliador ";
            string sqsl = $"SELECT b.Nome, ROUND(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }
        // NineBox para o Cargo de Analista Pleno
        public List<RecursosHumanosModel> NineAnalistaPleno()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir  + c.Superior_completo + c.Pacote_Office_intermediario + c.Flexibilidade_horario + c.Mudanca_residencia +  c.Job_Rotation   + c.Ingles_basico_CURSANDO, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo_pleno c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' and a.status='Já Avaliado'  AND a.NomeGestor = c.Avaliador  ";
            string sqsl = $"SELECT b.Nome, ROUND(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo_pleno c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }

        // NineBox para o Cargo de Analista Senior
        public List<RecursosHumanosModel> NineAnalistaSenior()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir  + c.Superior_completo + c.Pacote_Office_intermediario + c.Flexibilidade_horario + c.Mudanca_residencia +  c.Job_Rotation   + c.Ingles_intermediario_CURSANDO, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo_senior c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' and a.status='Já Avaliado'  AND a.NomeGestor = c.Avaliador ";
            string sqsl = $"SELECT b.Nome, ROUND(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo_senior c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }


        // NineBox para o Cargo de Encarregado Junior
        public List<RecursosHumanosModel> NineEncarregadoJunior()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir  + c.Superior_completo + c.Pacote_Office_intermediario + c.Flexibilidade_horario + c.Mudanca_residencia +  c.Job_Rotation   + c.Ingles_basico, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' and a.status='Já Avaliado'  AND a.NomeGestor = c.Avaliador ";
            string sqsl = $"SELECT b.Nome, round(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }

        // NineBox para o Cargo de Encarregado Pleno
        public List<RecursosHumanosModel> NineEncarregadoPleno()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir  + c.Superior_completo + c.Pacote_Office_intermediario + c.Flexibilidade_horario + c.Mudanca_residencia +  c.Job_Rotation   + c.Ingles_basico_CURSANDO, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo_pleno c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' and a.status='Já Avaliado'  AND a.NomeGestor = c.Avaliador ";
            string sqsl = $"SELECT b.Nome, round(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo_pleno c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }

        // NineBox para o Cargo de Encarregado Senior
        public List<RecursosHumanosModel> NineEncarregadoSenior()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir  + c.Superior_completo + c.Pacote_Office_intermediario + c.Flexibilidade_horario + c.Mudanca_residencia +  c.Job_Rotation   + c.Ingles_intermediario_CURSANDO, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo_senior c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' and a.status='Já Avaliado'  AND a.NomeGestor = c.Avaliador ";
            string sqsl = $"SELECT b.Nome, round(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo_senior c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }





        public List<RecursosHumanosModel> NineEspec()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome,b.Unidade,b.Gestor,b.Cargo, ROUND( a.pessoas16 + a.pessoas17 + a.pessoas20 + a.Processos08 + a.Processos09 + a.Processos10 + a.Processos11 + a.Processos13 + a.Negocios01 + a.Negocios02 + a.Negocios03 + a.Negocios06 + a.Negocios07 + c.Veiculo_proprio + c.CNH_Valida + c.habilidade_em_dirigir  + c.Superior_completo + c.`Pos_graduação_completo` + c.Pacote_Office_basico + c.Flexibilidade_horario + c.Mudanca_residencia +  c.Job_Rotation   + c.Ingles_intermediario, -1)  AS Total_Competencias from questionario a , usuario b, requisitocargo c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' and a.status='Já Avaliado'  AND a.NomeGestor = c.Avaliador ";
            string sqsl = $"SELECT b.Nome, ROUND(a.Nivel_Estrategico_01 + a.Nivel_Estrategico_02 + a.Nivel_Estrategico_03, -1) as Total  from metas a , usuario b, requisitocargo c where a.Matricula = b.Matricula and a.Matricula='{Nomes}' AND a.Avaliador = c.NomeGestor ";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);
            DataTable dr = objDAL.RetDataTable(sqsl);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Unidade = dt.Rows[i]["Unidade"].ToString();
                item.Total_Competencias = dt.Rows[i]["Total_Competencias"].ToString();
                item.Total = dr.Rows[i]["Total"].ToString();

                Lista.Add(item);
            }
            return Lista;
        }

        // DashBoard Radar
        public List<RecursosHumanosModel> RadarSV()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome, a.pessoas14 AS P1, a.pessoas15 AS P2, a.pessoas16 AS P3, a.pessoas17 AS P4,a.pessoas18 AS P5,  a.Processos08 AS P6, a.Processos09 AS P7, a.Processos10 AS P8 ,a.Processos11 AS P9,  a.Processos12 AS P10 , a.Negocios01 AS P11, a.Negocios02 AS P12, a.Negocios03 AS P13, a.Negocios04 AS P14, a.Negocios05 AS P15, a.Negocios06 AS P16, a.Negocios07 AS P17 from questionario a , usuario b where  a.Matricula = b.Matricula and a.Matricula = {Nomes} and a.status='Já Avaliado'  ";
            DAL objDAL = new DAL();
            DataTable dt = new DataTable();
            dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.P1 = dt.Rows[i]["P1"].ToString();
                item.P2 = dt.Rows[i]["P2"].ToString();
                item.P3 = dt.Rows[i]["P3"].ToString();
                item.P4 = dt.Rows[i]["P4"].ToString();
                item.P5 = dt.Rows[i]["P5"].ToString();
                item.P6 = dt.Rows[i]["P6"].ToString();
                item.P7 = dt.Rows[i]["P7"].ToString();
                item.P8 = dt.Rows[i]["P8"].ToString();
                item.P9 = dt.Rows[i]["P9"].ToString();
                item.P10 = dt.Rows[i]["P10"].ToString();
                item.P11 = dt.Rows[i]["P11"].ToString();
                item.P12 = dt.Rows[i]["P12"].ToString();
                item.P13 = dt.Rows[i]["P13"].ToString();
                item.P14 = dt.Rows[i]["P14"].ToString();
                item.P15 = dt.Rows[i]["P15"].ToString();
                item.P16 = dt.Rows[i]["P16"].ToString();
                item.P17 = dt.Rows[i]["P17"].ToString();

                Lista.Add(item);

                //parte 1 Pessoas Gestor

                if (item.P1 == "0,588235294")
                {
                    item.P1 = "1";
                }
                else if (item.P1 == "1,470588235")
                {
                    item.P1 = "2";
                }
                else if (item.P1 == "2,941176471")
                {
                    item.P1 = "3";
                }
                else if (item.P1 == "4,117647059")
                {
                    item.P1 = "4";
                }

                // parte 2 Pessoas Gestor

                if (item.P2 == "0,588235294")
                {
                    item.P2 = "1";
                }
                else if (item.P2 == "1,470588235")
                {
                    item.P2 = "2";
                }
                else if (item.P2 == "2,941176471")
                {
                    item.P2 = "3";
                }
                else if (item.P2 == "4,117647059")
                {
                    item.P2 = "4";
                }

                // parte 3 Pessoas Gestor

                if (item.P3 == "0,588235294")
                {
                    item.P3 = "1";
                }
                else if (item.P3 == "1,470588235")
                {
                    item.P3 = "2";
                }
                else if (item.P3 == "2,941176471")
                {
                    item.P3 = "3";
                }
                else if (item.P3 == "4,117647059")
                {
                    item.P3 = "4";
                }

                // parte4 Pessoas Gestor
                if (item.P4 == "0,588235294")
                {
                    item.P4 = "1";
                }
                else if (item.P4 == "1,470588235")
                {
                    item.P4 = "2";
                }
                else if (item.P4 == "2,941176471")
                {
                    item.P4 = "3";
                }
                else if (item.P4 == "4,117647059")
                {
                    item.P4 = "4";
                }

                //parte5 Pessoas Gestor
                if (item.P5 == "0,588235294")
                {
                    item.P5 = "1";
                }
                else if (item.P5 == "1,470588235")
                {
                    item.P5 = "2";
                }
                else if (item.P5 == "2,941176471")
                {
                    item.P5 = "3";
                }
                else if (item.P5 == "4,117647059")
                {
                    item.P5 = "4";
                }

                // Parte1 Gestor Processos
                if (item.P6 == "0,588235294")
                {
                    item.P6 = "1";
                }
                else if (item.P6 == "1,470588235")
                {
                    item.P6 = "2";
                }
                else if (item.P6 == "2,941176471")
                {
                    item.P6 = "3";
                }
                else if (item.P6 == "4,117647059")
                {
                    item.P6 = "4";
                }

                // Parte2 Gestor Processos
                if (item.P7 == "0,588235294")
                {
                    item.P7 = "1";
                }
                else if (item.P7 == "1,470588235")
                {
                    item.P7 = "2";
                }
                else if (item.P7 == "2,941176471")
                {
                    item.P7 = "3";
                }
                else if (item.P7 == "4,117647059")
                {
                    item.P7 = "4";
                }

                // Parte3 Gestor Processos
                if (item.P8 == "0,588235294")
                {
                    item.P8 = "1";
                }
                else if (item.P8 == "1,470588235")
                {
                    item.P8 = "2";
                }
                else if (item.P8 == "2,941176471")
                {
                    item.P8 = "3";
                }
                else if (item.P8 == "4,117647059")
                {
                    item.P8 = "4";
                }

                // Parte4 Gestor Processos
                if (item.P9 == "0,588235294")
                {
                    item.P9 = "1";
                }
                else if (item.P9 == "1,470588235")
                {
                    item.P9 = "2";
                }
                else if (item.P9 == "2,941176471")
                {
                    item.P9 = "3";
                }
                else if (item.P9 == "4,117647059")
                {
                    item.P9 = "4";
                }

                // Parte5 Gestor Processos
                if (item.P10 == "0,588235294")
                {
                    item.P10 = "1";
                }
                else if (item.P10 == "1,470588235")
                {
                    item.P10 = "2";
                }
                else if (item.P10 == "2,941176471")
                {
                    item.P10 = "3";
                }
                else if (item.P10 == "4,117647059")
                {
                    item.P10 = "4";
                }


                if (item.P11 == "0,588235294")
                {
                    item.P11 = "1";
                }
                else if (item.P11 == "1,470588235")
                {
                    item.P11 = "2";
                }
                else if (item.P11 == "2,941176471")
                {
                    item.P11 = "3";
                }
                else if (item.P11 == "4,117647059")
                {
                    item.P11 = "4";
                }

                // parte 2 Gestor

                if (item.P12 == "0,588235294")
                {
                    item.P12 = "1";
                }
                else if (item.P12 == "1,470588235")
                {
                    item.P12 = "2";
                }
                else if (item.P12 == "2,941176471")
                {
                    item.P12 = "3";
                }
                else if (item.P12 == "4,117647059")
                {
                    item.P12 = "4";
                }

                // parte 3 Gestor

                if (item.P13 == "0,588235294")
                {
                    item.P13 = "1";
                }
                else if (item.P13 == "1,470588235")
                {
                    item.P13 = "2";
                }
                else if (item.P13 == "2,941176471")
                {
                    item.P13 = "3";
                }
                else if (item.P13 == "4,117647059")
                {
                    item.P13 = "4";
                }

                // parte4 Gestor
                if (item.P14 == "0,588235294")
                {
                    item.P14 = "1";
                }
                else if (item.P14 == "1,470588235")
                {
                    item.P14 = "2";
                }
                else if (item.P14 == "2,941176471")
                {
                    item.P14 = "3";
                }
                else if (item.P14 == "4,117647059")
                {
                    item.P14 = "4";
                }
                //parte5 Gestor
                if (item.P15 == "0,588235294")
                {
                    item.P15 = "1";
                }
                else if (item.P15 == "1,470588235")
                {
                    item.P15 = "2";
                }
                else if (item.P15 == "2,941176471")
                {
                    item.P15 = "3";
                }
                else if (item.P15 == "4,117647059")
                {
                    item.P15 = "4";
                }

                //parte6 Gestor
                if (item.P16 == "0,588235294")
                {
                    item.P16 = "1";
                }
                else if (item.P16 == "1,470588235")
                {
                    item.P16 = "2";
                }
                else if (item.P16 == "2,941176471")
                {
                    item.P16 = "3";
                }
                else if (item.P16 == "4,117647059")
                {
                    item.P16 = "4";
                }
                //parte7 Gestor
                if (item.P17 == "0,588235294")
                {
                    item.P17 = "1";
                }
                else if (item.P17 == "1,470588235")
                {
                    item.P17 = "2";
                }
                else if (item.P17 == "2,941176471")
                {
                    item.P17 = "3";
                }
                else if (item.P17 == "4,117647059")
                {
                    item.P17 = "4";
                }
            }

            return Lista;

        }

        public List<RecursosHumanosModel> RadarGL()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome, a.pessoas14 AS P1, a.pessoas15 AS P2, a.pessoas16 AS P3, a.pessoas17 AS P4,a.pessoas18 AS P5, a.Processos08 AS P6, a.Processos09 AS P7,a.Processos10 AS P8, a.Processos11 AS P9, a.Processos12 AS P10, a.Negocios01 AS P11, a.Negocios02 AS P12, a.Negocios03  AS P13, a.Negocios04 AS P14, a.Negocios05 AS P15,a.Negocios06 AS P16,a.Negocios07 AS P17 from questionario a , usuario b where a.Matricula = b.Matricula   and a.Matricula = {Nomes} and a.status = 'Já Avaliado' ";
            DAL objDAL = new DAL();
            DataTable dt = new DataTable();
            dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.P1 = dt.Rows[i]["P1"].ToString();
                item.P2 = dt.Rows[i]["P2"].ToString();
                item.P3 = dt.Rows[i]["P3"].ToString();
                item.P4 = dt.Rows[i]["P4"].ToString();
                item.P5 = dt.Rows[i]["P5"].ToString();
                item.P6 = dt.Rows[i]["P6"].ToString();
                item.P7 = dt.Rows[i]["P7"].ToString();
                item.P8 = dt.Rows[i]["P8"].ToString();
                item.P9 = dt.Rows[i]["P9"].ToString();
                item.P10 = dt.Rows[i]["P10"].ToString();
                item.P11 = dt.Rows[i]["P11"].ToString();
                item.P12 = dt.Rows[i]["P12"].ToString();
                item.P13 = dt.Rows[i]["P13"].ToString();
                item.P14 = dt.Rows[i]["P14"].ToString();
                item.P15 = dt.Rows[i]["P15"].ToString();
                item.P16 = dt.Rows[i]["P16"].ToString();
                item.P17 = dt.Rows[i]["P17"].ToString();

                Lista.Add(item);
                // parte 2 Pessoas GL

                if (item.P1 == "0,588235294")
                {
                    item.P1 = "1";
                }
                else if (item.P1 == "1,470588235")
                {
                    item.P1 = "2";
                }
                else if (item.P1 == "2,941176471")
                {
                    item.P1 = "3";
                }
                else if (item.P1 == "4,117647059")
                {
                    item.P1 = "4";
                }

                // parte 3 Pessoas GL

                if (item.P2 == "0,588235294")
                {
                    item.P2 = "1";
                }
                else if (item.P2 == "1,470588235")
                {
                    item.P2 = "2";
                }
                else if (item.P2 == "2,941176471")
                {
                    item.P2 = "3";
                }
                else if (item.P2 == "4,117647059")
                {
                    item.P2 = "4";
                }

                // parte4 Pessoas GL
                if (item.P3 == "0,588235294")
                {
                    item.P3 = "1";
                }
                else if (item.P3 == "1,470588235")
                {
                    item.P3 = "2";
                }
                else if (item.P3 == "2,941176471")
                {
                    item.P3 = "3";
                }
                else if (item.P3 == "4,117647059")
                {
                    item.P3 = "4";
                }

                // Parte4 GL Processos
                if (item.P4 == "0,588235294")
                {
                    item.P4 = "1";
                }
                else if (item.P4 == "1,470588235")
                {
                    item.P4 = "2";
                }
                else if (item.P4 == "2,941176471")
                {
                    item.P4 = "3";
                }
                else if (item.P4 == "4,117647059")
                {
                    item.P4 = "4";
                }


                // Parte5 GL Processos
                if (item.P5 == "0,588235294")
                {
                    item.P5 = "1";
                }
                else if (item.P5 == "1,470588235")
                {
                    item.P5 = "2";
                }
                else if (item.P5 == "2,941176471")
                {
                    item.P5 = "3";
                }
                else if (item.P5 == "4,117647059")
                {
                    item.P5 = "4";
                }

                // Parte6 GL Processos
                if (item.P6 == "0,588235294")
                {
                    item.P6 = "1";
                }
                else if (item.P6 == "1,470588235")
                {
                    item.P6 = "2";
                }
                else if (item.P6 == "2,941176471")
                {
                    item.P6 = "3";
                }
                else if (item.P6 == "4,117647059")
                {
                    item.P6 = "4";
                }

                // Parte7 GL Processos
                if (item.P7 == "0,588235294")
                {
                    item.P7 = "1";
                }
                else if (item.P7 == "1,470588235")
                {
                    item.P7 = "2";
                }
                else if (item.P7 == "2,941176471")
                {
                    item.P7 = "3";
                }
                else if (item.P7 == "4,117647059")
                {
                    item.P7 = "4";
                }

                // Parte8 GL Processos
                if (item.P8 == "0,588235294")
                {
                    item.P8 = "1";
                }
                else if (item.P8 == "1,470588235")
                {
                    item.P8 = "2";
                }
                else if (item.P8 == "2,941176471")
                {
                    item.P8 = "3";
                }
                else if (item.P8 == "4,117647059")
                {
                    item.P8 = "4";
                }

                // Parte9 GL Processos
                if (item.P9 == "0,588235294")
                {
                    item.P9 = "1";
                }
                else if (item.P9 == "1,470588235")
                {
                    item.P9 = "2";
                }
                else if (item.P9 == "2,941176471")
                {
                    item.P9 = "3";
                }
                else if (item.P9 == "4,117647059")
                {
                    item.P9 = "4";
                }

                // Parte10 GL Processos
                if (item.P10 == "0,588235294")
                {
                    item.P10 = "1";
                }
                else if (item.P10 == "1,470588235")
                {
                    item.P10 = "2";
                }
                else if (item.P10 == "2,941176471")
                {
                    item.P10 = "3";
                }
                else if (item.P10 == "4,117647059")
                {
                    item.P10 = "4";
                }


                // parte11 GL

                if (item.P11 == "0,588235294")
                {
                    item.P11 = "1";
                }
                else if (item.P11 == "1,470588235")
                {
                    item.P11 = "2";
                }
                else if (item.P11 == "2,941176471")
                {
                    item.P11 = "3";
                }
                else if (item.P11 == "4,117647059")
                {
                    item.P11 = "4";
                }

                // parte 12 GL

                if (item.P12 == "0,588235294")
                {
                    item.P12 = "1";
                }
                else if (item.P12 == "1,470588235")
                {
                    item.P12 = "2";
                }
                else if (item.P12 == "2,941176471")
                {
                    item.P12 = "3";
                }
                else if (item.P12 == "4,117647059")
                {
                    item.P12 = "4";
                }

                // Parte13 GL Processos
                if (item.P13 == "0,588235294")
                {
                    item.P13 = "1";
                }
                else if (item.P13 == "1,470588235")
                {
                    item.P13 = "2";
                }
                else if (item.P13 == "2,941176471")
                {
                    item.P13 = "3";
                }
                else if (item.P13 == "4,117647059")
                {
                    item.P13 = "4";
                }
                //parte14 GL
                if (item.P14 == "0,588235294")
                {
                    item.P14 = "1";
                }
                else if (item.P14 == "1,470588235")
                {
                    item.P14 = "2";
                }
                else if (item.P14 == "2,941176471")
                {
                    item.P14 = "3";
                }
                else if (item.P14 == "4,117647059")
                {
                    item.P14 = "4";
                }
                //parte15 GL
                if (item.P15 == "0,588235294")
                {
                    item.P15 = "1";
                }
                else if (item.P15 == "1,470588235")
                {
                    item.P15 = "2";
                }
                else if (item.P15 == "2,941176471")
                {
                    item.P15 = "3";
                }
                else if (item.P15 == "4,117647059")
                {
                    item.P15 = "4";
                }
                //parte16 GL
                if (item.P16 == "0,588235294")
                {
                    item.P16 = "1";
                }
                else if (item.P16 == "1,470588235")
                {
                    item.P16 = "2";
                }
                else if (item.P16 == "2,941176471")
                {
                    item.P16 = "3";
                }
                else if (item.P16 == "4,117647059")
                {
                    item.P16 = "4";
                }
                //parte14 GL
                if (item.P17 == "0,588235294")
                {
                    item.P17 = "1";
                }
                else if (item.P17 == "1,470588235")
                {
                    item.P17 = "2";
                }
                else if (item.P17 == "2,941176471")
                {
                    item.P17 = "3";
                }
                else if (item.P17 == "4,117647059")
                {
                    item.P17 = "4";
                }
            }

            return Lista;

        }
        public List<RecursosHumanosModel> RadarAnalista()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome, a.pessoas16 AS P1, a.pessoas17 AS P2, a.pessoas20  AS P3, a.Processos08 AS P6, a.Processos09 AS P7, a.Processos10 AS P8 , a.Processos11  AS P9, a.Processos13 AS P10 , a.Negocios01 AS P11, a.Negocios02 AS P12, a.Negocios03 AS P13,a.Negocios06 AS P14, a.Negocios07 AS P15 from questionario a , usuario b where a.Matricula = b.Matricula  and a.Matricula = {Nomes} and a.status='Já Avaliado'  ";
            DAL objDAL = new DAL();
            DataTable dt = new DataTable();
            dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.P1 = dt.Rows[i]["P1"].ToString();
                item.P2 = dt.Rows[i]["P2"].ToString();
                item.P3 = dt.Rows[i]["P3"].ToString();
                item.P6 = dt.Rows[i]["P6"].ToString();
                item.P7 = dt.Rows[i]["P7"].ToString();
                item.P8 = dt.Rows[i]["P8"].ToString();
                item.P9 = dt.Rows[i]["P9"].ToString();
                item.P10 = dt.Rows[i]["P10"].ToString();
                item.P11 = dt.Rows[i]["P11"].ToString();
                item.P12 = dt.Rows[i]["P12"].ToString();
                item.P13 = dt.Rows[i]["P13"].ToString();
              
                Lista.Add(item);

                // parte 3 Pessoas Espec

                if (item.P1 == "0,769230769")
                {
                    item.P1 = "1";
                }
                else if (item.P1 == "1,923076923")
                {
                    item.P1 = "2";
                }
                else if (item.P1 == "3,846153846")
                {
                    item.P1 = "3";
                }
                else if (item.P1 == "5,384615385")
                {
                    item.P1 = "4";
                }

                // parte4 Pessoas Espec
                if (item.P2 == "0,769230769")
                {
                    item.P2 = "1";
                }
                else if (item.P2 == "1,923076923")
                {
                    item.P2 = "2";
                }
                else if (item.P2 == "3,846153846")
                {
                    item.P2 = "3";
                }
                else if (item.P2 == "5,384615385")
                {
                    item.P2 = "4";
                }

                if (item.P3 == "0,769230769")
                {
                    item.P3 = "1";
                }
                else if (item.P3 == "1,923076923")
                {
                    item.P3 = "2";
                }
                else if (item.P3 == "3,846153846")
                {
                    item.P3 = "3";
                }
                else if (item.P3 == "5,384615385")
                {
                    item.P3 = "4";
                }
                // Parte1 Espec Processos
                if (item.P6 == "0,769230769")
                {
                    item.P6 = "1";
                }
                else if (item.P6 == "1,923076923")
                {
                    item.P6 = "2";
                }
                else if (item.P6 == "3,846153846")
                {
                    item.P6 = "3";
                }
                else if (item.P6 == "5,384615385")
                {
                    item.P6 = "4";
                }

                // Parte2 Espec Processos
                 if (item.P7 == "0,769230769")
                {
                    item.P7 = "1";
                }
                else if (item.P7 == "1,923076923")
                {
                    item.P7 = "2";
                }
                else if (item.P7 == "3,846153846")
                {
                    item.P7 = "3";
                }
                else if (item.P7 == "5,384615385")
                {
                    item.P7 = "4";
                }
                // Parte3 Espec Processos
                 if (item.P8 == "0,769230769")
                {
                    item.P8 = "1";
                }
                else if (item.P8 == "1,923076923")
                {
                    item.P8 = "2";
                }
                else if (item.P8 == "3,846153846")
                {
                    item.P8 = "3";
                }
                else if (item.P8 == "5,384615385")
                {
                    item.P8 = "4";
                }
                // Parte4 Espec Processos
               if (item.P9 == "0,769230769")
                {
                    item.P9 = "1";
                }
                else if (item.P9 == "1,923076923")
                {
                    item.P9 = "2";
                }
                else if (item.P9 == "3,846153846")
                {
                    item.P9 = "3";
                }
                else if (item.P9 == "5,384615385")
                {
                    item.P9 = "4";
                }
        
                // Parte6 Espec Processos
                if (item.P10 == "0,769230769")
                {
                    item.P10 = "1";
                }
                else if (item.P10 == "1,923076923")
                {
                    item.P10 = "2";
                }
                else if (item.P10 == "3,846153846")
                {
                    item.P10 = "3";
                }
                else if (item.P10 == "5,384615385")
                {
                    item.P10 = "4";
                }
                //parte 1 especialista

                if (item.P11 == "0,769230769")
                {
                    item.P11 = "1";
                }
                else if (item.P11 == "1,923076923")
                {
                    item.P11 = "2";
                }
                else if (item.P11 == "3,846153846")
                {
                    item.P11 = "3";
                }
                else if (item.P11 == "5,384615385")
                {
                    item.P11 = "4";
                }

                // parte 2 especialista

                if (item.P12 == "0,769230769")
                {
                    item.P12 = "1";
                }
                else if (item.P12 == "1,923076923")
                {
                    item.P12 = "2";
                }
                else if (item.P12 == "3,846153846")
                {
                    item.P12 = "3";
                }
                else if (item.P12 == "5,384615385")
                {
                    item.P12 = "4";
                }

                // parte 3 especialista

                if (item.P13 == "0,769230769")
                {
                    item.P13 = "1";
                }
                else if (item.P13 == "1,923076923")
                {
                    item.P13 = "2";
                }
                else if (item.P13 == "3,846153846")
                {
                    item.P13 = "3";
                }
                else if (item.P13 == "5,384615385")
                {
                    item.P13 = "4";
                }
                         
            }

            return Lista;

        }
        public List<RecursosHumanosModel> RadarOper()
        {
            List<RecursosHumanosModel> Lista = new List<RecursosHumanosModel>();
            RecursosHumanosModel item;

            string Nomes = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");
            string sql = $"select b.Nome, round( a.pessoas16)AS P1, round(a.pessoas17) AS P2,round(a.pessoas20 ) AS P3, round(a.Processos09)  AS P6, round(a.Processos13 ) AS P7, round(a.Negocios01) AS P11, round(a.Negocios02 ) AS P12, round(a.Negocios03 ) AS P13, round(a.Negocios06 ) AS P14, round(a.Negocios07 ) AS P15 from questionario a , usuario b where a.Matricula = b.Matricula  and a.Matricula = {Nomes}  AND a.`Status`='Já Avaliado'" ;
            DAL objDAL = new DAL();
            DataTable dt = new DataTable();
            dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                item = new RecursosHumanosModel();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.P1 = dt.Rows[i]["P1"].ToString();
                item.P2 = dt.Rows[i]["P2"].ToString();
                item.P3 = dt.Rows[i]["P3"].ToString();
                item.P6 = dt.Rows[i]["P6"].ToString();
                item.P7 = dt.Rows[i]["P7"].ToString();
                item.P11 = dt.Rows[i]["P11"].ToString();
                item.P12 = dt.Rows[i]["P12"].ToString();
                item.P13 = dt.Rows[i]["P13"].ToString();
                item.P14 = dt.Rows[i]["P14"].ToString();
                item.P15 = dt.Rows[i]["P15"].ToString();
                
                Lista.Add(item);

                // parte 3 Pessoas Operador

                if (item.P1 == "1")
                {
                    item.P1 = "1";
                }
                else if (item.P1 == "2,5")
                {
                    item.P1 = "2";
                }
                else if (item.P1 == "5")
                {
                    item.P1 = "3";
                }
                else if (item.P1 == "7")
                {
                    item.P1 = "4";
                }

                // parte4 Pessoas Operador
                if (item.P2 == "1")
                {
                    item.P2 = "1";
                }
                else if (item.P2 == "2,5")
                {
                    item.P2 = "2";
                }
                else if (item.P2 == "5")
                {
                    item.P2 = "3";
                }
                else if (item.P2 == "7")
                {
                    item.P2 = "4";
                }

                //parte7 Pessoas Operador
                if (item.P3 == "1")
                {
                    item.P3 = "1";
                }
                else if (item.P3 == "2,5")
                {
                    item.P3 = "2";
                }
                else if (item.P3 == "5")
                {
                    item.P3 = "3";
                }
                else if (item.P3 == "7")
                {
                    item.P3 = "4";
                }

                // Parte2 Assist Processos
                if (item.P6 == "1")
                {
                    item.P6 = "1";
                }
                else if (item.P6 == "2,5")
                {
                    item.P6 = "2";
                }
                else if (item.P6 == "5")
                {
                    item.P6 = "3";
                }
                else if (item.P6 == "7")
                {
                    item.P6 = "4";
                }
                if (item.P7 == "1")
                {
                    item.P7 = "1";
                }
                else if (item.P7 == "2,5")
                {
                    item.P7 = "2";
                }
                else if (item.P7 == "5")
                {
                    item.P7 = "3";
                }
                else if (item.P7 == "7")
                {
                    item.P7 = "4";
                }

                //parte 1 Operador

                if (item.P11 == "1")
                {
                    item.P11 = "1";
                }
                else if (item.P11 == "2,5")
                {
                    item.P11 = "2";
                }
                else if (item.P11 == "5")
                {
                    item.P11 = "3";
                }
                else if (item.P11 == "7")
                {
                    item.P11 = "4";
                }

                // parte 2 Operador

                if (item.P12 == "1")
                {
                    item.P12 = "1";
                }
                else if (item.P12 == "2,5")
                {
                    item.P12 = "2";
                }
                else if (item.P12 == "5")
                {
                    item.P12 = "3";
                }
                else if (item.P12 == "7")
                {
                    item.P12 = "4";
                }

                // parte 3 Operador

                if (item.P13 == "1")
                {
                    item.P13 = "1";
                }
                else if (item.P13 == "2,5")
                {
                    item.P13 = "2";
                }
                else if (item.P13 == "5")
                {
                    item.P13 = "3";
                }
                else if (item.P13 == "7")
                {
                    item.P13 = "4";
                }
                //parte6 Operador
                if (item.P14 == "1")
                {
                    item.P14 = "1";
                }
                else if (item.P14 == "2,5")
                {
                    item.P14 = "2";
                }
                else if (item.P14 == "5")
                {
                    item.P14 = "3";
                }
                else if (item.P14 == "7")
                {
                    item.P14 = "4";
                }
                //parte7 Operador
                if (item.P15 == "1")
                {
                    item.P15 = "1";
                }
                else if (item.P15 == "2,5")
                {
                    item.P15 = "2";
                }
                else if (item.P15 == "5")
                {
                    item.P15 = "3";
                }
                else if (item.P15 == "7")
                {
                    item.P15 = "4";
                }

            }

            return Lista;

        }


    }

}




