using IOTForm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IOTForm.Repository
{
    public class AtivosDevicesRepository
    {

        public bool InsertAtivosDevices(AtivosDevices ativos)
        {
            using (SqlConnection conn = new SqlConnection("COLE A CONNECTION STRING AQUI"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO AtivosDevices (IdCliente, GeralNumeroAtivos,GeralValorAtivo,GeralValorEconomico," +
                                                            "GeralComplexidadeAtivo,GeralHeteroAtivo,PoderLogicaNegocio,PoderProcessamento,PoderRequerimentos" +
                                                            "PoderGestaoLocal,OutrosFonteEnergia,OutrosAmbiente,GestaoVidaUtil,GestaoRestricoesHardware," +
                                                            "GestaoRestricoesSoftware) VALUES (@idcliente, @geralnumeroativos,@geralvalorativos)", conn))
                {
                    cmd.Parameters.AddWithValue("@id", cliente.Id);
                    cmd.Parameters.AddWithValue("@idcliente", cliente.Nome);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}