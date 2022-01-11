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
    public partial class modyfikuj_obecnosc : Form
    {
        public modyfikuj_obecnosc()
        {
            InitializeComponent();
        }

        private void rabatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();  

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pabDataSet.Zawodnicy_na_treningu' table. You can move, or remove it, as needed.
            this.zawodnicy_na_treninguTableAdapter.Fill(this.pabDataSet.Zawodnicy_na_treningu);
            // TODO: This line of code loads data into the 'pabDataSet.Zawodnicy_na_treningu' table. You can move, or remove it, as needed.
            this.zawodnicy_na_treninguTableAdapter.Fill(this.pabDataSet.Zawodnicy_na_treningu);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'komis.Rabat' . Możesz go przenieść lub usunąć.
           

        }

        private void zawodnicy_na_treninguBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zawodnicy_na_treninguBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pabDataSet);

        }
    }
}
