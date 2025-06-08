namespace project_ARKANOID
{
    partial class FormMenu
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(125, 144);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(156, 59);
            this.buttonStartGame.TabIndex = 1;
            this.buttonStartGame.Text = "Начать игру";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(125, 305);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(156, 59);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Информация об игре";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 416);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(115, 48);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выйти из игры";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(125, 220);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(156, 59);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 476);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonStartGame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.Text = "МЕНЮ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSettings;
    }
}