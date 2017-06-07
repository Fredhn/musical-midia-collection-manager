using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumCollectionManager.Model.Core
{
    public class VCR : Midia
    {
        public VCR (string nome_album) : base (nome_album)
        {

        }
        public VCR (string nome_album, string artista, int ano_lancamento, string gravadora, string publisher, int numero_faixas, float valor_compra, string genero, int estrelas)
               : base(nome_album, artista, ano_lancamento, gravadora, publisher, numero_faixas, valor_compra, genero, estrelas)
        {

        }
        public override void ExibirInfo()
        {
            throw new NotImplementedException();
        }

    }
}
