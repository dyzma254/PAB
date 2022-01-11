using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopdb
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void markiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
         

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pabDataSet.trening' table. You can move, or remove it, as needed.
            this.treningTableAdapter.Fill(this.pabDataSet.trening);
            // TODO: This line of code loads data into the 'pabDataSet.trening' table. You can move, or remove it, as needed.
            this.treningTableAdapter.Fill(this.pabDataSet.trening);
            
            

        }

        private void treningBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.treningBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pabDataSet);

        }
    }
}
