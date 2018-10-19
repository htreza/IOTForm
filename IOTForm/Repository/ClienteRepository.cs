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
    //private string ConnString = System.Configuration.ConnectionStringSettings;
    public class ClienteRepository
    {
        public bool InsertCliente(Cliente cliente)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
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
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Cliente Set Nome=@nome, Status=@status WHERE Id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", cliente.Id);
                    cmd.Parameters.AddWithValue("@idcliente", cliente.Nome);
                    cmd.Parameters.AddWithValue("@status", cliente.Status);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}