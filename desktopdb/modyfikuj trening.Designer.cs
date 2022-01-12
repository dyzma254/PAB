
namespace desktopdb
{
    partial class Form5
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
            System.Windows.Forms.Label id_treningLabel;
            System.Windows.Forms.Label id_bazaLabel;
            System.Windows.Forms.Label id_klubLabel;
            System.Windows.Forms.Label obciazenieLabel;
            System.Windows.Forms.Label typ_treninguLabel;
            System.Windows.Forms.Label data_treninguLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pabDataSet = new desktopdb.pabDataSet();
            this.treningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treningTableAdapter = new desktopdb.pabDataSetTableAdapters.treningTableAdapter();
            this.tableAdapterManager = new desktopdb.pabDataSetTableAdapters.TableAdapterManager();
            this.treningBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.treningBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_treningTextBox = new System.Windows.Forms.TextBox();
            this.id_bazaTextBox = new System.Windows.Forms.TextBox();
            this.id_klubTextBox = new System.Windows.Forms.TextBox();
            this.obciazenieTextBox = new System.Windows.Forms.TextBox();
            this.typ_treninguTextBox = new System.Windows.Forms.TextBox();
            this.data_treninguDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            id_treningLabel = new System.Windows.Forms.Label();
            id_bazaLabel = new System.Windows.Forms.Label();
            id_klubLabel = new System.Windows.Forms.Label();
            obciazenieLabel = new System.Windows.Forms.Label();
            typ_treninguLabel = new System.Windows.Forms.Label();
            data_treninguLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingNavigator)).BeginInit();
            this.treningBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_treningLabel
            // 
            id_treningLabel.AutoSize = true;
            id_treningLabel.Location = new System.Drawing.Point(9, 31);
            id_treningLabel.Name = "id_treningLabel";
            id_treningLabel.Size = new System.Drawing.Size(53, 13);
            id_treningLabel.TabIndex = 1;
            id_treningLabel.Text = "id trening:";
            // 
            // id_bazaLabel
            // 
            id_bazaLabel.AutoSize = true;
            id_bazaLabel.Location = new System.Drawing.Point(9, 57);
            id_bazaLabel.Name = "id_bazaLabel";
            id_bazaLabel.Size = new System.Drawing.Size(33, 13);
            id_bazaLabel.TabIndex = 3;
            id_bazaLabel.Text = "baza:";
            id_bazaLabel.Click += new System.EventHandler(this.id_bazaLabel_Click);
            // 
            // id_klubLabel
            // 
            id_klubLabel.AutoSize = true;
            id_klubLabel.Location = new System.Drawing.Point(9, 83);
            id_klubLabel.Name = "id_klubLabel";
            id_klubLabel.Size = new System.Drawing.Size(30, 13);
            id_klubLabel.TabIndex = 5;
            id_klubLabel.Text = "klub:";
            // 
            // obciazenieLabel
            // 
            obciazenieLabel.AutoSize = true;
            obciazenieLabel.Location = new System.Drawing.Point(9, 109);
            obciazenieLabel.Name = "obciazenieLabel";
            obciazenieLabel.Size = new System.Drawing.Size(61, 13);
            obciazenieLabel.TabIndex = 7;
            obciazenieLabel.Text = "obciazenie:";
            // 
            // typ_treninguLabel
            // 
            typ_treninguLabel.AutoSize = true;
            typ_treninguLabel.Location = new System.Drawing.Point(9, 135);
            typ_treninguLabel.Name = "typ_treninguLabel";
            typ_treninguLabel.Size = new System.Drawing.Size(65, 13);
            typ_treninguLabel.TabIndex = 9;
            typ_treninguLabel.Text = "typ treningu:";
            // 
            // data_treninguLabel
            // 
            data_treninguLabel.AutoSize = true;
            data_treninguLabel.Location = new System.Drawing.Point(9, 162);
            data_treninguLabel.Name = "data_treninguLabel";
            data_treninguLabel.Size = new System.Drawing.Size(72, 13);
            data_treninguLabel.TabIndex = 11;
            data_treninguLabel.Text = "data treningu:";
            // 
            // pabDataSet
            // 
            this.pabDataSet.DataSetName = "pabDataSet";
            this.pabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treningBindingSource
            // 
            this.treningBindingSource.DataMember = "trening";
            this.treningBindingSource.DataSource = this.pabDataSet;
            // 
            // treningTableAdapter
            // 
            this.treningTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.baza_treningowaTableAdapter = null;
            this.tableAdapterManager.KlubTableAdapter = null;
            this.tableAdapterManager.LigaTableAdapter = null;
            this.tableAdapterManager.treningTableAdapter = this.treningTableAdapter;
            this.tableAdapterManager.UpdateOrder = desktopdb.pabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zawodnicy_na_treninguTableAdapter = null;
            this.tableAdapterManager.ZawodnikTableAdapter = null;
            // 
            // treningBindingNavigator
            // 
            this.treningBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.treningBindingNavigator.BindingSource = this.treningBindingSource;
            this.treningBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.treningBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.treningBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.treningBindingNavigatorSaveItem});
            this.treningBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.treningBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.treningBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.treningBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.treningBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.treningBindingNavigator.Name = "treningBindingNavigator";
            this.treningBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.treningBindingNavigator.Size = new System.Drawing.Size(613, 25);
            this.treningBindingNavigator.TabIndex = 0;
            this.treningBindingNavigator.Text = "bindingNavigator1";
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
            // treningBindingNavigatorSaveItem
            // 
            this.treningBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.treningBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("treningBindingNavigatorSaveItem.Image")));
            this.treningBindingNavigatorSaveItem.Name = "treningBindingNavigatorSaveItem";
            this.treningBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.treningBindingNavigatorSaveItem.Text = "Save Data";
            this.treningBindingNavigatorSaveItem.Click += new System.EventHandler(this.treningBindingNavigatorSaveItem_Click);
            // 
            // id_treningTextBox
            // 
            this.id_treningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treningBindingSource, "id_trening", true));
            this.id_treningTextBox.Enabled = false;
            this.id_treningTextBox.Location = new System.Drawing.Point(87, 28);
            this.id_treningTextBox.Name = "id_treningTextBox";
            this.id_treningTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_treningTextBox.TabIndex = 2;
            // 
            // id_bazaTextBox
            // 
            this.id_bazaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treningBindingSource, "id_baza", true));
            this.id_bazaTextBox.Enabled = false;
            this.id_bazaTextBox.Location = new System.Drawing.Point(307, 56);
            this.id_bazaTextBox.Name = "id_bazaTextBox";
            this.id_bazaTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_bazaTextBox.TabIndex = 4;
            // 
            // id_klubTextBox
            // 
            this.id_klubTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treningBindingSource, "id_klub", true));
            this.id_klubTextBox.Enabled = false;
            this.id_klubTextBox.Location = new System.Drawing.Point(307, 82);
            this.id_klubTextBox.Name = "id_klubTextBox";
            this.id_klubTextBox.Size = new System.Drawing.Size(200, 20);
            this.id_klubTextBox.TabIndex = 6;
            // 
            // obciazenieTextBox
            // 
            this.obciazenieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treningBindingSource, "obciazenie", true));
            this.obciazenieTextBox.Location = new System.Drawing.Point(87, 106);
            this.obciazenieTextBox.Name = "obciazenieTextBox";
            this.obciazenieTextBox.Size = new System.Drawing.Size(200, 20);
            this.obciazenieTextBox.TabIndex = 8;
            // 
            // typ_treninguTextBox
            // 
            this.typ_treninguTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.treningBindingSource, "typ_treningu", true));
            this.typ_treninguTextBox.Location = new System.Drawing.Point(87, 132);
            this.typ_treninguTextBox.Name = "typ_treninguTextBox";
            this.typ_treninguTextBox.Size = new System.Drawing.Size(200, 20);
            this.typ_treninguTextBox.TabIndex = 10;
            // 
            // data_treninguDateTimePicker
            // 
            this.data_treninguDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.treningBindingSource, "data_treningu", true));
            this.data_treninguDateTimePicker.Location = new System.Drawing.Point(87, 158);
            this.data_treninguDateTimePicker.Name = "data_treninguDateTimePicker";
            this.data_treninguDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_treninguDateTimePicker.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Location = new System.Drawing.Point(87, 52);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Text = "Wybierz";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 16;
            this.comboBox2.Location = new System.Drawing.Point(87, 77);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 24);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.Text = "Wybierz";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 253);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(id_treningLabel);
            this.Controls.Add(this.id_treningTextBox);
            this.Controls.Add(id_bazaLabel);
            this.Controls.Add(this.id_bazaTextBox);
            this.Controls.Add(id_klubLabel);
            this.Controls.Add(this.id_klubTextBox);
            this.Controls.Add(obciazenieLabel);
            this.Controls.Add(this.obciazenieTextBox);
            this.Controls.Add(typ_treninguLabel);
            this.Controls.Add(this.typ_treninguTextBox);
            this.Controls.Add(data_treninguLabel);
            this.Controls.Add(this.data_treninguDateTimePicker);
            this.Controls.Add(this.treningBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treningBindingNavigator)).EndInit();
            this.treningBindingNavigator.ResumeLayout(false);
            this.treningBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pabDataSet pabDataSet;
        private System.Windows.Forms.BindingSource treningBindingSource;
        private pabDataSetTableAdapters.treningTableAdapter treningTableAdapter;
        private pabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator treningBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton treningBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_treningTextBox;
        private System.Windows.Forms.TextBox id_bazaTextBox;
        private System.Windows.Forms.TextBox id_klubTextBox;
        private System.Windows.Forms.TextBox obciazenieTextBox;
        private System.Windows.Forms.TextBox typ_treninguTextBox;
        private System.Windows.Forms.DateTimePicker data_treninguDateTimePicker;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}