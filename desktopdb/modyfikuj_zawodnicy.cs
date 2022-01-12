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
    public partial class modyfikuj_zawodnicy : Form
    {
        public modyfikuj_zawodnicy()
        {
            InitializeComponent();
            FillCombo();
        }

        private void FillCombo()
        {
            string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
            string query = "select * from Klub";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //klub

            string constring = "Data Source=DYZMA-KOMPUTER;Initial Catalog=pab;Integrated Security=True";
            string query = "select * from klub where CONVERT(VARCHAR,nazwa)='" + comboBox1.Text + "';";
            SqlConnection condatabase = new SqlConnection(constring);
            SqlCommand cmddatabase = new SqlCommand(query, condatabase);
            SqlDataReader myreader;
            try
            {
                condatabase.Open();
                myreader = cmddatabase.ExecuteReader();
                while (myreader.Read())
                {
                    Object sname = myreader.GetValue(myreader.GetOrdinal("ID_klub"));
                    id_klubTextBox.Text = sname.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
