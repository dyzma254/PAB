
namespace desktopdb
{
    partial class modyfikuj_baza
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
            System.Windows.Forms.Label id_bazaLabel;
            System.Windows.Forms.Label miastoLabel;
            System.Windows.Forms.Label nazwaLabel;
            System.Windows.Forms.Label zadaszenieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modyfikuj_baza));
            this.pabDataSet = new desktopdb.pabDataSet();
            this.baza_treningowaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza_treningowaTableAdapter = new desktopdb.pabDataSetTableAdapters.baza_treningowaTableAdapter();
            this.tableAdapterManager = new desktopdb.pabDataSetTableAdapters.TableAdapterManager();
            this.baza_treningowaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.baza_treningowaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_bazaTextBox = new System.Windows.Forms.TextBox();
            this.miastoTextBox = new System.Windows.Forms.TextBox();
            this.nazwaTextBox = new System.Windows.Forms.TextBox();
            this.zadaszenieCheckBox = new System.Windows.Forms.CheckBox();
            id_bazaLabel = new System.Windows.Forms.Label();
            miastoLabel = new System.Windows.Forms.Label();
            nazwaLabel = new System.Windows.Forms.Label();
            zadaszenieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_treningowaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_treningowaBindingNavigator)).BeginInit();
            this.baza_treningowaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_bazaLabel
            // 
            id_bazaLabel.AutoSize = true;
            id_bazaLabel.Location = new System.Drawing.Point(62, 31);
            id_bazaLabel.Name = "id_bazaLabel";
            id_bazaLabel.Size = new System.Drawing.Size(44, 13);
            id_bazaLabel.TabIndex = 1;
            id_bazaLabel.Text = "id baza:";
            // 
            // miastoLabel
            // 
            miastoLabel.AutoSize = true;
            miastoLabel.Location = new System.Drawing.Point(62, 57);
            miastoLabel.Name = "miastoLabel";
            miastoLabel.Size = new System.Drawing.Size(40, 13);
            miastoLabel.TabIndex = 3;
            miastoLabel.Text = "miasto:";
            // 
            // nazwaLabel
            // 
            nazwaLabel.AutoSize = true;
            nazwaLabel.Location = new System.Drawing.Point(62, 83);
            nazwaLabel.Name = "nazwaLabel";
            nazwaLabel.Size = new System.Drawing.Size(41, 13);
            nazwaLabel.TabIndex = 5;
            nazwaLabel.Text = "nazwa:";
            // 
            // zadaszenieLabel
            // 
            zadaszenieLabel.AutoSize = true;
            zadaszenieLabel.Location = new System.Drawing.Point(62, 111);
            zadaszenieLabel.Name = "zadaszenieLabel";
            zadaszenieLabel.Size = new System.Drawing.Size(63, 13);
            zadaszenieLabel.TabIndex = 7;
            zadaszenieLabel.Text = "zadaszenie:";
            // 
            // pabDataSet
            // 
            this.pabDataSet.DataSetName = "pabDataSet";
            this.pabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baza_treningowaBindingSource
            // 
            this.baza_treningowaBindingSource.DataMember = "baza_treningowa";
            this.baza_treningowaBindingSource.DataSource = this.pabDataSet;
            // 
            // baza_treningowaTableAdapter
            // 
            this.baza_treningowaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.baza_treningowaTableAdapter = this.baza_treningowaTableAdapter;
            this.tableAdapterManager.KlubTableAdapter = null;
            this.tableAdapterManager.LigaTableAdapter = null;
            this.tableAdapterManager.treningTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = desktopdb.pabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Zawodnicy_na_treninguTableAdapter = null;
            this.tableAdapterManager.ZawodnikTableAdapter = null;
            // 
            // baza_treningowaBindingNavigator
            // 
            this.baza_treningowaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.baza_treningowaBindingNavigator.BindingSource = this.baza_treningowaBindingSource;
            this.baza_treningowaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.baza_treningowaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.baza_treningowaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.baza_treningowaBindingNavigatorSaveItem});
            this.baza_treningowaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.baza_treningowaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.baza_treningowaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.baza_treningowaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.baza_treningowaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.baza_treningowaBindingNavigator.Name = "baza_treningowaBindingNavigator";
            this.baza_treningowaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.baza_treningowaBindingNavigator.Size = new System.Drawing.Size(309, 25);
            this.baza_treningowaBindingNavigator.TabIndex = 0;
            this.baza_treningowaBindingNavigator.Text = "bindingNavigator1";
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
            // baza_treningowaBindingNavigatorSaveItem
            // 
            this.baza_treningowaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.baza_treningowaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("baza_treningowaBindingNavigatorSaveItem.Image")));
            this.baza_treningowaBindingNavigatorSaveItem.Name = "baza_treningowaBindingNavigatorSaveItem";
            this.baza_treningowaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.baza_treningowaBindingNavigatorSaveItem.Text = "Save Data";
            this.baza_treningowaBindingNavigatorSaveItem.Click += new System.EventHandler(this.baza_treningowaBindingNavigatorSaveItem_Click);
            // 
            // id_bazaTextBox
            // 
            this.id_bazaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baza_treningowaBindingSource, "id_baza", true));
            this.id_bazaTextBox.Enabled = false;
            this.id_bazaTextBox.Location = new System.Drawing.Point(131, 28);
            this.id_bazaTextBox.Name = "id_bazaTextBox";
            this.id_bazaTextBox.Size = new System.Drawing.Size(104, 20);
            this.id_bazaTextBox.TabIndex = 2;
            // 
            // miastoTextBox
            // 
            this.miastoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baza_treningowaBindingSource, "miasto", true));
            this.miastoTextBox.Location = new System.Drawing.Point(131, 54);
            this.miastoTextBox.Name = "miastoTextBox";
            this.miastoTextBox.Size = new System.Drawing.Size(104, 20);
            this.miastoTextBox.TabIndex = 4;
            // 
            // nazwaTextBox
            // 
            this.nazwaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.baza_treningowaBindingSource, "nazwa", true));
            this.nazwaTextBox.Location = new System.Drawing.Point(131, 80);
            this.nazwaTextBox.Name = "nazwaTextBox";
            this.nazwaTextBox.Size = new System.Drawing.Size(104, 20);
            this.nazwaTextBox.TabIndex = 6;
            // 
            // zadaszenieCheckBox
            // 
            this.zadaszenieCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.baza_treningowaBindingSource, "zadaszenie", true));
            this.zadaszenieCheckBox.Location = new System.Drawing.Point(131, 106);
            this.zadaszenieCheckBox.Name = "zadaszenieCheckBox";
            this.zadaszenieCheckBox.Size = new System.Drawing.Size(104, 24);
            this.zadaszenieCheckBox.TabIndex = 8;
            this.zadaszenieCheckBox.Text = "tak";
            this.zadaszenieCheckBox.UseVisualStyleBackColor = true;
            this.zadaszenieCheckBox.CheckedChanged += new System.EventHandler(this.zadaszenieCheckBox_CheckedChanged);
            // 
            // modyfikuj_baza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 155);
            this.Controls.Add(id_bazaLabel);
            this.Controls.Add(this.id_bazaTextBox);
            this.Controls.Add(miastoLabel);
            this.Controls.Add(this.miastoTextBox);
            this.Controls.Add(nazwaLabel);
            this.Controls.Add(this.nazwaTextBox);
            this.Controls.Add(zadaszenieLabel);
            this.Controls.Add(this.zadaszenieCheckBox);
            this.Controls.Add(this.baza_treningowaBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "modyfikuj_baza";
            this.Text = "Baza treningowa";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_treningowaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza_treningowaBindingNavigator)).EndInit();
            this.baza_treningowaBindingNavigator.ResumeLayout(false);
            this.baza_treningowaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pabDataSet pabDataSet;
        private System.Windows.Forms.BindingSource baza_treningowaBindingSource;
        private pabDataSetTableAdapters.baza_treningowaTableAdapter baza_treningowaTableAdapter;
        private pabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator baza_treningowaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton baza_treningowaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_bazaTextBox;
        private System.Windows.Forms.TextBox miastoTextBox;
        private System.Windows.Forms.TextBox nazwaTextBox;
        private System.Windows.Forms.CheckBox zadaszenieCheckBox;
    }
}