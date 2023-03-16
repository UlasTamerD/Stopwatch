namespace Stopwatch
{
    partial class stopwatch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            LblHour = new Label();
            LblMin = new Label();
            LblSec = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnStart = new Button();
            BtnPause = new Button();
            BtnRes = new Button();
            PicDarkMode = new PictureBox();
            LblPause = new Label();
            ((System.ComponentModel.ISupportInitialize)PicDarkMode).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // LblHour
            // 
            LblHour.AutoSize = true;
            LblHour.Font = new Font("DS-Digital", 72F, FontStyle.Regular, GraphicsUnit.Point);
            LblHour.Location = new Point(80, 133);
            LblHour.Name = "LblHour";
            LblHour.Size = new Size(134, 95);
            LblHour.TabIndex = 0;
            LblHour.Text = "00";
            // 
            // LblMin
            // 
            LblMin.AutoSize = true;
            LblMin.Font = new Font("DS-Digital", 72F, FontStyle.Regular, GraphicsUnit.Point);
            LblMin.Location = new Point(275, 133);
            LblMin.Name = "LblMin";
            LblMin.Size = new Size(134, 95);
            LblMin.TabIndex = 0;
            LblMin.Text = "00";
            // 
            // LblSec
            // 
            LblSec.AutoSize = true;
            LblSec.Font = new Font("DS-Digital", 72F, FontStyle.Regular, GraphicsUnit.Point);
            LblSec.Location = new Point(470, 133);
            LblSec.Name = "LblSec";
            LblSec.Size = new Size(134, 95);
            LblSec.TabIndex = 0;
            LblSec.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("DS-Digital", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(214, 133);
            label3.Name = "label3";
            label3.Size = new Size(61, 95);
            label3.TabIndex = 0;
            label3.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("DS-Digital", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(409, 133);
            label4.Name = "label4";
            label4.Size = new Size(61, 95);
            label4.TabIndex = 0;
            label4.Text = ":";
            // 
            // BtnStart
            // 
            BtnStart.FlatStyle = FlatStyle.Flat;
            BtnStart.Location = new Point(74, 278);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(140, 73);
            BtnStart.TabIndex = 1;
            BtnStart.Text = "START";
            BtnStart.UseVisualStyleBackColor = true;
            BtnStart.Click += BtnStart_Click;
            // 
            // BtnPause
            // 
            BtnPause.FlatStyle = FlatStyle.Flat;
            BtnPause.Location = new Point(269, 278);
            BtnPause.Name = "BtnPause";
            BtnPause.Size = new Size(140, 73);
            BtnPause.TabIndex = 1;
            BtnPause.Text = "PAUSE";
            BtnPause.UseVisualStyleBackColor = true;
            BtnPause.Click += BtnPause_Click;
            // 
            // BtnRes
            // 
            BtnRes.FlatStyle = FlatStyle.Flat;
            BtnRes.Location = new Point(470, 278);
            BtnRes.Name = "BtnRes";
            BtnRes.Size = new Size(143, 73);
            BtnRes.TabIndex = 1;
            BtnRes.Text = "RESTART";
            BtnRes.UseVisualStyleBackColor = true;
            BtnRes.Click += BtnRes_Click;
            // 
            // PicDarkMode
            // 
            PicDarkMode.Image = Properties.Resources.dark_mode;
            PicDarkMode.Location = new Point(12, 12);
            PicDarkMode.Name = "PicDarkMode";
            PicDarkMode.Size = new Size(72, 53);
            PicDarkMode.SizeMode = PictureBoxSizeMode.Zoom;
            PicDarkMode.TabIndex = 2;
            PicDarkMode.TabStop = false;
            PicDarkMode.Click += PicDarkMode_Click;
            // 
            // LblPause
            // 
            LblPause.AutoSize = true;
            LblPause.Font = new Font("DS-Digital", 60F, FontStyle.Regular, GraphicsUnit.Point);
            LblPause.Location = new Point(214, 33);
            LblPause.Name = "LblPause";
            LblPause.Size = new Size(229, 79);
            LblPause.TabIndex = 0;
            LblPause.Text = "PAUSE";
            LblPause.Visible = false;
            // 
            // stopwatch
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(654, 388);
            Controls.Add(PicDarkMode);
            Controls.Add(BtnRes);
            Controls.Add(BtnPause);
            Controls.Add(BtnStart);
            Controls.Add(LblSec);
            Controls.Add(LblMin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LblPause);
            Controls.Add(LblHour);
            Font = new Font("DS-Digital", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6);
            MaximizeBox = false;
            Name = "stopwatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stopwatch";
            ((System.ComponentModel.ISupportInitialize)PicDarkMode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label LblHour;
        private Label LblMin;
        private Label LblSec;
        private Label label3;
        private Label label4;
        private Button BtnStart;
        private Button BtnPause;
        private Button BtnRes;
        private PictureBox PicDarkMode;
        private Label LblPause;
    }
}