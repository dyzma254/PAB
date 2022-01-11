
namespace desktopdb
{
    partial class modyfikuj_zawodnicy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modyfikuj_zawodnicy));
            System.Windows.Forms.Label imieLabel;
            System.Windows.Forms.Label nazwiskoLabel;
            System.Windows.Forms.Label id_zawodnikLabel;
            System.Windows.Forms.Label id_klubLabel;
            System.Windows.Forms.Label narodowoscLabel;
            System.Windows.Forms.Label pozycjaLabel;
            System.Windows.Forms.Label data_urodzenieLabel;
            this.pabDataSet = new desktopdb.pabDataSet();
            this.zawodnikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zawodnikTableAdapter = new desktopdb.pabDataSetTableAdapters.ZawodnikTableAdapter();
            this.tableAdapterManager = new desktopdb.pabDataSetTableAdapters.TableAdapterManager();
            this.zawodnikBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.zawodnikBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.id_zawodnikTextBox = new System.Windows.Forms.TextBox();
            this.id_klubTextBox = new System.Windows.Forms.TextBox();
            this.narodowoscTextBox = new System.Windows.Forms.TextBox();
            this.pozycjaTextBox = new System.Windows.Forms.TextBox();
            this.data_urodzenieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            imieLabel = new System.Windows.Forms.Label();
            nazwiskoLabel = new System.Windows.Forms.Label();
            id_zawodnikLabel = new System.Windows.Forms.Label();
            id_klubLabel = new System.Windows.Forms.Label();
            narodowoscLabel = new System.Windows.Forms.Label();
            pozycjaLabel = new System.Windows.Forms.Label();
            data_urodzenieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zawodnikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zawodnikBindingNavigator)).BeginInit();
            this.zawodnikBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pabDataSet
            // 
            this.pabDataSet.DataSetName = "pabDataSet";
            this.pabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zawodnikBindingSource
            // 
            this.zawodnikBindingSource.DataMember = "Zawodnik";
            this.zawodnikBindingSource.DataSource = this.pabDataSet;
            // 
            // zawodnikTableAdapter
            // 
            this.zawodnikTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.baza_treningowaTableAdapter = null;
            this.tableAdapterManager.KlubTableAdapter = null;
            this.tableAdapterManager.LigaTableAdapter = null;
            this.tableAdapterManager.treningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = desktopdb.pabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zawodnicy_na_treninguTableAdapter = null;
            this.tableAdapterManager.ZawodnikTableAdapter = this.zawodnikTableAdapter;
            // 
            // zawodnikBindingNavigator
            // 
            this.zawodnikBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zawodnikBindingNavigator.BindingSource = this.zawodnikBindingSource;
            this.zawodnikBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zawodnikBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zawodnikBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zawodnikBindingNavigatorSaveItem});
            this.zawodnikBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zawodnikBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zawodnikBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zawodnikBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zawodnikBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zawodnikBindingNavigator.Name = "zawodnikBindingNavigator";
            this.zawodnikBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zawodnikBindingNavigator.Size = new System.Drawing.Size(626, 25);
            this.zawodnikBindingNavigator.TabIndex = 0;
            this.zawodnikBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // zawodnikBindingNavigatorSaveItem
            // 
            this.zawodnikBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zawodnikBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zawodnikBindingNavigatorSaveItem.Image")));
            this.zawodnikBindingNavigatorSaveItem.Name = "zawodnikBindingNavigatorSaveItem";
            this.zawodnikBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.zawodnikBindingNavigatorSaveItem.Text = "Save Data";
            this.zawodnikBindingNavigatorSaveItem.Click += new System.EventHandler(this.zawodnikBindingNavigatorSaveItem_Click);
            // 
            // imieLabel
            // 
            imieLabel.AutoSize = true;
            imieLabel.Location = new System.Drawing.Point(12, 39);
            imieLabel.Name = "imieLabel";
            imieLabel.Size = new System.Drawing.Size(28, 13);
            imieLabel.TabIndex = 1;
            imieLabel.Text = "imie:";
            // 
            // imieTextBox
            // 
            this.imieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zawodnikBindingSource, "imie", true));
            this.imieTextBox.Location = new System.Drawing.Point(98, 36);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(200, 20);
            this.imieTextBox.TabIndex = 2;
            // 
            // nazwiskoLabel
            // 
            nazwiskoLabel.AutoSize = true;
            nazwiskoLabel.Location = new System.Drawing.Point(12, 65);
            nazwiskoLabel.Name = "nazwiskoLabel";
            nazwiskoLabel.Size = new System.Drawing.Size(54, 13);
            nazwiskoLabel.TabIndex = 3;
            nazwiskoLabel.Text = "nazwisko:";
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zawodnikBindingSource, "nazwisko", true));
            this.nazwiskoTextBox.Location = new System.Drawing.Point(98, 62);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(200, 20);
            this.nazwiskoTextBox.TabIndex = 4;
            // 
            // id_zawodnikLabel
            // 
            id_zawodnikLabel.AutoSize = true;
            id_zawodnikLabel.Location = new System.Drawing.Point(12, 91);
            id_zawodnikLabel.Name = "id_zawodnikLabel";
            id_zawodnikLabel.Size = new System.Drawing.Size(66, 13);
            id_zawodnikLabel.TabIndex = 5;
            id_zawodnikLabel.Text = "id zawodnik:";
            // 
            // id_zawodnikTextBox
            // 
            this.id_zawodnikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zawodnikBindingSource, "id_zawodnik", true));
            this.id_zawodnikTextBox.Enabled = false;
            this.id_zawodnikTextBox.Location = new System.Drawing.Point(98, 88);
            this.id_zawodnikTextBox.Name = "id_zawodnikTextBox";
            this.id_zawodnikTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_zawodnikTextBox.TabIndex = 6;
            // 
            // id_klubLabel
            // 
            id_klubLabel.AutoSize = true;
            id_klubLabel.Location = new System.Drawing.Point(12, 117);
            id_klubLabel.Name = "id_klubLabel";
            id_klubLabel.Size = new System.Drawing.Size(41, 13);
            id_klubLabel.TabIndex = 7;
            id_klubLabel.Text = "id klub:";
            // 
            // id_klubTextBox
            // 
            this.id_klubTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zawodnikBindingSource, "id_klub", true));
            this.id_klubTextBox.Enabled = false;
            this.id_klubTextBox.Location = new System.Drawing.Point(98, 114);
            this.id_klubTextBox.Name = "id_klubTextBox";
            this.id_klubTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_klubTextBox.TabIndex = 8;
            // 
            // narodowoscLabel
            // 
            narodowoscLabel.AutoSize = true;
            narodowoscLabel.Location = new System.Drawing.Point(12, 143);
            narodowoscLabel.Name = "narodowoscLabel";
            narodowoscLabel.Size = new System.Drawing.Size(68, 13);
            narodowoscLabel.TabIndex = 9;
            narodowoscLabel.Text = "narodowosc:";
            // 
            // narodowoscTextBox
            // 
            this.narodowoscTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zawodnikBindingSource, "narodowosc", true));
            this.narodowoscTextBox.Location = new System.Drawing.Point(98, 140);
            this.narodowoscTextBox.Name = "narodowoscTextBox";
            this.narodowoscTextBox.Size = new System.Drawing.Size(200, 20);
            this.narodowoscTextBox.TabIndex = 10;
            // 
            // pozycjaLabel
            // 
            pozycjaLabel.AutoSize = true;
            pozycjaLabel.Location = new System.Drawing.Point(12, 169);
            pozycjaLabel.Name = "pozycjaLabel";
            pozycjaLabel.Size = new System.Drawing.Size(46, 13);
            pozycjaLabel.TabIndex = 11;
            pozycjaLabel.Text = "pozycja:";
            // 
            // pozycjaTextBox
            // 
            this.pozycjaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zawodnikBindingSource, "pozycja", true));
            this.pozycjaTextBox.Location = new System.Drawing.Point(98, 166);
            this.pozycjaTextBox.Name = "pozycjaTextBox";
            this.pozycjaTextBox.Size = new System.Drawing.Size(200, 20);
            this.pozycjaTextBox.TabIndex = 12;
            // 
            // data_urodzenieLabel
            // 
            data_urodzenieLabel.AutoSize = true;
            data_urodzenieLabel.Location = new System.Drawing.Point(12, 196);
            data_urodzenieLabel.Name = "data_urodzenieLabel";
            data_urodzenieLabel.Size = new System.Drawing.Size(80, 13);
            data_urodzenieLabel.TabIndex = 13;
            data_urodzenieLabel.Text = "data urodzenie:";
            // 
            // data_urodzenieDateTimePicker
            // 
            this.data_urodzenieDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zawodnikBindingSource, "data_urodzenie", true));
            this.data_urodzenieDateTimePicker.Location = new System.Drawing.Point(98, 192);
            this.data_urodzenieDateTimePicker.Name = "data_urodzenieDateTimePicker";
            this.data_urodzenieDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_urodzenieDateTimePicker.TabIndex = 14;
            // 
            // modyfikuj_zawodnicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 266);
            this.Controls.Add(imieLabel);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(nazwiskoLabel);
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(id_zawodnikLabel);
            this.Controls.Add(this.id_zawodnikTextBox);
            this.Controls.Add(id_klubLabel);
            this.Controls.Add(this.id_klubTextBox);
            this.Controls.Add(narodowoscLabel);
            this.Controls.Add(this.narodowoscTextBox);
            this.Controls.Add(pozycjaLabel);
            this.Controls.Add(this.pozycjaTextBox);
            this.Controls.Add(data_urodzenieLabel);
            this.Controls.Add(this.data_urodzenieDateTimePicker);
            this.Controls.Add(this.zawodnikBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "modyfikuj_zawodnicy";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zawodnikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zawodnikBindingNavigator)).EndInit();
            this.zawodnikBindingNavigator.ResumeLayout(false);
            this.zawodnikBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pabDataSet pabDataSet;
        private System.Windows.Forms.BindingSource zawodnikBindingSource;
        private pabDataSetTableAdapters.ZawodnikTableAdapter zawodnikTableAdapter;
        private pabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zawodnikBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zawodnikBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox id_zawodnikTextBox;
        private System.Windows.Forms.TextBox id_klubTextBox;
        private System.Windows.Forms.TextBox narodowoscTextBox;
        private System.Windows.Forms.TextBox pozycjaTextBox;
        private System.Windows.Forms.DateTimePicker data_urodzenieDateTimePicker;
    }
}