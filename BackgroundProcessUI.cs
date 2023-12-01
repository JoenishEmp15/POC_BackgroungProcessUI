using Microsoft.VisualBasic.ApplicationServices;
using POC_BackgroungProcessUI.Data;
using POC_BackgroungProcessUI.Models;
using System;

namespace POC_BackgroungProcessUI
{
    public partial class BackgroundProcessUI : Form
    {
        public BackgroundProcessUI()
        {
            InitializeComponent();
            Browsers.Items.AddRange(new object[] { "Chrome", "Edge", "Safari", "Firefox" });
            Browsers.SelectedIndex = 0;
        }

        private void SaveToDatabase(string browserName, string url)
        {
            try
            {
                var context = new BackgroundProcessDbContext();
                var browserInfo = new BrowserInfo { BroserName = browserName, Url = url };
                context.BrowserInfos.Add(browserInfo);
                context.SaveChanges();
                MessageBox.Show("Data saved to database successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving data to database: {ex.Message}");
            }
        }

        private void StartProcess_Click(object sender, EventArgs e)
        {
            string browserName = Browsers.Text;
            string url = Url.Text;

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please provide a URL.");
                return;
            }
            SaveToDatabase(browserName, url);
        }

        private void Browsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Url_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
