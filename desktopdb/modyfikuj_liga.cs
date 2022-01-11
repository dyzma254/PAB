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
            Fillcombo1();           
            sprawdz1();
            sprawdz2();
        }

        void Fillcombo1()
        {
            string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
            string query = "select * from Liga";
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
                    comboBox1.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

       
     
        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pabDataSet.Liga' table. You can move, or remove it, as needed.
            this.ligaTableAdapter.Fill(this.pabDataSet.Liga);        

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
            string query = "select * from Liga where CONVERT(VARCHAR,nazwa)='" + comboBox1.Text + "';";
            SqlConnection condatabase = new SqlConnection(constring);
            SqlCommand cmddatabase = new SqlCommand(query, condatabase);
            SqlDataReader myreader;
            try
            {
                condatabase.Open();
                myreader = cmddatabase.ExecuteReader();
                while (myreader.Read())
                {
                    Object sname = myreader.GetValue(myreader.GetOrdinal("ID_Ligi"));
                    id_ligaTextBox.Text = sname.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void iD_ModeluTextBox_TextChanged(object sender, EventArgs e)
        {
            
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

        private void powypadkowyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sprawdz1();
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

        private void rezerwacjaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            sprawdz2();
        }

        private void ligaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ligaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pabDataSet);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ligaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
