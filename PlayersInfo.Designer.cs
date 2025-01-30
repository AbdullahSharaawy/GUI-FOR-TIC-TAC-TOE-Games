namespace SeriesTicTacToe
{
    partial class PlayersInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayersInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbHuman = new System.Windows.Forms.RadioButton();
            this.rbComputer = new System.Windows.Forms.RadioButton();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.btSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbHuman2 = new System.Windows.Forms.RadioButton();
            this.rbComputer2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player Name";
            // 
            // lbPlayer1
            // 
            this.lbPlayer1.AutoSize = true;
            this.lbPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayer1.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPlayer1.Location = new System.Drawing.Point(-1, 15);
            this.lbPlayer1.Name = "lbPlayer1";
            this.lbPlayer1.Size = new System.Drawing.Size(272, 42);
            this.lbPlayer1.TabIndex = 1;
            this.lbPlayer1.Text = "Player_X Info";
            this.lbPlayer1.Click += new System.EventHandler(this.lbPlayer1_Click);
            // 
            // lbPlayer2
            // 
            this.lbPlayer2.AutoSize = true;
            this.lbPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayer2.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbPlayer2.Location = new System.Drawing.Point(302, 15);
            this.lbPlayer2.Name = "lbPlayer2";
            this.lbPlayer2.Size = new System.Drawing.Size(271, 42);
            this.lbPlayer2.TabIndex = 2;
            this.lbPlayer2.Text = "Player_O Info";
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.BackColor = System.Drawing.Color.Black;
            this.tbPlayer1.ForeColor = System.Drawing.Color.White;
            this.tbPlayer1.Location = new System.Drawing.Point(7, 138);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(199, 21);
            this.tbPlayer1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(305, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Player Name";
            // 
            // rbHuman
            // 
            this.rbHuman.AutoSize = true;
            this.rbHuman.BackColor = System.Drawing.Color.Transparent;
            this.rbHuman.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHuman.ForeColor = System.Drawing.Color.White;
            this.rbHuman.Location = new System.Drawing.Point(12, 29);
            this.rbHuman.Name = "rbHuman";
            this.rbHuman.Size = new System.Drawing.Size(69, 20);
            this.rbHuman.TabIndex = 6;
            this.rbHuman.TabStop = true;
            this.rbHuman.Text = "Human";
            this.rbHuman.UseVisualStyleBackColor = false;
            this.rbHuman.CheckedChanged += new System.EventHandler(this.rbHuman_CheckedChanged);
            // 
            // rbComputer
            // 
            this.rbComputer.AutoSize = true;
            this.rbComputer.BackColor = System.Drawing.Color.Transparent;
            this.rbComputer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComputer.ForeColor = System.Drawing.Color.White;
            this.rbComputer.Location = new System.Drawing.Point(103, 29);
            this.rbComputer.Name = "rbComputer";
            this.rbComputer.Size = new System.Drawing.Size(88, 20);
            this.rbComputer.TabIndex = 8;
            this.rbComputer.TabStop = true;
            this.rbComputer.Text = "Computer";
            this.rbComputer.UseVisualStyleBackColor = false;
            this.rbComputer.CheckedChanged += new System.EventHandler(this.rbComputer_CheckedChanged);
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.BackColor = System.Drawing.Color.Black;
            this.tbPlayer2.ForeColor = System.Drawing.Color.White;
            this.tbPlayer2.Location = new System.Drawing.Point(309, 138);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(199, 21);
            this.tbPlayer2.TabIndex = 9;
            // 
            // btSubmit
            // 
            this.btSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btSubmit.ForeColor = System.Drawing.Color.White;
            this.btSubmit.Location = new System.Drawing.Point(475, 242);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(93, 25);
            this.btSubmit.TabIndex = 12;
            this.btSubmit.Text = "submit";
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbHuman);
            this.panel1.Controls.Add(this.rbComputer);
            this.panel1.Location = new System.Drawing.Point(7, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 72);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.rbHuman2);
            this.panel2.Controls.Add(this.rbComputer2);
            this.panel2.Location = new System.Drawing.Point(308, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 72);
            this.panel2.TabIndex = 14;
            // 
            // rbHuman2
            // 
            this.rbHuman2.AutoSize = true;
            this.rbHuman2.BackColor = System.Drawing.Color.Transparent;
            this.rbHuman2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHuman2.ForeColor = System.Drawing.Color.White;
            this.rbHuman2.Location = new System.Drawing.Point(12, 29);
            this.rbHuman2.Name = "rbHuman2";
            this.rbHuman2.Size = new System.Drawing.Size(69, 20);
            this.rbHuman2.TabIndex = 6;
            this.rbHuman2.TabStop = true;
            this.rbHuman2.Text = "Human";
            this.rbHuman2.UseVisualStyleBackColor = false;
            this.rbHuman2.CheckedChanged += new System.EventHandler(this.rbHuman2_CheckedChanged);
            // 
            // rbComputer2
            // 
            this.rbComputer2.AutoSize = true;
            this.rbComputer2.BackColor = System.Drawing.Color.Transparent;
            this.rbComputer2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbComputer2.ForeColor = System.Drawing.Color.White;
            this.rbComputer2.Location = new System.Drawing.Point(103, 29);
            this.rbComputer2.Name = "rbComputer2";
            this.rbComputer2.Size = new System.Drawing.Size(88, 20);
            this.rbComputer2.TabIndex = 8;
            this.rbComputer2.TabStop = true;
            this.rbComputer2.Text = "Computer";
            this.rbComputer2.UseVisualStyleBackColor = false;
            this.rbComputer2.CheckedChanged += new System.EventHandler(this.rbConmputer2_CheckedChanged);
            // 
            // PlayersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.tbPlayer2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPlayer1);
            this.Controls.Add(this.lbPlayer2);
            this.Controls.Add(this.lbPlayer1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PlayersInfo";
            this.Size = new System.Drawing.Size(573, 280);
            this.Load += new System.EventHandler(this.PlayersInfo_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PlayersInfo_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbHuman;
        private System.Windows.Forms.RadioButton rbComputer;
        private System.Windows.Forms.TextBox tbPlayer2;
        private Guna.UI2.WinForms.Guna2Button btSubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbHuman2;
        private System.Windows.Forms.RadioButton rbComputer2;
    }
}
