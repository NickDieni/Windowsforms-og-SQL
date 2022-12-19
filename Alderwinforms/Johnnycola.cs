using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Alderwinforms
{
    public class Johnnycola
    {
        public string Navn;
        public string Efternavn;
        public string Alder;
        public void DataCheck()
        {
            string cstring = "server = 172.25.220.175; uid = Nick; pwd = Passw0rd; DATABASE = Loginpage;";
            SqlConnection conn = new SqlConnection();

            try
            {
                conn = new SqlConnection(cstring);

                //MessageBox.Show("SQL Connection godkendt");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl: {ex.Message}");
                throw;
            }



            
        }
        public void Opret(string Navn, string Efternavn, string Alder)
        {
            string cstring = "server = 172.25.220.175; uid = Nick; pwd = Passw0rd; DATABASE = Loginpage;";
            SqlConnection con = new SqlConnection(cstring);

            con.Open();

            string NavnData = Navn;
            string EfternavnData = Efternavn;
            string AlderData = Alder;
            if (int.TryParse(AlderData, out int id))
            {
                if (id >= 18)
                {
                    SqlCommand cmd = new SqlCommand($"INSERT INTO Users (navn, efternavn, alder, aldernok) VALUES ('{NavnData}', '{EfternavnData}', '{AlderData}', 1)", con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand($"INSERT INTO Users (navn, efternavn, alder, aldernok) VALUES ('{NavnData}', '{EfternavnData}', '{AlderData}', 0)", con);
                    cmd.ExecuteNonQuery();
                }
            }

           
          
            con.Close();
        }

    }
}
