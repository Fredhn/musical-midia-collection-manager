using AlbumCollectionManager.Control.Data;
using AlbumCollectionManager.Model.Core;
using AlbumCollectionManager.Model.Type;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumCollectionManager.Control.DataAccess
{
    class CD_DAO : Midia_DAO
    {
        public override DataTable getData()
        {
            SqlDataAdapter ada = new SqlDataAdapter("select * from CD", SqlDbConnection.getOpenedConnection());
            DataTable dt = new DataTable();
            ada.Fill(dt);
            SqlDbConnection.cn.Close();

            return dt;
        }

        public override DataTable getSpecificItem(int codigo)
        {
            SqlDataAdapter ada = new SqlDataAdapter("select * from CD where Id = " + codigo.ToString(), SqlDbConnection.getOpenedConnection());
            DataTable dt = new DataTable();
            ada.Fill(dt);
            SqlDbConnection.cn.Close();

            return dt;
        }

        public override Midia InsertMidia(MidiaType midia_type, string nome_album)
        {
            Midia new_album = new CD(nome_album);

            string sql = "INSERT INTO CD (nome_album) " +
             "VALUES (@Nome_Album)";
            SqlCommand cmd = new SqlCommand(sql, SqlDbConnection.getConnection());
            cmd.Parameters.AddWithValue("@Nome_Album", nome_album);
            cmd.CommandType = CommandType.Text;
            SqlDbConnection.cn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    Console.WriteLine("Registro incluido com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());
            }
            finally
            {
                SqlDbConnection.cn.Close();
            }

            return new_album;
        }

        public override void UpdateMidia(int codigo, string nome_album, string artista, int ano_lancamento, string gravadora, string publisher, int numero_faixas, float valor_compra, string genero, int estrelas)
        {
            string sql = "UPDATE CD SET nome_album=@Nome_Album, artista=@Artista, ano_lancamento=@Ano_Lancamento, gravadora=@Gravadora, " +
                         "publisher=@Publisher, qtd_faixas=@Numero_Faixas, valor_compra=@Valor_Compra, genero=@Genero, estrelas=@Estrelas WHERE ID=@Id";
            SqlCommand cmd = new SqlCommand(sql, SqlDbConnection.getConnection());
            cmd.Parameters.AddWithValue("@Id", codigo);
            cmd.Parameters.AddWithValue("@Nome_Album", nome_album);
            cmd.Parameters.AddWithValue("@Artista", artista);
            cmd.Parameters.AddWithValue("@Ano_Lancamento", ano_lancamento);
            cmd.Parameters.AddWithValue("@Gravadora", gravadora);
            cmd.Parameters.AddWithValue("@Publisher", publisher);
            cmd.Parameters.AddWithValue("@Numero_Faixas", numero_faixas);
            cmd.Parameters.AddWithValue("@Valor_Compra", valor_compra);
            cmd.Parameters.AddWithValue("@Genero", genero);
            cmd.Parameters.AddWithValue("@Estrelas", estrelas);
            cmd.CommandType = CommandType.Text;
            SqlDbConnection.cn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    Console.WriteLine("Registro incluido com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());
            }
            finally
            {
                SqlDbConnection.cn.Close();
            }
            //throw new NotImplementedException();
        }

        public override void DeleteMidia(int codigo)
        {
            string sql = "DELETE FROM CD WHERE ID=@Id";
            SqlCommand cmd = new SqlCommand(sql, SqlDbConnection.getConnection());
            cmd.Parameters.AddWithValue("@Id", codigo);
            cmd.CommandType = CommandType.Text;
            SqlDbConnection.cn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    Console.WriteLine("Registro incluido com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString());
            }
            finally
            {
                SqlDbConnection.cn.Close();
            }
            //throw new NotImplementedException();
        }
    }
}
