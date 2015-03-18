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
    public partial class ShowScores : Form
    {
        public ShowScores()
        {
            InitializeComponent();
            this.BringToFront();
            this.TopMost = true;
        }

        private void listView_aspr_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel=true;
            e.NewWidth = listView_aspr.Columns[e.ColumnIndex].Width;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                int rows = 0;
                MySqlCommand command = new MySqlCommand();
                string mySqlConnection = "Server=sql3.freesqldatabase.com;Database=sql346545;uid=sql346545;password=rY5!jS2%;";
                MySqlConnection connect = new MySqlConnection(mySqlConnection);
                connect.Open();
                command = connect.CreateCommand();
                command.CommandText = "SELECT * FROM scoretable ORDER BY score DESC";

                listView_aspr.Items.Clear();
                try
                {
                    MySqlDataReader dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        rows++;
                        ListViewItem Item = new ListViewItem();

                        string[] row = { dr["name"].ToString(), dr["score"].ToString() };
                        listView_aspr.Items.Add(rows.ToString()).SubItems.AddRange(row);

                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
                connect.Close();
            }

        }
    }
}
