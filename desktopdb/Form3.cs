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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void klienciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.klienciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.komis);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'komis.Klienci' . Możesz go przenieść lub usunąć.
            this.klienciTableAdapter.Fill(this.komis.Klienci);

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void klienciBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
