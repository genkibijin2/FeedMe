using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void FeedMeCard_Hover(Object sender, EventArgs e)
        {
            FeedMeCard.Image = Properties.Resources.I_B_CARD14_TMX_1BRIGHT;
        }

        private void FeedMeCard_Leave(object sender, EventArgs e)
        {
            FeedMeCard.Image = Properties.Resources.I_B_CARD14_TMX_1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
