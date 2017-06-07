using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlbumCollectionManager.Control.DataAccess;

namespace AlbumCollectionManager.Control.Adapter
{
    public class VCRAdapter : ListViewAdapter
    {        
        public VCRAdapter() : base()
        {
            
        }

        public override ListViewItem[] BuildItemsList()
        {
            dao = new VCR_DAO();
            dt = dao.getData();
            listitem = new ListViewItem[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                listitem[i] = new ListViewItem(dr["nome_album"].ToString());
                listitem[i].SubItems.Add(dr["artista"].ToString());
                listitem[i].SubItems.Add(dr["genero"].ToString());
                listitem[i].SubItems.Add(dr["ano_lancamento"].ToString());
                listitem[i].SubItems.Add(dr["Id"].ToString());

            }

            return listitem;
        }

        public override DataRow BuildTextBoxData(int codigo)
        {
            dao = new VCR_DAO();
            dt = dao.getSpecificItem(codigo);

            DataRow dr = dt.Rows[0];
            return dr;
        }
    }
}
