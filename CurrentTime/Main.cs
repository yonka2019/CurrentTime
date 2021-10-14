using System;
using System.Windows.Forms;

namespace CurrentTime
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            Update_Time();
            Set_TopMost_Status();
        }

        /// <summary>
        /// Controls the two main labels (Time & Date labels)
        /// </summary>
        private void Update_Time()
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            DateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        /// <summary>
        /// Sets the design of the button according the TopMost value
        /// </summary>
        private void Set_TopMost_Status()
        {
            if (TopMost) // true
            {
                TopMostButton.Image = Properties.Resources.top_menu_on_20px;
                MainToolTip.SetToolTip(TopMostButton, "Disable TopMost");
            }
            else // false
            {
                TopMostButton.Image = Properties.Resources.top_menu_off_20px;
                MainToolTip.SetToolTip(TopMostButton, "Enable TopMost");
            }
        }

        private void MainTimer_Tick(object sender, EventArgs e) =>
            Update_Time();

        private void TopMostButton_Click(object sender, EventArgs e)
        {
            TopMost = !TopMost; // Change top most value
            Set_TopMost_Status();
        }
    }
}
