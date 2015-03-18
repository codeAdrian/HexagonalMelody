using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HexagonalMelody
{
    public partial class UploadScoreForm : Form
    {
        public UploadScoreForm(int score)
        {
            InitializeComponent();
            lbl_score.Text = score.ToString();
            this.BringToFront();
            this.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                MySqlCommand command = new MySqlCommand();
                string mySqlConnection = "Server=sql3.freesqldatabase.com;Database=sql346545;uid=sql346545;password=rY5!jS2%;";
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(mySqlConnection))
                    {

                        connection.Open();
                        command = connection.CreateCommand();
                        command.CommandText = "INSERT INTO scoretable (score,name) VALUES(@score,@name)";
                        command.Parameters.AddWithValue("@score", Int32.Parse(lbl_score.Text));
                        command.Parameters.AddWithValue("@name", tbx_scoreName.Text);
                        command.ExecuteNonQuery();

                    }
                }
                catch (Exception)
                {
                    throw;
                }
                this.Close();
            }
        }
    }
}
