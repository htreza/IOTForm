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
    public class QuestionarioRepository
    {
        public bool InsertQuestionario(Questionario questionario)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Questionario (Questao) VALUES (@questao)", conn))
                {
                    cmd.Parameters.AddWithValue("@questao", questionario.Questao);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateQuestionario(Questionario questionario)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Questionario SET Questao=@questao, Status=@status VALUES (@questao)", conn))
                {
                    cmd.Parameters.AddWithValue("@questao", questionario.Questao);
                    cmd.Parameters.AddWithValue("@status", questionario.Status);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


        public bool InsertQuestionarioResposta(QuestionarioRespostas[] respostas)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO QuestionarioRespostas (IdCliente, IdQuestao, Resposta, RespostaTexto) VALUES (@id, @idcliente, @idquestao, @resposta, @respostatexto)", conn))
                {

                    foreach (QuestionarioRespostas resposta in respostas)
                    {
                        cmd.Parameters.AddWithValue("@idcliente", resposta.IdCliente);
                        cmd.Parameters.AddWithValue("@idquestao", resposta.IdQuestao);
                        cmd.Parameters.AddWithValue("@resposta", resposta.Resposta);
                        cmd.Parameters.AddWithValue("@respostatexto", resposta.RespostaTexto);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }            
        }

        public bool UpdateQuestionarioResposta(QuestionarioRespostas[] respostas)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                using (SqlCommand cmd = new SqlCommand(@"UPDATE QuestionarioRespostas SET IdCliente=@idcliente, IdQuestao=@idquestao,
                                                        Resposta=@resposta, RespostaTexto=@respostatexto WHERE Id=@id", conn))
                {

                    foreach (QuestionarioRespostas resposta in respostas)
                    {
                        cmd.Parameters.AddWithValue("@id", resposta.Id);
                        cmd.Parameters.AddWithValue("@idcliente", resposta.IdCliente);
                        cmd.Parameters.AddWithValue("@idquestao", resposta.IdQuestao);
                        cmd.Parameters.AddWithValue("@resposta", resposta.Resposta);
                        cmd.Parameters.AddWithValue("@respostatexto", resposta.RespostaTexto);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
        }
    }
}