
namespace desktopdb
{
    partial class modyfikuj_liga
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
            System.Windows.Forms.Label id_ligaLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label krajLabel;
            System.Windows.Forms.Label czy_grupyLabel;
            System.Windows.Forms.Label czy_playofyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modyfikuj_liga));
            this.pabDataSet = new desktopdb.pabDataSet();
            this.ligaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ligaTableAdapter = new desktopdb.pabDataSetTableAdapters.LigaTableAdapter();
            this.tableAdapterManager = new desktopdb.pabDataSetTableAdapters.TableAdapterManager();
            this.ligaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ligaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_ligaTextBox = new System.Windows.Forms.TextBox();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.krajTextBox = new System.Windows.Forms.TextBox();
            this.czy_grupyCheckBox = new System.Windows.Forms.CheckBox();
            this.czy_playofyCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            id_ligaLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            krajLabel = new System.Windows.Forms.Label();
            czy_grupyLabel = new System.Windows.Forms.Label();
            czy_playofyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligaBindingNavigator)).BeginInit();
            this.ligaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_ligaLabel
            // 
            id_ligaLabel.AutoSize = true;
            id_ligaLabel.Location = new System.Drawing.Point(48, 74);
            id_ligaLabel.Name = "id_ligaLabel";
            id_ligaLabel.Size = new System.Drawing.Size(38, 13);
            id_ligaLabel.TabIndex = 1;
            id_ligaLabel.Text = "Id liga:";
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(48, 100);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(41, 13);
            nazwaLabel.TabIndex = 3;
            nazwaLabel.Text = "nazwa:";
            // 
            // krajLabel
            // 
            krajLabel.AutoSize = true;
            krajLabel.Location = new System.Drawing.Point(48, 126);
            krajLabel.Name = "krajLabel";
            krajLabel.Size = new System.Drawing.Size(27, 13);
            krajLabel.TabIndex = 5;
            krajLabel.Text = "kraj:";
            // 
            // czy_grupyLabel
            // 
            czy_grupyLabel.AutoSize = true;
            czy_grupyLabel.Location = new System.Drawing.Point(48, 154);
            czy_grupyLabel.Name = "czy_grupyLabel";
            czy_grupyLabel.Size = new System.Drawing.Size(55, 13);
            czy_grupyLabel.TabIndex = 7;
            czy_grupyLabel.Text = "czy grupy:";
            // 
            // czy_playofyLabel
            // 
            czy_playofyLabel.AutoSize = true;
            czy_playofyLabel.Location = new System.Drawing.Point(48, 184);
            czy_playofyLabel.Name = "czy_playofyLabel";
            czy_playofyLabel.Size = new System.Drawing.Size(62, 13);
            czy_playofyLabel.TabIndex = 9;
            czy_playofyLabel.Text = "czy playofy:";
            // 
            // pabDataSet
            // 
            this.pabDataSet.DataSetName = "pabDataSet";
            this.pabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ligaBindingSource
            // 
            this.ligaBindingSource.DataMember = "Liga";
            this.ligaBindingSource.DataSource = this.pabDataSet;
            // 
            // ligaTableAdapter
            // 
            this.ligaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.baza_treningowaTableAdapter = null;
            this.tableAdapterManager.KlubTableAdapter = null;
            this.tableAdapterManager.LigaTableAdapter = this.ligaTableAdapter;
            this.tableAdapterManager.treningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = desktopdb.pabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zawodnicy_na_treninguTableAdapter = null;
            this.tableAdapterManager.ZawodnikTableAdapter = null;
            // 
            // ligaBindingNavigator
            // 
            this.ligaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ligaBindingNavigator.BindingSource = this.ligaBindingSource;
            this.ligaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ligaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ligaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ligaBindingNavigatorSaveItem});
            this.ligaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ligaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ligaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ligaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ligaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ligaBindingNavigator.Name = "ligaBindingNavigator";
            this.ligaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ligaBindingNavigator.Size = new System.Drawing.Size(435, 25);
            this.ligaBindingNavigator.TabIndex = 0;
            this.ligaBindingNavigator.Text = "bindingNavigator1";
            this.ligaBindingNavigator.RefreshItems += new System.EventHandler(this.ligaBindingNavigator_RefreshItems);
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
            // ligaBindingNavigatorSaveItem
            // 
            this.ligaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ligaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ligaBindingNavigatorSaveItem.Image")));
            this.ligaBindingNavigatorSaveItem.Name = "ligaBindingNavigatorSaveItem";
            this.ligaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ligaBindingNavigatorSaveItem.Text = "Save Data";
            this.ligaBindingNavigatorSaveItem.Click += new System.EventHandler(this.ligaBindingNavigatorSaveItem_Click);
            // 
            // id_ligaTextBox
            // 
            this.id_ligaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligaBindingSource, "Id_liga", true));
            this.id_ligaTextBox.Enabled = false;
            this.id_ligaTextBox.Location = new System.Drawing.Point(116, 71);
            this.id_ligaTextBox.Name = "id_ligaTextBox";
            this.id_ligaTextBox.Size = new System.Drawing.Size(108, 20);
            this.id_ligaTextBox.TabIndex = 2;
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligaBindingSource, "nazwa", true));
            this.nazwaTextBox.Location = new System.Drawing.Point(116, 97);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(108, 20);
            this.nazwaTextBox.TabIndex = 4;
            // 
            // krajTextBox
            // 
            this.krajTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ligaBindingSource, "kraj", true));
            this.krajTextBox.Location = new System.Drawing.Point(116, 123);
            this.krajTextBox.Name = "krajTextBox";
            this.krajTextBox.Size = new System.Drawing.Size(108, 20);
            this.krajTextBox.TabIndex = 6;
            // 
            // czy_grupyCheckBox
            // 
            this.czy_grupyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ligaBindingSource, "czy_grupy", true));
            this.czy_grupyCheckBox.Location = new System.Drawing.Point(116, 149);
            this.czy_grupyCheckBox.Name = "czy_grupyCheckBox";
            this.czy_grupyCheckBox.Size = new System.Drawing.Size(108, 26);
            this.czy_grupyCheckBox.TabIndex = 8;
            this.czy_grupyCheckBox.Text = "Tak";
            this.czy_grupyCheckBox.UseVisualStyleBackColor = true;
            // 
            // czy_playofyCheckBox
            // 
            this.czy_playofyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ligaBindingSource, "czy_playofy", true));
            this.czy_playofyCheckBox.Location = new System.Drawing.Point(116, 179);
            this.czy_playofyCheckBox.Name = "czy_playofyCheckBox";
            this.czy_playofyCheckBox.Size = new System.Drawing.Size(108, 26);
            this.czy_playofyCheckBox.TabIndex = 10;
            this.czy_playofyCheckBox.Text = "Tak";
            this.czy_playofyCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Location = new System.Drawing.Point(250, 69);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.Text = "Wybierz";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // modyfikuj_liga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 309);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(id_ligaLabel);
            this.Controls.Add(this.id_ligaTextBox);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(krajLabel);
            this.Controls.Add(this.krajTextBox);
            this.Controls.Add(czy_grupyLabel);
            this.Controls.Add(this.czy_grupyCheckBox);
            this.Controls.Add(czy_playofyLabel);
            this.Controls.Add(this.czy_playofyCheckBox);
            this.Controls.Add(this.ligaBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "modyfikuj_liga";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ligaBindingNavigator)).EndInit();
            this.ligaBindingNavigator.ResumeLayout(false);
            this.ligaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pabDataSet pabDataSet;
        private System.Windows.Forms.BindingSource ligaBindingSource;
        private pabDataSetTableAdapters.LigaTableAdapter ligaTableAdapter;
        private pabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ligaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ligaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_ligaTextBox;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.TextBox krajTextBox;
        private System.Windows.Forms.CheckBox czy_grupyCheckBox;
        private System.Windows.Forms.CheckBox czy_playofyCheckBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}