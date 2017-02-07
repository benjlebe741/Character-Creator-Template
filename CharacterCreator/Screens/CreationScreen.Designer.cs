namespace CharacterCreator
{
    partial class CreationScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pointsLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.speedRadio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.intuitionRadio = new System.Windows.Forms.RadioButton();
            this.charmRadio = new System.Windows.Forms.RadioButton();
            this.sneakRadio = new System.Windows.Forms.RadioButton();
            this.healthMinus = new System.Windows.Forms.Button();
            this.healthPlus = new System.Windows.Forms.Button();
            this.healthInput = new System.Windows.Forms.Label();
            this.stregthMinus = new System.Windows.Forms.Button();
            this.strengthPlus = new System.Windows.Forms.Button();
            this.strengthInput = new System.Windows.Forms.Label();
            this.dexMinus = new System.Windows.Forms.Button();
            this.dexPlus = new System.Windows.Forms.Button();
            this.dexInput = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.attributesLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.mageButton = new System.Windows.Forms.Button();
            this.rangerButton = new System.Windows.Forms.Button();
            this.fighterButton = new System.Windows.Forms.Button();
            this.imageBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsLabel
            // 
            this.pointsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.Location = new System.Drawing.Point(432, 108);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(32, 25);
            this.pointsLabel.TabIndex = 55;
            this.pointsLabel.Text = "5";
            this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(400, 346);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(64, 27);
            this.cancelButton.TabIndex = 54;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(330, 346);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 27);
            this.saveButton.TabIndex = 53;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // speedRadio
            // 
            this.speedRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedRadio.Location = new System.Drawing.Point(350, 282);
            this.speedRadio.Name = "speedRadio";
            this.speedRadio.Size = new System.Drawing.Size(114, 24);
            this.speedRadio.TabIndex = 52;
            this.speedRadio.TabStop = true;
            this.speedRadio.Text = "Speed";
            this.speedRadio.UseVisualStyleBackColor = true;
            this.speedRadio.CheckedChanged += new System.EventHandler(this.speedRadio_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Perks (select one)";
            // 
            // intuitionRadio
            // 
            this.intuitionRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intuitionRadio.Location = new System.Drawing.Point(236, 282);
            this.intuitionRadio.Name = "intuitionRadio";
            this.intuitionRadio.Size = new System.Drawing.Size(114, 24);
            this.intuitionRadio.TabIndex = 50;
            this.intuitionRadio.TabStop = true;
            this.intuitionRadio.Text = "Intuition";
            this.intuitionRadio.UseVisualStyleBackColor = true;
            this.intuitionRadio.CheckedChanged += new System.EventHandler(this.intuitionRadio_CheckedChanged);
            // 
            // charmRadio
            // 
            this.charmRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charmRadio.Location = new System.Drawing.Point(350, 261);
            this.charmRadio.Name = "charmRadio";
            this.charmRadio.Size = new System.Drawing.Size(114, 24);
            this.charmRadio.TabIndex = 49;
            this.charmRadio.TabStop = true;
            this.charmRadio.Text = "Charm";
            this.charmRadio.UseVisualStyleBackColor = true;
            this.charmRadio.CheckedChanged += new System.EventHandler(this.charmRadio_CheckedChanged);
            // 
            // sneakRadio
            // 
            this.sneakRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sneakRadio.Location = new System.Drawing.Point(236, 261);
            this.sneakRadio.Name = "sneakRadio";
            this.sneakRadio.Size = new System.Drawing.Size(114, 24);
            this.sneakRadio.TabIndex = 48;
            this.sneakRadio.TabStop = true;
            this.sneakRadio.Text = "Sneak";
            this.sneakRadio.UseVisualStyleBackColor = true;
            this.sneakRadio.CheckedChanged += new System.EventHandler(this.sneakRadio_CheckedChanged);
            // 
            // healthMinus
            // 
            this.healthMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.healthMinus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthMinus.Location = new System.Drawing.Point(432, 180);
            this.healthMinus.Margin = new System.Windows.Forms.Padding(0);
            this.healthMinus.Name = "healthMinus";
            this.healthMinus.Size = new System.Drawing.Size(32, 25);
            this.healthMinus.TabIndex = 47;
            this.healthMinus.Text = "-";
            this.healthMinus.UseVisualStyleBackColor = true;
            this.healthMinus.Click += new System.EventHandler(this.healthMinus_Click);
            // 
            // healthPlus
            // 
            this.healthPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.healthPlus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthPlus.Location = new System.Drawing.Point(403, 180);
            this.healthPlus.Margin = new System.Windows.Forms.Padding(0);
            this.healthPlus.Name = "healthPlus";
            this.healthPlus.Size = new System.Drawing.Size(32, 25);
            this.healthPlus.TabIndex = 46;
            this.healthPlus.Text = "+";
            this.healthPlus.UseVisualStyleBackColor = true;
            this.healthPlus.Click += new System.EventHandler(this.healthPlus_Click);
            // 
            // healthInput
            // 
            this.healthInput.BackColor = System.Drawing.Color.White;
            this.healthInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthInput.Location = new System.Drawing.Point(348, 180);
            this.healthInput.Name = "healthInput";
            this.healthInput.Size = new System.Drawing.Size(60, 25);
            this.healthInput.TabIndex = 45;
            this.healthInput.Text = "5";
            this.healthInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stregthMinus
            // 
            this.stregthMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stregthMinus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stregthMinus.Location = new System.Drawing.Point(432, 156);
            this.stregthMinus.Margin = new System.Windows.Forms.Padding(0);
            this.stregthMinus.Name = "stregthMinus";
            this.stregthMinus.Size = new System.Drawing.Size(32, 26);
            this.stregthMinus.TabIndex = 44;
            this.stregthMinus.Text = "-";
            this.stregthMinus.UseVisualStyleBackColor = true;
            this.stregthMinus.Click += new System.EventHandler(this.StregthMinus_Click);
            // 
            // strengthPlus
            // 
            this.strengthPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strengthPlus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthPlus.Location = new System.Drawing.Point(403, 156);
            this.strengthPlus.Margin = new System.Windows.Forms.Padding(0);
            this.strengthPlus.Name = "strengthPlus";
            this.strengthPlus.Size = new System.Drawing.Size(32, 26);
            this.strengthPlus.TabIndex = 43;
            this.strengthPlus.Text = "+";
            this.strengthPlus.UseVisualStyleBackColor = true;
            this.strengthPlus.Click += new System.EventHandler(this.strengthPlus_Click);
            // 
            // strengthInput
            // 
            this.strengthInput.BackColor = System.Drawing.Color.White;
            this.strengthInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.strengthInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthInput.Location = new System.Drawing.Point(348, 156);
            this.strengthInput.Name = "strengthInput";
            this.strengthInput.Size = new System.Drawing.Size(60, 26);
            this.strengthInput.TabIndex = 42;
            this.strengthInput.Text = "5";
            this.strengthInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dexMinus
            // 
            this.dexMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dexMinus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexMinus.Location = new System.Drawing.Point(432, 132);
            this.dexMinus.Margin = new System.Windows.Forms.Padding(0);
            this.dexMinus.Name = "dexMinus";
            this.dexMinus.Size = new System.Drawing.Size(32, 26);
            this.dexMinus.TabIndex = 41;
            this.dexMinus.Text = "-";
            this.dexMinus.UseVisualStyleBackColor = true;
            this.dexMinus.Click += new System.EventHandler(this.dexMinus_Click);
            // 
            // dexPlus
            // 
            this.dexPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dexPlus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexPlus.Location = new System.Drawing.Point(403, 132);
            this.dexPlus.Margin = new System.Windows.Forms.Padding(0);
            this.dexPlus.Name = "dexPlus";
            this.dexPlus.Size = new System.Drawing.Size(32, 26);
            this.dexPlus.TabIndex = 40;
            this.dexPlus.Text = "+";
            this.dexPlus.UseVisualStyleBackColor = true;
            this.dexPlus.Click += new System.EventHandler(this.dexPlus_Click);
            // 
            // dexInput
            // 
            this.dexInput.BackColor = System.Drawing.Color.White;
            this.dexInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dexInput.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexInput.Location = new System.Drawing.Point(348, 132);
            this.dexInput.Name = "dexInput";
            this.dexInput.Size = new System.Drawing.Size(60, 26);
            this.dexInput.TabIndex = 39;
            this.dexInput.Text = "5";
            this.dexInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // healthLabel
            // 
            this.healthLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.healthLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(236, 180);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(113, 25);
            this.healthLabel.TabIndex = 38;
            this.healthLabel.Text = "Health";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 37;
            this.label2.Text = "Strength";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Dexterity";
            // 
            // attributesLabel
            // 
            this.attributesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.attributesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributesLabel.Location = new System.Drawing.Point(236, 108);
            this.attributesLabel.Name = "attributesLabel";
            this.attributesLabel.Size = new System.Drawing.Size(199, 25);
            this.attributesLabel.TabIndex = 35;
            this.attributesLabel.Text = "Attributes:              Points Left:";
            // 
            // nameInput
            // 
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(236, 51);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(228, 25);
            this.nameInput.TabIndex = 34;
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(236, 27);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(228, 25);
            this.nameLabel.TabIndex = 33;
            this.nameLabel.Text = "Character Name:";
            // 
            // classLabel
            // 
            this.classLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.classLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(28, 27);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(186, 25);
            this.classLabel.TabIndex = 32;
            this.classLabel.Text = "Select Your Class:";
            // 
            // mageButton
            // 
            this.mageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mageButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mageButton.Location = new System.Drawing.Point(91, 51);
            this.mageButton.Name = "mageButton";
            this.mageButton.Size = new System.Drawing.Size(64, 27);
            this.mageButton.TabIndex = 31;
            this.mageButton.Text = "Mage";
            this.mageButton.UseVisualStyleBackColor = true;
            this.mageButton.Click += new System.EventHandler(this.mageButton_Click);
            // 
            // rangerButton
            // 
            this.rangerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rangerButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangerButton.Location = new System.Drawing.Point(150, 51);
            this.rangerButton.Name = "rangerButton";
            this.rangerButton.Size = new System.Drawing.Size(64, 27);
            this.rangerButton.TabIndex = 30;
            this.rangerButton.Text = "Ranger";
            this.rangerButton.UseVisualStyleBackColor = true;
            this.rangerButton.Click += new System.EventHandler(this.rangerButton_Click);
            // 
            // fighterButton
            // 
            this.fighterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fighterButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fighterButton.Location = new System.Drawing.Point(28, 51);
            this.fighterButton.Name = "fighterButton";
            this.fighterButton.Size = new System.Drawing.Size(64, 27);
            this.fighterButton.TabIndex = 29;
            this.fighterButton.Text = "Fighter";
            this.fighterButton.UseVisualStyleBackColor = true;
            this.fighterButton.Click += new System.EventHandler(this.fighterButton_Click);
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.Transparent;
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageBox.Location = new System.Drawing.Point(28, 81);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(185, 292);
            this.imageBox.TabIndex = 28;
            this.imageBox.TabStop = false;
            // 
            // CreationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CharacterCreator.Properties.Resources.forestCrop;
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.speedRadio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intuitionRadio);
            this.Controls.Add(this.charmRadio);
            this.Controls.Add(this.sneakRadio);
            this.Controls.Add(this.healthMinus);
            this.Controls.Add(this.healthPlus);
            this.Controls.Add(this.healthInput);
            this.Controls.Add(this.stregthMinus);
            this.Controls.Add(this.strengthPlus);
            this.Controls.Add(this.strengthInput);
            this.Controls.Add(this.dexMinus);
            this.Controls.Add(this.dexPlus);
            this.Controls.Add(this.dexInput);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attributesLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.mageButton);
            this.Controls.Add(this.rangerButton);
            this.Controls.Add(this.fighterButton);
            this.Controls.Add(this.imageBox);
            this.Name = "CreationScreen";
            this.Size = new System.Drawing.Size(493, 401);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton speedRadio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton intuitionRadio;
        private System.Windows.Forms.RadioButton charmRadio;
        private System.Windows.Forms.RadioButton sneakRadio;
        private System.Windows.Forms.Button healthMinus;
        private System.Windows.Forms.Button healthPlus;
        private System.Windows.Forms.Label healthInput;
        private System.Windows.Forms.Button stregthMinus;
        private System.Windows.Forms.Button strengthPlus;
        private System.Windows.Forms.Label strengthInput;
        private System.Windows.Forms.Button dexMinus;
        private System.Windows.Forms.Button dexPlus;
        private System.Windows.Forms.Label dexInput;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label attributesLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.Button mageButton;
        private System.Windows.Forms.Button rangerButton;
        private System.Windows.Forms.Button fighterButton;
        private System.Windows.Forms.PictureBox imageBox;
    }
}
