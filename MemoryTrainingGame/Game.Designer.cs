namespace MemoryTrainingGame
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkTextInput = new System.Windows.Forms.TextBox();
            this.CheckBtn = new System.Windows.Forms.Button();
            this.HelperLabel = new System.Windows.Forms.Label();
            this.LevelLabelText = new System.Windows.Forms.Label();
            this.LevelLabelValue = new System.Windows.Forms.Label();
            this.ScoreLabelValue = new System.Windows.Forms.Label();
            this.ScoreLabelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Location = new System.Drawing.Point(107, 12);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(173, 40);
            this.StartGameBtn.TabIndex = 0;
            this.StartGameBtn.Text = "СТАРТ ";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 62);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkTextInput
            // 
            this.checkTextInput.Enabled = false;
            this.checkTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTextInput.Location = new System.Drawing.Point(46, 176);
            this.checkTextInput.Multiline = true;
            this.checkTextInput.Name = "checkTextInput";
            this.checkTextInput.Size = new System.Drawing.Size(301, 27);
            this.checkTextInput.TabIndex = 9;
            this.checkTextInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.checkTextInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.checkTextInput_KeyPress);
            // 
            // CheckBtn
            // 
            this.CheckBtn.Enabled = false;
            this.CheckBtn.Location = new System.Drawing.Point(105, 209);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(173, 27);
            this.CheckBtn.TabIndex = 10;
            this.CheckBtn.Text = "ПРОВЕРИТЬ";
            this.CheckBtn.UseVisualStyleBackColor = true;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // HelperLabel
            // 
            this.HelperLabel.AutoSize = true;
            this.HelperLabel.Location = new System.Drawing.Point(81, 160);
            this.HelperLabel.Name = "HelperLabel";
            this.HelperLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HelperLabel.Size = new System.Drawing.Size(231, 13);
            this.HelperLabel.TabIndex = 11;
            this.HelperLabel.Text = "Введите запомненные числа через запятую";
            this.HelperLabel.Visible = false;
            // 
            // LevelLabelText
            // 
            this.LevelLabelText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabelText.Location = new System.Drawing.Point(12, 12);
            this.LevelLabelText.Name = "LevelLabelText";
            this.LevelLabelText.Size = new System.Drawing.Size(49, 40);
            this.LevelLabelText.TabIndex = 12;
            this.LevelLabelText.Text = "Lvl:";
            this.LevelLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LevelLabelValue
            // 
            this.LevelLabelValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabelValue.Location = new System.Drawing.Point(58, 12);
            this.LevelLabelValue.Name = "LevelLabelValue";
            this.LevelLabelValue.Size = new System.Drawing.Size(46, 40);
            this.LevelLabelValue.TabIndex = 13;
            this.LevelLabelValue.Text = "1";
            this.LevelLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScoreLabelValue
            // 
            this.ScoreLabelValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabelValue.Location = new System.Drawing.Point(347, 12);
            this.ScoreLabelValue.Name = "ScoreLabelValue";
            this.ScoreLabelValue.Size = new System.Drawing.Size(44, 40);
            this.ScoreLabelValue.TabIndex = 15;
            this.ScoreLabelValue.Text = "1";
            this.ScoreLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScoreLabelText
            // 
            this.ScoreLabelText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabelText.Location = new System.Drawing.Point(289, 12);
            this.ScoreLabelText.Name = "ScoreLabelText";
            this.ScoreLabelText.Size = new System.Drawing.Size(80, 40);
            this.ScoreLabelText.TabIndex = 14;
            this.ScoreLabelText.Text = "Score:";
            this.ScoreLabelText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(396, 245);
            this.Controls.Add(this.ScoreLabelValue);
            this.Controls.Add(this.ScoreLabelText);
            this.Controls.Add(this.LevelLabelValue);
            this.Controls.Add(this.LevelLabelText);
            this.Controls.Add(this.HelperLabel);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.checkTextInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartGameBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игра";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox checkTextInput;
        private System.Windows.Forms.Button CheckBtn;
        private System.Windows.Forms.Label HelperLabel;
        private System.Windows.Forms.Label LevelLabelText;
        private System.Windows.Forms.Label LevelLabelValue;
        private System.Windows.Forms.Label ScoreLabelValue;
        private System.Windows.Forms.Label ScoreLabelText;
    }
}