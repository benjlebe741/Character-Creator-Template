using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class HomeScreen : UserControl
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            //Close this screen and show the CreationScreen
            MainForm.DisplayScreen(this, new CreationScreen());
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            //Close this screen and show the ViewScreen
            MainForm.DisplayScreen(this, new ViewScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close whole program
            Application.Exit();
        }
    }
}
