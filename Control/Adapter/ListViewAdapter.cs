using System.Data;
using System.Linq;
using System.Windows.Forms;
using AlbumCollectionManager.Control.DataAccess;

namespace AlbumCollectionManager.Control.Adapter
{
    public abstract class ListViewAdapter
    {
        protected DataTable dt;
        protected ListViewItem[] listitem;
        protected Midia_DAO dao;

        public ListViewAdapter ()
        {

        }

        public abstract ListViewItem[] BuildItemsList();

        public abstract DataRow BuildTextBoxData(int codigo);
    }
}
