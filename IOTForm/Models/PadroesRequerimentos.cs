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

        private int requerimentosIndustria;

        public int RequerimentosIndustria
        {
            get { return requerimentosIndustria; }
            set { requerimentosIndustria = value; }
        }

        private int requerimentosTecnologia;

        public int RequerimentosTecnologia
        {
            get { return requerimentosTecnologia; }
            set { requerimentosTecnologia = value; }
        }

        private int padroesTecnicos;

        public int PadroesTecnicos
        {
            get { return padroesTecnicos; }
            set { padroesTecnicos = value; }
        }

        private int padroesFuncionais;

        public int PadroesFuncionais
        {
            get { return padroesFuncionais; }
            set { padroesFuncionais = value; }
        }

    }
}