
namespace desktopdb
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_KlientaLabel;
            System.Windows.Forms.Label imieLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label data_UrodzeniaLabel;
            System.Windows.Forms.Label kod_PocztowyLabel;
            System.Windows.Forms.Label nipLabel;
            System.Windows.Forms.Label ulicaLabel;
            System.Windows.Forms.Label miastoLabel;
            System.Windows.Forms.Label nr_DomuLabel;
            System.Windows.Forms.Label nr_LokaluLabel;
            System.Windows.Forms.Label mailLabel;
            System.Windows.Forms.Label nr_TelefonuLabel;
            System.Windows.Forms.Label nr_DokumentuLabel;
            System.Windows.Forms.Label rodzaj_DokumentuLabel;
            System.Windows.Forms.Label peselLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.komis = new desktopdb.Komis();
            this.klienciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klienciTableAdapter = new desktopdb.KomisTableAdapters.KlienciTableAdapter();
            this.tableAdapterManager = new desktopdb.KomisTableAdapters.TableAdapterManager();
            this.klienciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.klienciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_KlientaTextBox = new System.Windows.Forms.TextBox();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.data_UrodzeniaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kod_PocztowyTextBox = new System.Windows.Forms.TextBox();
            this.nipTextBox = new System.Windows.Forms.TextBox();
            this.ulicaTextBox = new System.Windows.Forms.TextBox();
            this.miastoTextBox = new System.Windows.Forms.TextBox();
            this.nr_DomuTextBox = new System.Windows.Forms.TextBox();
            this.nr_LokaluTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.nr_TelefonuTextBox = new System.Windows.Forms.TextBox();
            this.nr_DokumentuTextBox = new System.Windows.Forms.TextBox();
            this.rodzaj_DokumentuTextBox = new System.Windows.Forms.TextBox();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            iD_KlientaLabel = new System.Windows.Forms.Label();
            imieLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            data_UrodzeniaLabel = new System.Windows.Forms.Label();
            kod_PocztowyLabel = new System.Windows.Forms.Label();
            nipLabel = new System.Windows.Forms.Label();
            ulicaLabel = new System.Windows.Forms.Label();
            miastoLabel = new System.Windows.Forms.Label();
            nr_DomuLabel = new System.Windows.Forms.Label();
            nr_LokaluLabel = new System.Windows.Forms.Label();
            mailLabel = new System.Windows.Forms.Label();
            nr_TelefonuLabel = new System.Windows.Forms.Label();
            nr_DokumentuLabel = new System.Windows.Forms.Label();
            rodzaj_DokumentuLabel = new System.Windows.Forms.Label();
            peselLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.komis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingNavigator)).BeginInit();
            this.klienciBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_KlientaLabel
            // 
            iD_KlientaLabel.AutoSize = true;
            iD_KlientaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            iD_KlientaLabel.Location = new System.Drawing.Point(68, 145);
            iD_KlientaLabel.Name = "iD_KlientaLabel";
            iD_KlientaLabel.Size = new System.Drawing.Size(163, 37);
            iD_KlientaLabel.TabIndex = 1;
            iD_KlientaLabel.Text = "ID Klienta:";
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            imieLabel.Location = new System.Drawing.Point(68, 219);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new System.Drawing.Size(85, 37);
            imieLabel.TabIndex = 3;
            imieLabel.Text = "Imie:";
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nazwiskoLabel.Location = new System.Drawing.Point(68, 298);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(164, 37);
            nazwiskoLabel.TabIndex = 5;
            nazwiskoLabel.Text = "Nazwisko:";
            // 
            // data_UrodzeniaLabel
            // 
            data_UrodzeniaLabel.AutoSize = true;
            data_UrodzeniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            data_UrodzeniaLabel.Location = new System.Drawing.Point(68, 372);
            data_UrodzeniaLabel.Name = "data_UrodzeniaLabel";
            data_UrodzeniaLabel.Size = new System.Drawing.Size(249, 37);
            data_UrodzeniaLabel.TabIndex = 7;
            data_UrodzeniaLabel.Text = "Data Urodzenia:";
            // 
            // kod_PocztowyLabel
            // 
            kod_PocztowyLabel.AutoSize = true;
            kod_PocztowyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            kod_PocztowyLabel.Location = new System.Drawing.Point(68, 446);
            kod_PocztowyLabel.Name = "kod_PocztowyLabel";
            kod_PocztowyLabel.Size = new System.Drawing.Size(228, 37);
            kod_PocztowyLabel.TabIndex = 9;
            kod_PocztowyLabel.Text = "Kod Pocztowy:";
            // 
            // nipLabel
            // 
            nipLabel.AutoSize = true;
            nipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nipLabel.Location = new System.Drawing.Point(68, 518);
            nipLabel.Name = "nipLabel";
            nipLabel.Size = new System.Drawing.Size(75, 37);
            nipLabel.TabIndex = 11;
            nipLabel.Text = "Nip:";
            // 
            // ulicaLabel
            // 
            ulicaLabel.AutoSize = true;
            ulicaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            ulicaLabel.Location = new System.Drawing.Point(68, 594);
            ulicaLabel.Name = "ulicaLabel";
            ulicaLabel.Size = new System.Drawing.Size(97, 37);
            ulicaLabel.TabIndex = 13;
            ulicaLabel.Text = "Ulica:";
            // 
            // miastoLabel
            // 
            miastoLabel.AutoSize = true;
            miastoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            miastoLabel.Location = new System.Drawing.Point(68, 668);
            miastoLabel.Name = "miastoLabel";
            miastoLabel.Size = new System.Drawing.Size(120, 37);
            miastoLabel.TabIndex = 15;
            miastoLabel.Text = "Miasto:";
            // 
            // nr_DomuLabel
            // 
            nr_DomuLabel.AutoSize = true;
            nr_DomuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nr_DomuLabel.Location = new System.Drawing.Point(68, 740);
            nr_DomuLabel.Name = "nr_DomuLabel";
            nr_DomuLabel.Size = new System.Drawing.Size(156, 37);
            nr_DomuLabel.TabIndex = 17;
            nr_DomuLabel.Text = "Nr Domu:";
            // 
            // nr_LokaluLabel
            // 
            nr_LokaluLabel.AutoSize = true;
            nr_LokaluLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nr_LokaluLabel.Location = new System.Drawing.Point(68, 808);
            nr_LokaluLabel.Name = "nr_LokaluLabel";
            nr_LokaluLabel.Size = new System.Drawing.Size(165, 37);
            nr_LokaluLabel.TabIndex = 19;
            nr_LokaluLabel.Text = "Nr Lokalu:";
            // 
            // mailLabel
            // 
            mailLabel.AutoSize = true;
            mailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            mailLabel.Location = new System.Drawing.Point(741, 140);
            mailLabel.Name = "mailLabel";
            mailLabel.Size = new System.Drawing.Size(84, 37);
            mailLabel.TabIndex = 21;
            mailLabel.Text = "Mail:";
            // 
            // nr_TelefonuLabel
            // 
            nr_TelefonuLabel.AutoSize = true;
            nr_TelefonuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nr_TelefonuLabel.Location = new System.Drawing.Point(741, 219);
            nr_TelefonuLabel.Name = "nr_TelefonuLabel";
            nr_TelefonuLabel.Size = new System.Drawing.Size(194, 37);
            nr_TelefonuLabel.TabIndex = 23;
            nr_TelefonuLabel.Text = "Nr Telefonu:";
            // 
            // nr_DokumentuLabel
            // 
            nr_DokumentuLabel.AutoSize = true;
            nr_DokumentuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            nr_DokumentuLabel.Location = new System.Drawing.Point(741, 301);
            nr_DokumentuLabel.Name = "nr_DokumentuLabel";
            nr_DokumentuLabel.Size = new System.Drawing.Size(234, 37);
            nr_DokumentuLabel.TabIndex = 25;
            nr_DokumentuLabel.Text = "Nr Dokumentu:";
            // 
            // rodzaj_DokumentuLabel
            // 
            rodzaj_DokumentuLabel.AutoSize = true;
            rodzaj_DokumentuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            rodzaj_DokumentuLabel.Location = new System.Drawing.Point(741, 398);
            rodzaj_DokumentuLabel.Name = "rodzaj_DokumentuLabel";
            rodzaj_DokumentuLabel.Size = new System.Drawing.Size(298, 37);
            rodzaj_DokumentuLabel.TabIndex = 27;
            rodzaj_DokumentuLabel.Text = "Rodzaj Dokumentu:";
            // 
            // peselLabel
            // 
            peselLabel.AutoSize = true;
            peselLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            peselLabel.Location = new System.Drawing.Point(741, 482);
            peselLabel.Name = "peselLabel";
            peselLabel.Size = new System.Drawing.Size(104, 37);
            peselLabel.TabIndex = 29;
            peselLabel.Text = "Pesel:";
            // 
            // komis
            // 
            this.komis.DataSetName = "Komis";
            this.komis.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klienciBindingSource
            // 
            this.klienciBindingSource.DataMember = "Klienci";
            this.klienciBindingSource.DataSource = this.komis;
            // 
            // klienciTableAdapter
            // 
            this.klienciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KlienciTableAdapter = this.klienciTableAdapter;
            this.tableAdapterManager.KoloryTableAdapter = null;
            this.tableAdapterManager.MarkiTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.PojazdyTableAdapter = null;
            this.tableAdapterManager.RabatTableAdapter = null;
            this.tableAdapterManager.Rodzaje_TransakcjiTableAdapter = null;
            
            this.tableAdapterManager.TransakcjeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = desktopdb.KomisTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // klienciBindingNavigator
            // 
            this.klienciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.klienciBindingNavigator.BindingSource = this.klienciBindingSource;
            this.klienciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.klienciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.klienciBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.klienciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.klienciBindingNavigatorSaveItem});
            this.klienciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.klienciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.klienciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.klienciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.klienciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.klienciBindingNavigator.Name = "klienciBindingNavigator";
            this.klienciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.klienciBindingNavigator.Size = new System.Drawing.Size(1400, 78);
            this.klienciBindingNavigator.TabIndex = 0;
            this.klienciBindingNavigator.Text = "bindingNavigator1";
            this.klienciBindingNavigator.RefreshItems += new System.EventHandler(this.klienciBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 72);
            this.bindingNavigatorAddNewItem.Text = "Dodaj nowy";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(130, 72);
            this.bindingNavigatorCountItem.Text = "z {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Suma elementów";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 72);
            this.bindingNavigatorDeleteItem.Text = "Usuń";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 72);
            this.bindingNavigatorMoveFirstItem.Text = "Przenieś pierwszy";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 72);
            this.bindingNavigatorMovePreviousItem.Text = "Przenieś poprzedni";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 78);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Pozycja";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 78);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Bieżąca pozycja";
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 78);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 72);
            this.bindingNavigatorMoveNextItem.Text = "Przenieś następny";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 72);
            this.bindingNavigatorMoveLastItem.Text = "Przenieś ostatni";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 78);
            // 
            // klienciBindingNavigatorSaveItem
            // 
            this.klienciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.klienciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("klienciBindingNavigatorSaveItem.Image")));
            this.klienciBindingNavigatorSaveItem.Name = "klienciBindingNavigatorSaveItem";
            this.klienciBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 72);
            this.klienciBindingNavigatorSaveItem.Text = "Zapisz dane";
            this.klienciBindingNavigatorSaveItem.Click += new System.EventHandler(this.klienciBindingNavigatorSaveItem_Click);
            // 
            // iD_KlientaTextBox
            // 
            this.iD_KlientaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "ID_Klienta", true));
            this.iD_KlientaTextBox.Enabled = false;
            this.iD_KlientaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.iD_KlientaTextBox.Location = new System.Drawing.Point(295, 140);
            this.iD_KlientaTextBox.Name = "iD_KlientaTextBox";
            this.iD_KlientaTextBox.Size = new System.Drawing.Size(200, 44);
            this.iD_KlientaTextBox.TabIndex = 2;
            // 
            // imieTextBox
            // 
            this.imieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Imie", true));
            this.imieTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.imieTextBox.Location = new System.Drawing.Point(295, 214);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(343, 44);
            this.imieTextBox.TabIndex = 4;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Nazwisko", true));
            this.nazwiskoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nazwiskoTextBox.Location = new System.Drawing.Point(294, 298);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(344, 44);
            this.nazwiskoTextBox.TabIndex = 6;
            // 
            // data_UrodzeniaDateTimePicker
            // 
            this.data_UrodzeniaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.klienciBindingSource, "Data_Urodzenia", true));
            this.data_UrodzeniaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.data_UrodzeniaDateTimePicker.Location = new System.Drawing.Point(414, 372);
            this.data_UrodzeniaDateTimePicker.Name = "data_UrodzeniaDateTimePicker";
            this.data_UrodzeniaDateTimePicker.Size = new System.Drawing.Size(224, 44);
            this.data_UrodzeniaDateTimePicker.TabIndex = 8;
            // 
            // kod_PocztowyTextBox
            // 
            this.kod_PocztowyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Kod_Pocztowy", true));
            this.kod_PocztowyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.kod_PocztowyTextBox.Location = new System.Drawing.Point(382, 446);
            this.kod_PocztowyTextBox.Name = "kod_PocztowyTextBox";
            this.kod_PocztowyTextBox.Size = new System.Drawing.Size(256, 44);
            this.kod_PocztowyTextBox.TabIndex = 10;
            // 
            // nipTextBox
            // 
            this.nipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Nip", true));
            this.nipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nipTextBox.Location = new System.Drawing.Point(186, 518);
            this.nipTextBox.Name = "nipTextBox";
            this.nipTextBox.Size = new System.Drawing.Size(452, 44);
            this.nipTextBox.TabIndex = 12;
            // 
            // ulicaTextBox
            // 
            this.ulicaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Ulica", true));
            this.ulicaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ulicaTextBox.Location = new System.Drawing.Point(201, 594);
            this.ulicaTextBox.Name = "ulicaTextBox";
            this.ulicaTextBox.Size = new System.Drawing.Size(437, 44);
            this.ulicaTextBox.TabIndex = 14;
            // 
            // miastoTextBox
            // 
            this.miastoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Miasto", true));
            this.miastoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.miastoTextBox.Location = new System.Drawing.Point(245, 665);
            this.miastoTextBox.Name = "miastoTextBox";
            this.miastoTextBox.Size = new System.Drawing.Size(393, 44);
            this.miastoTextBox.TabIndex = 16;
            // 
            // nr_DomuTextBox
            // 
            this.nr_DomuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Nr_Domu", true));
            this.nr_DomuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nr_DomuTextBox.Location = new System.Drawing.Point(280, 740);
            this.nr_DomuTextBox.Name = "nr_DomuTextBox";
            this.nr_DomuTextBox.Size = new System.Drawing.Size(231, 44);
            this.nr_DomuTextBox.TabIndex = 18;
            // 
            // nr_LokaluTextBox
            // 
            this.nr_LokaluTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Nr_Lokalu", true));
            this.nr_LokaluTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nr_LokaluTextBox.Location = new System.Drawing.Point(292, 808);
            this.nr_LokaluTextBox.Name = "nr_LokaluTextBox";
            this.nr_LokaluTextBox.Size = new System.Drawing.Size(281, 44);
            this.nr_LokaluTextBox.TabIndex = 20;
            // 
            // mailTextBox
            // 
            this.mailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Mail", true));
            this.mailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mailTextBox.Location = new System.Drawing.Point(861, 145);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(439, 44);
            this.mailTextBox.TabIndex = 22;
            // 
            // nr_TelefonuTextBox
            // 
            this.nr_TelefonuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Nr_Telefonu", true));
            this.nr_TelefonuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nr_TelefonuTextBox.Location = new System.Drawing.Point(1005, 219);
            this.nr_TelefonuTextBox.Name = "nr_TelefonuTextBox";
            this.nr_TelefonuTextBox.Size = new System.Drawing.Size(349, 44);
            this.nr_TelefonuTextBox.TabIndex = 24;
            // 
            // nr_DokumentuTextBox
            // 
            this.nr_DokumentuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Nr_Dokumentu", true));
            this.nr_DokumentuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nr_DokumentuTextBox.Location = new System.Drawing.Point(1058, 301);
            this.nr_DokumentuTextBox.Name = "nr_DokumentuTextBox";
            this.nr_DokumentuTextBox.Size = new System.Drawing.Size(296, 44);
            this.nr_DokumentuTextBox.TabIndex = 26;
            // 
            // rodzaj_DokumentuTextBox
            // 
            this.rodzaj_DokumentuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Rodzaj_Dokumentu", true));
            this.rodzaj_DokumentuTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rodzaj_DokumentuTextBox.Location = new System.Drawing.Point(1058, 391);
            this.rodzaj_DokumentuTextBox.Name = "rodzaj_DokumentuTextBox";
            this.rodzaj_DokumentuTextBox.Size = new System.Drawing.Size(296, 44);
            this.rodzaj_DokumentuTextBox.TabIndex = 28;
            // 
            // peselTextBox
            // 
            this.peselTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klienciBindingSource, "Pesel", true));
            this.peselTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.peselTextBox.Location = new System.Drawing.Point(902, 482);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(337, 44);
            this.peselTextBox.TabIndex = 30;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 888);
            this.Controls.Add(iD_KlientaLabel);
            this.Controls.Add(this.iD_KlientaTextBox);
            this.Controls.Add(imieLabel);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(nazwiskoLabel);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(data_UrodzeniaLabel);
            this.Controls.Add(this.data_UrodzeniaDateTimePicker);
            this.Controls.Add(kod_PocztowyLabel);
            this.Controls.Add(this.kod_PocztowyTextBox);
            this.Controls.Add(nipLabel);
            this.Controls.Add(this.nipTextBox);
            this.Controls.Add(ulicaLabel);
            this.Controls.Add(this.ulicaTextBox);
            this.Controls.Add(miastoLabel);
            this.Controls.Add(this.miastoTextBox);
            this.Controls.Add(nr_DomuLabel);
            this.Controls.Add(this.nr_DomuTextBox);
            this.Controls.Add(nr_LokaluLabel);
            this.Controls.Add(this.nr_LokaluTextBox);
            this.Controls.Add(mailLabel);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(nr_TelefonuLabel);
            this.Controls.Add(this.nr_TelefonuTextBox);
            this.Controls.Add(nr_DokumentuLabel);
            this.Controls.Add(this.nr_DokumentuTextBox);
            this.Controls.Add(rodzaj_DokumentuLabel);
            this.Controls.Add(this.rodzaj_DokumentuTextBox);
            this.Controls.Add(peselLabel);
            this.Controls.Add(this.peselTextBox);
            this.Controls.Add(this.klienciBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.komis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klienciBindingNavigator)).EndInit();
            this.klienciBindingNavigator.ResumeLayout(false);
            this.klienciBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Komis komis;
        private System.Windows.Forms.BindingSource klienciBindingSource;
        private KomisTableAdapters.KlienciTableAdapter klienciTableAdapter;
        private KomisTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator klienciBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton klienciBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_KlientaTextBox;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.DateTimePicker data_UrodzeniaDateTimePicker;
        private System.Windows.Forms.TextBox kod_PocztowyTextBox;
        private System.Windows.Forms.TextBox nipTextBox;
        private System.Windows.Forms.TextBox ulicaTextBox;
        private System.Windows.Forms.TextBox miastoTextBox;
        private System.Windows.Forms.TextBox nr_DomuTextBox;
        private System.Windows.Forms.TextBox nr_LokaluTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox nr_TelefonuTextBox;
        private System.Windows.Forms.TextBox nr_DokumentuTextBox;
        private System.Windows.Forms.TextBox rodzaj_DokumentuTextBox;
        private System.Windows.Forms.TextBox peselTextBox;
    }
}