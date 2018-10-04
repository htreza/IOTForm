﻿using IOTForm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IOTForm.Repository
{
    public class AmbienteProjetoRepository
    {

        public bool InsertAmbienteProjeto(AmbienteProjeto ambiente)
        {
            using (SqlConnection conn = new SqlConnection("COLE A CONNECTION STRING AQUI"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO AmbienteProjeto (IdCliente, AmbienteTempo, AmbienteBudget, AmbienteFuncionais, AmbienteTecnicas)"+
                                                            "VALUES (@idcliente, @ambientetempo, @ambientebudget, @ambientefuncionais, @ambientetecnicas)", conn))
                {
                    cmd.Parameters.AddWithValue("@idcliente", ambiente.IdCliente);
                    cmd.Parameters.AddWithValue("@ambientetempo", ambiente.IdCliente);
                    cmd.Parameters.AddWithValue("@ambientebudget", ambiente.IdCliente);
                    cmd.Parameters.AddWithValue("@ambientefuncionais", ambiente.IdCliente);
                    cmd.Parameters.AddWithValue("@ambientetecnicas", ambiente.IdCliente);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateAtivosDevices(AmbienteProjeto ambiente)
        {
            using (SqlConnection conn = new SqlConnection("COLE A CONNECTION STRING AQUI"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"UPDATE AmbienteProjeto SET IdCliente=@idcliente, AmbienteTempo=@ambientetempo, AmbienteBudget=@ambientebudget,"+
                                                        "AmbienteFuncionais=@ambientefuncionais, AmbienteTecnicas=@ambientetecnicas WHERE IdCliente=@idcliente", conn))
                {
                    cmd.Parameters.AddWithValue("@idcliente", ambiente.IdCliente);
                    cmd.Parameters.AddWithValue("@ambientetempo", ambiente.IdCliente);
                    cmd.Parameters.AddWithValue("@ambientebudget", ambiente.IdCliente);
                    cmd.Parameters.AddWithValue("@ambientefuncionais", ambiente.IdCliente);
                    cmd.Parameters.AddWithValue("@ambientetecnicas", ambiente.IdCliente);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}