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

namespace CharacterCreator
{
    public partial class CreationScreen : UserControl
    {
        //These variables will hold temporary values that are used to create
        //a hero object
        int dexterity, strength, health, points;
        string heroType, name, perk;

        public CreationScreen()
        {
            InitializeComponent();

            //each attribute and extra points value is set to 5 to start
            dexterity = strength = health = points = 5;

        }

        #region character type
        //TODO: For each button click set the image on screen and the heroType variable

        private void mageButton_Click(object sender, EventArgs e)
        {

        }

        private void rangerButton_Click(object sender, EventArgs e)
        {

        }

        private void fighterButton_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region attributes
        //TODO: For each button click add or remove 1 from the appropriate attribute display on screen. 
        // Also either add or remove 1 to the points variable. Do not allow points to go below 0 
        // or for the user to be able to add more points if they have all been used up.

        private void dexPlus_Click(object sender, EventArgs e)
        {

        }

        private void dexMinus_Click(object sender, EventArgs e)
        {

        }

        private void strengthPlus_Click(object sender, EventArgs e)
        {

        }

        private void StregthMinus_Click(object sender, EventArgs e)
        {

        }

        private void healthPlus_Click(object sender, EventArgs e)
        {

        }

        private void healthMinus_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region perks
        //TODO: set the perk variable based on the selected radio button

        private void sneakRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void charmRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void intuitionRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void speedRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion


        private void saveButton_Click(object sender, EventArgs e)
        {
            // used to temporarly hold values that will then be used to creat object
            string dex, str, hea;

            //TODO: get name from input and set dex, str, and hea

            //TODO: create character object and place it characterDB

            //TODO: close this screen and open the Home Screen

        }


        private void cancelButton_Click(object sender, EventArgs e)
        {
            //TODO: close this screen and open the Home Screen
        }
    }
}
