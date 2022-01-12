
namespace desktopdb
{
    partial class modyfikuj_obecnosc
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
            System.Windows.Forms.Label id_zawodnikLabel;
            System.Windows.Forms.Label obecnyLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modyfikuj_obecnosc));
            this.pabDataSet = new desktopdb.pabDataSet();
            this.zawodnicy_na_treninguBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zawodnicy_na_treninguTableAdapter = new desktopdb.pabDataSetTableAdapters.Zawodnicy_na_treninguTableAdapter();
            this.tableAdapterManager = new desktopdb.pabDataSetTableAdapters.TableAdapterManager();
            this.zawodnicy_na_treninguBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.zawodnicy_na_treninguBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_treningTextBox = new System.Windows.Forms.TextBox();
            this.id_zawodnikTextBox = new System.Windows.Forms.TextBox();
            this.obecnyCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            id_treningLabel = new System.Windows.Forms.Label();
            id_zawodnikLabel = new System.Windows.Forms.Label();
            obecnyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zawodnicy_na_treninguBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zawodnicy_na_treninguBindingNavigator)).BeginInit();
            this.zawodnicy_na_treninguBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_treningLabel
            // 
            id_treningLabel.AutoSize = true;
            id_treningLabel.Location = new System.Drawing.Point(12, 34);
            id_treningLabel.Name = "id_treningLabel";
            id_treningLabel.Size = new System.Drawing.Size(43, 13);
            id_treningLabel.TabIndex = 1;
            id_treningLabel.Text = "Trening";
            // 
            // id_zawodnikLabel
            // 
            id_zawodnikLabel.AutoSize = true;
            id_zawodnikLabel.Location = new System.Drawing.Point(12, 60);
            id_zawodnikLabel.Name = "id_zawodnikLabel";
            id_zawodnikLabel.Size = new System.Drawing.Size(54, 13);
            id_zawodnikLabel.TabIndex = 3;
            id_zawodnikLabel.Text = "Zawodnik";
            // 
            // obecnyLabel
            // 
            obecnyLabel.AutoSize = true;
            obecnyLabel.Location = new System.Drawing.Point(12, 88);
            obecnyLabel.Name = "obecnyLabel";
            obecnyLabel.Size = new System.Drawing.Size(45, 13);
            obecnyLabel.TabIndex = 5;
            obecnyLabel.Text = "obecny:";
            // 
            // pabDataSet
            // 
            this.pabDataSet.DataSetName = "pabDataSet";
            this.pabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zawodnicy_na_treninguBindingSource
            // 
            this.zawodnicy_na_treninguBindingSource.DataMember = "Zawodnicy_na_treningu";
            this.zawodnicy_na_treninguBindingSource.DataSource = this.pabDataSet;
            // 
            // zawodnicy_na_treninguTableAdapter
            // 
            this.zawodnicy_na_treninguTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.baza_treningowaTableAdapter = null;
            this.tableAdapterManager.KlubTableAdapter = null;
            this.tableAdapterManager.LigaTableAdapter = null;
            this.tableAdapterManager.treningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = desktopdb.pabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zawodnicy_na_treninguTableAdapter = this.zawodnicy_na_treninguTableAdapter;
            this.tableAdapterManager.ZawodnikTableAdapter = null;
            // 
            // zawodnicy_na_treninguBindingNavigator
            // 
            this.zawodnicy_na_treninguBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.zawodnicy_na_treninguBindingNavigator.BindingSource = this.zawodnicy_na_treninguBindingSource;
            this.zawodnicy_na_treninguBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.zawodnicy_na_treninguBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.zawodnicy_na_treninguBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.zawodnicy_na_treninguBindingNavigatorSaveItem});
            this.zawodnicy_na_treninguBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.zawodnicy_na_treninguBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.zawodnicy_na_treninguBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.zawodnicy_na_treninguBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.zawodnicy_na_treninguBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.zawodnicy_na_treninguBindingNavigator.Name = "zawodnicy_na_treninguBindingNavigator";
            this.zawodnicy_na_treninguBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.zawodnicy_na_treninguBindingNavigator.Size = new System.Drawing.Size(484, 25);
            this.zawodnicy_na_treninguBindingNavigator.TabIndex = 0;
            this.zawodnicy_na_treninguBindingNavigator.Text = "bindingNavigator1";
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
            // zawodnicy_na_treninguBindingNavigatorSaveItem
            // 
            this.zawodnicy_na_treninguBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zawodnicy_na_treninguBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("zawodnicy_na_treninguBindingNavigatorSaveItem.Image")));
            this.zawodnicy_na_treninguBindingNavigatorSaveItem.Name = "zawodnicy_na_treninguBindingNavigatorSaveItem";
            this.zawodnicy_na_treninguBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.zawodnicy_na_treninguBindingNavigatorSaveItem.Text = "Save Data";
            this.zawodnicy_na_treninguBindingNavigatorSaveItem.Click += new System.EventHandler(this.zawodnicy_na_treninguBindingNavigatorSaveItem_Click);
            // 
            // id_treningTextBox
            // 
            this.id_treningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zawodnicy_na_treninguBindingSource, "id_trening", true));
            this.id_treningTextBox.Enabled = false;
            this.id_treningTextBox.Location = new System.Drawing.Point(252, 28);
            this.id_treningTextBox.Name = "id_treningTextBox";
            this.id_treningTextBox.Size = new System.Drawing.Size(104, 20);
            this.id_treningTextBox.TabIndex = 2;
            this.id_treningTextBox.Visible = false;
            // 
            // id_zawodnikTextBox
            // 
            this.id_zawodnikTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zawodnicy_na_treninguBindingSource, "id_zawodnik", true));
            this.id_zawodnikTextBox.Enabled = false;
            this.id_zawodnikTextBox.Location = new System.Drawing.Point(252, 60);
            this.id_zawodnikTextBox.Name = "id_zawodnikTextBox";
            this.id_zawodnikTextBox.Size = new System.Drawing.Size(104, 20);
            this.id_zawodnikTextBox.TabIndex = 4;
            this.id_zawodnikTextBox.Visible = false;
            // 
            // obecnyCheckBox
            // 
            this.obecnyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.zawodnicy_na_treninguBindingSource, "obecny", true));
            this.obecnyCheckBox.Location = new System.Drawing.Point(84, 83);
            this.obecnyCheckBox.Name = "obecnyCheckBox";
            this.obecnyCheckBox.Size = new System.Drawing.Size(104, 24);
            this.obecnyCheckBox.TabIndex = 6;
            this.obecnyCheckBox.Text = "tak";
            this.obecnyCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 16;
            this.comboBox1.Location = new System.Drawing.Point(84, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 24);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Text = "Wybierz";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 16;
            this.comboBox2.Location = new System.Drawing.Point(84, 53);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 24);
            this.comboBox2.TabIndex = 32;
            this.comboBox2.Text = "Wybierz";
            // 
            // modyfikuj_obecnosc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 121);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(id_treningLabel);
            this.Controls.Add(this.id_treningTextBox);
            this.Controls.Add(id_zawodnikLabel);
            this.Controls.Add(this.id_zawodnikTextBox);
            this.Controls.Add(obecnyLabel);
            this.Controls.Add(this.obecnyCheckBox);
            this.Controls.Add(this.zawodnicy_na_treninguBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "modyfikuj_obecnosc";
            this.Text = "Obecnosc";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zawodnicy_na_treninguBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zawodnicy_na_treninguBindingNavigator)).EndInit();
            this.zawodnicy_na_treninguBindingNavigator.ResumeLayout(false);
            this.zawodnicy_na_treninguBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pabDataSet pabDataSet;
        private System.Windows.Forms.BindingSource zawodnicy_na_treninguBindingSource;
        private pabDataSetTableAdapters.Zawodnicy_na_treninguTableAdapter zawodnicy_na_treninguTableAdapter;
        private pabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator zawodnicy_na_treninguBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton zawodnicy_na_treninguBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_treningTextBox;
        private System.Windows.Forms.TextBox id_zawodnikTextBox;
        private System.Windows.Forms.CheckBox obecnyCheckBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}