using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOTForm.Models
{
    public class ServicosBackend
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

        private int geralEstrategiaAplicacao;
        public int GeralEstrategiaAplicacao
        {
            get { return geralEstrategiaAplicacao; }
            set { geralEstrategiaAplicacao = value; }
        }

        private string geralEstrategiaAplicacaoC;
        public string GeralEstrategiaAplicacaoC
        {
            get { return geralEstrategiaAplicacaoC; }
            set { geralEstrategiaAplicacaoC = value; }
        }

        private int geralComplexidadeNegocio;
        public int GeralComplexidadeNegocio
        {
            get { return geralComplexidadeNegocio; }
            set { geralComplexidadeNegocio = value; }
        }

        private string geralComplexidadeNegocioC;
        public string GeralComplexidadeNegocioC
        {
            get { return geralComplexidadeNegocioC; }
            set { geralComplexidadeNegocioC = value; }
        }

        private int geralIntegracaoBackend;
        public int GeralIntegracaoBackend
        {
            get { return geralIntegracaoBackend; }
            set { geralIntegracaoBackend = value; }
        }

        private string geralIntegracaoBackendC;
        public string GeralIntegracaoBackendC
        {
            get { return geralIntegracaoBackendC; }
            set { geralIntegracaoBackendC = value; }
        }

        private int gestaoVolumeDados;
        public int GestaoVolumeDados
        {
            get { return gestaoVolumeDados; }
            set { gestaoVolumeDados = value; }
        }

        private string gestaoVolumeDadosC;
        public string GestaoVolumeDadosC
        {
            get { return gestaoVolumeDadosC; }
            set { gestaoVolumeDadosC = value; }
        }

        private int gestaoVariedadeDados;
        public int GestaoVariedadeDados
        {
            get { return gestaoVariedadeDados; }
            set { gestaoVariedadeDados = value; }
        }

        private string gestaoVariedadeDadosC;
        public string GestaoVariedadeDadosC
        {
            get { return gestaoVariedadeDadosC; }
            set { gestaoVariedadeDadosC = value; }
        }

        private int gestaoVariabilidadeDados;
        public int GestaoVariabilidadeDados
        {
            get { return gestaoVariabilidadeDados; }
            set { gestaoVariabilidadeDados = value; }
        }

        private string gestaoVariabilidadeDadosC;
        public string GestaoVariabilidadeDadosC
        {
            get { return gestaoVariabilidadeDadosC; }
            set { gestaoVariabilidadeDadosC = value; }
        }

        private int gestaoAnalytics;
        public int GestaoAnalytics
        {
            get { return gestaoAnalytics; }
            set { gestaoAnalytics = value; }
        }

        private string gestaoAnalyticsC;
        public string GestaoAnalyticsC
        {
            get { return gestaoAnalyticsC; }
            set { gestaoAnalyticsC = value; }
        }
    }
}