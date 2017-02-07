namespace CharacterCreator
{
    partial class ViewScreen
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
            this.classOutput = new System.Windows.Forms.Label();
            this.dexterityOutput = new System.Windows.Forms.Label();
            this.strengthOutput = new System.Windows.Forms.Label();
            this.healthOutput = new System.Windows.Forms.Label();
            this.perkOutput = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.perkLabel = new System.Windows.Forms.Label();
            this.strLabel = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.dexLabel = new System.Windows.Forms.Label();
            this.classLabel = new System.Windows.Forms.Label();
            this.heroSelect = new System.Windows.Forms.ComboBox();
            this.nameOutput = new System.Windows.Forms.Label();
            this.heroImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.heroImage)).BeginInit();
            this.SuspendLayout();
            // 
            // classOutput
            // 
            this.classOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classOutput.Location = new System.Drawing.Point(404, 104);
            this.classOutput.Name = "classOutput";
            this.classOutput.Size = new System.Drawing.Size(77, 21);
            this.classOutput.TabIndex = 46;
            // 
            // dexterityOutput
            // 
            this.dexterityOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dexterityOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexterityOutput.Location = new System.Drawing.Point(404, 140);
            this.dexterityOutput.Name = "dexterityOutput";
            this.dexterityOutput.Size = new System.Drawing.Size(77, 21);
            this.dexterityOutput.TabIndex = 45;
            // 
            // strengthOutput
            // 
            this.strengthOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.strengthOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthOutput.Location = new System.Drawing.Point(404, 177);
            this.strengthOutput.Name = "strengthOutput";
            this.strengthOutput.Size = new System.Drawing.Size(77, 21);
            this.strengthOutput.TabIndex = 44;
            // 
            // healthOutput
            // 
            this.healthOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.healthOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthOutput.Location = new System.Drawing.Point(404, 213);
            this.healthOutput.Name = "healthOutput";
            this.healthOutput.Size = new System.Drawing.Size(77, 21);
            this.healthOutput.TabIndex = 43;
            // 
            // perkOutput
            // 
            this.perkOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.perkOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perkOutput.Location = new System.Drawing.Point(404, 248);
            this.perkOutput.Name = "perkOutput";
            this.perkOutput.Size = new System.Drawing.Size(77, 21);
            this.perkOutput.TabIndex = 42;
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(417, 362);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(64, 27);
            this.exitButton.TabIndex = 41;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // perkLabel
            // 
            this.perkLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.perkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perkLabel.Location = new System.Drawing.Point(295, 248);
            this.perkLabel.Name = "perkLabel";
            this.perkLabel.Size = new System.Drawing.Size(81, 21);
            this.perkLabel.TabIndex = 40;
            this.perkLabel.Text = "Perk:";
            // 
            // strLabel
            // 
            this.strLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.strLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strLabel.Location = new System.Drawing.Point(295, 177);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(81, 21);
            this.strLabel.TabIndex = 39;
            this.strLabel.Text = "Strength:";
            // 
            // healthLabel
            // 
            this.healthLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.healthLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthLabel.Location = new System.Drawing.Point(295, 213);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(81, 21);
            this.healthLabel.TabIndex = 38;
            this.healthLabel.Text = "Health:";
            // 
            // dexLabel
            // 
            this.dexLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dexLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexLabel.Location = new System.Drawing.Point(295, 140);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(81, 21);
            this.dexLabel.TabIndex = 37;
            this.dexLabel.Text = "Dexterity:";
            // 
            // classLabel
            // 
            this.classLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.classLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(295, 104);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(81, 23);
            this.classLabel.TabIndex = 36;
            this.classLabel.Text = "Class:";
            // 
            // heroSelect
            // 
            this.heroSelect.FormattingEnabled = true;
            this.heroSelect.Location = new System.Drawing.Point(3, 12);
            this.heroSelect.Name = "heroSelect";
            this.heroSelect.Size = new System.Drawing.Size(135, 21);
            this.heroSelect.TabIndex = 35;
            this.heroSelect.Text = "Select Character";
            this.heroSelect.SelectedIndexChanged += new System.EventHandler(this.heroSelect_SelectedIndexChanged);
            // 
            // nameOutput
            // 
            this.nameOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nameOutput.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOutput.Location = new System.Drawing.Point(295, 12);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(186, 41);
            this.nameOutput.TabIndex = 34;
            // 
            // heroImage
            // 
            this.heroImage.BackColor = System.Drawing.Color.Transparent;
            this.heroImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.heroImage.Location = new System.Drawing.Point(20, 39);
            this.heroImage.Name = "heroImage";
            this.heroImage.Size = new System.Drawing.Size(269, 362);
            this.heroImage.TabIndex = 47;
            this.heroImage.TabStop = false;
            // 
            // ViewScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CharacterCreator.Properties.Resources.roadway;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.classOutput);
            this.Controls.Add(this.dexterityOutput);
            this.Controls.Add(this.strengthOutput);
            this.Controls.Add(this.healthOutput);
            this.Controls.Add(this.perkOutput);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.perkLabel);
            this.Controls.Add(this.strLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.dexLabel);
            this.Controls.Add(this.classLabel);
            this.Controls.Add(this.heroSelect);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.heroImage);
            this.Name = "ViewScreen";
            this.Size = new System.Drawing.Size(493, 401);
            this.Load += new System.EventHandler(this.ViewScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.heroImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label classOutput;
        private System.Windows.Forms.Label dexterityOutput;
        private System.Windows.Forms.Label strengthOutput;
        private System.Windows.Forms.Label healthOutput;
        private System.Windows.Forms.Label perkOutput;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label perkLabel;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox heroSelect;
        private System.Windows.Forms.Label nameOutput;
        private System.Windows.Forms.PictureBox heroImage;
    }
}
