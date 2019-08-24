namespace VirtualPet
{
    partial class YourPet
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
            this.petLabel = new System.Windows.Forms.Label();
            this.nameDisplay = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.feedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // petLabel
            // 
            this.petLabel.AutoSize = true;
            this.petLabel.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.petLabel.Location = new System.Drawing.Point(60, 40);
            this.petLabel.Name = "petLabel";
            this.petLabel.Size = new System.Drawing.Size(49, 23);
            this.petLabel.TabIndex = 0;
            this.petLabel.Text = "Pet:";
            // 
            // nameDisplay
            // 
            this.nameDisplay.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDisplay.Location = new System.Drawing.Point(140, 40);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.Size = new System.Drawing.Size(120, 20);
            this.nameDisplay.TabIndex = 1;
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(40, 180);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(100, 40);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // feedButton
            // 
            this.feedButton.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedButton.Location = new System.Drawing.Point(200, 180);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(100, 40);
            this.feedButton.TabIndex = 3;
            this.feedButton.Text = "Feed";
            this.feedButton.UseVisualStyleBackColor = true;
            // 
            // YourPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 394);
            this.Controls.Add(this.feedButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.nameDisplay);
            this.Controls.Add(this.petLabel);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "YourPet";
            this.Text = "Your Pet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label petLabel;
        private System.Windows.Forms.Label nameDisplay;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button feedButton;
    }
}