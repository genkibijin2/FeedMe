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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Size = new Size(450, 450);
        }

        private void dungeonForm1_Click(object sender, EventArgs e)
        {

        }

        private void Background_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
