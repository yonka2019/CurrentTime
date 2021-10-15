namespace CurrentTime
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TimeLabel = new System.Windows.Forms.Label();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.DateLabel = new System.Windows.Forms.Label();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ThemeModeChangeButton = new System.Windows.Forms.Button();
            this.TopMostButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.Font = new System.Drawing.Font("Open Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(14, 10);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(252, 42);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Time";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.DateLabel.Location = new System.Drawing.Point(37, 48);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(206, 31);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "Time";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThemeModeChangeButton
            // 
            this.ThemeModeChangeButton.Image = global::CurrentTime.Properties.Resources.dark_mode;
            this.ThemeModeChangeButton.Location = new System.Drawing.Point(243, 53);
            this.ThemeModeChangeButton.Name = "ThemeModeChangeButton";
            this.ThemeModeChangeButton.Size = new System.Drawing.Size(26, 27);
            this.ThemeModeChangeButton.TabIndex = 3;
            this.MainToolTip.SetToolTip(this.ThemeModeChangeButton, "Dark Mode");
            this.ThemeModeChangeButton.UseVisualStyleBackColor = true;
            this.ThemeModeChangeButton.Click += new System.EventHandler(this.ThemeModeChangeButton_Click);
            // 
            // TopMostButton
            // 
            this.TopMostButton.Image = global::CurrentTime.Properties.Resources.dark_topmost;
            this.TopMostButton.Location = new System.Drawing.Point(12, 53);
            this.TopMostButton.Name = "TopMostButton";
            this.TopMostButton.Size = new System.Drawing.Size(26, 27);
            this.TopMostButton.TabIndex = 2;
            this.MainToolTip.SetToolTip(this.TopMostButton, "Enable TopMost");
            this.TopMostButton.UseVisualStyleBackColor = true;
            this.TopMostButton.Click += new System.EventHandler(this.TopMostButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 92);
            this.Controls.Add(this.ThemeModeChangeButton);
            this.Controls.Add(this.TopMostButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.TimeLabel);
            this.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button TopMostButton;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.Button ThemeModeChangeButton;
    }
}

