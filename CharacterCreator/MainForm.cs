using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator
{
    public partial class MainForm : Form
    {
        //List to hold character information.
        public static List<Character> characterDB = new List<Character>();

        public MainForm()
        {
            InitializeComponent();
            DisplayScreen(this, new HomeScreen());
        }

        public static void DisplayScreen(object sender, UserControl next)
        {
            Form f;
            if (sender is Form)
            {
                f = (Form)sender;
            }
            else
            {
                UserControl current = (UserControl)sender;
                f = current.FindForm();
                f.Controls.Remove(current);
            }
            next.Location = new Point((f.Width - next.Width) / 2, (f.Height - next.Height) / 2);
            f.Controls.Add(next);
        }
    }
}
