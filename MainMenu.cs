using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeriesTicTacToe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }

       

        private void MainMenu_Load(object sender, EventArgs e)
        {
            btPyramic.BackColor=Color.FromArgb(128,Color.White);
            btWord.BackColor = Color.FromArgb(128, Color.White);
            btExist.BackColor = Color.FromArgb(128, Color.White);
        }

      

        

        private void btWord_Click(object sender, EventArgs e)
        {
            Form form = new GetPlayerInfo(2);
            form.ShowDialog();
        }

        private void btPyramic_Click_1(object sender, EventArgs e)
        {
            Form form = new GetPlayerInfo(1);
            form.ShowDialog();
        }

        private void bt4dot4_Click(object sender, EventArgs e)
        {
            Form form = new GetPlayerInfo(3);
            form.ShowDialog();
        }

        private void btExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
