namespace SeriesTicTacToe
{
    partial class FourXFour
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
            this.btRestart = new Guna.UI2.WinForms.Guna2GradientButton();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelTurn = new System.Windows.Forms.Label();
            this.labelInProgress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btRestart
            // 
            this.btRestart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btRestart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btRestart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btRestart.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btRestart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btRestart.FillColor = System.Drawing.Color.White;
            this.btRestart.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btRestart.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestart.ForeColor = System.Drawing.Color.Black;
            this.btRestart.Location = new System.Drawing.Point(20, 429);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(138, 36);
            this.btRestart.TabIndex = 33;
            this.btRestart.Text = "restart";
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.labelGameOver.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameOver.ForeColor = System.Drawing.Color.Silver;
            this.labelGameOver.Location = new System.Drawing.Point(12, 94);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(101, 65);
            this.labelGameOver.TabIndex = 32;
            this.labelGameOver.Text = "Turn";
            // 
            // labelTurn
            // 
            this.labelTurn.AutoSize = true;
            this.labelTurn.BackColor = System.Drawing.Color.Transparent;
            this.labelTurn.Font = new System.Drawing.Font("Playbill", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTurn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelTurn.Location = new System.Drawing.Point(14, 178);
            this.labelTurn.Name = "labelTurn";
            this.labelTurn.Size = new System.Drawing.Size(179, 65);
            this.labelTurn.TabIndex = 31;
            this.labelTurn.Text = "Player_X";
            // 
            // labelInProgress
            // 
            this.labelInProgress.AutoSize = true;
            this.labelInProgress.BackColor = System.Drawing.Color.Transparent;
            this.labelInProgress.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelInProgress.Location = new System.Drawing.Point(17, 351);
            this.labelInProgress.Name = "labelInProgress";
            this.labelInProgress.Size = new System.Drawing.Size(193, 45);
            this.labelInProgress.TabIndex = 30;
            this.labelInProgress.Text = "In Progress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(15, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 60);
            this.label2.TabIndex = 29;
            this.label2.Text = "Winer";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(651, 304);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 95);
            this.button8.TabIndex = 27;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(522, 304);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 95);
            this.button7.TabIndex = 26;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(408, 304);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 95);
            this.button6.TabIndex = 25;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(294, 304);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 95);
            this.button5.TabIndex = 24;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(651, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 90);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(522, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 90);
            this.button3.TabIndex = 22;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(408, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 88);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::SeriesTicTacToe.Properties.Resources.O;
            this.button1.Location = new System.Drawing.Point(521, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 92);
            this.button1.TabIndex = 20;
            this.button1.Tag = "O";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(294, 202);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(101, 88);
            this.button10.TabIndex = 34;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Image = global::SeriesTicTacToe.Properties.Resources.X;
            this.button12.Location = new System.Drawing.Point(408, 96);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(101, 92);
            this.button12.TabIndex = 36;
            this.button12.Tag = "X";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Transparent;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Image = global::SeriesTicTacToe.Properties.Resources.O;
            this.button13.Location = new System.Drawing.Point(294, 96);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(101, 92);
            this.button13.TabIndex = 37;
            this.button13.Tag = "O";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Transparent;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Image = global::SeriesTicTacToe.Properties.Resources.X;
            this.button14.Location = new System.Drawing.Point(651, 96);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(110, 92);
            this.button14.TabIndex = 38;
            this.button14.Tag = "X";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Transparent;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Image = global::SeriesTicTacToe.Properties.Resources.O;
            this.button17.Location = new System.Drawing.Point(651, 410);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(110, 95);
            this.button17.TabIndex = 43;
            this.button17.Tag = "O";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Transparent;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Image = global::SeriesTicTacToe.Properties.Resources.X;
            this.button18.Location = new System.Drawing.Point(522, 410);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(119, 95);
            this.button18.TabIndex = 42;
            this.button18.Tag = "X";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.Transparent;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Image = global::SeriesTicTacToe.Properties.Resources.O;
            this.button19.Location = new System.Drawing.Point(408, 410);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(101, 95);
            this.button19.TabIndex = 41;
            this.button19.Tag = "O";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Transparent;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Image = global::SeriesTicTacToe.Properties.Resources.X;
            this.button20.Location = new System.Drawing.Point(294, 410);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(101, 95);
            this.button20.TabIndex = 40;
            this.button20.Tag = "X";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // FourXFour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SeriesTicTacToe.Properties.Resources.R;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 549);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btRestart);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelTurn);
            this.Controls.Add(this.labelInProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FourXFour";
            this.Text = "_4dot4TicTacToe";
            this.Load += new System.EventHandler(this.FourXFour_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FourXFour_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btRestart;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelTurn;
        private System.Windows.Forms.Label labelInProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
    }
}