using Resume_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resume_Manager
{
    public partial class SearchJobListingForm : Form
    {
        public List<JobListing> JobListings { get; set; }
        public ListBox JobListingsListBox { get; private set; }

        public SearchJobListingForm()
        {
            Text = "Поиск вакансий";
            Width = 400;
            Height = 300;

            JobListingsListBox = new ListBox
            {
                Location = new System.Drawing.Point(10, 10),
                Width = 360,
                Height = 260
            };

            var okButton = new Button
            {
                Text = "OK",
                Location = new System.Drawing.Point(10, 280),
                Width = 80
            };
            var cancelButton = new Button
            {
                Text = "Отмена",
                Location = new System.Drawing.Point(100, 280),
                Width = 80
            };

            okButton.Click += (sender, e) =>
            {
                DialogResult = DialogResult.OK;
                Close();
            };

            cancelButton.Click += (sender, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };

            Controls.Add(JobListingsListBox);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (JobListings != null)
            {
                foreach (var jobListing in JobListings)
                {
                    JobListingsListBox.Items.Add(jobListing.ToString());
                }
            }
        }
    }
}
