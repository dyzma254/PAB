using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktopdb
{
    public partial class modyfikuj_liga : Form
    {
        public modyfikuj_liga()
        {
            InitializeComponent();
                     
            sprawdz1();
            sprawdz2();
        }

       
       
     
        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pabDataSet.Liga' table. You can move, or remove it, as needed.
            this.ligaTableAdapter.Fill(this.pabDataSet.Liga);        

        }

      
        
        void sprawdz1()
        {
            if (czy_playofyCheckBox.Checked)
            {
                czy_playofyCheckBox.Text = "Tak";
            }
            else
            {
                czy_playofyCheckBox.Text = "tak";
            }
        }

      
        
        void sprawdz2()
        {
            if (czy_grupyCheckBox.Checked)
            {
                czy_grupyCheckBox.Text = "Tak";
            }
            else
            {
                czy_grupyCheckBox.Text = "tak";
            }
        }

       

        private void ligaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ligaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pabDataSet);

        }

        

        private void ligaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
