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
    public partial class modyfikuj_baza : Form
    {
        public modyfikuj_baza()
        {
            InitializeComponent();
            Fillcombo();

            
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pabDataSet.baza_treningowa' table. You can move, or remove it, as needed.
            this.baza_treningowaTableAdapter.Fill(this.pabDataSet.baza_treningowa);
            // TODO: This line of code loads data into the 'pabDataSet.baza_treningowa' table. You can move, or remove it, as needed.
            this.baza_treningowaTableAdapter.Fill(this.pabDataSet.baza_treningowa);
        }

        private void modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void modelBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void modelBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
         

        }

        

        private void iD_MarkiTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        void Fillcombo()
        {
            string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
            string query = "select * from baza_treningowa";
            SqlConnection condatabase = new SqlConnection(constring);
            SqlCommand cmddatabase = new SqlCommand(query, condatabase);
            SqlDataReader myreader;
            try
            {
                condatabase.Open();
                myreader = cmddatabase.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(myreader.GetOrdinal("nazwa"));
                    //comboBox1.Items.Add(sname);
                    
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modelBindingNavigator_RefreshItems_1(object sender, EventArgs e)
        {

        }

        private void baza_treningowaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.baza_treningowaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pabDataSet);

        }
        /*
if (iD_MarkiComboBox.SelectedIndex == -1)
{
iD_MarkiTextBox.Text = string.Empty;
}
else
{
foreach (var item in iD_MarkiComboBox.SelectedIndex.ToString())
{
iD_MarkiTextBox.Text = item.ToString();
}

}
*/
    }
}
