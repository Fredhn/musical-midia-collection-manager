using AlbumCollectionManager.Model.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumCollectionManager.Template
{
    class Ordering_byGenre : OrderingTemplate
    {
        public override bool isPrimeiro(ListViewItem album1, ListViewItem album2)
        {
            if (String.Compare(album1.SubItems[2].Text, album2.SubItems[2].Text, true) <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
