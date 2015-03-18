namespace HexagonalMelody
{
    partial class drums_fj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_drumkits = new System.Windows.Forms.ComboBox();
            this.b_drumAbout = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.openHiHat = new System.Windows.Forms.Button();
            this.crashCymbal = new System.Windows.Forms.Button();
            this.hTomDrum = new System.Windows.Forms.Button();
            this.mTomDrum = new System.Windows.Forms.Button();
            this.closedHiHat = new System.Windows.Forms.Button();
            this.kickDrum = new System.Windows.Forms.Button();
            this.lTomDrum = new System.Windows.Forms.Button();
            this.snareDrum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbox_drumkits);
            this.splitContainer1.Panel1.Controls.Add(this.b_drumAbout);
            this.splitContainer1.Panel1.Controls.Add(this.b_exit);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.openHiHat);
            this.splitContainer1.Panel2.Controls.Add(this.crashCymbal);
            this.splitContainer1.Panel2.Controls.Add(this.hTomDrum);
            this.splitContainer1.Panel2.Controls.Add(this.mTomDrum);
            this.splitContainer1.Panel2.Controls.Add(this.closedHiHat);
            this.splitContainer1.Panel2.Controls.Add(this.kickDrum);
            this.splitContainer1.Panel2.Controls.Add(this.lTomDrum);
            this.splitContainer1.Panel2.Controls.Add(this.snareDrum);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 500);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(22, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Drumset size";
            // 
            // cbox_drumkits
            // 
            this.cbox_drumkits.BackColor = System.Drawing.SystemColors.Control;
            this.cbox_drumkits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_drumkits.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbox_drumkits.FormattingEnabled = true;
            this.cbox_drumkits.Location = new System.Drawing.Point(26, 197);
            this.cbox_drumkits.Name = "cbox_drumkits";
            this.cbox_drumkits.Size = new System.Drawing.Size(188, 25);
            this.cbox_drumkits.TabIndex = 1;
            this.cbox_drumkits.SelectedIndexChanged += new System.EventHandler(this.cbox_drumkits_SelectedIndexChanged);
            // 
            // b_drumAbout
            // 
            this.b_drumAbout.BackColor = System.Drawing.Color.DarkOrange;
            this.b_drumAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_drumAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_drumAbout.Location = new System.Drawing.Point(26, 372);
            this.b_drumAbout.Name = "b_drumAbout";
            this.b_drumAbout.Size = new System.Drawing.Size(182, 40);
            this.b_drumAbout.TabIndex = 3;
            this.b_drumAbout.Text = "Drum info";
            this.b_drumAbout.UseVisualStyleBackColor = false;
            this.b_drumAbout.Click += new System.EventHandler(this.b_drumAbout_Click);
            // 
            // b_exit
            // 
            this.b_exit.BackColor = System.Drawing.Color.DarkOrange;
            this.b_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_exit.Location = new System.Drawing.Point(26, 433);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(182, 40);
            this.b_exit.TabIndex = 0;
            this.b_exit.Text = "Return to main menu";
            this.b_exit.UseVisualStyleBackColor = false;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // openHiHat
            // 
            this.openHiHat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.openHiHat.Location = new System.Drawing.Point(329, 148);
            this.openHiHat.Name = "openHiHat";
            this.openHiHat.Size = new System.Drawing.Size(102, 61);
            this.openHiHat.TabIndex = 5;
            this.openHiHat.Text = "[W]";
            this.openHiHat.UseMnemonic = false;
            this.openHiHat.UseVisualStyleBackColor = true;
            this.openHiHat.Click += new System.EventHandler(this.openHiHat_Click);
            // 
            // crashCymbal
            // 
            this.crashCymbal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.crashCymbal.Location = new System.Drawing.Point(126, 148);
            this.crashCymbal.Name = "crashCymbal";
            this.crashCymbal.Size = new System.Drawing.Size(102, 61);
            this.crashCymbal.TabIndex = 7;
            this.crashCymbal.Text = "[Q]";
            this.crashCymbal.UseMnemonic = false;
            this.crashCymbal.UseVisualStyleBackColor = true;
            this.crashCymbal.Click += new System.EventHandler(this.crashCymbal_Click);
            // 
            // hTomDrum
            // 
            this.hTomDrum.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hTomDrum.Location = new System.Drawing.Point(126, 303);
            this.hTomDrum.Name = "hTomDrum";
            this.hTomDrum.Size = new System.Drawing.Size(102, 61);
            this.hTomDrum.TabIndex = 6;
            this.hTomDrum.Text = "[Y]";
            this.hTomDrum.UseMnemonic = false;
            this.hTomDrum.UseVisualStyleBackColor = true;
            this.hTomDrum.Click += new System.EventHandler(this.hTomDrum_Click);
            // 
            // mTomDrum
            // 
            this.mTomDrum.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mTomDrum.Location = new System.Drawing.Point(538, 303);
            this.mTomDrum.Name = "mTomDrum";
            this.mTomDrum.Size = new System.Drawing.Size(102, 61);
            this.mTomDrum.TabIndex = 4;
            this.mTomDrum.Text = "[C]";
            this.mTomDrum.UseMnemonic = false;
            this.mTomDrum.UseVisualStyleBackColor = true;
            this.mTomDrum.Click += new System.EventHandler(this.mTomDrum_Click);
            // 
            // closedHiHat
            // 
            this.closedHiHat.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.closedHiHat.Location = new System.Drawing.Point(538, 148);
            this.closedHiHat.Name = "closedHiHat";
            this.closedHiHat.Size = new System.Drawing.Size(102, 61);
            this.closedHiHat.TabIndex = 0;
            this.closedHiHat.Text = "[E]";
            this.closedHiHat.UseMnemonic = false;
            this.closedHiHat.UseVisualStyleBackColor = true;
            this.closedHiHat.Click += new System.EventHandler(this.hiHat_Click);
            // 
            // kickDrum
            // 
            this.kickDrum.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kickDrum.Location = new System.Drawing.Point(329, 236);
            this.kickDrum.Name = "kickDrum";
            this.kickDrum.Size = new System.Drawing.Size(102, 61);
            this.kickDrum.TabIndex = 1;
            this.kickDrum.Text = "[V]";
            this.kickDrum.UseMnemonic = false;
            this.kickDrum.UseVisualStyleBackColor = true;
            this.kickDrum.Click += new System.EventHandler(this.kickDrum_Click);
            // 
            // lTomDrum
            // 
            this.lTomDrum.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lTomDrum.Location = new System.Drawing.Point(221, 236);
            this.lTomDrum.Name = "lTomDrum";
            this.lTomDrum.Size = new System.Drawing.Size(102, 61);
            this.lTomDrum.TabIndex = 3;
            this.lTomDrum.Text = "[A]";
            this.lTomDrum.UseMnemonic = false;
            this.lTomDrum.UseVisualStyleBackColor = true;
            this.lTomDrum.Click += new System.EventHandler(this.tomDrum_Click);
            // 
            // snareDrum
            // 
            this.snareDrum.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.snareDrum.Location = new System.Drawing.Point(437, 236);
            this.snareDrum.Name = "snareDrum";
            this.snareDrum.Size = new System.Drawing.Size(102, 61);
            this.snareDrum.TabIndex = 2;
            this.snareDrum.Text = "[D]";
            this.snareDrum.UseMnemonic = false;
            this.snareDrum.UseVisualStyleBackColor = true;
            this.snareDrum.Click += new System.EventHandler(this.snareDrum_Click);
            // 
            // drums_fj
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HexagonalMelody.Properties.Resources.Drums;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "drums_fj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Free Jam - Drums";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.drums_fj_KeyPress);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button kickDrum;
        private System.Windows.Forms.Button closedHiHat;
        private System.Windows.Forms.Button lTomDrum;
        private System.Windows.Forms.Button snareDrum;
        private System.Windows.Forms.ComboBox cbox_drumkits;
        private System.Windows.Forms.Button openHiHat;
        private System.Windows.Forms.Button mTomDrum;
        private System.Windows.Forms.Button hTomDrum;
        private System.Windows.Forms.Button crashCymbal;
        private System.Windows.Forms.Button b_drumAbout;
        private System.Windows.Forms.Label label1;
    }
}