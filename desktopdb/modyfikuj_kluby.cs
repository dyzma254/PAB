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
    public partial class modyfikuj_kluby : Form
    {
        public modyfikuj_kluby()
        {
            InitializeComponent();
            Fillcombo1();
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
                    Object sname = myreader.GetValue(myreader.GetOrdinal("ID_Liga"));
                    id_ligaTextBox.Text = sname.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        
    }
    }
}
