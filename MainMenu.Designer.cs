namespace SeriesTicTacToe
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btPyramic = new System.Windows.Forms.Button();
            this.btWord = new System.Windows.Forms.Button();
            this.bt4dot4 = new System.Windows.Forms.Button();
            this.btExist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome to Tic-Tac-Toe Series";
            // 
            // btPyramic
            // 
            this.btPyramic.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPyramic.Location = new System.Drawing.Point(37, 97);
            this.btPyramic.Name = "btPyramic";
            this.btPyramic.Size = new System.Drawing.Size(220, 32);
            this.btPyramic.TabIndex = 10;
            this.btPyramic.Text = "Pyramic Tic-Tac-Toe";
            this.btPyramic.UseVisualStyleBackColor = true;
            this.btPyramic.Click += new System.EventHandler(this.btPyramic_Click_1);
            // 
            // btWord
            // 
            this.btWord.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWord.Location = new System.Drawing.Point(37, 152);
            this.btWord.Name = "btWord";
            this.btWord.Size = new System.Drawing.Size(220, 32);
            this.btWord.TabIndex = 11;
            this.btWord.Text = "Word Tic-Tac-Toe";
            this.btWord.UseVisualStyleBackColor = true;
            this.btWord.Click += new System.EventHandler(this.btWord_Click);
            // 
            // bt4dot4
            // 
            this.bt4dot4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4dot4.Location = new System.Drawing.Point(37, 206);
            this.bt4dot4.Name = "bt4dot4";
            this.bt4dot4.Size = new System.Drawing.Size(220, 32);
            this.bt4dot4.TabIndex = 12;
            this.bt4dot4.Text = "Four X Four Tic-Tac-Toe";
            this.bt4dot4.UseVisualStyleBackColor = true;
            this.bt4dot4.Click += new System.EventHandler(this.bt4dot4_Click);
            // 
            // btExist
            // 
            this.btExist.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExist.Location = new System.Drawing.Point(37, 264);
            this.btExist.Name = "btExist";
            this.btExist.Size = new System.Drawing.Size(107, 32);
            this.btExist.TabIndex = 13;
            this.btExist.Text = "Exist";
            this.btExist.UseVisualStyleBackColor = true;
            this.btExist.Click += new System.EventHandler(this.btExist_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(622, 404);
            this.Controls.Add(this.btExist);
            this.Controls.Add(this.bt4dot4);
            this.Controls.Add(this.btWord);
            this.Controls.Add(this.btPyramic);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPyramic;
        private System.Windows.Forms.Button btWord;
        private System.Windows.Forms.Button bt4dot4;
        private System.Windows.Forms.Button btExist;
    }
}

