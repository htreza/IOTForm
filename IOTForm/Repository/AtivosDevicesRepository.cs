using IOTForm.DBTools;
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
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO AtivosDevices (IdCliente, GeralNumeroAtivos,GeralValorAtivo,GeralValorEconomico," +
                                                            "GeralComplexidadeAtivo,GeralHeteroAtivo,PoderLogicaNegocio,PoderProcessamento,PoderRequerimentos" +
                                                            "PoderGestaoLocal,OutrosFonteEnergia,OutrosAmbiente,GestaoVidaUtil,GestaoRestricoesHardware," +
                                                            "GestaoRestricoesSoftware) VALUES (@idcliente, @geralnumeroativos,@geralvalorativos,@geralvaloreconomico," +
                                                            "@geralcomplexidadeativo,@geralheteroativo,@poderlogicanegocio,@poderprocessamento,@poderrequerimentos" +
                                                            "@podergestaolocal,@outrosfonteenergia,@outrosambiente,@gestaovidautil,@gestaorestricoeshardware," +
                                                            "@gestaorestricoessoftware)", conn))
                {
                    cmd.Parameters.AddWithValue("@idcliente", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@geralnumerosativos", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@geralvalorativo", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@geralvaloreconomico", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@geralcomplexidadeativo", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@geralheteroativo", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@poderlogicanegocio", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@poderprocessamento", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@poderrequerimentos", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@podergestaolocal", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@outrosfonteenergia", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@outrosambiente", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@gestaovidautil", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@gestaorestricoeshardware", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@gestaorestricoessoftware", ativos.IdCliente);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateAtivosDevices(AtivosDevices ativos)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                using (SqlCommand cmd = new SqlCommand(@"UPDATE AtivosDevices SET GeralNumeroAtivos=@geralnumeroativos, GeralValorAtivo=@geralvalorativos, "+
                                                        "GeralValorEconomico=@geralvaloreconomico, GeralComplexidadeAtivo=@geralcomplexidadeativo, GeralHeteroAtivo=@geralheteroativo, " +
                                                        "PoderLogicaNegocio=@poderlogicanegocio, PoderProcessamento=@poderprocessamento, PoderRequerimentos=@poderrequerimentos, " +
                                                        "PoderGestaoLocal=@podergestaolocal, OutrosFonteEnergia=@outrosfonteenergia, OutrosAmbiente=@outrosambiente, " +
                                                        "GestaoVidaUtil=@gestaovidautil, GestaoRestricoesHardware=@gestaorestricoeshardware, GestaoRestricoesSoftware=@gestaorestricoessoftware " +
                                                        "WHERE IdCliente=@idcliente", conn))
                {
                    cmd.Parameters.AddWithValue("@idcliente", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@geralnumerosativos", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@geralvalorativo", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@geralvaloreconomico", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@geralcomplexidadeativo", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@geralheteroativo", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@poderlogicanegocio", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@poderprocessamento", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@poderrequerimentos", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@podergestaolocal", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@outrosfonteenergia", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@outrosambiente", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@gestaovidautil", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@gestaorestricoeshardware", ativos.IdCliente);
                    cmd.Parameters.AddWithValue("@gestaorestricoessoftware", ativos.IdCliente);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}