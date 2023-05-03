namespace Enterprise_application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RoundRectRgn = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RoundRectRgn
            // 
            this.RoundRectRgn.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("RoundRectRgn.AnimationFunction")));
            this.RoundRectRgn.AnimationSpeed = 20;
            this.RoundRectRgn.BackColor = System.Drawing.Color.White;
            this.RoundRectRgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundRectRgn.ForeColor = System.Drawing.Color.Black;
            this.RoundRectRgn.InnerColor = System.Drawing.Color.White;
            this.RoundRectRgn.InnerMargin = 2;
            this.RoundRectRgn.InnerWidth = -1;
            this.RoundRectRgn.Location = new System.Drawing.Point(68, 324);
            this.RoundRectRgn.MarqueeAnimationSpeed = 2000;
            this.RoundRectRgn.Name = "RoundRectRgn";
            this.RoundRectRgn.OuterColor = System.Drawing.Color.DimGray;
            this.RoundRectRgn.OuterMargin = -20;
            this.RoundRectRgn.OuterWidth = 15;
            this.RoundRectRgn.ProgressColor = System.Drawing.Color.DarkOrange;
            this.RoundRectRgn.ProgressWidth = 20;
            this.RoundRectRgn.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundRectRgn.Size = new System.Drawing.Size(330, 317);
            this.RoundRectRgn.StartAngle = 270;
            this.RoundRectRgn.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.RoundRectRgn.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.RoundRectRgn.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.RoundRectRgn.SubscriptText = "";
            this.RoundRectRgn.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.RoundRectRgn.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.RoundRectRgn.SuperscriptText = "";
            this.RoundRectRgn.TabIndex = 5;
            this.RoundRectRgn.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.RoundRectRgn.Value = 68;
            this.RoundRectRgn.Click += new System.EventHandler(this.RoundRectRgn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(32, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 64);
            this.label1.TabIndex = 6;
            this.label1.Text = "Inventry Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-107, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1600, 872);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1442, 838);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoundRectRgn);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar RoundRectRgn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

