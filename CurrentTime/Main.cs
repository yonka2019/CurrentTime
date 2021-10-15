using System;
using System.Drawing;
using System.Windows.Forms;

namespace CurrentTime
{
    enum Themes
    {
        Light,
        Dark
    }

    public partial class Main : Form
    {
        private Themes currentTheme = Themes.Light;

        public Main()
        {
            InitializeComponent();

            Update_Time();
            RemoveBorder(ThemeModeChangeButton);
            RemoveBorder(TopMostButton);
        }

        /// <summary>
        /// Changes current program theme to the given one
        /// </summary>
        /// <param name="theme">Theme to change the program to</param>
        private void ChangeTheme(Themes theme)
        {
            switch (theme)
            {
                case Themes.Light:  // Dark mode enabled

                    MainToolTip.SetToolTip(ThemeModeChangeButton, "Dark Mode");
                    ThemeModeChangeButton.Image = Properties.Resources.light_mode;

                    BackColor = ColorTranslator.FromHtml("#121212");
                    ThemeModeChangeButton.BackColor = ColorTranslator.FromHtml("#121212");
                    TopMostButton.BackColor = ColorTranslator.FromHtml("#121212");

                    TimeLabel.ForeColor = Color.FromArgb(87, ColorTranslator.FromHtml("#FFFFFF"));
                    DateLabel.ForeColor = Color.FromArgb(87, ColorTranslator.FromHtml("#FFFFFF"));

                    TopMostButton.Image = Properties.Resources.light_topmost;

                    currentTheme = Themes.Dark;
                    break;

                case Themes.Dark:  // Light mode enabled

                    MainToolTip.SetToolTip(ThemeModeChangeButton, "Light Mode");
                    ThemeModeChangeButton.Image = Properties.Resources.dark_mode;

                    BackColor = SystemColors.Control;
                    TopMostButton.BackColor = SystemColors.Control;
                    ThemeModeChangeButton.BackColor = SystemColors.Control;

                    TimeLabel.ForeColor = SystemColors.ControlText;
                    DateLabel.ForeColor = SystemColors.ControlText;

                    TopMostButton.Image = Properties.Resources.dark_topmost;

                    currentTheme = Themes.Light;
                    break;

            }
        }

        /// <summary>
        /// Removes border to the given button
        /// </summary>
        /// <param name="button">Button to remove his border</param>
        private void RemoveBorder(Button button)
        {
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        /// Controls the two main labels (Time & Date labels)
        /// </summary>
        private void Update_Time()
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            DateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void MainTimer_Tick(object sender, EventArgs e) =>
            Update_Time();

        private void TopMostButton_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost; // Change top most value

            if (TopMost)
                MainToolTip.SetToolTip(TopMostButton, "Disable TopMost");
            else
                MainToolTip.SetToolTip(TopMostButton, "Enable TopMost");
        }

        private void ThemeModeChangeButton_Click(object sender, EventArgs e)
        {
            ChangeTheme(currentTheme);
        }
    }
}
