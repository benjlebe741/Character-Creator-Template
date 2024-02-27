using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using CharacterCreator.Properties;
using System.Reflection;

namespace CharacterCreator
{
    public partial class CreationScreen : UserControl
    {
        //These variables will hold temporary values that are used to create
        //a hero object
        int[] dshpInts = new int[4] { 5, 5, 5, 5 };
        Label[] dshpLabels;
        string heroType, name, perk;

        Image[] images = new Image[3] { Resources.mage2, Resources.ranger, Resources.fighter };
        string[] types = new string[3] { "Mage", "Ranger", "Fighter" };
        string[] perks = new string[4] { "Sneak", "Charm", "Intuition", "Speed" };
        public CreationScreen()
        {
            InitializeComponent();

            //each attribute and extra points value is set to 5 to start
            dshpLabels = new Label[4] { dexInput, strengthInput, healthInput, pointsLabel };
        }

        #region character type
        //TODO: For each button click set the image on screen and the heroType variable

        private void mageButton_Click(object sender, EventArgs e)
        {
            setType(0);
        }

        private void rangerButton_Click(object sender, EventArgs e)
        {
            setType(1);
        }

        private void fighterButton_Click(object sender, EventArgs e)
        {
            setType(2);
        }

        void setType(int typeNum)
        {
            heroType = types[typeNum];
            imageBox.BackgroundImage = images[typeNum];
        }

        #endregion

        #region attributes
        //TODO: For each button click add or remove 1 from the appropriate attribute display on screen. 
        // Also either add or remove 1 to the points variable. Do not allow points to go below 0 
        // or for the user to be able to add more points if they have all been used up.

        private void dexPlus_Click(object sender, EventArgs e)
        {
            movePoints(3, 0);
        }

        private void dexMinus_Click(object sender, EventArgs e)
        {
            movePoints(0, 3);
        }

        private void strengthPlus_Click(object sender, EventArgs e)
        {
            movePoints(3, 1);
        }

        private void StregthMinus_Click(object sender, EventArgs e)
        {
            movePoints(1, 3);
        }

        private void healthPlus_Click(object sender, EventArgs e)
        {
            movePoints(3, 2);
        }

        private void healthMinus_Click(object sender, EventArgs e)
        {
            movePoints(2, 3);
        }

        void movePoints(int takeFrom, int giveTo)
        {
            if (dshpInts[takeFrom] != 0)
            {
                dshpInts[takeFrom]--;
                dshpInts[giveTo]++;
                dshpLabels[takeFrom].Text = $"{dshpInts[takeFrom]}";
                dshpLabels[giveTo].Text = $"{dshpInts[giveTo]}";
            }

        }

        #endregion

        #region perks
        //set the perk variable based on the selected radio button

        private void sneakRadio_CheckedChanged(object sender, EventArgs e)
        {
            setPerk(0);
        }

        private void charmRadio_CheckedChanged(object sender, EventArgs e)
        {
            setPerk(1);
        }

        private void intuitionRadio_CheckedChanged(object sender, EventArgs e)
        {
            setPerk(2);
        }

        private void speedRadio_CheckedChanged(object sender, EventArgs e)
        {
            setPerk(3);
        }

        void setPerk(int perkNum)
        {
            perk = perks[perkNum];
        }
        #endregion


        private void saveButton_Click(object sender, EventArgs e)
        {
            //get name from input 
            name = nameInput.Text;

            //create character object and place it characterDB
            MainForm.characterDB.Add(new Character(name, heroType, dshpInts[0], dshpInts[1], dshpInts[2], perk));

            //Close this screen and open the Home Screen
            MainForm.DisplayScreen(this, new HomeScreen());
        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Close this screen and open the Home Screen
            MainForm.DisplayScreen(this, new HomeScreen());
        }
    }
}
