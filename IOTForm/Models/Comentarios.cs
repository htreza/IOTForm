using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOTForm.Models
{
    public class Comentarios
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int idCampoTabela;

        public int IdCampoTabela
        {
            get { return idCampoTabela; }
            set { idCampoTabela = value; }
        }

        private string nomeTabela;

        public string NomeTabela
        {
            get { return nomeTabela; }
            set { nomeTabela = value; }
        }

        private string nomeColuna;

        public string NomeColuna
        {
            get { return nomeColuna; }
            set { nomeColuna = value; }
        }

        private string comentario;

        public string Comentario
        {
            get { return comentario; }
            set { comentario = value; }
        }

    }
}