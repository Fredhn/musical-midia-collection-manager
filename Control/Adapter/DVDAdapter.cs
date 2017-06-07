using AlbumCollectionManager.Control.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumCollectionManager.Control.Adapter
{
    public class DVDAdapter : ListViewAdapter
    {
        public DVDAdapter() : base()
        {

        }

        public override ListViewItem[] BuildItemsList()
        {
            dao = new DVD_DAO();
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
            dao = new DVD_DAO();
            dt = dao.getSpecificItem(codigo);

            DataRow dr = dt.Rows[0];
            return dr;
        }
    }
}
