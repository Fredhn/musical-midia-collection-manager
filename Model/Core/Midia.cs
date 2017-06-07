using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumCollectionManager.Model.Core
{
    public abstract class Midia
    {
        public string nome_album { get; private set; }
        public string artista { get; private set; }
        public int ano_lancamento { get; private set; }
        public string gravadora { get; private set; }
        public string publisher { get; private set; }
        public int duracao { get; private set; }
        public int numero_faixas { get; private set; }
        public float valor_compra { get; private set; }
        public string genero { get; private set; }
        public int estrelas { get; private set; }

        protected Midia (string nome_album)
        {
            this.nome_album = nome_album;
        }
        protected Midia (string nome_album, string artista, int ano_lancamento, string gravadora, string publisher, int numero_faixas, float valor_compra, string genero, int estrelas)
        {
            this.nome_album = nome_album;
            this.artista = artista;
            this.ano_lancamento = ano_lancamento;
            this.gravadora = gravadora;
            this.publisher = publisher;
            this.numero_faixas = numero_faixas;
            this.valor_compra = valor_compra;
            this.genero = genero;
            this.estrelas = estrelas;
        }

        public abstract void ExibirInfo();

    }
}
