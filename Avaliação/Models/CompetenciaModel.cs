using Avaliação.Util;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Data;

namespace Avaliação.Models
{
    public class CompetenciaModel
    {
#pragma warning disable CS0169 // O campo "CompetenciaModel.nome" nunca é usado
        private string nome;
#pragma warning restore CS0169 // O campo "CompetenciaModel.nome" nunca é usado
        
        public DateTime Data { get; set; }
        public string NomeGestor { get; set; }
        public string Gestor { get; set; }
        public string Colaborador { get; set; }
        public string Matricula { get; set; }
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
        public string Perfil { get; set; }
        public string Negocio { get; set; }
        public string Processos { get; set; }
        public string Pessoas { get; set; }
        public string Total_Competencias { get; set; }
        public string Nivel_Estrategico_01 { get; set; }
        public string Nivel_Estrategico_02 { get; set; }
        public string Nivel_Estrategico_03 { get; set; }
        public string Nivel_Tatico_01 { get; set; }
        public string Nivel_Tatico_02 { get; set; }
        public string Nivel_Tatico_03 { get; set; }
        public string Nivel_Execucao_01 { get; set; }
        public string Nivel_Execucao_02 { get; set; }
        public string Nivel_Execucao_03 { get; set; }
        public string Carro_proprio { get; set; }
        public string CNH { get; set; }
        public string Superior_completo { get; set; }
        public string Pos_graduacao_MBA { get; set; }
        public string Ingles_japones_intermediario { get; set; }
        public string Excel_intermediario { get; set; }
        public string Ingles_basico { get; set; }
        public string Excel_basico { get; set; }
        public string Excel_Avancado { get; set; }
        public string Operador_de_Empilhadeira { get; set; }
        public string Superior_cursando { get; set; }
        public string Conhecimento_Pacote_Office { get; set; }
        public string Pacote_Office_basico { get; set; }
        public string Credenciamento_da_atividade { get; set; }
        public string Ensino_medio_completo { get; set; }
        
        public IHttpContextAccessor HttpContextAccessor { get; set; }

        public CompetenciaModel(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
            

        }


        public CompetenciaModel()
        {

            

        }

        public List<AvaliacaoPessoasModel> ListaUsuario()
        {



            List<AvaliacaoPessoasModel> Lista = new List<AvaliacaoPessoasModel>();
            AvaliacaoPessoasModel item;


            string Nome = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"select Matricula,Nome, Gestor from usuario where gestor = '{Nome}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                item = new AvaliacaoPessoasModel();


                item.Matricula = dt.Rows[i]["Matricula"].ToString();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Gestor = dt.Rows[i]["Gestor"].ToString();



                Lista.Add(item);

            }

            return Lista;

        }

        public List<CompetenciaModel> ListaCadastro()
        {

             

            List<CompetenciaModel> Lista = new List<CompetenciaModel>();
            CompetenciaModel item;
            

            string Nome = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string sql = $"SELECT a.Data, a.Matricula,a.NomeGestor,b.Nome, a.Negocios01,a.Negocios02,a.Negocios03,a.Negocios04,a.Negocios05,a.Negocios06,a.Negocios07,a.Processos08, a.Processos09,a.Processos10,a.Processos11,a.Processos12,a.Processos13,a.Pessoas14,a.Pessoas15,a.Pessoas16,a.Pessoas17,a.Pessoas18,a.Pessoas19,a.Pessoas20 , d.Carro_proprio,d.CNH,d.Superior_completo,d.Pos_graduacao_MBA,d.Ingles_japones_intermediario,d.Excel_intermediario,d.Ingles_basico,d.Excel_basico,d.Excel_Avancado,d.Operador_de_Empilhadeira,d.Superior_cursando,d.Conhecimento_Pacote_Office,d.Pacote_Office_basico,d.Credenciamento_da_atividade,d.Ensino_medio_completo, c.Nivel_Estrategico_01,c.Nivel_Estrategico_02,c.Nivel_Estrategico_03,c.Nivel_Tatico_01,c.Nivel_Tatico_02,c.Nivel_Tatico_03,c.Nivel_Execucao_01,c.Nivel_Execucao_02,c.Nivel_Execucao_03 FROM questionario a, usuario b , requisitocargo d, metas c WHERE a.Matricula = b.Matricula AND a.NomeGestor = d.NomeGestor AND a.NomeGestor = c.NomeGestor AND b.Gestor = '{Nome}'";
            DAL objDAL = new DAL();
            DataTable dt = objDAL.RetDataTable(sql);

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                item = new CompetenciaModel();
                item.Data = DateTime.Parse(dt.Rows[i]["Data"].ToString());
                item.NomeGestor = dt.Rows[i]["NomeGestor"].ToString();
                item.Nome = dt.Rows[i]["Nome"].ToString();
                item.Matricula = dt.Rows[i]["Matricula"].ToString();
                item.Negocios01 = dt.Rows[i]["Negocios01"].ToString();
                item.Negocios02 = dt.Rows[i]["Negocios02"].ToString();
                item.Negocios03 = dt.Rows[i]["Negocios03"].ToString();
                item.Negocios04 = dt.Rows[i]["Negocios04"].ToString();
                item.Negocios05 = dt.Rows[i]["Negocios05"].ToString();
                item.Negocios06 = dt.Rows[i]["Negocios06"].ToString();
                item.Negocios07 = dt.Rows[i]["Negocios07"].ToString();
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
                item.Nivel_Estrategico_01 = dt.Rows[i]["Nivel_Estrategico_01"].ToString();
                item.Nivel_Estrategico_02 = dt.Rows[i]["Nivel_Estrategico_02"].ToString();
                item.Nivel_Estrategico_03 = dt.Rows[i]["Nivel_Estrategico_03"].ToString();
                item.Nivel_Tatico_01 = dt.Rows[i]["Nivel_Tatico_01"].ToString();
                item.Nivel_Tatico_02 = dt.Rows[i]["Nivel_Tatico_02"].ToString();
                item.Nivel_Tatico_03 = dt.Rows[i]["Nivel_Tatico_03"].ToString();
                item.Nivel_Execucao_01 = dt.Rows[i]["Nivel_Execucao_01"].ToString();
                item.Nivel_Execucao_02 = dt.Rows[i]["Nivel_Execucao_02"].ToString();
                item.Nivel_Execucao_03 = dt.Rows[i]["Nivel_Execucao_03"].ToString();
                item.Carro_proprio = dt.Rows[i]["Carro_proprio"].ToString();
                item.CNH = dt.Rows[i]["CNH"].ToString();
                item.Superior_completo = dt.Rows[i]["Superior_completo"].ToString();
                item.Pos_graduacao_MBA = dt.Rows[i]["Pos_graduacao_MBA"].ToString();
                item.Ingles_japones_intermediario = dt.Rows[i]["Ingles_japones_intermediario"].ToString();
                item.Excel_intermediario = dt.Rows[i]["Excel_intermediario"].ToString();
                item.Ingles_basico = dt.Rows[i]["Ingles_basico"].ToString();
                item.Excel_basico = dt.Rows[i]["Excel_basico"].ToString();
                item.Excel_Avancado = dt.Rows[i]["Excel_Avancado"].ToString();
                item.Operador_de_Empilhadeira = dt.Rows[i]["Operador_de_Empilhadeira"].ToString();
                item.Superior_cursando = dt.Rows[i]["Superior_cursando"].ToString();
                item.Conhecimento_Pacote_Office = dt.Rows[i]["Conhecimento_Pacote_Office"].ToString();
                item.Pacote_Office_basico = dt.Rows[i]["Pacote_Office_basico"].ToString();
                item.Credenciamento_da_atividade = dt.Rows[i]["Credenciamento_da_atividade"].ToString();
                item.Ensino_medio_completo = dt.Rows[i]["Ensino_medio_completo"].ToString();

                

                Lista.Add(item);

                //parte 1 especialista

                 if (item.Negocios01 == "0,769230769" )
               {
                    item.Negocios01 = "1";
                   

                }
               else if (item.Negocios01 == "1,923076923" )
                {
                    item.Negocios01 = "2";
                    

                }
               else if (item.Negocios01 == "3,846153846" )
                {
                    item.Negocios01 = "3";
                  

                }
               else if (item.Negocios01 == "5,384615385" )
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

                // parte1 Metas Assist
                if(item.Nivel_Execucao_01 == "8,333333333")
                {
                    item.Nivel_Execucao_01 = "1";

                }

               else if (item.Nivel_Execucao_01 == "16,66666667")
                {
                    item.Nivel_Execucao_01 = "2";


                }
                else if (item.Nivel_Execucao_01 == "25")
                {
                    item.Nivel_Execucao_01 = "3";


                }
                else if (item.Nivel_Execucao_01 == "33,33333333")
                {
                    item.Nivel_Execucao_01 = "4";


                }

                // parte2 Metas Assist
                if (item.Nivel_Execucao_02 == "8,333333333")
                {
                    item.Nivel_Execucao_02 = "1";

                }

                else if (item.Nivel_Execucao_02 == "16,66666667")
                {
                    item.Nivel_Execucao_02 = "2";


                }
                else if (item.Nivel_Execucao_02 == "25")
                {
                    item.Nivel_Execucao_02 = "3";


                }
                else if (item.Nivel_Execucao_02 == "33,33333333")
                {
                    item.Nivel_Execucao_02 = "4";


                }

                // parte3 Metas Assist
                if (item.Nivel_Execucao_03 == "8,333333333")
                {
                    item.Nivel_Execucao_03 = "1";

                }

                else if (item.Nivel_Execucao_03 == "16,66666667")
                {
                    item.Nivel_Execucao_03 = "2";


                }
                else if (item.Nivel_Execucao_03 == "25")
                {
                    item.Nivel_Execucao_03 = "3";


                }
                else if (item.Nivel_Execucao_03 == "33,33333333")
                {
                    item.Nivel_Execucao_03 = "4";


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

                // parte1 Metas Estrategico
                if (item.Nivel_Tatico_01 == "8,333333333")
                {
                    item.Nivel_Tatico_01 = "1";

                }

                else if (item.Nivel_Tatico_01 == "16,66666667")
                {
                    item.Nivel_Tatico_01 = "2";


                }
                else if (item.Nivel_Tatico_01 == "25")
                {
                    item.Nivel_Tatico_01 = "3";


                }
                else if (item.Nivel_Tatico_01 == "33,33333333")
                {
                    item.Nivel_Tatico_01 = "4";


                }

                // parte2 Metas Assist
                if (item.Nivel_Tatico_02 == "8,333333333")
                {
                    item.Nivel_Tatico_02 = "1";

                }

                else if (item.Nivel_Tatico_02 == "16,66666667")
                {
                    item.Nivel_Tatico_02 = "2";


                }
                else if (item.Nivel_Tatico_02 == "25")
                {
                    item.Nivel_Tatico_02 = "3";


                }
                else if (item.Nivel_Tatico_02 == "33,33333333")
                {
                    item.Nivel_Tatico_02 = "4";


                }

                // parte3 Metas Assist
                if (item.Nivel_Tatico_03 == "8,333333333")
                {
                    item.Nivel_Tatico_03 = "1";

                }

                else if (item.Nivel_Tatico_03 == "16,66666667")
                {
                    item.Nivel_Tatico_03 = "2";


                }
                else if (item.Nivel_Tatico_03 == "25")
                {
                    item.Nivel_Tatico_03 = "3";


                }
                else if (item.Nivel_Tatico_03 == "33,33333333")
                {
                    item.Nivel_Tatico_03 = "4";


                }

            }


            return Lista;

        }

       


        public void CompetenciaUpdate(string Negocios01, string Negocios02, string Negocios03, string Negocios04, string Negocios05, string Negocios06, string Negocios07)
        {

            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");

            new DAL().ExecutarComandoSQL($"UPDATE questionario SET Negocios01='{Negocios01}',Negocios02='{Negocios02}',Negocios03='{Negocios03}',Negocios04='{Negocios04}',Negocios05='{Negocios05}',Negocios06='{Negocios06}',Negocios07='{Negocios07}' WHERE  NomeGestor= '{NomeGestor}' and Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");



        }
        public void CompetenciaOPerador(string Negocios01, string Negocios02, string Negocios03, string Negocios04, string Negocios05, string Negocios06, string Negocios07)
        {

            string NomeGestor = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioLogado");
            string Matricula = HttpContextAccessor.HttpContext.Session.GetString("NomeUsuarioMatricula");

            new DAL().ExecutarComandoSQL($"UPDATE questionario SET Negocios01='{Negocios01}',Negocios02='{Negocios02}',Negocios03='{Negocios03}',Negocios04='{Negocios04}',Negocios05='{Negocios05}',Negocios06='{Negocios06}',Negocios07='{Negocios07}' WHERE   Matricula='{Matricula}'ORDER BY id DESC LIMIT 1");



        }


    }

}