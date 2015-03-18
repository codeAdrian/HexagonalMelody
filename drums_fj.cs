using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;

namespace HexagonalMelody
{
    public partial class drums_fj : Form
    {
        private WavePlayer drumSounds = new WavePlayer();
        bool isKeyDown = false;
        Color color_kickdrum = ColorTranslator.FromHtml("#603913");
        Color color_snareDrum = ColorTranslator.FromHtml("#c7b299");
        Color color_lTomDrum = ColorTranslator.FromHtml("#8c6239");
        Color color_mTomDrum = ColorTranslator.FromHtml("#c69c6d");
        Color color_hTomDrum = ColorTranslator.FromHtml("#fbaf5d");
        Color color_closedHiHat = ColorTranslator.FromHtml("#fff799");
        Color color_openHiHat = ColorTranslator.FromHtml("#fff568");
        Color color_crashCymbal = ColorTranslator.FromHtml("#fff200");

        public drums_fj()
        {
            InitializeComponent();
            KeyPreview = true;
            this.BringToFront();
            this.TopMost = true;
            this.Focus();
            generateInstruments();
            string[] drumkits_list = new string[] { "4-piece Drumkit", "6-piece Drumkit", "8-piece Drumkit" };
            cbox_drumkits.Items.AddRange(drumkits_list);
            cbox_drumkits.SelectedIndex = 0;

            drumSounds.AddWave("kickDrum", "Sounds/AcousticDrumset/KickDrum.wav");
            drumSounds.AddWave("tom1Drum", "Sounds/AcousticDrumset/Tom1.wav");
            drumSounds.AddWave("openHiHat", "Sounds/AcousticDrumset/OpenHiHat.wav");
            drumSounds.AddWave("snareDrum", "Sounds/AcousticDrumset/SnareDrum.wav");
            drumSounds.AddWave("closedHiHat", "Sounds/AcousticDrumset/ClosedHiHat.wav");
            drumSounds.AddWave("tom2Drum", "Sounds/AcousticDrumset/Tom2.wav");
            drumSounds.AddWave("tom3Drum", "Sounds/AcousticDrumset/Tom3.wav");
            drumSounds.AddWave("crashCymbal", "Sounds/AcousticDrumset/CrashCymbal.wav");
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void generateInstruments()
        {
            Point[] hexCoordinates = { new Point(40, 0), new Point(120, 0), new Point(160, 70), new Point(120, 140), new Point(40, 140), new Point(0, 70) }; 
            Point[] smallHexCoordinates = { new Point(20, 0), new Point(60, 0), new Point(75, 30), new Point(60, 60), new Point(20, 60), new Point(5, 30) };

            GraphicsPath polygon_path = new GraphicsPath(FillMode.Winding);
            polygon_path.AddPolygon(hexCoordinates);
            Region polygon_region = new Region(polygon_path);

            GraphicsPath smallPolygon_path = new GraphicsPath(FillMode.Winding);
            smallPolygon_path.AddPolygon(smallHexCoordinates);
            Region smallPolygon_region = new Region(smallPolygon_path);

            closedHiHat.FlatStyle = FlatStyle.Flat;
            closedHiHat.FlatAppearance.BorderSize = 0;
            closedHiHat.Region = polygon_region;
            closedHiHat.SetBounds(510, 130, 160, 140);
            closedHiHat.BackColor = color_closedHiHat;
            closedHiHat.Visible = false;

            kickDrum.FlatStyle = FlatStyle.Flat;
            kickDrum.FlatAppearance.BorderSize = 0;
            kickDrum.Region = polygon_region;
            kickDrum.SetBounds(275, 260, 160, 140);
            kickDrum.BackColor = color_kickdrum;

            lTomDrum.FlatStyle = FlatStyle.Flat;
            lTomDrum.FlatAppearance.BorderSize = 0;
            lTomDrum.Region = polygon_region;
            lTomDrum.SetBounds(155, 190, 160, 140);
            lTomDrum.BackColor = color_lTomDrum;

            snareDrum.FlatStyle = FlatStyle.Flat;
            snareDrum.FlatAppearance.BorderSize = 0;
            snareDrum.Region = polygon_region;
            snareDrum.SetBounds(395, 190, 160, 140);
            snareDrum.BackColor = color_snareDrum;

            mTomDrum.FlatStyle = FlatStyle.Flat;
            mTomDrum.FlatAppearance.BorderSize = 0;
            mTomDrum.Region = polygon_region;
            mTomDrum.SetBounds(515, 260, 160, 140);
            mTomDrum.BackColor = color_mTomDrum;
            mTomDrum.Visible = false;

            openHiHat.FlatStyle = FlatStyle.Flat;
            openHiHat.FlatAppearance.BorderSize = 0;
            openHiHat.Region = polygon_region;
            openHiHat.SetBounds(275, 150, 160, 140);
            openHiHat.BackColor = color_openHiHat;

            hTomDrum.FlatStyle = FlatStyle.Flat;
            hTomDrum.FlatAppearance.BorderSize = 0;
            hTomDrum.Region = polygon_region;
            hTomDrum.SetBounds(35, 260, 160, 140);
            hTomDrum.BackColor = color_hTomDrum;
            hTomDrum.Visible = false;

            crashCymbal.FlatStyle = FlatStyle.Flat;
            crashCymbal.FlatAppearance.BorderSize = 0;
            crashCymbal.Region = polygon_region;
            crashCymbal.SetBounds(40, 130, 160, 140);
            crashCymbal.BackColor = color_crashCymbal;
            crashCymbal.Visible = false;
        }

        private void kickDrum_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("kickDrum");
        }

        private void hiHat_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("closedHiHat");
        }

        private void snareDrum_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("snareDrum");
        }

        private void tomDrum_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("tom1Drum");
        }

        private void mTomDrum_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("tom2Drum");
        }

        private void hTomDrum_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("tom3Drum");
        }

        private void openHiHat_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("openHiHat");
        }

        private void crashCymbal_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("crashCymbal");
        }

        private void cbox_drumkits_SelectedIndexChanged(object sender, EventArgs e)
        {
            mTomDrum.Visible = false;
            hTomDrum.Visible = false;
            closedHiHat.Visible = false;
            crashCymbal.Visible = false;

            if (cbox_drumkits.SelectedIndex == 1)
            {
                crashCymbal.Visible = true;
                closedHiHat.Visible = true;
            }

            if (cbox_drumkits.SelectedIndex == 2)
            {
                crashCymbal.Visible = true;
                closedHiHat.Visible = true;
                mTomDrum.Visible = true;
                hTomDrum.Visible = true;
            }

        }

       private void drums_fj_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar=='v') kickDrum.PerformClick();
           if (e.KeyChar == 'a') lTomDrum.PerformClick();
           if (e.KeyChar == 'd') snareDrum.PerformClick();
           if (e.KeyChar == 'q') crashCymbal.PerformClick();
           if (e.KeyChar == 'w') openHiHat.PerformClick();
           if (e.KeyChar == 'e') closedHiHat.PerformClick();
           if (e.KeyChar == 'y') hTomDrum.PerformClick();
           if (e.KeyChar == 'c') mTomDrum.PerformClick();

        }

       private void b_drumAbout_Click(object sender, EventArgs e)
       {
           Drums_about drumInfo = new Drums_about();
           drumInfo.Show();
       }



    }
}
