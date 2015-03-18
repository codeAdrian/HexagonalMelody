namespace HexagonalMelody
{
    partial class UploadScoreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_scoreName = new System.Windows.Forms.TextBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msg = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // tbx_scoreName
            // 
            this.tbx_scoreName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbx_scoreName.Location = new System.Drawing.Point(80, 64);
            this.tbx_scoreName.Name = "tbx_scoreName";
            this.tbx_scoreName.Size = new System.Drawing.Size(178, 29);
            this.tbx_scoreName.TabIndex = 2;
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_score.Location = new System.Drawing.Point(76, 30);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(46, 21);
            this.lbl_score.TabIndex = 3;
            this.lbl_score.Text = "0000";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = global::HexagonalMelody.Properties.Resources.blue;
            this.groupBox1.Controls.Add(this.msg);
            this.groupBox1.Controls.Add(this.btn_upload);
            this.groupBox1.Controls.Add(this.lbl_score);
            this.groupBox1.Controls.Add(this.tbx_scoreName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Upload Score";
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.BackColor = System.Drawing.Color.Transparent;
            this.msg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.msg.ForeColor = System.Drawing.Color.DarkOrange;
            this.msg.Location = new System.Drawing.Point(14, 104);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(259, 21);
            this.msg.TabIndex = 5;
            this.msg.Text = "Upload requires internet connection";
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_upload.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_upload.FlatAppearance.BorderSize = 2;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upload.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_upload.ForeColor = System.Drawing.Color.Black;
            this.btn_upload.Location = new System.Drawing.Point(282, 59);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(92, 36);
            this.btn_upload.TabIndex = 4;
            this.btn_upload.Text = "Upload Score";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(294, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Continue";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UploadScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::HexagonalMelody.Properties.Resources.blue;
            this.ClientSize = new System.Drawing.Size(430, 200);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UploadScoreForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Score";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_scoreName;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label msg;
    }
}