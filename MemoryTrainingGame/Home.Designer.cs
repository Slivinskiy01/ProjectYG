namespace MemoryTrainingGame
{
    partial class Home
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.AboutBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameBtn.Location = new System.Drawing.Point(72, 24);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(174, 31);
            this.StartGameBtn.TabIndex = 0;
            this.StartGameBtn.Text = " Игра ";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingBtn.Location = new System.Drawing.Point(72, 61);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(174, 32);
            this.SettingBtn.TabIndex = 1;
            this.SettingBtn.Text = "Настройки";
            this.SettingBtn.UseVisualStyleBackColor = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // AboutBtn
            // 
            this.AboutBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutBtn.Location = new System.Drawing.Point(72, 99);
            this.AboutBtn.Name = "AboutBtn";
            this.AboutBtn.Size = new System.Drawing.Size(174, 32);
            this.AboutBtn.TabIndex = 2;
            this.AboutBtn.Text = "О программе ";
            this.AboutBtn.UseVisualStyleBackColor = true;
            this.AboutBtn.Click += new System.EventHandler(this.AboutBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(72, 137);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(174, 33);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "Выход ";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(315, 200);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.AboutBtn);
            this.Controls.Add(this.SettingBtn);
            this.Controls.Add(this.StartGameBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "тренеруй свою память ";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Button AboutBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}

