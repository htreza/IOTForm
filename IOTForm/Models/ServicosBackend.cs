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

        private int geralComplexidadeNegocio;

        public int GeralComplexidadeNegocio
        {
            get { return geralComplexidadeNegocio; }
            set { geralComplexidadeNegocio = value; }
        }

        private int geralIntegracaoBackend;

        public int GeralIntegracaoBackend
        {
            get { return geralIntegracaoBackend; }
            set { geralIntegracaoBackend = value; }
        }

        private int gestaoVolumeDados;

        public int GestaoVolumeDados
        {
            get { return gestaoVolumeDados; }
            set { gestaoVolumeDados = value; }
        }

        private int gestaoVariedadeDados;

        public int GestaoVariedadeDados
        {
            get { return gestaoVariedadeDados; }
            set { gestaoVariedadeDados = value; }
        }

        private int gestaoVariabilidadeDados;

        public int GestaoVariabilidadeDados
        {
            get { return gestaoVariabilidadeDados; }
            set { gestaoVariabilidadeDados = value; }
        }

        private int gestaoAnalytics;

        public int GestaoAnalytics
        {
            get { return gestaoAnalytics; }
            set { gestaoAnalytics = value; }
        }

    }
}