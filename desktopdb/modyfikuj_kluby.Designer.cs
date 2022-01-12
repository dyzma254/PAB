
namespace desktopdb
{
    partial class modyfikuj_kluby
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
            System.Windows.Forms.Label id_klubLabel;
            System.Windows.Forms.Label id_ligaLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label krajLabel;
            System.Windows.Forms.Label ile_tytulowLabel;
            System.Windows.Forms.Label data_zalozeniaLabel;
            System.Windows.Forms.Label miastoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modyfikuj_kluby));
            this.pabDataSet = new desktopdb.pabDataSet();
            this.klubBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klubTableAdapter = new desktopdb.pabDataSetTableAdapters.KlubTableAdapter();
            this.tableAdapterManager = new desktopdb.pabDataSetTableAdapters.TableAdapterManager();
            this.klubBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.klubBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_klubTextBox = new System.Windows.Forms.TextBox();
            this.id_ligaTextBox = new System.Windows.Forms.TextBox();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.krajTextBox = new System.Windows.Forms.TextBox();
            this.ile_tytulowTextBox = new System.Windows.Forms.TextBox();
            this.data_zalozeniaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.miastoTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            id_klubLabel = new System.Windows.Forms.Label();
            id_ligaLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            krajLabel = new System.Windows.Forms.Label();
            ile_tytulowLabel = new System.Windows.Forms.Label();
            data_zalozeniaLabel = new System.Windows.Forms.Label();
            miastoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klubBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klubBindingNavigator)).BeginInit();
            this.klubBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_klubLabel
            // 
            id_klubLabel.AutoSize = true;
            id_klubLabel.Location = new System.Drawing.Point(12, 40);
            id_klubLabel.Name = "id_klubLabel";
            id_klubLabel.Size = new System.Drawing.Size(41, 13);
            id_klubLabel.TabIndex = 1;
            id_klubLabel.Text = "id klub:";
            // 
            // id_ligaLabel
            // 
            id_ligaLabel.AutoSize = true;
            id_ligaLabel.Location = new System.Drawing.Point(12, 66);
            id_ligaLabel.Name = "id_ligaLabel";
            id_ligaLabel.Size = new System.Drawing.Size(27, 13);
            id_ligaLabel.TabIndex = 3;
            id_ligaLabel.Text = "Liga";
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(12, 92);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(41, 13);
            nazwaLabel.TabIndex = 5;
            nazwaLabel.Text = "nazwa:";
            // 
            // krajLabel
            // 
            krajLabel.AutoSize = true;
            krajLabel.Location = new System.Drawing.Point(12, 118);
            krajLabel.Name = "krajLabel";
            krajLabel.Size = new System.Drawing.Size(27, 13);
            krajLabel.TabIndex = 7;
            krajLabel.Text = "kraj:";
            // 
            // ile_tytulowLabel
            // 
            ile_tytulowLabel.AutoSize = true;
            ile_tytulowLabel.Location = new System.Drawing.Point(12, 144);
            ile_tytulowLabel.Name = "ile_tytulowLabel";
            ile_tytulowLabel.Size = new System.Drawing.Size(56, 13);
            ile_tytulowLabel.TabIndex = 9;
            ile_tytulowLabel.Text = "ile tytulow:";
            // 
            // data_zalozeniaLabel
            // 
            data_zalozeniaLabel.AutoSize = true;
            data_zalozeniaLabel.Location = new System.Drawing.Point(12, 171);
            data_zalozeniaLabel.Name = "data_zalozeniaLabel";
            data_zalozeniaLabel.Size = new System.Drawing.Size(78, 13);
            data_zalozeniaLabel.TabIndex = 11;
            data_zalozeniaLabel.Text = "data zalozenia:";
            // 
            // miastoLabel
            // 
            miastoLabel.AutoSize = true;
            miastoLabel.Location = new System.Drawing.Point(12, 196);
            miastoLabel.Name = "miastoLabel";
            miastoLabel.Size = new System.Drawing.Size(40, 13);
            miastoLabel.TabIndex = 13;
            miastoLabel.Text = "miasto:";
            // 
            // pabDataSet
            // 
            this.pabDataSet.DataSetName = "pabDataSet";
            this.pabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klubBindingSource
            // 
            this.klubBindingSource.DataMember = "Klub";
            this.klubBindingSource.DataSource = this.pabDataSet;
            // 
            // klubTableAdapter
            // 
            this.klubTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.baza_treningowaTableAdapter = null;
            this.tableAdapterManager.KlubTableAdapter = this.klubTableAdapter;
            this.tableAdapterManager.LigaTableAdapter = null;
            this.tableAdapterManager.treningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = desktopdb.pabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zawodnicy_na_treninguTableAdapter = null;
            this.tableAdapterManager.ZawodnikTableAdapter = null;
            // 
            // klubBindingNavigator
            // 
            this.klubBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.klubBindingNavigator.BindingSource = this.klubBindingSource;
            this.klubBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.klubBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.klubBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.klubBindingNavigatorSaveItem});
            this.klubBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.klubBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.klubBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.klubBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.klubBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.klubBindingNavigator.Name = "klubBindingNavigator";
            this.klubBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.klubBindingNavigator.Size = new System.Drawing.Size(314, 25);
            this.klubBindingNavigator.TabIndex = 0;
            this.klubBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // klubBindingNavigatorSaveItem
            // 
            this.klubBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.klubBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("klubBindingNavigatorSaveItem.Image")));
            this.klubBindingNavigatorSaveItem.Name = "klubBindingNavigatorSaveItem";
            this.klubBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.klubBindingNavigatorSaveItem.Text = "Save Data";
            this.klubBindingNavigatorSaveItem.Click += new System.EventHandler(this.klubBindingNavigatorSaveItem_Click);
            // 
            // id_klubTextBox
            // 
            this.id_klubTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klubBindingSource, "id_klub", true));
            this.id_klubTextBox.Enabled = false;
            this.id_klubTextBox.Location = new System.Drawing.Point(96, 37);
            this.id_klubTextBox.Name = "id_klubTextBox";
            this.id_klubTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_klubTextBox.TabIndex = 2;
            // 
            // id_ligaTextBox
            // 
            this.id_ligaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klubBindingSource, "Id_liga", true));
            this.id_ligaTextBox.Enabled = false;
            this.id_ligaTextBox.Location = new System.Drawing.Point(319, 63);
            this.id_ligaTextBox.Name = "id_ligaTextBox";
            this.id_ligaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_ligaTextBox.TabIndex = 4;
            this.id_ligaTextBox.Visible = false;
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klubBindingSource, "nazwa", true));
            this.nazwaTextBox.Location = new System.Drawing.Point(96, 89);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(200, 20);
            this.nazwaTextBox.TabIndex = 6;
            // 
            // krajTextBox
            // 
            this.krajTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klubBindingSource, "kraj", true));
            this.krajTextBox.Location = new System.Drawing.Point(96, 115);
            this.krajTextBox.Name = "krajTextBox";
            this.krajTextBox.Size = new System.Drawing.Size(200, 20);
            this.krajTextBox.TabIndex = 8;
            // 
            // ile_tytulowTextBox
            // 
            this.ile_tytulowTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klubBindingSource, "ile_tytulow", true));
            this.ile_tytulowTextBox.Location = new System.Drawing.Point(96, 141);
            this.ile_tytulowTextBox.Name = "ile_tytulowTextBox";
            this.ile_tytulowTextBox.Size = new System.Drawing.Size(200, 20);
            this.ile_tytulowTextBox.TabIndex = 10;
            // 
            // data_zalozeniaDateTimePicker
            // 
            this.data_zalozeniaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.klubBindingSource, "data_zalozenia", true));
            this.data_zalozeniaDateTimePicker.Location = new System.Drawing.Point(96, 167);
            this.data_zalozeniaDateTimePicker.Name = "data_zalozeniaDateTimePicker";
            this.data_zalozeniaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_zalozeniaDateTimePicker.TabIndex = 12;
            // 
            // miastoTextBox
            // 
            this.miastoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.klubBindingSource, "miasto", true));
            this.miastoTextBox.Location = new System.Drawing.Point(96, 193);
            this.miastoTextBox.Name = "miastoTextBox";
            this.miastoTextBox.Size = new System.Drawing.Size(200, 20);
            this.miastoTextBox.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Location = new System.Drawing.Point(96, 61);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Text = "Wybierz";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // modyfikuj_kluby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 234);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(id_klubLabel);
            this.Controls.Add(this.id_klubTextBox);
            this.Controls.Add(id_ligaLabel);
            this.Controls.Add(this.id_ligaTextBox);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(krajLabel);
            this.Controls.Add(this.krajTextBox);
            this.Controls.Add(ile_tytulowLabel);
            this.Controls.Add(this.ile_tytulowTextBox);
            this.Controls.Add(data_zalozeniaLabel);
            this.Controls.Add(this.data_zalozeniaDateTimePicker);
            this.Controls.Add(miastoLabel);
            this.Controls.Add(this.miastoTextBox);
            this.Controls.Add(this.klubBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "modyfikuj_kluby";
            this.Text = "Kluby";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klubBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klubBindingNavigator)).EndInit();
            this.klubBindingNavigator.ResumeLayout(false);
            this.klubBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pabDataSet pabDataSet;
        private System.Windows.Forms.BindingSource klubBindingSource;
        private pabDataSetTableAdapters.KlubTableAdapter klubTableAdapter;
        private pabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator klubBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton klubBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_klubTextBox;
        private System.Windows.Forms.TextBox id_ligaTextBox;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox krajTextBox;
        private System.Windows.Forms.TextBox ile_tytulowTextBox;
        private System.Windows.Forms.DateTimePicker data_zalozeniaDateTimePicker;
        private System.Windows.Forms.TextBox miastoTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}