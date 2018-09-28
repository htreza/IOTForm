using IOTForm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IOTForm.Repository
{
    //private string ConnString = System.Configuration.ConnectionStringSettings;
    public class ClienteRepository
    {
        public bool InsertCliente(Cliente cliente)
        {
            using (SqlConnection conn = new SqlConnection("COLE A CONNECTION STRING AQUI"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("INSERT INTO Cliente (Id, Nome) VALUES (@id, @nome)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", cliente.Id);
                    cmd.Parameters.AddWithValue("@idcliente", cliente.Nome);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateCliente(Cliente cliente)
        {
            using (SqlConnection conn = new SqlConnection("COLE A CONNECTION STRING AQUI"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("UPDATE Cliente Set Nome=@nome WHERE Id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", cliente.Id);
                    cmd.Parameters.AddWithValue("@idcliente", cliente.Nome);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}