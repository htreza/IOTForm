using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IOTForm.Models
{
    public class AmbienteProjeto
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

        private int ambienteTempo;

        public int AmbienteTempo
        {
            get { return ambienteTempo; }
            set { ambienteTempo = value; }
        }
        private int ambienteBudget;

        public int AmbienteBudget
        {
            get { return ambienteBudget; }
            set { ambienteBudget = value; }
        }
        private int ambienteFuncionais;

        public int AmbienteFuncionais
        {
            get { return ambienteFuncionais; }
            set { ambienteFuncionais = value; }
        }

        private int ambienteTecnicas;

        public int AmbienteTecnicas
        {
            get { return ambienteTecnicas; }
            set { ambienteTecnicas = value; }
        }
        
    }
}