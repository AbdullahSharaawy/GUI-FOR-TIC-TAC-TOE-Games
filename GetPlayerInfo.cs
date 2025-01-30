using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoardGame_Classes;
namespace SeriesTicTacToe
{
    public partial class GetPlayerInfo : Form
    {
        

        private int _GameNumber;
        public static GameManager<char> _gameManager;
        public GetPlayerInfo(int GameNumber)
        {
            InitializeComponent();

            _GameNumber = GameNumber;
            
            initializePlayerInfoControl();

             
    }

        private void initializePlayerInfoControl()
        {
            // Instantiate the UserControl
            PlayersInfo playersInfo = new PlayersInfo(_GameNumber);

            // Set properties for the control (adjust size and location as needed)
            playersInfo.Size = new Size(573, 280);  // Example size
            playersInfo.Location = new Point(0, 0);  // Example location

            // Optionally set other properties like BackColor, Anchor, etc.
            playersInfo.BackColor = Color.LightGray;

            // Add the UserControl to the form's Controls collection
            this.Controls.Add(playersInfo);
            playersInfo.evDisplayingBoard += displaysBoard;
        }
        void displaysBoard()
        {
            switch (_GameNumber)
            {
                case 1:
                    
                    Form form1 = new Pyramic();
                    form1.ShowDialog();
                    break;
                case 2:

                    Form form2 = new Word();
                    form2.ShowDialog();
                    break;
                case 3:

                    Form form3 = new FourXFour();
                    form3.ShowDialog();
                    break;
            }
            this.Close();
        }
        private void GetPlayerInfo_Load(object sender, EventArgs e)
        {
            
        }
       
    }
}
