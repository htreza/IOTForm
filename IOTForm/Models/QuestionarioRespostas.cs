using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOTForm.Models
{
    public class QuestionarioRespostas
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

        private int idQuestao;

        public int IdQuestao
        {
            get { return idQuestao; }
            set { idQuestao = value; }
        }

        private int resposta;

        public int Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }

        private string respostaTexto;

        public string RespostaTexto
        {
            get { return respostaTexto; }
            set { respostaTexto = value; }
        }
        
    }
}