using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumCollectionManager.View.Tools
{
    public class TextBoxLoader
    {
        Form_Main frm;
        DataRow dr;

        public TextBoxLoader (Form_Main _frm, DataRow _dr)
        {
            this.frm = _frm;
            this.dr = _dr;
        }

        public void DoIt ()
        {
            frm.tb_pnlCollections_NomeAlbum.Text = dr["nome_album"].ToString();
            frm.tb_pnlCollections_Artista.Text = dr["artista"].ToString();
            frm.tb_pnlCollections_AnoLancamento.Text = dr["ano_lancamento"].ToString();
            frm.tb_pnlCollections_Gravadora.Text = dr["gravadora"].ToString();
            frm.tb_pnlCollections_Publisher.Text = dr["publisher"].ToString();
            frm.tb_pnlCollections_QtdFaixas.Text = dr["qtd_faixas"].ToString();
            frm.tb_pnlCollections_ValorCompra.Text = dr["valor_compra"].ToString();
            frm.comboBox_pnlCollections_Genero.Text = dr["genero"].ToString();
            frm.tb_pnlCollections_Estrelas.Text = dr["estrelas"].ToString();
        }

    }
}
