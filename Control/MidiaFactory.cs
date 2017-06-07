using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlbumCollectionManager.Model.Core;
using AlbumCollectionManager.Model.Type;
using AlbumCollectionManager.Control.DataAccess;

namespace AlbumCollectionManager.Model.Factory
{
    public abstract class MidiaFactory
    {
        public Midia_DAO obj_dao;
        public Midia new_album;
        public MidiaFactory()
        {

        }

        public abstract Midia CreateMidia(MidiaType midia_type, string nome_album);
        public abstract void EditMidia(int codigo, string nome_album, string artista, int ano_lancamento, string gravadora, string publisher, int numero_faixas, float valor_compra, string genero, int estrelas);
        public abstract void EraseMidia(int codigo);

    }
}
