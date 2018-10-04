using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOTForm.Models
{
    public class Cliente
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

    }
}