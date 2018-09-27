using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOTForm.Models
{
    public class AtivosDevices
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

        private int geralNumeroAtivos;

        public int GeralNumeroAtivos
        {
            get { return geralNumeroAtivos; }
            set { geralNumeroAtivos = value; }
        }

        private int geralValorAtivo;

        public int GeralValorAtivo
        {
            get { return geralValorAtivo; }
            set { geralValorAtivo = value; }
        }

        private int geralValorEconomico;

        public int GeralValorEconomico
        {
            get { return geralValorEconomico; }
            set { geralValorEconomico = value; }
        }

        private int geralComplexidadeAtivo;

        public int GeralComplexidadeAtivo
        {
            get { return geralComplexidadeAtivo; }
            set { geralComplexidadeAtivo = value; }
        }
        private int geralHeteroAtivo;

        public int GeralHeteroAtivo
        {
            get { return geralHeteroAtivo; }
            set { geralHeteroAtivo = value; }
        }

        private int poderLogicaNegocio;

        public int PoderLogicaNegocio
        {
            get { return poderLogicaNegocio; }
            set { poderLogicaNegocio = value; }
        }
        private int poderProcessamento;

        public int PoderProcessamento
        {
            get { return poderProcessamento; }
            set { poderProcessamento = value; }
        }

        private int poderRequerimentos;

        public int PoderRequerimentos
        {
            get { return poderRequerimentos; }
            set { poderRequerimentos = value; }
        }

        private int poderGestaoLocal;

        public int PoderGestaoLocal
        {
            get { return poderGestaoLocal; }
            set { poderGestaoLocal = value; }
        }

        private int outrosFonteEnergia;

        public int OutrosFonteEnergia
        {
            get { return outrosFonteEnergia; }
            set { outrosFonteEnergia = value; }
        }

        private int outrosAmbiente;

        public int OutrosAmbiente
        {
            get { return outrosAmbiente; }
            set { outrosAmbiente = value; }
        }

        private int gestaoVidaUtil;

        public int GestaoVidaUtil
        {
            get { return gestaoVidaUtil; }
            set { gestaoVidaUtil = value; }
        }

        private int gestaoRestricoesHardware;

        public int GestaoRestricoesHardware
        {
            get { return gestaoRestricoesHardware; }
            set { gestaoRestricoesHardware = value; }
        }

        private int gestaoRestricoesSoftware;

        public int GestaoRestricoesSoftware
        {
            get { return gestaoRestricoesSoftware; }
            set { gestaoRestricoesSoftware = value; }
        }

    }
}