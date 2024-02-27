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
    public partial class ViewScreen : UserControl
    {
        public ViewScreen()
        {
            InitializeComponent();
        }

        private void ViewScreen_Load(object sender, EventArgs e)
        {
            // add each Characters name to the dropdown box
            foreach (Character c in MainForm.characterDB)
            {
                heroSelect.Items.Add(c.name);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainForm.DisplayScreen(this, new HomeScreen());
        }

        private void heroSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].name;
            classOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].charClass;
            dexterityOutput.Text = Convert.ToString(MainForm.characterDB[heroSelect.SelectedIndex].dexterity);
            strengthOutput.Text = Convert.ToString(MainForm.characterDB[heroSelect.SelectedIndex].strength);
            healthOutput.Text = Convert.ToString(MainForm.characterDB[heroSelect.SelectedIndex].health);
            perkOutput.Text = MainForm.characterDB[heroSelect.SelectedIndex].perk;

            if (MainForm.characterDB[heroSelect.SelectedIndex].charClass == "Fighter")
            {
                heroImage.BackgroundImage = Properties.Resources.fighter;
            }
            else if (MainForm.characterDB[heroSelect.SelectedIndex].charClass == "Mage")
            {
                heroImage.BackgroundImage = Properties.Resources.mage2;
            }
            else if (MainForm.characterDB[heroSelect.SelectedIndex].charClass == "Ranger")
            {
                heroImage.BackgroundImage = Properties.Resources.ranger;
            }
        }
    }
}
