using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlbumCollectionManager.Control.Data;
using AlbumCollectionManager.Model.Core;
using AlbumCollectionManager.Model.Type;

namespace AlbumCollectionManager.Control.DataAccess
{
    public abstract class Midia_DAO
    {
        public Midia_DAO()
        {

        }

        public abstract DataTable getData();
        public abstract DataTable getSpecificItem(int codigo);
        public abstract Midia InsertMidia(MidiaType midia_type, string nome_album);
        public abstract void UpdateMidia(int codigo, string nome_album, string artista, int ano_lancamento, string gravadora, string publisher, int numero_faixas, float valor_compra, string genero, int estrelas);
        public abstract void DeleteMidia(int codigo);

    }
}
