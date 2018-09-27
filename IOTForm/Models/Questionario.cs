using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOTForm.Models
{
    public class Questionario
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string questao;

        public string Questao
        {
            get { return questao; }
            set { questao = value; }
        }
                
    }
}