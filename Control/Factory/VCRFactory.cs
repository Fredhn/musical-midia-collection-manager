﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlbumCollectionManager.Model.Core;
using AlbumCollectionManager.Model.Type;
using System.Data.SqlClient;
using AlbumCollectionManager.Control.Data;
using System.Data;
using AlbumCollectionManager.Control.DataAccess;

namespace AlbumCollectionManager.Model.Factory
{
    public class VCRFactory : MidiaFactory
    {
        public VCRFactory() : base ()
        {

        }

        #region CRUD VCR
        public override Midia CreateMidia(MidiaType midia_type, string nome_album)
        {
            obj_dao = new VCR_DAO();
            new_album = obj_dao.InsertMidia(midia_type, nome_album);

            return new_album;

            //throw new NotImplementedException();
        }

        public override void EditMidia(int codigo, string nome_album, string artista, int ano_lancamento, string gravadora, string publisher, int numero_faixas, float valor_compra, string genero, int estrelas)
        {
            obj_dao = new VCR_DAO();
            obj_dao.UpdateMidia(codigo, nome_album, artista, ano_lancamento, gravadora, publisher, numero_faixas, valor_compra, genero, estrelas);

            //throw new NotImplementedException();
        }

        public override void EraseMidia(int codigo)
        {
            obj_dao = new VCR_DAO();
            obj_dao.DeleteMidia(codigo);

            //throw new NotImplementedException();
        }
        #endregion
    }
}
