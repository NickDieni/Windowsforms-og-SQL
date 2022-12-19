using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Alderwinforms
{
    public partial class Datavis : Form
    {
        public Datavis()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Velkommenside form1 = new Velkommenside();
            form1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        public void Login_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("server = 172.25.220.175; uid = Nick; pwd = Passw0rd; DATABASE = Loginpage;");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);
            //SqlDataReader dr = cmd.ExecuteReader();

            //string[] temp;
            //while (dr.Read())
            //{
            //    temp = new string[] {
            //    Convert.ToString(dr.GetValue(0)),
            //    Convert.ToString(dr.GetValue(1)),
            //    Convert.ToString(dr.GetValue(2)),
            //    Convert.ToString(dr.GetValue(3)),
            //    Convert.ToString(dr.GetValue(4))
            //    };
            //    dataGridView1.Rows.Add(temp);
            //}
            //dr.Close();
            //cmd.Cancel();
            //con.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int valgtindex = dataGridView1.SelectedRows[0].Index;
                SqlConnection con = new SqlConnection("server = 172.25.220.175; uid = Nick; pwd = Passw0rd; DATABASE = Loginpage;");
                con.Open();
                int rowID = int.Parse(dataGridView1[0, valgtindex].Value.ToString());

                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE id = " + rowID, con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Users", con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        public void Updatetable_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server = 172.25.220.175; uid = Nick; pwd = Passw0rd; DATABASE = Loginpage;");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Brugeradd_Click(object sender, EventArgs e)
        {
            Miniadd nyAdd = new Miniadd();
            nyAdd.ShowDialog();
        }
    }
}
