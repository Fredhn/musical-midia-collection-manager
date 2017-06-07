using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlbumCollectionManager.Model.Core;
using System.Windows.Forms;

namespace AlbumCollectionManager.Template
{
    public class Ordering_byYear : OrderingTemplate
    {
        public override bool isPrimeiro(ListViewItem album1, ListViewItem album2)
        {
            Console.WriteLine("Ok Two!");
            int int1 = (int.Parse(album1.SubItems[3].Text));
            int int2 = (int.Parse(album2.SubItems[3].Text));
            //var codigo = listView_pnlCollections_Albuns.Items[listView_pnlCollections_Albuns.SelectedItems[0].Index].SubItems[4];
            if ((int.Parse(album1.SubItems[3].Text)) < (int.Parse(album2.SubItems[3].Text)))
            {
                return true;
            }
            return false;
        }
    }
}
