namespace HexagonalMelody
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_exit = new System.Windows.Forms.Button();
            this.b_drums_mm = new System.Windows.Forms.Button();
            this.b_drums_fj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_exit.FlatAppearance.BorderSize = 2;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_exit.Location = new System.Drawing.Point(55, 339);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(175, 36);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // b_drums_mm
            // 
            this.b_drums_mm.BackColor = System.Drawing.Color.DarkOrange;
            this.b_drums_mm.FlatAppearance.BorderSize = 2;
            this.b_drums_mm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_drums_mm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_drums_mm.ForeColor = System.Drawing.Color.Black;
            this.b_drums_mm.Location = new System.Drawing.Point(55, 115);
            this.b_drums_mm.Margin = new System.Windows.Forms.Padding(0);
            this.b_drums_mm.Name = "b_drums_mm";
            this.b_drums_mm.Size = new System.Drawing.Size(175, 36);
            this.b_drums_mm.TabIndex = 1;
            this.b_drums_mm.Text = "Melody Memory";
            this.b_drums_mm.UseVisualStyleBackColor = false;
            this.b_drums_mm.Click += new System.EventHandler(this.b_drums_mm_Click);
            // 
            // b_drums_fj
            // 
            this.b_drums_fj.BackColor = System.Drawing.Color.DarkOrange;
            this.b_drums_fj.FlatAppearance.BorderSize = 2;
            this.b_drums_fj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_drums_fj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_drums_fj.ForeColor = System.Drawing.Color.Black;
            this.b_drums_fj.Location = new System.Drawing.Point(55, 171);
            this.b_drums_fj.Margin = new System.Windows.Forms.Padding(0);
            this.b_drums_fj.Name = "b_drums_fj";
            this.b_drums_fj.Size = new System.Drawing.Size(175, 36);
            this.b_drums_fj.TabIndex = 2;
            this.b_drums_fj.Text = "Free Jam";
            this.b_drums_fj.UseVisualStyleBackColor = false;
            this.b_drums_fj.Click += new System.EventHandler(this.b_drums_fj_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(55, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(55, 228);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "View High-Scores";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::HexagonalMelody.Properties.Resources.MainMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(280, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_drums_fj);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.b_drums_mm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexagonal Melody (Adrian Bece 2014.)";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button b_drums_mm;
        private System.Windows.Forms.Button b_drums_fj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

