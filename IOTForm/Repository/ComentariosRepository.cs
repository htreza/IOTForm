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
    public class ComentariosRepository
    {
        public bool InsertComentario(Comentarios comentario)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Comentarios (IdCampoTabela, NomeTabela, NomeColuna, Comentario)" +
                                                        "VALUES (@idcampotabela, @nometabela, @nomecoluna, @comentario)", conn))
                {
                    cmd.Parameters.AddWithValue("@idcampotabela", comentario.IdCampoTabela);
                    cmd.Parameters.AddWithValue("@nometabela", comentario.IdCampoTabela);
                    cmd.Parameters.AddWithValue("@nomecoluna", comentario.IdCampoTabela);
                    cmd.Parameters.AddWithValue("@comentario", comentario.IdCampoTabela);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool UpdateComentario(Comentarios comentario)
        {
            using (SqlConnection conn = DBConnection.AbrirConn())
            {
                using (SqlCommand cmd = new SqlCommand(@"UPDATE Comentarios SET NomeTabela= @nometabela, NomeColuna=@nomecoluna,"+
                                                        "Comentario=@comentario WHERE IdCampoTabela=@idcampotabela", conn))
                {
                    cmd.Parameters.AddWithValue("@idcampotabela", comentario.IdCampoTabela);
                    cmd.Parameters.AddWithValue("@nometabela", comentario.IdCampoTabela);
                    cmd.Parameters.AddWithValue("@nomecoluna", comentario.IdCampoTabela);
                    cmd.Parameters.AddWithValue("@comentario", comentario.IdCampoTabela);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}