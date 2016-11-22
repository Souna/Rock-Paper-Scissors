namespace RPS
{
    partial class frmRPS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRPS));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplayCPUroll = new System.Windows.Forms.Label();
            this.lblCpuRoll = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClr = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TimeLeftDisplay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picSadFace = new System.Windows.Forms.PictureBox();
            this.picScissorsDisabled = new System.Windows.Forms.PictureBox();
            this.picPaperDisabled = new System.Windows.Forms.PictureBox();
            this.picRockDisabled = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.lblYourRoll = new System.Windows.Forms.Label();
            this.lblDisplayYourRoll = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLeftDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSadFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissorsDisabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaperDisabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRockDisabled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(252, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press Play!";
            // 
            // lblDisplayCPUroll
            // 
            this.lblDisplayCPUroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayCPUroll.ForeColor = System.Drawing.Color.DarkRed;
            this.lblDisplayCPUroll.Location = new System.Drawing.Point(139, 378);
            this.lblDisplayCPUroll.Name = "lblDisplayCPUroll";
            this.lblDisplayCPUroll.Size = new System.Drawing.Size(98, 29);
            this.lblDisplayCPUroll.TabIndex = 4;
            // 
            // lblCpuRoll
            // 
            this.lblCpuRoll.AutoSize = true;
            this.lblCpuRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuRoll.Location = new System.Drawing.Point(12, 378);
            this.lblCpuRoll.Name = "lblCpuRoll";
            this.lblCpuRoll.Size = new System.Drawing.Size(126, 25);
            this.lblCpuRoll.TabIndex = 3;
            this.lblCpuRoll.Text = "CPU chose:";
            this.lblCpuRoll.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(245, 254);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(202, 136);
            this.lblResult.TabIndex = 6;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.Location = new System.Drawing.Point(63, 414);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(138, 37);
            this.btnClr.TabIndex = 1;
            this.btnClr.Text = "&Reset Game";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(262, 393);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(180, 58);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "&Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(600, 293);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(83, 39);
            this.lblTimeLeft.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(106, 295);
            this.progressBar1.Maximum = 1000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(493, 29);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Value = 1000;
            // 
            // TimeLeftDisplay
            // 
            this.TimeLeftDisplay.Location = new System.Drawing.Point(506, 418);
            this.TimeLeftDisplay.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.TimeLeftDisplay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeLeftDisplay.Name = "TimeLeftDisplay";
            this.TimeLeftDisplay.Size = new System.Drawing.Size(40, 20);
            this.TimeLeftDisplay.TabIndex = 2;
            this.TimeLeftDisplay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Timer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "seconds";
            // 
            // picSadFace
            // 
            this.picSadFace.Image = global::RPS.Properties.Resources.frownyface2;
            this.picSadFace.Location = new System.Drawing.Point(453, 295);
            this.picSadFace.Name = "picSadFace";
            this.picSadFace.Size = new System.Drawing.Size(90, 85);
            this.picSadFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSadFace.TabIndex = 18;
            this.picSadFace.TabStop = false;
            this.picSadFace.Visible = false;
            // 
            // picScissorsDisabled
            // 
            this.picScissorsDisabled.BackColor = System.Drawing.SystemColors.Control;
            this.picScissorsDisabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picScissorsDisabled.Image = global::RPS.Properties.Resources.scissorsDisabled1;
            this.picScissorsDisabled.Location = new System.Drawing.Point(501, 86);
            this.picScissorsDisabled.Name = "picScissorsDisabled";
            this.picScissorsDisabled.Size = new System.Drawing.Size(182, 165);
            this.picScissorsDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScissorsDisabled.TabIndex = 13;
            this.picScissorsDisabled.TabStop = false;
            this.picScissorsDisabled.Visible = false;
            this.picScissorsDisabled.Click += new System.EventHandler(this.picScissorsDisabled_Click);
            // 
            // picPaperDisabled
            // 
            this.picPaperDisabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPaperDisabled.Image = global::RPS.Properties.Resources.paperDisabled1;
            this.picPaperDisabled.Location = new System.Drawing.Point(260, 86);
            this.picPaperDisabled.Name = "picPaperDisabled";
            this.picPaperDisabled.Size = new System.Drawing.Size(182, 165);
            this.picPaperDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaperDisabled.TabIndex = 12;
            this.picPaperDisabled.TabStop = false;
            this.picPaperDisabled.Visible = false;
            this.picPaperDisabled.Click += new System.EventHandler(this.picPaperDisabled_Click);
            // 
            // picRockDisabled
            // 
            this.picRockDisabled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRockDisabled.Image = global::RPS.Properties.Resources.rockDisabled1;
            this.picRockDisabled.Location = new System.Drawing.Point(19, 86);
            this.picRockDisabled.Name = "picRockDisabled";
            this.picRockDisabled.Size = new System.Drawing.Size(182, 165);
            this.picRockDisabled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRockDisabled.TabIndex = 11;
            this.picRockDisabled.TabStop = false;
            this.picRockDisabled.Tag = "";
            this.picRockDisabled.Visible = false;
            this.picRockDisabled.Click += new System.EventHandler(this.picRockDisabled_Click);
            // 
            // picScissors
            // 
            this.picScissors.BackColor = System.Drawing.SystemColors.Control;
            this.picScissors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picScissors.Enabled = false;
            this.picScissors.Image = global::RPS.Properties.Resources.scissors1;
            this.picScissors.Location = new System.Drawing.Point(501, 86);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(182, 165);
            this.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScissors.TabIndex = 2;
            this.picScissors.TabStop = false;
            this.picScissors.Click += new System.EventHandler(this.picScissors_Click);
            // 
            // picPaper
            // 
            this.picPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPaper.Enabled = false;
            this.picPaper.Image = global::RPS.Properties.Resources.paper1;
            this.picPaper.Location = new System.Drawing.Point(260, 86);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(182, 165);
            this.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaper.TabIndex = 1;
            this.picPaper.TabStop = false;
            this.picPaper.Click += new System.EventHandler(this.picPaper_Click);
            // 
            // picRock
            // 
            this.picRock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRock.Enabled = false;
            this.picRock.Image = global::RPS.Properties.Resources.rock1;
            this.picRock.Location = new System.Drawing.Point(19, 86);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(182, 165);
            this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRock.TabIndex = 0;
            this.picRock.TabStop = false;
            this.picRock.Tag = "";
            this.picRock.Click += new System.EventHandler(this.picRock_Click);
            // 
            // lblYourRoll
            // 
            this.lblYourRoll.AutoSize = true;
            this.lblYourRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourRoll.Location = new System.Drawing.Point(12, 343);
            this.lblYourRoll.Name = "lblYourRoll";
            this.lblYourRoll.Size = new System.Drawing.Size(121, 25);
            this.lblYourRoll.TabIndex = 19;
            this.lblYourRoll.Text = "You chose:";
            this.lblYourRoll.Visible = false;
            // 
            // lblDisplayYourRoll
            // 
            this.lblDisplayYourRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayYourRoll.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDisplayYourRoll.Location = new System.Drawing.Point(139, 343);
            this.lblDisplayYourRoll.Name = "lblDisplayYourRoll";
            this.lblDisplayYourRoll.Size = new System.Drawing.Size(94, 25);
            this.lblDisplayYourRoll.TabIndex = 20;
            // 
            // frmRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(698, 468);
            this.Controls.Add(this.lblDisplayYourRoll);
            this.Controls.Add(this.lblYourRoll);
            this.Controls.Add(this.picSadFace);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TimeLeftDisplay);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.picScissorsDisabled);
            this.Controls.Add(this.picPaperDisabled);
            this.Controls.Add(this.picRockDisabled);
            this.Controls.Add(this.lblTimeLeft);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCpuRoll);
            this.Controls.Add(this.lblDisplayCPUroll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.picRock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissors";
            this.Load += new System.EventHandler(this.frmRPS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeLeftDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSadFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissorsDisabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaperDisabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRockDisabled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplayCPUroll;
        private System.Windows.Forms.Label lblCpuRoll;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.PictureBox picRockDisabled;
        private System.Windows.Forms.PictureBox picPaperDisabled;
        private System.Windows.Forms.PictureBox picScissorsDisabled;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.NumericUpDown TimeLeftDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picSadFace;
        private System.Windows.Forms.Label lblYourRoll;
        private System.Windows.Forms.Label lblDisplayYourRoll;
    }
}

