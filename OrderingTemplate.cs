using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlbumCollectionManager.Model.Core;
using System.Windows.Forms;

namespace AlbumCollectionManager.Template
{
    public abstract class OrderingTemplate
    {
        public abstract bool isPrimeiro(ListViewItem album1, ListViewItem album2);

        public ListViewItem[] ordenarAlbuns(ListViewItem[] itemsList)
        {
            ListViewItem[] newItemsList = new ListViewItem[itemsList.Length];
            for (int i = 0; i < itemsList.Length; i++)
            {
                newItemsList.SetValue(itemsList.GetValue(i), i);
            }

            for (int k = 0; k < newItemsList.Length; k++)
            {
                for (int j = k; j < newItemsList.Length; j++)
                {                   
                    if (!isPrimeiro(newItemsList[k], newItemsList[j]))
                    {
                        ListViewItem lviTemp = newItemsList[j];
                        newItemsList.SetValue(newItemsList[k], j);
                        newItemsList.SetValue(lviTemp, k);
                    }
                }
            }

            return newItemsList;
        }
    }
}
