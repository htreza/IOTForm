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
    public class PadroesRequerimentosRepository
    {
        public bool InsertPadroesRequerimentos(PadroesRequerimentos padroes)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO ServicosBackend (IdCliente, RequerimentosRegiao, RequerimentosIndustria," +
                                                        "RequerimentosTecnologia, PadroesTecnicos, PadroesFuncionais) VALUES (@idcliente," +
                                                        "@requerimentosregiao, @requerimentosindustria, @requerimentostecnologia, @padroestecnicos," +
                                                        "@padroesfuncionais)", conn))
                {
                    cmd.Parameters.AddWithValue("@idcliente", padroes);
                    cmd.Parameters.AddWithValue("@requerimentosregiao", padroes);
                    cmd.Parameters.AddWithValue("@requerimentosindustria", padroes);
                    cmd.Parameters.AddWithValue("@requerimentostecnologia", padroes);
                    cmd.Parameters.AddWithValue("@padroestecnicos", padroes);
                    cmd.Parameters.AddWithValue("@padroesfuncionais", padroes);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdatePadroesRequerimentos(PadroesRequerimentos padroes)
        {
            using (SqlConnection conn = DBConnection.AbrirConn()
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"UPDATE ServicosBackend SET, RequerimentosRegiao=@requerimentosregiao," +
                                                        "RequerimentosIndustria=@requerimentosindustria, RequerimentosTecnologia=@requerimentostecnologia," +
                                                        "PadroesTecnicos=@padroestecnicos, PadroesFuncionais=@padroesfuncionais WHERE IdCliente=@idcliente", conn))
                {
                    cmd.Parameters.AddWithValue("@idcliente", padroes);
                    cmd.Parameters.AddWithValue("@requerimentosregiao", padroes);
                    cmd.Parameters.AddWithValue("@requerimentosindustria", padroes);
                    cmd.Parameters.AddWithValue("@requerimentostecnologia", padroes);
                    cmd.Parameters.AddWithValue("@padroestecnicos", padroes);
                    cmd.Parameters.AddWithValue("@padroesfuncionais", padroes);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}