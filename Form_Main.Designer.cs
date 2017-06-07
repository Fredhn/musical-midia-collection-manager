using System.Windows.Forms;

namespace AlbumCollectionManager.View
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.toolStrip_FormMain = new System.Windows.Forms.ToolStrip();
            this.panel_NewAlbum = new System.Windows.Forms.Panel();
            this.btn_pnlNewAlbum_saveNewAlbum = new System.Windows.Forms.Button();
            this.label_pnlNewAlbum_NewAlbumTitle = new System.Windows.Forms.Label();
            this.label_pnlNewAlbum_NewAlbumMidia = new System.Windows.Forms.Label();
            this.tb_pnlNewAlbum_albumTitle = new System.Windows.Forms.TextBox();
            this.comboBox_pnlNewAlbum_albumType = new System.Windows.Forms.ComboBox();
            this.label_pnlNewAlbum_Title = new System.Windows.Forms.Label();
            this.panel_Collection = new System.Windows.Forms.Panel();
            this.lbl_pnlCollections_comboboxTitle = new System.Windows.Forms.Label();
            this.comboBox_pnlCollections_ColecaoSelecionada = new System.Windows.Forms.ComboBox();
            this.btn_pnlCollections_Delete = new System.Windows.Forms.Button();
            this.btn_pnlCollections_Salvar = new System.Windows.Forms.Button();
            this.comboBox_pnlCollections_Genero = new System.Windows.Forms.ComboBox();
            this.lbl_pnlCollections_Genero = new System.Windows.Forms.Label();
            this.lbl_pnlCollections_Estrelas = new System.Windows.Forms.Label();
            this.lbl_pnlCollections_ValorCompra = new System.Windows.Forms.Label();
            this.lbl_pnlCollections_QtdFaixas = new System.Windows.Forms.Label();
            this.lbl_pnlCollections_Gravadora = new System.Windows.Forms.Label();
            this.lbl_pnlCollections_Publisher = new System.Windows.Forms.Label();
            this.lbl_pnlCollections_DataLancamento = new System.Windows.Forms.Label();
            this.lbl_pnlCollections_Artista = new System.Windows.Forms.Label();
            this.lbl_pnlCollections_NomeAlbum = new System.Windows.Forms.Label();
            this.tb_pnlCollections_QtdFaixas = new System.Windows.Forms.TextBox();
            this.tb_pnlCollections_Gravadora = new System.Windows.Forms.TextBox();
            this.tb_pnlCollections_Publisher = new System.Windows.Forms.TextBox();
            this.tb_pnlCollections_Estrelas = new System.Windows.Forms.TextBox();
            this.tb_pnlCollections_ValorCompra = new System.Windows.Forms.TextBox();
            this.tb_pnlCollections_AnoLancamento = new System.Windows.Forms.TextBox();
            this.tb_pnlCollections_Artista = new System.Windows.Forms.TextBox();
            this.tb_pnlCollections_NomeAlbum = new System.Windows.Forms.TextBox();
            this.lbl_panelCollection_Title = new System.Windows.Forms.Label();
            this.toolStripBtn_newAlbum = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtn_collection = new System.Windows.Forms.ToolStripButton();
            this.listView_pnlCollections_Albuns = new System.Windows.Forms.ListView();
            this.pb_panelCollection_Close = new System.Windows.Forms.PictureBox();
            this.pb_pnlNewAlbum_closePnl = new System.Windows.Forms.PictureBox();
            this.toolStrip_FormMain.SuspendLayout();
            this.panel_NewAlbum.SuspendLayout();
            this.panel_Collection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_panelCollection_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pnlNewAlbum_closePnl)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip_FormMain
            // 
            this.toolStrip_FormMain.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip_FormMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtn_newAlbum,
            this.toolStripBtn_collection});
            this.toolStrip_FormMain.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_FormMain.Name = "toolStrip_FormMain";
            this.toolStrip_FormMain.Size = new System.Drawing.Size(627, 25);
            this.toolStrip_FormMain.TabIndex = 0;
            this.toolStrip_FormMain.Text = "toolStrip1";
            // 
            // panel_NewAlbum
            // 
            this.panel_NewAlbum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_NewAlbum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_NewAlbum.Controls.Add(this.btn_pnlNewAlbum_saveNewAlbum);
            this.panel_NewAlbum.Controls.Add(this.pb_pnlNewAlbum_closePnl);
            this.panel_NewAlbum.Controls.Add(this.label_pnlNewAlbum_NewAlbumTitle);
            this.panel_NewAlbum.Controls.Add(this.label_pnlNewAlbum_NewAlbumMidia);
            this.panel_NewAlbum.Controls.Add(this.tb_pnlNewAlbum_albumTitle);
            this.panel_NewAlbum.Controls.Add(this.comboBox_pnlNewAlbum_albumType);
            this.panel_NewAlbum.Controls.Add(this.label_pnlNewAlbum_Title);
            this.panel_NewAlbum.Location = new System.Drawing.Point(12, 29);
            this.panel_NewAlbum.Name = "panel_NewAlbum";
            this.panel_NewAlbum.Size = new System.Drawing.Size(602, 301);
            this.panel_NewAlbum.TabIndex = 1;
            this.panel_NewAlbum.Visible = false;
            // 
            // btn_pnlNewAlbum_saveNewAlbum
            // 
            this.btn_pnlNewAlbum_saveNewAlbum.Location = new System.Drawing.Point(253, 253);
            this.btn_pnlNewAlbum_saveNewAlbum.Name = "btn_pnlNewAlbum_saveNewAlbum";
            this.btn_pnlNewAlbum_saveNewAlbum.Size = new System.Drawing.Size(97, 23);
            this.btn_pnlNewAlbum_saveNewAlbum.TabIndex = 6;
            this.btn_pnlNewAlbum_saveNewAlbum.Text = "Save New Album";
            this.btn_pnlNewAlbum_saveNewAlbum.UseVisualStyleBackColor = true;
            this.btn_pnlNewAlbum_saveNewAlbum.Click += new System.EventHandler(this.btn_pnlNewAlbum_saveNewAlbum_Click);
            // 
            // label_pnlNewAlbum_NewAlbumTitle
            // 
            this.label_pnlNewAlbum_NewAlbumTitle.AutoSize = true;
            this.label_pnlNewAlbum_NewAlbumTitle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pnlNewAlbum_NewAlbumTitle.Location = new System.Drawing.Point(37, 191);
            this.label_pnlNewAlbum_NewAlbumTitle.Name = "label_pnlNewAlbum_NewAlbumTitle";
            this.label_pnlNewAlbum_NewAlbumTitle.Size = new System.Drawing.Size(138, 20);
            this.label_pnlNewAlbum_NewAlbumTitle.TabIndex = 4;
            this.label_pnlNewAlbum_NewAlbumTitle.Text = "New Album Title";
            // 
            // label_pnlNewAlbum_NewAlbumMidia
            // 
            this.label_pnlNewAlbum_NewAlbumMidia.AutoSize = true;
            this.label_pnlNewAlbum_NewAlbumMidia.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pnlNewAlbum_NewAlbumMidia.Location = new System.Drawing.Point(37, 140);
            this.label_pnlNewAlbum_NewAlbumMidia.Name = "label_pnlNewAlbum_NewAlbumMidia";
            this.label_pnlNewAlbum_NewAlbumMidia.Size = new System.Drawing.Size(148, 20);
            this.label_pnlNewAlbum_NewAlbumMidia.TabIndex = 3;
            this.label_pnlNewAlbum_NewAlbumMidia.Text = "New Album Midia";
            // 
            // tb_pnlNewAlbum_albumTitle
            // 
            this.tb_pnlNewAlbum_albumTitle.Location = new System.Drawing.Point(191, 193);
            this.tb_pnlNewAlbum_albumTitle.Name = "tb_pnlNewAlbum_albumTitle";
            this.tb_pnlNewAlbum_albumTitle.Size = new System.Drawing.Size(367, 20);
            this.tb_pnlNewAlbum_albumTitle.TabIndex = 2;
            // 
            // comboBox_pnlNewAlbum_albumType
            // 
            this.comboBox_pnlNewAlbum_albumType.FormattingEnabled = true;
            this.comboBox_pnlNewAlbum_albumType.Location = new System.Drawing.Point(191, 142);
            this.comboBox_pnlNewAlbum_albumType.Name = "comboBox_pnlNewAlbum_albumType";
            this.comboBox_pnlNewAlbum_albumType.Size = new System.Drawing.Size(121, 21);
            this.comboBox_pnlNewAlbum_albumType.TabIndex = 1;
            // 
            // label_pnlNewAlbum_Title
            // 
            this.label_pnlNewAlbum_Title.AutoSize = true;
            this.label_pnlNewAlbum_Title.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pnlNewAlbum_Title.Location = new System.Drawing.Point(31, 14);
            this.label_pnlNewAlbum_Title.Name = "label_pnlNewAlbum_Title";
            this.label_pnlNewAlbum_Title.Size = new System.Drawing.Size(540, 58);
            this.label_pnlNewAlbum_Title.TabIndex = 0;
            this.label_pnlNewAlbum_Title.Text = "Register a New Album";
            // 
            // panel_Collection
            // 
            this.panel_Collection.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_Collection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Collection.Controls.Add(this.lbl_pnlCollections_comboboxTitle);
            this.panel_Collection.Controls.Add(this.comboBox_pnlCollections_ColecaoSelecionada);
            this.panel_Collection.Controls.Add(this.btn_pnlCollections_Delete);
            this.panel_Collection.Controls.Add(this.btn_pnlCollections_Salvar);
            this.panel_Collection.Controls.Add(this.comboBox_pnlCollections_Genero);
            this.panel_Collection.Controls.Add(this.lbl_pnlCollections_Genero);
            this.panel_Collection.Controls.Add(this.lbl_pnlCollections_Estrelas);
            this.panel_Collection.Controls.Add(this.lbl_pnlCollections_ValorCompra);
            this.panel_Collection.Controls.Add(this.lbl_pnlCollections_QtdFaixas);
            this.panel_Collection.Controls.Add(this.lbl_pnlCollections_Gravadora);
            this.panel_Collection.Controls.Add(this.lbl_pnlCollections_Publisher);
            this.panel_Collection.Controls.Add(this.lbl_pnlCollections_DataLancamento);
            this.panel_Collection.Controls.Add(this.lbl_pnlCollections_Artista);
            this.panel_Collection.Controls.Add(this.lbl_pnlCollections_NomeAlbum);
            this.panel_Collection.Controls.Add(this.tb_pnlCollections_QtdFaixas);
            this.panel_Collection.Controls.Add(this.tb_pnlCollections_Gravadora);
            this.panel_Collection.Controls.Add(this.tb_pnlCollections_Publisher);
            this.panel_Collection.Controls.Add(this.tb_pnlCollections_Estrelas);
            this.panel_Collection.Controls.Add(this.tb_pnlCollections_ValorCompra);
            this.panel_Collection.Controls.Add(this.tb_pnlCollections_AnoLancamento);
            this.panel_Collection.Controls.Add(this.tb_pnlCollections_Artista);
            this.panel_Collection.Controls.Add(this.tb_pnlCollections_NomeAlbum);
            this.panel_Collection.Controls.Add(this.listView_pnlCollections_Albuns);
            this.panel_Collection.Controls.Add(this.pb_panelCollection_Close);
            this.panel_Collection.Controls.Add(this.lbl_panelCollection_Title);
            this.panel_Collection.Location = new System.Drawing.Point(12, 29);
            this.panel_Collection.Name = "panel_Collection";
            this.panel_Collection.Size = new System.Drawing.Size(602, 301);
            this.panel_Collection.TabIndex = 2;
            this.panel_Collection.Visible = false;
            // 
            // lbl_pnlCollections_comboboxTitle
            // 
            this.lbl_pnlCollections_comboboxTitle.AutoSize = true;
            this.lbl_pnlCollections_comboboxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnlCollections_comboboxTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_pnlCollections_comboboxTitle.Location = new System.Drawing.Point(490, 167);
            this.lbl_pnlCollections_comboboxTitle.Name = "lbl_pnlCollections_comboboxTitle";
            this.lbl_pnlCollections_comboboxTitle.Size = new System.Drawing.Size(82, 13);
            this.lbl_pnlCollections_comboboxTitle.TabIndex = 29;
            this.lbl_pnlCollections_comboboxTitle.Text = "View Collection:";
            // 
            // comboBox_pnlCollections_ColecaoSelecionada
            // 
            this.comboBox_pnlCollections_ColecaoSelecionada.FormattingEnabled = true;
            this.comboBox_pnlCollections_ColecaoSelecionada.Location = new System.Drawing.Point(468, 186);
            this.comboBox_pnlCollections_ColecaoSelecionada.Name = "comboBox_pnlCollections_ColecaoSelecionada";
            this.comboBox_pnlCollections_ColecaoSelecionada.Size = new System.Drawing.Size(121, 21);
            this.comboBox_pnlCollections_ColecaoSelecionada.TabIndex = 28;
            this.comboBox_pnlCollections_ColecaoSelecionada.SelectedIndexChanged += new System.EventHandler(this.listView_pnlCollections_Albuns_SelectedIndexChanged);
            // 
            // btn_pnlCollections_Delete
            // 
            this.btn_pnlCollections_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_pnlCollections_Delete.Location = new System.Drawing.Point(497, 253);
            this.btn_pnlCollections_Delete.Name = "btn_pnlCollections_Delete";
            this.btn_pnlCollections_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_pnlCollections_Delete.TabIndex = 27;
            this.btn_pnlCollections_Delete.Text = "Delete";
            this.btn_pnlCollections_Delete.UseVisualStyleBackColor = false;
            this.btn_pnlCollections_Delete.Click += new System.EventHandler(this.btn_pnlCollections_Delete_Click);
            // 
            // btn_pnlCollections_Salvar
            // 
            this.btn_pnlCollections_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_pnlCollections_Salvar.Location = new System.Drawing.Point(497, 219);
            this.btn_pnlCollections_Salvar.Name = "btn_pnlCollections_Salvar";
            this.btn_pnlCollections_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_pnlCollections_Salvar.TabIndex = 26;
            this.btn_pnlCollections_Salvar.Text = "Edit";
            this.btn_pnlCollections_Salvar.UseVisualStyleBackColor = false;
            this.btn_pnlCollections_Salvar.Click += new System.EventHandler(this.btn_pnlCollections_Salvar_Click);
            // 
            // comboBox_pnlCollections_Genero
            // 
            this.comboBox_pnlCollections_Genero.FormattingEnabled = true;
            this.comboBox_pnlCollections_Genero.Location = new System.Drawing.Point(346, 136);
            this.comboBox_pnlCollections_Genero.Name = "comboBox_pnlCollections_Genero";
            this.comboBox_pnlCollections_Genero.Size = new System.Drawing.Size(100, 21);
            this.comboBox_pnlCollections_Genero.TabIndex = 25;
            // 
            // lbl_pnlCollections_Genero
            // 
            this.lbl_pnlCollections_Genero.AutoSize = true;
            this.lbl_pnlCollections_Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnlCollections_Genero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_pnlCollections_Genero.Location = new System.Drawing.Point(346, 121);
            this.lbl_pnlCollections_Genero.Name = "lbl_pnlCollections_Genero";
            this.lbl_pnlCollections_Genero.Size = new System.Drawing.Size(45, 13);
            this.lbl_pnlCollections_Genero.TabIndex = 24;
            this.lbl_pnlCollections_Genero.Text = "Genre:";
            // 
            // lbl_pnlCollections_Estrelas
            // 
            this.lbl_pnlCollections_Estrelas.AutoSize = true;
            this.lbl_pnlCollections_Estrelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnlCollections_Estrelas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_pnlCollections_Estrelas.Location = new System.Drawing.Point(346, 78);
            this.lbl_pnlCollections_Estrelas.Name = "lbl_pnlCollections_Estrelas";
            this.lbl_pnlCollections_Estrelas.Size = new System.Drawing.Size(112, 13);
            this.lbl_pnlCollections_Estrelas.TabIndex = 23;
            this.lbl_pnlCollections_Estrelas.Text = "Evaluation (Stars):";
            // 
            // lbl_pnlCollections_ValorCompra
            // 
            this.lbl_pnlCollections_ValorCompra.AutoSize = true;
            this.lbl_pnlCollections_ValorCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnlCollections_ValorCompra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_pnlCollections_ValorCompra.Location = new System.Drawing.Point(346, 36);
            this.lbl_pnlCollections_ValorCompra.Name = "lbl_pnlCollections_ValorCompra";
            this.lbl_pnlCollections_ValorCompra.Size = new System.Drawing.Size(68, 13);
            this.lbl_pnlCollections_ValorCompra.TabIndex = 22;
            this.lbl_pnlCollections_ValorCompra.Text = "Price paid:";
            // 
            // lbl_pnlCollections_QtdFaixas
            // 
            this.lbl_pnlCollections_QtdFaixas.AutoSize = true;
            this.lbl_pnlCollections_QtdFaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnlCollections_QtdFaixas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_pnlCollections_QtdFaixas.Location = new System.Drawing.Point(179, 121);
            this.lbl_pnlCollections_QtdFaixas.Name = "lbl_pnlCollections_QtdFaixas";
            this.lbl_pnlCollections_QtdFaixas.Size = new System.Drawing.Size(108, 13);
            this.lbl_pnlCollections_QtdFaixas.TabIndex = 21;
            this.lbl_pnlCollections_QtdFaixas.Text = "Number of tracks:";
            // 
            // lbl_pnlCollections_Gravadora
            // 
            this.lbl_pnlCollections_Gravadora.AutoSize = true;
            this.lbl_pnlCollections_Gravadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnlCollections_Gravadora.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_pnlCollections_Gravadora.Location = new System.Drawing.Point(179, 78);
            this.lbl_pnlCollections_Gravadora.Name = "lbl_pnlCollections_Gravadora";
            this.lbl_pnlCollections_Gravadora.Size = new System.Drawing.Size(42, 13);
            this.lbl_pnlCollections_Gravadora.TabIndex = 20;
            this.lbl_pnlCollections_Gravadora.Text = "Label:";
            // 
            // lbl_pnlCollections_Publisher
            // 
            this.lbl_pnlCollections_Publisher.AutoSize = true;
            this.lbl_pnlCollections_Publisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnlCollections_Publisher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_pnlCollections_Publisher.Location = new System.Drawing.Point(179, 36);
            this.lbl_pnlCollections_Publisher.Name = "lbl_pnlCollections_Publisher";
            this.lbl_pnlCollections_Publisher.Size = new System.Drawing.Size(63, 13);
            this.lbl_pnlCollections_Publisher.TabIndex = 19;
            this.lbl_pnlCollections_Publisher.Text = "Publisher:";
            // 
            // lbl_pnlCollections_DataLancamento
            // 
            this.lbl_pnlCollections_DataLancamento.AutoSize = true;
            this.lbl_pnlCollections_DataLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnlCollections_DataLancamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_pnlCollections_DataLancamento.Location = new System.Drawing.Point(9, 121);
            this.lbl_pnlCollections_DataLancamento.Name = "lbl_pnlCollections_DataLancamento";
            this.lbl_pnlCollections_DataLancamento.Size = new System.Drawing.Size(85, 13);
            this.lbl_pnlCollections_DataLancamento.TabIndex = 18;
            this.lbl_pnlCollections_DataLancamento.Text = "Release year:";
            // 
            // lbl_pnlCollections_Artista
            // 
            this.lbl_pnlCollections_Artista.AutoSize = true;
            this.lbl_pnlCollections_Artista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnlCollections_Artista.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_pnlCollections_Artista.Location = new System.Drawing.Point(9, 78);
            this.lbl_pnlCollections_Artista.Name = "lbl_pnlCollections_Artista";
            this.lbl_pnlCollections_Artista.Size = new System.Drawing.Size(40, 13);
            this.lbl_pnlCollections_Artista.TabIndex = 17;
            this.lbl_pnlCollections_Artista.Text = "Artist:";
            // 
            // lbl_pnlCollections_NomeAlbum
            // 
            this.lbl_pnlCollections_NomeAlbum.AutoSize = true;
            this.lbl_pnlCollections_NomeAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pnlCollections_NomeAlbum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_pnlCollections_NomeAlbum.Location = new System.Drawing.Point(9, 36);
            this.lbl_pnlCollections_NomeAlbum.Name = "lbl_pnlCollections_NomeAlbum";
            this.lbl_pnlCollections_NomeAlbum.Size = new System.Drawing.Size(79, 13);
            this.lbl_pnlCollections_NomeAlbum.TabIndex = 16;
            this.lbl_pnlCollections_NomeAlbum.Text = "Album name:";
            // 
            // tb_pnlCollections_QtdFaixas
            // 
            this.tb_pnlCollections_QtdFaixas.Location = new System.Drawing.Point(179, 137);
            this.tb_pnlCollections_QtdFaixas.Name = "tb_pnlCollections_QtdFaixas";
            this.tb_pnlCollections_QtdFaixas.Size = new System.Drawing.Size(100, 20);
            this.tb_pnlCollections_QtdFaixas.TabIndex = 15;
            // 
            // tb_pnlCollections_Gravadora
            // 
            this.tb_pnlCollections_Gravadora.Location = new System.Drawing.Point(179, 94);
            this.tb_pnlCollections_Gravadora.Name = "tb_pnlCollections_Gravadora";
            this.tb_pnlCollections_Gravadora.Size = new System.Drawing.Size(100, 20);
            this.tb_pnlCollections_Gravadora.TabIndex = 14;
            // 
            // tb_pnlCollections_Publisher
            // 
            this.tb_pnlCollections_Publisher.Location = new System.Drawing.Point(179, 52);
            this.tb_pnlCollections_Publisher.Name = "tb_pnlCollections_Publisher";
            this.tb_pnlCollections_Publisher.Size = new System.Drawing.Size(100, 20);
            this.tb_pnlCollections_Publisher.TabIndex = 13;
            // 
            // tb_pnlCollections_Estrelas
            // 
            this.tb_pnlCollections_Estrelas.Location = new System.Drawing.Point(346, 94);
            this.tb_pnlCollections_Estrelas.Name = "tb_pnlCollections_Estrelas";
            this.tb_pnlCollections_Estrelas.Size = new System.Drawing.Size(100, 20);
            this.tb_pnlCollections_Estrelas.TabIndex = 11;
            // 
            // tb_pnlCollections_ValorCompra
            // 
            this.tb_pnlCollections_ValorCompra.Location = new System.Drawing.Point(346, 52);
            this.tb_pnlCollections_ValorCompra.Name = "tb_pnlCollections_ValorCompra";
            this.tb_pnlCollections_ValorCompra.Size = new System.Drawing.Size(100, 20);
            this.tb_pnlCollections_ValorCompra.TabIndex = 10;
            // 
            // tb_pnlCollections_AnoLancamento
            // 
            this.tb_pnlCollections_AnoLancamento.Location = new System.Drawing.Point(9, 135);
            this.tb_pnlCollections_AnoLancamento.Name = "tb_pnlCollections_AnoLancamento";
            this.tb_pnlCollections_AnoLancamento.Size = new System.Drawing.Size(100, 20);
            this.tb_pnlCollections_AnoLancamento.TabIndex = 9;
            // 
            // tb_pnlCollections_Artista
            // 
            this.tb_pnlCollections_Artista.Location = new System.Drawing.Point(9, 92);
            this.tb_pnlCollections_Artista.Name = "tb_pnlCollections_Artista";
            this.tb_pnlCollections_Artista.Size = new System.Drawing.Size(100, 20);
            this.tb_pnlCollections_Artista.TabIndex = 8;
            // 
            // tb_pnlCollections_NomeAlbum
            // 
            this.tb_pnlCollections_NomeAlbum.Location = new System.Drawing.Point(9, 50);
            this.tb_pnlCollections_NomeAlbum.Name = "tb_pnlCollections_NomeAlbum";
            this.tb_pnlCollections_NomeAlbum.Size = new System.Drawing.Size(100, 20);
            this.tb_pnlCollections_NomeAlbum.TabIndex = 7;
            // 
            // lbl_panelCollection_Title
            // 
            this.lbl_panelCollection_Title.AutoSize = true;
            this.lbl_panelCollection_Title.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_panelCollection_Title.Location = new System.Drawing.Point(195, -6);
            this.lbl_panelCollection_Title.Name = "lbl_panelCollection_Title";
            this.lbl_panelCollection_Title.Size = new System.Drawing.Size(208, 32);
            this.lbl_panelCollection_Title.TabIndex = 0;
            this.lbl_panelCollection_Title.Text = "My Collections";
            // 
            // toolStripBtn_newAlbum
            // 
            this.toolStripBtn_newAlbum.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripBtn_newAlbum.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_newAlbum.Image")));
            this.toolStripBtn_newAlbum.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_newAlbum.Name = "toolStripBtn_newAlbum";
            this.toolStripBtn_newAlbum.Size = new System.Drawing.Size(90, 22);
            this.toolStripBtn_newAlbum.Text = "New Album";
            this.toolStripBtn_newAlbum.Click += new System.EventHandler(this.toolStripBtn_newAlbum_Click);
            // 
            // toolStripBtn_collection
            // 
            this.toolStripBtn_collection.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripBtn_collection.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtn_collection.Image")));
            this.toolStripBtn_collection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtn_collection.Name = "toolStripBtn_collection";
            this.toolStripBtn_collection.Size = new System.Drawing.Size(86, 22);
            this.toolStripBtn_collection.Text = "Collections";
            this.toolStripBtn_collection.ToolTipText = "Collection";
            this.toolStripBtn_collection.Click += new System.EventHandler(this.toolStripBtn_collection_Click);
            // 
            // listView_pnlCollections_Albuns
            // 
            this.listView_pnlCollections_Albuns.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView_pnlCollections_Albuns.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_pnlCollections_Albuns.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView_pnlCollections_Albuns.Location = new System.Drawing.Point(9, 167);
            this.listView_pnlCollections_Albuns.MultiSelect = false;
            this.listView_pnlCollections_Albuns.Name = "listView_pnlCollections_Albuns";
            this.listView_pnlCollections_Albuns.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView_pnlCollections_Albuns.Size = new System.Drawing.Size(446, 125);
            this.listView_pnlCollections_Albuns.TabIndex = 6;
            this.listView_pnlCollections_Albuns.UseCompatibleStateImageBehavior = false;
            this.listView_pnlCollections_Albuns.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ColumnClick);
            // 
            // pb_panelCollection_Close
            // 
            this.pb_panelCollection_Close.Image = global::Album_Collection_Manager.Properties.Resources.cancel;
            this.pb_panelCollection_Close.Location = new System.Drawing.Point(570, 4);
            this.pb_panelCollection_Close.Name = "pb_panelCollection_Close";
            this.pb_panelCollection_Close.Size = new System.Drawing.Size(25, 25);
            this.pb_panelCollection_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_panelCollection_Close.TabIndex = 5;
            this.pb_panelCollection_Close.TabStop = false;
            this.pb_panelCollection_Close.Click += new System.EventHandler(this.pb_panelCollection_Close_Click);
            // 
            // pb_pnlNewAlbum_closePnl
            // 
            this.pb_pnlNewAlbum_closePnl.Image = global::Album_Collection_Manager.Properties.Resources.cancel;
            this.pb_pnlNewAlbum_closePnl.Location = new System.Drawing.Point(570, 4);
            this.pb_pnlNewAlbum_closePnl.Name = "pb_pnlNewAlbum_closePnl";
            this.pb_pnlNewAlbum_closePnl.Size = new System.Drawing.Size(25, 25);
            this.pb_pnlNewAlbum_closePnl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_pnlNewAlbum_closePnl.TabIndex = 5;
            this.pb_pnlNewAlbum_closePnl.TabStop = false;
            this.pb_pnlNewAlbum_closePnl.Click += new System.EventHandler(this.pb_pnlNewAlbum_closePnl_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(627, 342);
            this.Controls.Add(this.toolStrip_FormMain);
            this.Controls.Add(this.panel_Collection);
            this.Controls.Add(this.panel_NewAlbum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musical Midia Collection Manager";
            this.toolStrip_FormMain.ResumeLayout(false);
            this.toolStrip_FormMain.PerformLayout();
            this.panel_NewAlbum.ResumeLayout(false);
            this.panel_NewAlbum.PerformLayout();
            this.panel_Collection.ResumeLayout(false);
            this.panel_Collection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_panelCollection_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pnlNewAlbum_closePnl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_FormMain;
        private System.Windows.Forms.ToolStripButton toolStripBtn_newAlbum;
        private System.Windows.Forms.Panel panel_NewAlbum;
        private System.Windows.Forms.Label label_pnlNewAlbum_Title;
        private System.Windows.Forms.TextBox tb_pnlNewAlbum_albumTitle;
        private System.Windows.Forms.ComboBox comboBox_pnlNewAlbum_albumType;
        private System.Windows.Forms.Label label_pnlNewAlbum_NewAlbumTitle;
        private System.Windows.Forms.Label label_pnlNewAlbum_NewAlbumMidia;
        private System.Windows.Forms.PictureBox pb_pnlNewAlbum_closePnl;
        private System.Windows.Forms.Button btn_pnlNewAlbum_saveNewAlbum;
        private System.Windows.Forms.ToolStripButton toolStripBtn_collection;
        private System.Windows.Forms.PictureBox pb_panelCollection_Close;
        private System.Windows.Forms.Panel panel_Collection;
        private System.Windows.Forms.Label lbl_panelCollection_Title;
        public  System.Windows.Forms.ListView listView_pnlCollections_Albuns;
        public System.Windows.Forms.TextBox tb_pnlCollections_AnoLancamento;
        public System.Windows.Forms.TextBox tb_pnlCollections_Artista;
        public System.Windows.Forms.TextBox tb_pnlCollections_NomeAlbum;
        public System.Windows.Forms.TextBox tb_pnlCollections_Estrelas;
        public System.Windows.Forms.TextBox tb_pnlCollections_ValorCompra;
        private System.Windows.Forms.Label lbl_pnlCollections_NomeAlbum;
        public System.Windows.Forms.TextBox tb_pnlCollections_QtdFaixas;
        public System.Windows.Forms.TextBox tb_pnlCollections_Gravadora;
        public System.Windows.Forms.TextBox tb_pnlCollections_Publisher;
        private System.Windows.Forms.Label lbl_pnlCollections_Artista;
        private System.Windows.Forms.Label lbl_pnlCollections_DataLancamento;
        private System.Windows.Forms.Label lbl_pnlCollections_QtdFaixas;
        private System.Windows.Forms.Label lbl_pnlCollections_Gravadora;
        private System.Windows.Forms.Label lbl_pnlCollections_Publisher;
        private System.Windows.Forms.Label lbl_pnlCollections_Genero;
        private System.Windows.Forms.Label lbl_pnlCollections_Estrelas;
        private System.Windows.Forms.Label lbl_pnlCollections_ValorCompra;
        public System.Windows.Forms.ComboBox comboBox_pnlCollections_Genero;
        private System.Windows.Forms.Button btn_pnlCollections_Delete;
        private System.Windows.Forms.Button btn_pnlCollections_Salvar;
        private System.Windows.Forms.Label lbl_pnlCollections_comboboxTitle;
        private System.Windows.Forms.ComboBox comboBox_pnlCollections_ColecaoSelecionada;
    }
}

