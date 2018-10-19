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
    public class ServicosBackendRepository
    {
        public bool InsertServicosBackend(ServicosBackend servico)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO ServicosBackend (IdCliente, GeralEstrategiaAplicacao, GeralComplexidadeNegocio," + 
                                                        "GeralIntegracaoBackend, GestaoVolumeDados, GestaoVariedadeDados, GestaoVariabilidadeDados," +
                                                        "GestaoAnalytics) VALUES (@idcliente, @geralestrategiaaplicacao, @geralcomplexidadenegocio," +
                                                        "@geralintegracaobackend, @gestaovolumedados, @gestaovariedadedados, @gestaovariabilidadedados," +
                                                        "@gestaoanalytics)", conn))
                {
                    cmd.Parameters.AddWithValue("@idcliente", servico.IdCliente);
                    cmd.Parameters.AddWithValue("@geralestrategiaaplicacao", servico.GeralEstrategiaAplicacao);
                    cmd.Parameters.AddWithValue("@geralcomplexidadenegocio", servico.GeralComplexidadeNegocio);
                    cmd.Parameters.AddWithValue("@geralintegracaobackend", servico.GeralIntegracaoBackend);
                    cmd.Parameters.AddWithValue("@gestaovolumedados", servico.GestaoVolumeDados);
                    cmd.Parameters.AddWithValue("@gestaovariedadedados", servico.GestaoVariedadeDados);
                    cmd.Parameters.AddWithValue("@gestaovariabilidadedados", servico.GestaoVariabilidadeDados);
                    cmd.Parameters.AddWithValue("@gestaoanalytics", servico.GestaoAnalytics);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateServicosBackend(ServicosBackend servico)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"UPDATE ServicosBackend SET GeralEstrategiaAplicacao=@geralestrategiaaplicacao," +
                                                        "GeralComplexidadeNegocio=@geralcomplexidadenegocio, GeralIntegracaoBackend=@geralintegracaobackend," +
                                                        "GestaoVolumeDados=@gestaovolumedados, GestaoVariedadeDados=@gestaovariedadedados," +
                                                        "GestaoVariabilidadeDados=@gestaovariabilidadedados,GestaoAnalytics=@gestaoanalytics WHERE IdCliente=@idcliente", conn))
                {
                    cmd.Parameters.AddWithValue("@idcliente", servico.IdCliente);
                    cmd.Parameters.AddWithValue("@geralestrategiaaplicacao", servico.GeralEstrategiaAplicacao);
                    cmd.Parameters.AddWithValue("@geralcomplexidadenegocio", servico.GeralComplexidadeNegocio);
                    cmd.Parameters.AddWithValue("@geralintegracaobackend", servico.GeralIntegracaoBackend);
                    cmd.Parameters.AddWithValue("@gestaovolumedados", servico.GestaoVolumeDados);
                    cmd.Parameters.AddWithValue("@gestaovariedadedados", servico.GestaoVariedadeDados);
                    cmd.Parameters.AddWithValue("@gestaovariabilidadedados", servico.GestaoVariabilidadeDados);
                    cmd.Parameters.AddWithValue("@gestaoanalytics", servico.GestaoAnalytics);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}