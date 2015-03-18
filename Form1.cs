using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HexagonalMelody
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void b_drums_mm_Click(object sender, EventArgs e)
        {
            Form drums_mm = new Drums_mm();
            drums_mm.Show();
        }

        private void b_drums_fj_Click(object sender, EventArgs e)
        {
            Form drums_fj = new drums_fj();
            drums_fj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form viewscores = new ShowScores();
            viewscores.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.Show();
        }

    }
}
