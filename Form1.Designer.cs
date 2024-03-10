namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.guard1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.guard2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.time3 = new System.Windows.Forms.Label();
            this.time2 = new System.Windows.Forms.Label();
            this.sc2 = new System.Windows.Forms.Label();
            this.sc1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guard1
            // 
            this.guard1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guard1.Location = new System.Drawing.Point(766, 184);
            this.guard1.Name = "guard1";
            this.guard1.Size = new System.Drawing.Size(21, 79);
            this.guard1.TabIndex = 0;
            this.guard1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ball.Location = new System.Drawing.Point(290, 150);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // guard2
            // 
            this.guard2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guard2.Location = new System.Drawing.Point(12, 184);
            this.guard2.Name = "guard2";
            this.guard2.Size = new System.Drawing.Size(20, 78);
            this.guard2.TabIndex = 2;
            this.guard2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(396, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 564);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(629, 21);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(48, 36);
            this.time.TabIndex = 4;
            this.time.Text = "1 :";
            this.time.Click += new System.EventHandler(this.label1_Click);
            // 
            // time3
            // 
            this.time3.AutoSize = true;
            this.time3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time3.Location = new System.Drawing.Point(712, 21);
            this.time3.Name = "time3";
            this.time3.Size = new System.Drawing.Size(32, 36);
            this.time3.TabIndex = 5;
            this.time3.Text = "0";
            // 
            // time2
            // 
            this.time2.AutoSize = true;
            this.time2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time2.Location = new System.Drawing.Point(683, 21);
            this.time2.Name = "time2";
            this.time2.Size = new System.Drawing.Size(32, 36);
            this.time2.TabIndex = 6;
            this.time2.Text = "0";
            // 
            // sc2
            // 
            this.sc2.AutoSize = true;
            this.sc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sc2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sc2.Location = new System.Drawing.Point(323, 397);
            this.sc2.Name = "sc2";
            this.sc2.Size = new System.Drawing.Size(42, 46);
            this.sc2.TabIndex = 7;
            this.sc2.Text = "0";
            // 
            // sc1
            // 
            this.sc1.AutoSize = true;
            this.sc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sc1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sc1.Location = new System.Drawing.Point(428, 397);
            this.sc1.Name = "sc1";
            this.sc1.Size = new System.Drawing.Size(42, 46);
            this.sc1.TabIndex = 8;
            this.sc1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sc1);
            this.Controls.Add(this.sc2);
            this.Controls.Add(this.time2);
            this.Controls.Add(this.time3);
            this.Controls.Add(this.time);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guard2);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.guard1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.guard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox guard1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox guard2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label time3;
        private System.Windows.Forms.Label time2;
        private System.Windows.Forms.Label sc2;
        private System.Windows.Forms.Label sc1;
    }
}

