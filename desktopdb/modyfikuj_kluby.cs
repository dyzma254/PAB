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
    public partial class modyfikuj_kluby : Form
    {
        public modyfikuj_kluby()
        {
            InitializeComponent();
        }

        private void koloryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
     

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pabDataSet.Klub' table. You can move, or remove it, as needed.
            this.klubTableAdapter.Fill(this.pabDataSet.Klub);
            // TODO: This line of code loads data into the 'pabDataSet.Klub' table. You can move, or remove it, as needed.
            this.klubTableAdapter.Fill(this.pabDataSet.Klub);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'komis.Kolory' . Możesz go przenieść lub usunąć.
            

        }

        private void klubBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klubBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pabDataSet);

        }
    }
}
