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
    public class FormularioAssessmentRepository
    {
        public FormularioAssessment SelectFormulario(int IdCliente)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(@"SELECT
                                                            AP.AmbienteTempo, 
                                                            AP.AmbienteTempoC, 
                                                            AP.AmbienteBudget,
                                                            AP.AmbienteBudgetC,
                                                            AP.AmbienteFuncionais,
                                                            AP.AmbienteFuncionaisC,
                                                            AP.AmbienteTecnicas,
                                                            AP.AmbienteTecnicasC,
                                                            AD.GeralNumeroAtivos,
                                                            AD.GeralNumeroAtivosC,
                                                            AD.GeralValorAtivo,
                                                            AD.GeralValorAtivoC,
                                                            AD.GeralValorEconomico,
                                                            AD.GeralValorEconomicoC,
                                                            AD.GeralComplexidadeAtivo,
                                                            AD.GeralComplexidadeAtivoC,
                                                            AD.GeralHeteroAtivo,
                                                            AD.GeralHeteroAtivoC,
                                                            AD.PoderLogicaNegocio,
                                                            AD.PoderLogicaNegocioC,
                                                            AD.PoderProcessamento,
                                                            AD.PoderProcessamentoC,
                                                            AD.PoderRequerimentos,
                                                            AD.PoderRequerimentosC,
                                                            AD.PoderGestaoLocal,
                                                            AD.PoderGestaoLocalC,
                                                            AD.OutrosFonteEnergia,
                                                            AD.OutrosFonteEnergiaC,
                                                            AD.OutrosAmbiente,
                                                            AD.OutrosAmbienteC,
                                                            AD.GestaoVidaUtil,
                                                            AD.GestaoVidaUtilC,
                                                            AD.GestaoRestricoesHardware,
                                                            AD.GestaoRestricoesHardwareC,
                                                            AD.GestaoRestricoesSoftware,
                                                            AD.GestaoRestricoesSoftwareC,
                                                            PR.RequerimentosRegiao,
                                                            PR.RequerimentosRegiaoC,
                                                            PR.RequerimentosIndustria,
                                                            PR.RequerimentosIndustriaC,
                                                            PR.RequerimentosTecnologia,
                                                            PR.RequerimentosTecnologiaC,
                                                            PR.PadroesTecnicos,
                                                            PR.PadroesTecnicosC,
                                                            PR.PadroesFuncionais,
                                                            PR.PadroesFuncionaisC,
                                                            SB.GeralEstrategiaAplicacao,
                                                            SB.GeralEstrategiaAplicacaoC,
                                                            SB.GeralComplexidadeNegocio,
                                                            SB.GeralComplexidadeNegocioC,
                                                            SB.GeralIntegracaoBackend,
                                                            SB.GeralIntegracaoBackendC,
                                                            SB.GestaoVolumeDados,
                                                            SB.GestaoVolumeDadosC,
                                                            SB.GestaoVariedadeDados,
                                                            SB.GestaoVariedadeDadosC,
                                                            SB.GestaoVariabilidadeDados,
                                                            SB.GestaoVariabilidadeDadosC,
                                                            SB.GestaoAnalytics,
                                                            SB.GestaoAnalyticsC
                                                                FROM Cliente AS C
                                                                INNER JOIN AmbienteProjeto AS AP
                                                                    ON AP.IdCliente = C.Id
                                                                INNER JOIN AtivosDevices AS AD
                                                                    ON AD.IdCliente = C.Id
                                                                INNER JOIN PadroesRequerimentos AS PR
                                                                    ON PR.IdCliente = C.Id
                                                                INNER JOIN ServicosBackend AS SB
                                                                    ON SB.IdCliente = C.Id
                                                                    WHERE C.Id=@idcliente
                                                                ", conn))
                {
                    cmd.Parameters.AddWithValue("@idcliente", IdCliente);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read() == true)
                        {
                            return new FormularioAssessment(
                                new AmbienteProjeto
                                {
                                    AmbienteTempo = reader.GetInt32(0),
                                    AmbienteTempoC = reader.GetString(1),
                                    AmbienteBudget = reader.GetInt32(2),
                                    AmbienteBudgetC = reader.GetString(3),
                                    AmbienteFuncionais = reader.GetInt32(4),
                                    AmbienteFuncionaisC = reader.GetString(5),
                                    AmbienteTecnicas = reader.GetInt32(6),
                                    AmbienteTecnicasC = reader.GetString(7)
                                },
                                new AtivosDevices
                                {
                                    GeralNumeroAtivos = reader.GetInt32(8),
                                    GeralNumeroAtivosC = reader.GetString(9),
                                    GeralValorAtivo = reader.GetInt32(10),
                                    GeralValorAtivosC = reader.GetString(11),
                                    GeralValorEconomico = reader.GetInt32(12),
                                    GeralValorEconomicoC = reader.GetString(13),
                                    GeralComplexidadeAtivo = reader.GetInt32(14),
                                    GeralComplexidadeAtivoC = reader.GetString(15),
                                    GeralHeteroAtivo = reader.GetInt32(16),
                                    GeralHeteroAtivoC = reader.GetString(17),
                                    PoderLogicaNegocio = reader.GetInt32(18),
                                    PoderLogicaNegocioC = reader.GetString(19),
                                    PoderProcessamento = reader.GetInt32(20),
                                    PoderProcessamentoC = reader.GetString(21),
                                    PoderRequerimentos = reader.GetInt32(22),
                                    PoderRequerimentosC = reader.GetString(23),
                                    PoderGestaoLocal = reader.GetInt32(24),
                                    PoderGestaoLocalC = reader.GetString(25),
                                    OutrosFonteEnergia = reader.GetInt32(26),
                                    OutrosFontesEnergiaC = reader.GetString(27),
                                    OutrosAmbiente = reader.GetInt32(28),
                                    OutrosAmbienteC = reader.GetString(29),
                                    GestaoVidaUtil = reader.GetInt32(30),
                                    GestaoVidaUtilC = reader.GetString(31),
                                    GestaoRestricoesHardware = reader.GetInt32(32),
                                    GestaoRestricoesHardwareC = reader.GetString(33),
                                    GestaoRestricoesSoftware = reader.GetInt32(34),
                                    GestaoRestricoesSofrwareC = reader.GetString(35)

                                },
                                new PadroesRequerimentos
                                {
                                    RequerimentosRegiao = reader.GetInt32(36),
                                    RequerimentosRegiaoC = reader.GetString(37),
                                    RequerimentosIndustria = reader.GetInt32(38),
                                    RequerimentosIndustriaC = reader.GetString(39),
                                    RequerimentosTecnologia = reader.GetInt32(40),
                                    RequerimentosTecnologiaC = reader.GetString(41),
                                    PadroesTecnicos = reader.GetInt32(42),
                                    PadroesTecnicosC = reader.GetString(43),
                                    PadroesFuncionais = reader.GetInt32(44),
                                    PadroesFuncionaisC = reader.GetString(45)
                                },
                                new ServicosBackend
                                {
                                    GeralEstrategiaAplicacao = reader.GetInt32(46),
                                    GeralEstrategiaAplicacaoC = reader.GetString(47),
                                    GeralComplexidadeNegocio = reader.GetInt32(48),
                                    GeralComplexidadeNegocioC = reader.GetString(49),
                                    GeralIntegracaoBackend = reader.GetInt32(50),
                                    GeralIntegracaoBackendC = reader.GetString(51),
                                    GestaoVolumeDados = reader.GetInt32(52),
                                    GestaoVolumeDadosC = reader.GetString(53),
                                    GestaoVariedadeDados = reader.GetInt32(54),
                                    GestaoVariedadeDadosC = reader.GetString(55),
                                    GestaoVariabilidadeDados = reader.GetInt32(56),
                                    GestaoVariabilidadeDadosC = reader.GetString(57),
                                    GestaoAnalytics = reader.GetInt32(58),
                                    GestaoAnalyticsC = reader.GetString(59)
                                }
                            );
                        }
                    }
                }
            }
            return null;
        }

        public bool InsertFormulario(FormularioAssessment Formulario)
        {
            AmbienteProjetoRepository AmbienteProjeto = new AmbienteProjetoRepository();
            AtivosDevicesRepository AtivosDevices = new AtivosDevicesRepository();
            PadroesRequerimentosRepository PadroesRequerimentos = new PadroesRequerimentosRepository();
            ServicosBackendRepository ServicosBackend = new ServicosBackendRepository();

            if (AmbienteProjeto.InsertAmbienteProjeto(Formulario.AmbienteProjeto) && 
                AtivosDevices.InsertAtivosDevices(Formulario.AtivosDevices) && 
                PadroesRequerimentos.InsertPadroesRequerimentos(Formulario.PadroesRequerimentos) && 
                ServicosBackend.InsertServicosBackend(Formulario.ServicosBackend))
            {
                return true;
            }

            return false;
        }

        public bool UpdateFormulario(FormularioAssessment Formulario)
        {
            AmbienteProjetoRepository AmbienteProjeto = new AmbienteProjetoRepository();
            AtivosDevicesRepository AtivosDevices = new AtivosDevicesRepository();
            PadroesRequerimentosRepository PadroesRequerimentos = new PadroesRequerimentosRepository();
            ServicosBackendRepository ServicosBackend = new ServicosBackendRepository();

            if (AmbienteProjeto.UpdateAmbienteProjeto(Formulario.AmbienteProjeto) &&
                AtivosDevices.UpdateAtivosDevices(Formulario.AtivosDevices) &&
                PadroesRequerimentos.UpdatePadroesRequerimentos(Formulario.PadroesRequerimentos) &&
                ServicosBackend.UpdateServicosBackend(Formulario.ServicosBackend))
            {
                return true;
            }
            return false;
        }
    }
}