using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOTForm.Models
{
    public class PadroesRequerimentos
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int idCliente;
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        private int requerimentosRegiao;
        public int RequerimentosRegiao
        {
            get { return requerimentosRegiao; }
            set { requerimentosRegiao = value; }
        }

        private string requerimentosRegiaoC;
        public string RequerimentosRegiaoC
        {
            get { return requerimentosRegiaoC; }
            set { requerimentosRegiaoC = value; }
        }

        private int requerimentosIndustria;
        public int RequerimentosIndustria
        {
            get { return requerimentosIndustria; }
            set { requerimentosIndustria = value; }
        }

        private string requerimentosIndustriaC;
        public string RequerimentosIndustriaC
        {
            get { return requerimentosIndustriaC; }
            set { requerimentosIndustriaC = value; }
        }

        private int requerimentosTecnologia;
        public int RequerimentosTecnologia
        {
            get { return requerimentosTecnologia; }
            set { requerimentosTecnologia = value; }
        }

        private string requerimentosTecnologiaC;
        public string RequerimentosTecnologiaC
        {
            get { return requerimentosTecnologiaC; }
            set { requerimentosTecnologiaC = value; }
        }

        private int padroesTecnicos;
        public int PadroesTecnicos
        {
            get { return padroesTecnicos; }
            set { padroesTecnicos = value; }
        }

        private string padroesTecnicosC;
        public string PadroesTecnicosC
        {
            get { return padroesTecnicosC; }
            set { padroesTecnicosC = value; }
        }

        private int padroesFuncionais;
        public int PadroesFuncionais
        {
            get { return padroesFuncionais; }
            set { padroesFuncionais = value; }
        }

        private string padroesFuncionaisC;
        public string PadroesFuncionaisC
        {
            get { return padroesFuncionaisC; }
            set { padroesFuncionaisC = value; }
        }
    }
}