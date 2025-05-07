using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GardenForms
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();



        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void FeedMeCard_Click(object sender, EventArgs e)
        {
            Form1 game1 = new Form1();
            game1.ShowDialog();
        }

        private void FeedMeCard_Hover(Object sender, EventArgs e) //change picture to highlighted version (OPTION 1: FEED ME)
        {
            FeedMeCard.Image = Properties.Resources.I_B_CARD14_TMX_1BRIGHT;
        }

        private void FeedMeCard_Leave(object sender, EventArgs e) //revert it back
        {
            FeedMeCard.Image = Properties.Resources.I_B_CARD14_TMX_1;
        }


        private void GardenToolsBox_Click(object sender, EventArgs e)
        {
            Form2 game2 = new Form2();
            game2.ShowDialog();
        }

        private void GardenToolsBox_Hover(object sender, EventArgs e)
        {
            GardenToolsBox.Image = Properties.Resources.ToolBoxCard_bright;
        }

        private void GardenToolsBox_Leave(object sender, EventArgs e)
        {
            GardenToolsBox.Image = Properties.Resources.ToolBoxCard;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void mahjongBetBox_Click(object sender, EventArgs e)
        {
            windows95 game3 = new windows95();
            game3.ShowDialog();
        }

        private void mahjongBetBox_Hover(object sender, EventArgs e)
        {
            mahjongBetBox.Image = Properties.Resources.MahjongCard_bright;
        }

        private void mahjongBetBox_MouseLeave(object sender, EventArgs e)
        {
            mahjongBetBox.Image = Properties.Resources.MahjongCard;
        }
    }
}
