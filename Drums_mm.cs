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
using System.Threading;
using System.Threading.Tasks;

namespace HexagonalMelody
{
    public partial class Drums_mm : Form
    {
        int[] beats = new int[] {0,0,0,0,0,0,0,0,0,0,0,0};
        int difficultySize = 0;
        int gameFlag = 0, gameCounter=0;
        private WavePlayer drumSounds = new WavePlayer();
        Color color_kickdrum = ColorTranslator.FromHtml("#603913");
        Color color_snareDrum = ColorTranslator.FromHtml("#c7b299");
        Color color_lTomDrum = ColorTranslator.FromHtml("#8c6239");
        Color color_mTomDrum = ColorTranslator.FromHtml("#c69c6d");
        Color color_hTomDrum = ColorTranslator.FromHtml("#fbaf5d");
        Color color_closedHiHat = ColorTranslator.FromHtml("#fff799");
        Color color_openHiHat = ColorTranslator.FromHtml("#fff568");
        Color color_crashCymbal = ColorTranslator.FromHtml("#fff200");

        public Drums_mm()
        {
            InitializeComponent();
            this.BringToFront();
            this.TopMost = true;

            KeyPreview = true;
            this.BringToFront();
            this.TopMost = true;
            this.Focus();
            generateInstruments();
            string[] drumkits_list = new string[] { "4-piece Drumkit", "6-piece Drumkit", "8-piece Drumkit" };
            string[] difficulty_list = new string[] { "Easy", "Medium", "Hard" };
            cbox_drumkits.Items.AddRange(drumkits_list);
            cbox_drumkits.SelectedIndex = 0;
            cbx_difficulty.Items.AddRange(difficulty_list);
            cbx_difficulty.SelectedIndex = 0;

            drumSounds.AddWave("kickDrum", "Sounds/AcousticDrumset/KickDrum.wav");
            drumSounds.AddWave("tom1Drum", "Sounds/AcousticDrumset/Tom1.wav");
            drumSounds.AddWave("openHiHat", "Sounds/AcousticDrumset/OpenHiHat.wav");
            drumSounds.AddWave("snareDrum", "Sounds/AcousticDrumset/SnareDrum.wav");
            drumSounds.AddWave("closedHiHat", "Sounds/AcousticDrumset/ClosedHiHat.wav");
            drumSounds.AddWave("tom2Drum", "Sounds/AcousticDrumset/Tom2.wav");
            drumSounds.AddWave("tom3Drum", "Sounds/AcousticDrumset/Tom3.wav");
            drumSounds.AddWave("crashCymbal", "Sounds/AcousticDrumset/CrashCymbal.wav");
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

            if (gameFlag == 1 && gameCounter < difficultySize-1 && beats[gameCounter] == 1)
            { gameCounter++; }

            else if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] != 1)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] == 1)
            {
                lbl_nCorrect.Text = (Int32.Parse(lbl_nCorrect.Text) + 1).ToString();
                lbl_message.Text = "Correct! Click on the 'New Puzzle' button!";
                gameFlag = 0; gameCounter = 0;
                b_newPuzzle.Enabled = true;
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] != 1)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }
  
        }

        private void closedHiHat_Click(object sender, EventArgs e)
        {
            // 1 - kickDrum 2-snare 3-lowTom 4-openHiHat 5-ClosedHiHat 6-CrashCymbal 7-mediumTom 8-highTom 
            drumSounds.PlayWave("closedHiHat");

            if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] == 5)
            { gameCounter++; }

            else if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] != 1)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] == 5)
            {
                lbl_nCorrect.Text = (Int32.Parse(lbl_nCorrect.Text) + 1).ToString();
                lbl_message.Text = "Correct! Click on the 'New Puzzle' button!";
                gameFlag = 0; gameCounter = 0;
                b_newPuzzle.Enabled = true;
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] != 5)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }
        }

        private void crashCymbal_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("crashCymbal");

            if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] == 6)
            { gameCounter++; }

            else if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] != 6)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] == 6)
            {
                lbl_nCorrect.Text = (Int32.Parse(lbl_nCorrect.Text) + 1).ToString();
                lbl_message.Text = "Correct! Click on the 'New Puzzle' button!";
                gameFlag = 0; gameCounter = 0;
                b_newPuzzle.Enabled = true;
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] != 6)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }
        }

        private void mTomDrum_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("tom2Drum");

            if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] == 7)
            { gameCounter++; }

            else if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] != 7)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] == 7)
            {
                lbl_nCorrect.Text = (Int32.Parse(lbl_nCorrect.Text) + 1).ToString();
                lbl_message.Text = "Correct! Click on the 'New Puzzle' button!";
                gameFlag = 0; gameCounter = 0;
                b_newPuzzle.Enabled = true;
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] != 7)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }
        }

        private void lTomDrum_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("tom1Drum");

            if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] == 3)
            { gameCounter++; }

            else if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] != 3)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] == 3)
            {
                lbl_nCorrect.Text = (Int32.Parse(lbl_nCorrect.Text) + 1).ToString();
                lbl_message.Text = "Correct! Click on the 'New Puzzle' button!";
                gameFlag = 0; gameCounter = 0;
                b_newPuzzle.Enabled = true;
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] != 3)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }
        }

        private void openHiHat_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("openHiHat");

            if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] == 4)
            { gameCounter++; }

            else if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] != 4)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] == 4)
            {
                lbl_nCorrect.Text = (Int32.Parse(lbl_nCorrect.Text) + 1).ToString();
                lbl_message.Text = "Correct! Click on the 'New Puzzle' button!";
                gameFlag = 0; gameCounter = 0;
                b_newPuzzle.Enabled = true;
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] != 4)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }
        }

        private void snareDrum_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("snareDrum");

            if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] == 2)
            { gameCounter++; }

            else if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] != 2)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] == 2)
            {
                lbl_nCorrect.Text = (Int32.Parse(lbl_nCorrect.Text) + 1).ToString();
                lbl_message.Text = "Correct! Click on the 'New Puzzle' button!";
                gameFlag = 0; gameCounter = 0;
                b_newPuzzle.Enabled = true;
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] != 2)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;
                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }
        }

        private void hTomDrum_Click(object sender, EventArgs e)
        {
            drumSounds.PlayWave("tom3Drum");

            if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] == 8)
            { gameCounter++; }

            else if (gameFlag == 1 && gameCounter < difficultySize - 1 && beats[gameCounter] != 8)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;

                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                b_newPuzzle.Enabled = true;
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                calculateScore();
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] == 8)
            {
                lbl_nCorrect.Text = (Int32.Parse(lbl_nCorrect.Text) + 1).ToString();
                lbl_message.Text = "Correct! Click on the 'New Puzzle' button!";
                b_newPuzzle.Enabled = true;
                gameFlag = 0; gameCounter = 0;
            }

            else if (gameFlag == 1 && gameCounter == difficultySize - 1 && beats[gameCounter] != 8)
            {
                cbox_drumkits.Enabled = true;
                cbx_difficulty.Enabled = true;
                cbx_noVisualClues.Enabled = true;

                gameFlag = 0; gameCounter = 0; lbl_message.Text = "Incorrect! Click on the 'New Puzzle' Button!";
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                b_newPuzzle.Enabled = true;
                calculateScore();
            }
        }

        private void Drums_mm_KeyPress(object sender, KeyPressEventArgs e)
        {

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

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_newPuzzle_Click(object sender, EventArgs e)
        {
            if (cbx_noVisualClues.Checked == false) { lbl_message.Text = "Watch the pattern!"; }
            else lbl_message.Text = "Listen to the sequence!";
            cbox_drumkits.Enabled = false;
            cbx_difficulty.Enabled = false;
            cbx_noVisualClues.Enabled = false;
            b_newPuzzle.Enabled = false;
            if (gameFlag == 1)
            {
                lbl_nIncorrect.Text = (Int32.Parse(lbl_nIncorrect.Text) + 1).ToString();
                gameFlag = 0; gameCounter = 0;
            }
            int randomDrum=0;
            Random random = new Random();
            if (cbx_difficulty.SelectedIndex == 0) difficultySize = 4;
            if (cbx_difficulty.SelectedIndex == 1) difficultySize = 6;
            if (cbx_difficulty.SelectedIndex == 2) difficultySize = 8;

            int maxNum = 0;
            if (cbox_drumkits.SelectedIndex == 0) maxNum = 5;
            if (cbox_drumkits.SelectedIndex == 1) maxNum = 7;
            if (cbox_drumkits.SelectedIndex == 2) maxNum = 9;

            for (int i = 0; i < difficultySize; i++)
            {
                randomDrum = random.Next(1, maxNum);
                beats[i]=randomDrum;
               using( Task playBeatTask = Task.Factory.StartNew(()=>playBeat(randomDrum))) playBeatTask.Wait();
            }
            gameFlag = 1; gameCounter = 0;
            lbl_message.Text = "Go!";
        }

        private void calculateScore()
        {
            int score = 0;
            double fscore=0;
            score = Int32.Parse(lbl_nCorrect.Text) * 10;
            if (cbx_difficulty.SelectedIndex == 1) score = score * 2;
            if (cbx_difficulty.SelectedIndex == 2) score = score * 4;
            if (cbx_noVisualClues.Checked == true) score = score * 2;
            if (cbox_drumkits.SelectedIndex == 1) { fscore = ((float)score); fscore = fscore * 1.5; score = (int)fscore; }
            if (cbox_drumkits.SelectedIndex == 2) score = score * 2;
            if (score < 0) score = 0;
            Form uScore = new UploadScoreForm(score);
            lbl_nCorrect.Text = "0";
            uScore.Show();
        }


        private void playBeat(int drum)
        {
            // 1 - kickDrum 2-snare 3-lowTom 4-openHiHat 5-ClosedHiHat 6-CrashCymbal 7-mediumTom 8-highTom 

                if (cbx_noVisualClues.Checked == false && drum==1)
                {
                        kickDrum.BackColor = Color.White;
                        kickDrum.PerformClick();
                        System.Threading.Thread.Sleep(50);
                        kickDrum.BackColor = color_kickdrum;
                        System.Threading.Thread.Sleep(950);
                }


                if (cbx_noVisualClues.Checked == true && drum == 1)
                {
                    kickDrum.PerformClick();
                    System.Threading.Thread.Sleep(1000);
                }

                if (cbx_noVisualClues.Checked == false && drum==2)
                {
                    snareDrum.BackColor = Color.White;
                    snareDrum.PerformClick();
                    System.Threading.Thread.Sleep(50);
                    snareDrum.BackColor = color_snareDrum;
                    System.Threading.Thread.Sleep(950);
                }

                if (cbx_noVisualClues.Checked == true && drum == 2)
                {
                    snareDrum.PerformClick();
                    System.Threading.Thread.Sleep(1000);
                }

                if (cbx_noVisualClues.Checked == false && drum == 3)
                {
                    lTomDrum.BackColor = Color.White;
                    lTomDrum.PerformClick();
                    System.Threading.Thread.Sleep(50);
                    lTomDrum.BackColor = color_lTomDrum;
                    System.Threading.Thread.Sleep(950);
                }

                if (cbx_noVisualClues.Checked == true && drum == 3)
                {
                    lTomDrum.PerformClick();
                    System.Threading.Thread.Sleep(1000);
                }

                if (cbx_noVisualClues.Checked == false && drum == 4)
                {
                    openHiHat.BackColor = Color.White;
                    openHiHat.PerformClick();
                    System.Threading.Thread.Sleep(50);
                    openHiHat.BackColor = color_openHiHat;
                    System.Threading.Thread.Sleep(950);
                }

                if (cbx_noVisualClues.Checked == true && drum == 4)
                {
                    openHiHat.PerformClick();
                    System.Threading.Thread.Sleep(1000);
                }

                if (cbx_noVisualClues.Checked == false && drum == 5)
                {
                    closedHiHat.BackColor = Color.White;
                    closedHiHat.PerformClick();
                    System.Threading.Thread.Sleep(50);
                    closedHiHat.BackColor = color_closedHiHat;
                    System.Threading.Thread.Sleep(950);
                }

                if (cbx_noVisualClues.Checked == true && drum == 5)
                {
                    closedHiHat.PerformClick();
                    System.Threading.Thread.Sleep(1000);
                }


                if (cbx_noVisualClues.Checked == false && drum == 6)
                {
                    crashCymbal.BackColor = Color.White;
                    crashCymbal.PerformClick();
                    System.Threading.Thread.Sleep(50);
                    crashCymbal.BackColor = color_crashCymbal;
                    System.Threading.Thread.Sleep(950);
                }

                if (cbx_noVisualClues.Checked == true && drum == 6)
                {
                    crashCymbal.PerformClick();
                    System.Threading.Thread.Sleep(1000);
                }

                if (cbx_noVisualClues.Checked == false && drum == 7)
                {
                    mTomDrum.BackColor = Color.White;
                    mTomDrum.PerformClick();
                    System.Threading.Thread.Sleep(50);
                    mTomDrum.BackColor = color_mTomDrum;
                    System.Threading.Thread.Sleep(950);
                }

                if (cbx_noVisualClues.Checked == true && drum == 7)
                {
                    mTomDrum.PerformClick();
                    System.Threading.Thread.Sleep(1000);
                }

                if (cbx_noVisualClues.Checked == false && drum == 8)
                {
                    hTomDrum.BackColor = Color.White;
                    hTomDrum.PerformClick();
                    System.Threading.Thread.Sleep(50);
                    hTomDrum.BackColor = color_hTomDrum;
                    System.Threading.Thread.Sleep(950);
                }

                if (cbx_noVisualClues.Checked == true && drum == 8)
                {
                    hTomDrum.PerformClick();
                    System.Threading.Thread.Sleep(1000);
                }

        }

    }
}
