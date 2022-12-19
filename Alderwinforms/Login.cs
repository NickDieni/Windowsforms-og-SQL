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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
                this.Hide();
                Velkommenside form1 = new Velkommenside();
                form1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            SqlConnection con = new SqlConnection("server = 172.25.220.175; uid = Nick; pwd = Passw0rd; DATABASE = Loginpage;");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Users WHERE navn ='" + textBox1.Text + "' AND efternavn ='" + textBox2.Text + "' AND aldernok = '" + i + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                this.Hide();
                Datavis nyData = new Datavis();
                nyData.Show();
            }
            else
            {
                MessageBox.Show("Ugyldigt navn og efternavn, du skal også være 18 for at logge ind");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
