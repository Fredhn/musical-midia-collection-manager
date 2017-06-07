using System;
using System.Windows.Forms;
using AlbumCollectionManager.Model.Type;
using AlbumCollectionManager.Model.Factory;
using AlbumCollectionManager.View.Tools;
using AlbumCollectionManager.Control.Adapter;
using AlbumCollectionManager.Template;
using System.Threading.Tasks;

namespace AlbumCollectionManager.View
{
    public partial class Form_Main : Form
    {

        FormatCollectionListView clv;
        ListViewAdapter lva;
        MidiaFactory new_factory = null;
        TextBoxLoader tbl;
        OrderingTemplate ordering;
        ListViewItem[] newListviewitems;

        public Form_Main()
        {
            InitializeComponent();
            DisableTextBoxes();
            this.listView_pnlCollections_Albuns.ItemActivate += ListViewPnlCollections_ItemClick;
            //Classe permite formatar o componente List View com o padrão determinado em 'InitializeStandardCollectionListView'
            clv = new FormatCollectionListView(this);
            clv.InitializeStandardCollectionListView();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //Carrega a ComboBox de tipos de midia no 'Panel New Album'
            foreach (var item in Enum.GetValues(typeof(MidiaType)))
            {
                comboBox_pnlNewAlbum_albumType.Items.Add(item);
            }

            //Carrega a ComboBox de coleções no 'Panel Collections
            foreach (var item in Enum.GetValues(typeof(CollectionsViewType)))
            {
                comboBox_pnlCollections_ColecaoSelecionada.Items.Add(item);
            }

            //Carrega a ComboBox de tipos de gênero musical no 'Panel Collection'
            foreach (var item in Enum.GetValues(typeof(GenreType)))
            {
                comboBox_pnlCollections_Genero.Items.Add(item);
            }
        }

        #region ToolStrip Event Methods

        private void toolStripBtn_newAlbum_Click(object sender, EventArgs e)
        {
            if (panel_NewAlbum.Visible == false)
            {
                panel_NewAlbum.Visible = true;
                panel_Collection.Visible = false;
                tb_pnlNewAlbum_albumTitle.Text = "";
                comboBox_pnlNewAlbum_albumType.Text = "";
            }
            else
            {
                panel_NewAlbum.Visible = false;
            }

        }

        private void toolStripBtn_collection_Click(object sender, EventArgs e)
        {
            if (panel_Collection.Visible == false)
            {
                panel_Collection.Visible = true;
                panel_NewAlbum.Visible = false;

                CleanPnlCollectionTb();
            }
            else
            {
                panel_Collection.Visible = false;
                NormalizeBtnSave();
                DisableTextBoxes();
            }
        }
        #endregion

        #region Panel New Album Controls
        private void pb_pnlNewAlbum_closePnl_Click(object sender, EventArgs e)
        {
            panel_NewAlbum.Visible = false;
            comboBox_pnlNewAlbum_albumType.Text = "";
            tb_pnlNewAlbum_albumTitle.Text = "";
        }

        private void btn_pnlNewAlbum_saveNewAlbum_Click(object sender, EventArgs e)
        {
            //Recebe o tipo de midia selecionado na combo box
            MidiaType album_type = (MidiaType)comboBox_pnlNewAlbum_albumType.SelectedItem;


            switch (album_type)
            {
                case MidiaType.TAPE:
                    new_factory = new TapeFactory();
                    new_factory.CreateMidia(album_type, tb_pnlNewAlbum_albumTitle.Text);

                    break;
                case MidiaType.VINYL:
                    new_factory = new VinylFactory();
                    new_factory.CreateMidia(album_type, tb_pnlNewAlbum_albumTitle.Text);

                    break;
                case MidiaType.CD:
                    new_factory = new CDFactory();
                    new_factory.CreateMidia(album_type, tb_pnlNewAlbum_albumTitle.Text);

                    break;
                case MidiaType.DVD:
                    new_factory = new DVDFactory();
                    new_factory.CreateMidia(album_type, tb_pnlNewAlbum_albumTitle.Text);

                    break;
                case MidiaType.BLURAY:
                    new_factory = new BluRayFactory();
                    new_factory.CreateMidia(album_type, tb_pnlNewAlbum_albumTitle.Text);

                    break;
                case MidiaType.VCR:
                    new_factory = new VCRFactory();
                    new_factory.CreateMidia(album_type, tb_pnlNewAlbum_albumTitle.Text);

                    break;
            }

            panel_NewAlbum.Visible = false;
        }
        #endregion

        #region Panel Collection Controls

        //Evento PbClosePanelCollection_Click
        private void pb_panelCollection_Close_Click(object sender, EventArgs e)
        {
            panel_Collection.Visible = false;

            NormalizeBtnSave();
            DisableTextBoxes();
            CleanPnlCollectionTb();
        }

        //Evento SaveButton_Click
        private void btn_pnlCollections_Salvar_Click(object sender, EventArgs e)
        {
            if (btn_pnlCollections_Salvar.Text == "Edit")
            {
                if (listView_pnlCollections_Albuns.SelectedItems.Count > 0 && tb_pnlCollections_NomeAlbum.Text != "")
                {
                    EnableTextBoxes();
                    btn_pnlCollections_Salvar.Text = "Save";
                    btn_pnlCollections_Salvar.BackColor = System.Drawing.Color.LightGreen;
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure to edit this item?",
                                     "Confirm Edit!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    NormalizeBtnSave();
                    DisableTextBoxes();
                    UploadAlbumData();
                    this.listView_pnlCollections_Albuns.Items.Clear();
                    PopulateLV();
                }
                else
                {
                    NormalizeBtnSave();
                    DisableTextBoxes();
                }            
            }
        }

        //Evento DeleteButton_Click
        private void btn_pnlCollections_Delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this item?",
                                     "Confirm Delete!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (listView_pnlCollections_Albuns.SelectedItems.Count > 0)
                {
                    var codigo = listView_pnlCollections_Albuns.Items[listView_pnlCollections_Albuns.SelectedItems[0].Index].SubItems[4];
                    MidiaType album_type = (MidiaType)comboBox_pnlCollections_ColecaoSelecionada.SelectedItem;

                    switch (album_type)
                    {
                        case MidiaType.TAPE:
                            new_factory = new TapeFactory();
                            new_factory.EraseMidia(int.Parse(codigo.Text));

                            break;
                        case MidiaType.VINYL:
                            new_factory = new VinylFactory();
                            new_factory.EraseMidia(int.Parse(codigo.Text));

                            break;
                        case MidiaType.CD:
                            new_factory = new CDFactory();
                            new_factory.EraseMidia(int.Parse(codigo.Text));

                            break;
                        case MidiaType.DVD:
                            new_factory = new DVDFactory();
                            new_factory.EraseMidia(int.Parse(codigo.Text));

                            break;
                        case MidiaType.BLURAY:
                            new_factory = new BluRayFactory();
                            new_factory.EraseMidia(int.Parse(codigo.Text));

                            break;
                        case MidiaType.VCR:
                            new_factory = new VCRFactory();
                            new_factory.EraseMidia(int.Parse(codigo.Text));

                            break;
                    }
                }
            }
            else
            {
                // If 'No', do something here.
            }
            listView_pnlCollections_Albuns.Items.Clear();
            PopulateLV();
        }

        //Evento ListViewItem_Click
        private void ListViewPnlCollections_ItemClick(object sender, EventArgs e)
        {
            NormalizeBtnSave();
            DisableTextBoxes();
            CleanPnlCollectionTb();
            //Recupera o Id do ListViewItem selecionado
            var codigo = listView_pnlCollections_Albuns.Items[listView_pnlCollections_Albuns.SelectedItems[0].Index].SubItems[4];

            CollectionsViewType collection_type = (CollectionsViewType)comboBox_pnlCollections_ColecaoSelecionada.SelectedItem;

            switch (collection_type)
            {
                case CollectionsViewType.TAPE:
                    lva = new TapeAdapter();
                    tbl = new TextBoxLoader(this, lva.BuildTextBoxData(int.Parse(codigo.Text)));
                    tbl.DoIt();

                    break;
                case CollectionsViewType.VINYL:
                    lva = new VinylAdapter();
                    tbl = new TextBoxLoader(this, lva.BuildTextBoxData(int.Parse(codigo.Text)));
                    tbl.DoIt();

                    break;
                case CollectionsViewType.CD:
                    lva = new CDAdapter();
                    tbl = new TextBoxLoader(this, lva.BuildTextBoxData(int.Parse(codigo.Text)));
                    tbl.DoIt();

                    break;
                case CollectionsViewType.DVD:
                    lva = new DVDAdapter();
                    tbl = new TextBoxLoader(this, lva.BuildTextBoxData(int.Parse(codigo.Text)));
                    tbl.DoIt();

                    break;
                case CollectionsViewType.BLURAY:
                    lva = new BluRayAdapter();
                    tbl = new TextBoxLoader(this, lva.BuildTextBoxData(int.Parse(codigo.Text)));
                    tbl.DoIt();

                    break;
                case CollectionsViewType.VCR:
                    lva = new VCRAdapter();
                    tbl = new TextBoxLoader(this, lva.BuildTextBoxData(int.Parse(codigo.Text)));
                    tbl.DoIt();

                    break;
            }
        }

        //Evento ComboBox ListViewCollection_IndexChange
        private void listView_pnlCollections_Albuns_SelectedIndexChanged(object sender, EventArgs e)
        {
            NormalizaListView();
            CleanPnlCollectionTb();
            NormalizeBtnSave();
            DisableTextBoxes();
            this.listView_pnlCollections_Albuns.Items.Clear();
            PopulateLV();
        }
        //Evento ListView Column Click
        private void ColumnClick(object sender, ColumnClickEventArgs e)
        { 
            //this.listView_pnlCollections_Albuns.ItemActivate += ListViewPnlCollections_ItemClick;
            string column = e.Column.ToString();
            OrderListView(column);
        }

        /// <summary>
        /// /Popula ListView com o tipo de midia determinado no ComboBox
        /// </summary>
        private void PopulateLV()
        {

            CollectionsViewType collection_type = (CollectionsViewType)comboBox_pnlCollections_ColecaoSelecionada.SelectedItem;

            switch (collection_type)
            {
                case CollectionsViewType.TAPE:
                    btn_pnlCollections_Delete.Visible = true;
                    btn_pnlCollections_Salvar.Visible = true;
                    lva = new TapeAdapter();
                    listView_pnlCollections_Albuns.Items.AddRange(lva.BuildItemsList());

                    break;
                case CollectionsViewType.VINYL:
                    btn_pnlCollections_Delete.Visible = true;
                    btn_pnlCollections_Salvar.Visible = true;
                    lva = new VinylAdapter();
                    listView_pnlCollections_Albuns.Items.AddRange(lva.BuildItemsList());

                    break;
                case CollectionsViewType.CD:
                    btn_pnlCollections_Delete.Visible = true;
                    btn_pnlCollections_Salvar.Visible = true;
                    lva = new CDAdapter();
                    listView_pnlCollections_Albuns.Items.AddRange(lva.BuildItemsList());

                    break;
                case CollectionsViewType.DVD:
                    btn_pnlCollections_Delete.Visible = true;
                    btn_pnlCollections_Salvar.Visible = true;
                    lva = new DVDAdapter();
                    listView_pnlCollections_Albuns.Items.AddRange(lva.BuildItemsList());

                    break;
                case CollectionsViewType.BLURAY:
                    btn_pnlCollections_Delete.Visible = true;
                    btn_pnlCollections_Salvar.Visible = true;
                    lva = new BluRayAdapter();
                    listView_pnlCollections_Albuns.Items.AddRange(lva.BuildItemsList());

                    break;
                case CollectionsViewType.VCR:
                    btn_pnlCollections_Delete.Visible = true;
                    btn_pnlCollections_Salvar.Visible = true;
                    lva = new VCRAdapter();
                    listView_pnlCollections_Albuns.Items.AddRange(lva.BuildItemsList());

                    break;
                case CollectionsViewType.ALL:
                    listView_pnlCollections_Albuns.BringToFront();
                    listView_pnlCollections_Albuns.Height = 255;
                    listView_pnlCollections_Albuns.Location = new System.Drawing.Point(9, 32);

                    btn_pnlCollections_Delete.Visible = false;
                    btn_pnlCollections_Salvar.Visible = false;
                    lva = new BluRayAdapter();
                    listView_pnlCollections_Albuns.Items.AddRange(lva.BuildItemsList());
                    lva = new CDAdapter();
                    listView_pnlCollections_Albuns.Items.AddRange(lva.BuildItemsList());
                    lva = new DVDAdapter();
                    listView_pnlCollections_Albuns.Items.AddRange(lva.BuildItemsList());
                    lva = new TapeAdapter();
                    listView_pnlCollections_Albuns.Items.AddRange(lva.BuildItemsList());
                    lva = new VCRAdapter();
                    listView_pnlCollections_Albuns.Items.AddRange(lva.BuildItemsList());
                    lva = new VinylAdapter();
                    listView_pnlCollections_Albuns.Items.AddRange(lva.BuildItemsList());

                    break;
            }
        }
        /// <summary>
        /// /Chama o Factory.UpdateMidia para atualizar dados sobre albuns
        /// </summary>
        private void UploadAlbumData()
        {
            if (listView_pnlCollections_Albuns.SelectedItems.Count > 0 && tb_pnlCollections_NomeAlbum.Text != "")
            {
                var codigo = listView_pnlCollections_Albuns.Items[listView_pnlCollections_Albuns.SelectedItems[0].Index].SubItems[4];
                MidiaType album_type = (MidiaType)comboBox_pnlCollections_ColecaoSelecionada.SelectedItem;

                switch (album_type)
                {
                    case MidiaType.TAPE:
                        new_factory = new TapeFactory();
                        new_factory.EditMidia(int.Parse(codigo.Text), tb_pnlCollections_NomeAlbum.Text, tb_pnlCollections_Artista.Text,
                                                int.Parse(tb_pnlCollections_AnoLancamento.Text), tb_pnlCollections_Gravadora.Text, tb_pnlCollections_Publisher.Text,
                                                int.Parse(tb_pnlCollections_QtdFaixas.Text), float.Parse(tb_pnlCollections_ValorCompra.Text), comboBox_pnlCollections_Genero.Text,
                                                int.Parse(tb_pnlCollections_Estrelas.Text));

                        break;
                    case MidiaType.VINYL:
                        new_factory = new VinylFactory();
                        new_factory.EditMidia(int.Parse(codigo.Text), tb_pnlCollections_NomeAlbum.Text, tb_pnlCollections_Artista.Text,
                                                int.Parse(tb_pnlCollections_AnoLancamento.Text), tb_pnlCollections_Gravadora.Text, tb_pnlCollections_Publisher.Text,
                                                int.Parse(tb_pnlCollections_QtdFaixas.Text), float.Parse(tb_pnlCollections_ValorCompra.Text), comboBox_pnlCollections_Genero.Text,
                                                int.Parse(tb_pnlCollections_Estrelas.Text));

                        break;
                    case MidiaType.CD:
                        new_factory = new CDFactory();
                        new_factory.EditMidia(int.Parse(codigo.Text), tb_pnlCollections_NomeAlbum.Text, tb_pnlCollections_Artista.Text,
                                                int.Parse(tb_pnlCollections_AnoLancamento.Text), tb_pnlCollections_Gravadora.Text, tb_pnlCollections_Publisher.Text,
                                                int.Parse(tb_pnlCollections_QtdFaixas.Text), float.Parse(tb_pnlCollections_ValorCompra.Text), comboBox_pnlCollections_Genero.Text,
                                                int.Parse(tb_pnlCollections_Estrelas.Text));

                        break;
                    case MidiaType.DVD:
                        new_factory = new DVDFactory();
                        new_factory.EditMidia(int.Parse(codigo.Text), tb_pnlCollections_NomeAlbum.Text, tb_pnlCollections_Artista.Text,
                                                int.Parse(tb_pnlCollections_AnoLancamento.Text), tb_pnlCollections_Gravadora.Text, tb_pnlCollections_Publisher.Text,
                                                int.Parse(tb_pnlCollections_QtdFaixas.Text), float.Parse(tb_pnlCollections_ValorCompra.Text), comboBox_pnlCollections_Genero.Text,
                                                int.Parse(tb_pnlCollections_Estrelas.Text));

                        break;
                    case MidiaType.BLURAY:
                        new_factory = new BluRayFactory();
                        new_factory.EditMidia(int.Parse(codigo.Text), tb_pnlCollections_NomeAlbum.Text, tb_pnlCollections_Artista.Text,
                                                int.Parse(tb_pnlCollections_AnoLancamento.Text), tb_pnlCollections_Gravadora.Text, tb_pnlCollections_Publisher.Text,
                                                int.Parse(tb_pnlCollections_QtdFaixas.Text), float.Parse(tb_pnlCollections_ValorCompra.Text), comboBox_pnlCollections_Genero.Text,
                                                int.Parse(tb_pnlCollections_Estrelas.Text));

                        break;
                    case MidiaType.VCR:
                        new_factory = new VCRFactory();
                        new_factory.EditMidia(int.Parse(codigo.Text), tb_pnlCollections_NomeAlbum.Text, tb_pnlCollections_Artista.Text,
                                                int.Parse(tb_pnlCollections_AnoLancamento.Text), tb_pnlCollections_Gravadora.Text, tb_pnlCollections_Publisher.Text,
                                                int.Parse(tb_pnlCollections_QtdFaixas.Text), float.Parse(tb_pnlCollections_ValorCompra.Text), comboBox_pnlCollections_Genero.Text,
                                                int.Parse(tb_pnlCollections_Estrelas.Text));

                        break;
                }
            }
        }
        /// <summary>
        /// /Limpa as TextBoxes do Panel Collections
        /// </summary>
        private void CleanPnlCollectionTb()
        {
            tb_pnlCollections_NomeAlbum.Text = "";
            tb_pnlCollections_Artista.Text = "";
            tb_pnlCollections_AnoLancamento.Text = "";
            tb_pnlCollections_Publisher.Text = "";
            tb_pnlCollections_Gravadora.Text = "";
            tb_pnlCollections_QtdFaixas.Text = "";
            tb_pnlCollections_ValorCompra.Text = "";
            tb_pnlCollections_Estrelas.Text = "";
            comboBox_pnlCollections_Genero.Text = "";
        }
        /// <summary>
        /// /Desabilita as TextBoxes do Panel Collections para edição
        /// </summary>
        private void DisableTextBoxes()
        {
            tb_pnlCollections_NomeAlbum.Enabled = false;
            tb_pnlCollections_Artista.Enabled = false;
            tb_pnlCollections_AnoLancamento.Enabled = false;
            tb_pnlCollections_Gravadora.Enabled = false;
            tb_pnlCollections_Publisher.Enabled = false;
            tb_pnlCollections_Estrelas.Enabled = false;
            tb_pnlCollections_QtdFaixas.Enabled = false;
            tb_pnlCollections_ValorCompra.Enabled = false;
            comboBox_pnlCollections_Genero.Enabled = false;
        }
        /// <summary>
        /// /Habilita as TextBoxes do Panel Collections para edição
        /// </summary>
        private void EnableTextBoxes()
        {
            tb_pnlCollections_NomeAlbum.Enabled = true;
            tb_pnlCollections_Artista.Enabled = true;
            tb_pnlCollections_AnoLancamento.Enabled = true;
            tb_pnlCollections_Gravadora.Enabled = true;
            tb_pnlCollections_Publisher.Enabled = true;
            tb_pnlCollections_Estrelas.Enabled = true;
            tb_pnlCollections_QtdFaixas.Enabled = true;
            tb_pnlCollections_ValorCompra.Enabled = true;
            comboBox_pnlCollections_Genero.Enabled = true;
        }
        /// <summary>
        /// /Normaliza a aparência do Button Save (Panel Collections)
        /// </summary>
        private void NormalizeBtnSave()
        {
            btn_pnlCollections_Salvar.Text = "Edit";
            btn_pnlCollections_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
        }
        /// <summary>
        /// /Normaliza a aparência da ListView Collections
        /// </summary>
        private void NormalizaListView()
        {
            listView_pnlCollections_Albuns.Location = new System.Drawing.Point(9, 167);
            listView_pnlCollections_Albuns.Size = new System.Drawing.Size(446, 125);
        }
        /// <summary>
        /// /Método que busca os items da ListView e chama as respectivas entidades ordenadores
        /// </summary>
        private void OrderListView(string column)
        {
            //Recupera os itens da ListView em um Array
            ListViewItem[] listviewitems = new ListViewItem[this.listView_pnlCollections_Albuns.Items.Count];
            newListviewitems = new ListViewItem[this.listView_pnlCollections_Albuns.Items.Count];
            int indx = 0;
            foreach (ListViewItem itemRow in this.listView_pnlCollections_Albuns.Items)
            {
                listviewitems.SetValue(itemRow, indx);
                indx++;
            }

            switch (column)
            {
                case "0":
                    ordering = new Ordering_byAlbumName();
                    newListviewitems = ordering.ordenarAlbuns(listviewitems);
                    this.listView_pnlCollections_Albuns.Items.Clear();
                    break;

                case "1":
                    ordering = new Ordering_byArtist();
                    newListviewitems = ordering.ordenarAlbuns(listviewitems);
                    this.listView_pnlCollections_Albuns.Items.Clear();
                    break;

                case "2":
                    ordering = new Ordering_byGenre();
                    newListviewitems = ordering.ordenarAlbuns(listviewitems);
                    this.listView_pnlCollections_Albuns.Items.Clear();
                    break;

                case "3":
                    ordering = new Ordering_byYear();
                    newListviewitems = ordering.ordenarAlbuns(listviewitems);
                    this.listView_pnlCollections_Albuns.Items.Clear();
                    break;

                //case "4":
                //    break;
            }
            ////this.listView_pnlCollections_Albuns.Items.AddRange(newListviewitems);

            if (column != "4")
            {
                Task t = new Task(new Action(() =>
                {
                    RefreshListViewLines();
                }));

                t.Start();
            }

         }
        /// <summary>
        /// /Método auxiliar ao OrderListView(), usa Delegate para conseguir reinserir os items ordenados na ListView
        /// </summary>
        public void RefreshListViewLines()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate { this.listView_pnlCollections_Albuns.Items.AddRange(newListviewitems);
                                                         this.listView_pnlCollections_Albuns.EnsureVisible(listView_pnlCollections_Albuns.Items.Count - 1);
                                                         Application.DoEvents();
                }));
            }
        }

        #endregion
    }
}