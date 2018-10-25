using IOTForm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using IOTForm.DBTools;

namespace IOTForm.Repository
{
    public class FormularioInicialRepository
    {
        public List<Questionario> SelectFormulario(int IdCliente)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Id, Questao FROM Questao WHERE Status = 1", conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Questionario> Lista = new List<Questionario>(); 
                        while (reader.Read() == true)
                        {
                            Lista.Add(new Questionario
                            {
                                Id = reader.GetInt32(0),
                                Questao = reader.GetString(1),
                                Status = 1
                            }); 
                        }
                        return Lista;
                    }
                }
            }
        }
    }
}