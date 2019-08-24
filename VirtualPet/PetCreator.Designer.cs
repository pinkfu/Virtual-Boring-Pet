namespace VirtualPet
{
    partial class PetCreator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createButton = new System.Windows.Forms.Button();
            this.createPetLabel = new System.Windows.Forms.Label();
            this.petName = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(220, 100);
            this.createButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(100, 28);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create!";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // createPetLabel
            // 
            this.createPetLabel.AutoSize = true;
            this.createPetLabel.Font = new System.Drawing.Font("Georgia", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPetLabel.Location = new System.Drawing.Point(100, 20);
            this.createPetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createPetLabel.Name = "createPetLabel";
            this.createPetLabel.Size = new System.Drawing.Size(113, 23);
            this.createPetLabel.TabIndex = 1;
            this.createPetLabel.Text = "Create Pet";
            // 
            // petName
            // 
            this.petName.AutoSize = true;
            this.petName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petName.Location = new System.Drawing.Point(20, 100);
            this.petName.Name = "petName";
            this.petName.Size = new System.Drawing.Size(56, 18);
            this.petName.TabIndex = 2;
            this.petName.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(80, 100);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(120, 22);
            this.name.TabIndex = 3;
            // 
            // PetCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 200);
            this.Controls.Add(this.name);
            this.Controls.Add(this.petName);
            this.Controls.Add(this.createPetLabel);
            this.Controls.Add(this.createButton);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PetCreator";
            this.Text = "Boring Pet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label createPetLabel;
        private System.Windows.Forms.Label petName;
        private System.Windows.Forms.TextBox name;
    }
}

