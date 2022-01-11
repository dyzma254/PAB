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
    public partial class modyfikuj_zawodnicy : Form
    {
        public modyfikuj_zawodnicy()
        {
            InitializeComponent();
        }

        private void rodzaje_TransakcjiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
         

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pabDataSet.Zawodnik' table. You can move, or remove it, as needed.
            this.zawodnikTableAdapter.Fill(this.pabDataSet.Zawodnik);
            // TODO: This line of code loads data into the 'pabDataSet.Zawodnik' table. You can move, or remove it, as needed.
            this.zawodnikTableAdapter.Fill(this.pabDataSet.Zawodnik);
        
         

        }

        private void zawodnikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zawodnikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pabDataSet);

        }
    }
}
