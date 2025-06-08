namespace project_ARKANOID
{
    partial class FormGame
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
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.LabelPlayerScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelBotScore = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonStasik = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Location = new System.Drawing.Point(435, 10);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(45, 16);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "CЧЕТ";
            // 
            // LabelPlayerScore
            // 
            this.LabelPlayerScore.AutoSize = true;
            this.LabelPlayerScore.Location = new System.Drawing.Point(432, 37);
            this.LabelPlayerScore.Name = "LabelPlayerScore";
            this.LabelPlayerScore.Size = new System.Drawing.Size(14, 16);
            this.LabelPlayerScore.TabIndex = 1;
            this.LabelPlayerScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // LabelBotScore
            // 
            this.LabelBotScore.AutoSize = true;
            this.LabelBotScore.Location = new System.Drawing.Point(468, 37);
            this.LabelBotScore.Name = "LabelBotScore";
            this.LabelBotScore.Size = new System.Drawing.Size(14, 16);
            this.LabelBotScore.TabIndex = 3;
            this.LabelBotScore.Text = "0";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(403, 56);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(107, 37);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(39, 12);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(120, 43);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonStasik
            // 
            this.buttonStasik.Location = new System.Drawing.Point(624, 12);
            this.buttonStasik.Name = "buttonStasik";
            this.buttonStasik.Size = new System.Drawing.Size(107, 41);
            this.buttonStasik.TabIndex = 6;
            this.buttonStasik.Text = "Стасик";
            this.buttonStasik.UseVisualStyleBackColor = true;
            this.buttonStasik.Click += new System.EventHandler(this.buttonStasik_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(762, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(108, 43);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выйти из игры";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 637);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStasik);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.LabelBotScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelPlayerScore);
            this.Controls.Add(this.ScoreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGame";
            this.Text = "Arkanoid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        public System.Windows.Forms.Label LabelPlayerScore;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LabelBotScore;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonStasik;
        private System.Windows.Forms.Button buttonExit;
    }
}

