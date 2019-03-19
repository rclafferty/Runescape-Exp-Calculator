namespace ExpGuiThreePointOh
{
    partial class MainGUI
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
            this.uxMemberButton = new System.Windows.Forms.RadioButton();
            this.uxFreeToPlayButton = new System.Windows.Forms.RadioButton();
            this.uxSkillBox = new System.Windows.Forms.ComboBox();
            this.uxSkillLabel = new System.Windows.Forms.Label();
            this.uxItemLabel = new System.Windows.Forms.Label();
            this.uxItemBox = new System.Windows.Forms.ComboBox();
            this.uxCurrentLabel = new System.Windows.Forms.Label();
            this.uxCurrentLevelLabel = new System.Windows.Forms.Label();
            this.uxCurrentExperienceLabel = new System.Windows.Forms.Label();
            this.uxCurrentLevelBox = new System.Windows.Forms.TextBox();
            this.uxCurrentExperienceBox = new System.Windows.Forms.TextBox();
            this.uxGoalLevelBox = new System.Windows.Forms.TextBox();
            this.uxGoalExperienceBox = new System.Windows.Forms.TextBox();
            this.uxGoalExperienceLabel = new System.Windows.Forms.Label();
            this.uxGoalLevelLabel = new System.Windows.Forms.Label();
            this.uxGoalLabel = new System.Windows.Forms.Label();
            this.uxCalculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxMemberButton
            // 
            this.uxMemberButton.AutoSize = true;
            this.uxMemberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxMemberButton.Location = new System.Drawing.Point(20, 14);
            this.uxMemberButton.Margin = new System.Windows.Forms.Padding(5);
            this.uxMemberButton.Name = "uxMemberButton";
            this.uxMemberButton.Size = new System.Drawing.Size(99, 28);
            this.uxMemberButton.TabIndex = 0;
            this.uxMemberButton.TabStop = true;
            this.uxMemberButton.Text = "Member";
            this.uxMemberButton.UseVisualStyleBackColor = true;
            this.uxMemberButton.CheckedChanged += new System.EventHandler(this.uxMemberButton_CheckedChanged);
            // 
            // uxFreeToPlayButton
            // 
            this.uxFreeToPlayButton.AutoSize = true;
            this.uxFreeToPlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFreeToPlayButton.Location = new System.Drawing.Point(175, 14);
            this.uxFreeToPlayButton.Margin = new System.Windows.Forms.Padding(5);
            this.uxFreeToPlayButton.Name = "uxFreeToPlayButton";
            this.uxFreeToPlayButton.Size = new System.Drawing.Size(136, 28);
            this.uxFreeToPlayButton.TabIndex = 1;
            this.uxFreeToPlayButton.TabStop = true;
            this.uxFreeToPlayButton.Text = "Free To Play";
            this.uxFreeToPlayButton.UseVisualStyleBackColor = true;
            // 
            // uxSkillBox
            // 
            this.uxSkillBox.FormattingEnabled = true;
            this.uxSkillBox.Location = new System.Drawing.Point(104, 52);
            this.uxSkillBox.Margin = new System.Windows.Forms.Padding(5);
            this.uxSkillBox.Name = "uxSkillBox";
            this.uxSkillBox.Size = new System.Drawing.Size(207, 28);
            this.uxSkillBox.TabIndex = 2;
            this.uxSkillBox.SelectedIndexChanged += new System.EventHandler(this.uxSkillBox_SelectedIndexChanged);
            // 
            // uxSkillLabel
            // 
            this.uxSkillLabel.AutoSize = true;
            this.uxSkillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uxSkillLabel.Location = new System.Drawing.Point(16, 52);
            this.uxSkillLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxSkillLabel.Name = "uxSkillLabel";
            this.uxSkillLabel.Size = new System.Drawing.Size(43, 24);
            this.uxSkillLabel.TabIndex = 3;
            this.uxSkillLabel.Text = "Skill";
            // 
            // uxItemLabel
            // 
            this.uxItemLabel.AutoSize = true;
            this.uxItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uxItemLabel.Location = new System.Drawing.Point(16, 85);
            this.uxItemLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxItemLabel.Name = "uxItemLabel";
            this.uxItemLabel.Size = new System.Drawing.Size(45, 24);
            this.uxItemLabel.TabIndex = 5;
            this.uxItemLabel.Text = "Item";
            // 
            // uxItemBox
            // 
            this.uxItemBox.FormattingEnabled = true;
            this.uxItemBox.Location = new System.Drawing.Point(104, 85);
            this.uxItemBox.Margin = new System.Windows.Forms.Padding(5);
            this.uxItemBox.Name = "uxItemBox";
            this.uxItemBox.Size = new System.Drawing.Size(207, 28);
            this.uxItemBox.TabIndex = 4;
            this.uxItemBox.SelectedIndexChanged += new System.EventHandler(this.uxItemBox_SelectedIndexChanged);
            // 
            // uxCurrentLabel
            // 
            this.uxCurrentLabel.AutoSize = true;
            this.uxCurrentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uxCurrentLabel.Location = new System.Drawing.Point(120, 133);
            this.uxCurrentLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxCurrentLabel.Name = "uxCurrentLabel";
            this.uxCurrentLabel.Size = new System.Drawing.Size(72, 24);
            this.uxCurrentLabel.TabIndex = 6;
            this.uxCurrentLabel.Text = "Current";
            // 
            // uxCurrentLevelLabel
            // 
            this.uxCurrentLevelLabel.AutoSize = true;
            this.uxCurrentLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uxCurrentLevelLabel.Location = new System.Drawing.Point(64, 157);
            this.uxCurrentLevelLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxCurrentLevelLabel.Name = "uxCurrentLevelLabel";
            this.uxCurrentLevelLabel.Size = new System.Drawing.Size(55, 24);
            this.uxCurrentLevelLabel.TabIndex = 7;
            this.uxCurrentLevelLabel.Text = "Level";
            // 
            // uxCurrentExperienceLabel
            // 
            this.uxCurrentExperienceLabel.AutoSize = true;
            this.uxCurrentExperienceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uxCurrentExperienceLabel.Location = new System.Drawing.Point(187, 157);
            this.uxCurrentExperienceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxCurrentExperienceLabel.Name = "uxCurrentExperienceLabel";
            this.uxCurrentExperienceLabel.Size = new System.Drawing.Size(108, 24);
            this.uxCurrentExperienceLabel.TabIndex = 8;
            this.uxCurrentExperienceLabel.Text = "Experience";
            // 
            // uxCurrentLevelBox
            // 
            this.uxCurrentLevelBox.Location = new System.Drawing.Point(20, 184);
            this.uxCurrentLevelBox.Name = "uxCurrentLevelBox";
            this.uxCurrentLevelBox.ReadOnly = true;
            this.uxCurrentLevelBox.Size = new System.Drawing.Size(136, 26);
            this.uxCurrentLevelBox.TabIndex = 9;
            // 
            // uxCurrentExperienceBox
            // 
            this.uxCurrentExperienceBox.Location = new System.Drawing.Point(175, 184);
            this.uxCurrentExperienceBox.Name = "uxCurrentExperienceBox";
            this.uxCurrentExperienceBox.Size = new System.Drawing.Size(136, 26);
            this.uxCurrentExperienceBox.TabIndex = 10;
            this.uxCurrentExperienceBox.TextChanged += new System.EventHandler(this.uxCurrentExperienceBox_TextChanged);
            // 
            // uxGoalLevelBox
            // 
            this.uxGoalLevelBox.Location = new System.Drawing.Point(20, 283);
            this.uxGoalLevelBox.Name = "uxGoalLevelBox";
            this.uxGoalLevelBox.Size = new System.Drawing.Size(136, 26);
            this.uxGoalLevelBox.TabIndex = 15;
            this.uxGoalLevelBox.TextChanged += new System.EventHandler(this.uxGoalLevelBox_TextChanged);
            // 
            // uxGoalExperienceBox
            // 
            this.uxGoalExperienceBox.Location = new System.Drawing.Point(175, 283);
            this.uxGoalExperienceBox.Name = "uxGoalExperienceBox";
            this.uxGoalExperienceBox.ReadOnly = true;
            this.uxGoalExperienceBox.Size = new System.Drawing.Size(136, 26);
            this.uxGoalExperienceBox.TabIndex = 14;
            // 
            // uxGoalExperienceLabel
            // 
            this.uxGoalExperienceLabel.AutoSize = true;
            this.uxGoalExperienceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uxGoalExperienceLabel.Location = new System.Drawing.Point(187, 256);
            this.uxGoalExperienceLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxGoalExperienceLabel.Name = "uxGoalExperienceLabel";
            this.uxGoalExperienceLabel.Size = new System.Drawing.Size(108, 24);
            this.uxGoalExperienceLabel.TabIndex = 13;
            this.uxGoalExperienceLabel.Text = "Experience";
            // 
            // uxGoalLevelLabel
            // 
            this.uxGoalLevelLabel.AutoSize = true;
            this.uxGoalLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uxGoalLevelLabel.Location = new System.Drawing.Point(64, 256);
            this.uxGoalLevelLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxGoalLevelLabel.Name = "uxGoalLevelLabel";
            this.uxGoalLevelLabel.Size = new System.Drawing.Size(55, 24);
            this.uxGoalLevelLabel.TabIndex = 12;
            this.uxGoalLevelLabel.Text = "Level";
            // 
            // uxGoalLabel
            // 
            this.uxGoalLabel.AutoSize = true;
            this.uxGoalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.uxGoalLabel.Location = new System.Drawing.Point(132, 231);
            this.uxGoalLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.uxGoalLabel.Name = "uxGoalLabel";
            this.uxGoalLabel.Size = new System.Drawing.Size(49, 24);
            this.uxGoalLabel.TabIndex = 11;
            this.uxGoalLabel.Text = "Goal";
            // 
            // uxCalculateButton
            // 
            this.uxCalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxCalculateButton.Location = new System.Drawing.Point(20, 329);
            this.uxCalculateButton.Name = "uxCalculateButton";
            this.uxCalculateButton.Size = new System.Drawing.Size(136, 37);
            this.uxCalculateButton.TabIndex = 16;
            this.uxCalculateButton.Text = "Calculate";
            this.uxCalculateButton.UseVisualStyleBackColor = true;
            this.uxCalculateButton.Click += new System.EventHandler(this.uxCalculateButton_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 403);
            this.Controls.Add(this.uxCalculateButton);
            this.Controls.Add(this.uxGoalLevelBox);
            this.Controls.Add(this.uxGoalExperienceBox);
            this.Controls.Add(this.uxGoalExperienceLabel);
            this.Controls.Add(this.uxGoalLevelLabel);
            this.Controls.Add(this.uxGoalLabel);
            this.Controls.Add(this.uxCurrentExperienceBox);
            this.Controls.Add(this.uxCurrentLevelBox);
            this.Controls.Add(this.uxCurrentExperienceLabel);
            this.Controls.Add(this.uxCurrentLevelLabel);
            this.Controls.Add(this.uxCurrentLabel);
            this.Controls.Add(this.uxItemLabel);
            this.Controls.Add(this.uxItemBox);
            this.Controls.Add(this.uxSkillLabel);
            this.Controls.Add(this.uxSkillBox);
            this.Controls.Add(this.uxFreeToPlayButton);
            this.Controls.Add(this.uxMemberButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainGUI";
            this.Text = "Exp Calculator 3.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton uxMemberButton;
        private System.Windows.Forms.RadioButton uxFreeToPlayButton;
        private System.Windows.Forms.ComboBox uxSkillBox;
        private System.Windows.Forms.Label uxSkillLabel;
        private System.Windows.Forms.Label uxItemLabel;
        private System.Windows.Forms.ComboBox uxItemBox;
        private System.Windows.Forms.Label uxCurrentLabel;
        private System.Windows.Forms.Label uxCurrentLevelLabel;
        private System.Windows.Forms.Label uxCurrentExperienceLabel;
        private System.Windows.Forms.TextBox uxCurrentLevelBox;
        private System.Windows.Forms.TextBox uxCurrentExperienceBox;
        private System.Windows.Forms.TextBox uxGoalLevelBox;
        private System.Windows.Forms.TextBox uxGoalExperienceBox;
        private System.Windows.Forms.Label uxGoalExperienceLabel;
        private System.Windows.Forms.Label uxGoalLevelLabel;
        private System.Windows.Forms.Label uxGoalLabel;
        private System.Windows.Forms.Button uxCalculateButton;
    }
}

