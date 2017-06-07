using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlbumCollectionManager.View;
using System.Windows.Forms;

namespace AlbumCollectionManager.View.Tools
{
    public class FormatCollectionListView
    {
        Form_Main frm;
        public FormatCollectionListView(Form_Main frm)
        {
            this.frm = frm;

        }

        public void InitializeStandardCollectionListView ()
        {
            frm.listView_pnlCollections_Albuns.View = System.Windows.Forms.View.Details;
            frm.listView_pnlCollections_Albuns.LabelEdit = true;
            frm.listView_pnlCollections_Albuns.AllowColumnReorder = true;
            frm.listView_pnlCollections_Albuns.FullRowSelect = true;
            frm.listView_pnlCollections_Albuns.GridLines = true;
            frm.listView_pnlCollections_Albuns.Sorting = SortOrder.None;

            frm.listView_pnlCollections_Albuns.Columns.Add("Album", 200, HorizontalAlignment.Left);
            frm.listView_pnlCollections_Albuns.Columns.Add("Artist", 70, HorizontalAlignment.Left);
            frm.listView_pnlCollections_Albuns.Columns.Add("Genre", 70, HorizontalAlignment.Left);
            frm.listView_pnlCollections_Albuns.Columns.Add("Ano", 70, HorizontalAlignment.Left);
            frm.listView_pnlCollections_Albuns.Columns.Add("Id", 30, HorizontalAlignment.Left);
        }
    }
}
