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
    public partial class AddJobListingForm : Form
    {
        public string JobTitle { get; private set; }
        public string Company { get; private set; }
        public string Description { get; private set; }
        public string Requirements { get; private set; }

        public AddJobListingForm()
        {
            Text = "Добавить вакансию";
            Width = 300;
            Height = 300;

            var jobTitleLabel = new Label
            {
                Text = "Название вакансии:",
                Location = new System.Drawing.Point(10, 10)
            };
            var jobTitleTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 30),
                Width = 260
            };

            var companyLabel = new Label
            {
                Text = "Компания:",
                Location = new System.Drawing.Point(10, 50)
            };
            var companyTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 70),
                Width = 260
            };

            var descriptionLabel = new Label
            {
                Text = "Описание:",
                Location = new System.Drawing.Point(10, 90)
            };
            var descriptionTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 110),
                Width = 260
            };

            var requirementsLabel = new Label
            {
                Text = "Требования:",
                Location = new System.Drawing.Point(10, 130)
            };
            var requirementsTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 150),
                Width = 260
            };

            var okButton = new Button
            {
                Text = "OK",
                Location = new System.Drawing.Point(10, 240),
                Width = 80
            };
            var cancelButton = new Button
            {
                Text = "Отмена",
                Location = new System.Drawing.Point(100, 240),
                Width = 80
            };

            okButton.Click += (sender, e) =>
            {
                JobTitle = jobTitleTextBox.Text;
                Company = companyTextBox.Text;
                Description = descriptionTextBox.Text;
                Requirements = requirementsTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            };

            cancelButton.Click += (sender, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };

            Controls.Add(jobTitleLabel);
            Controls.Add(jobTitleTextBox);
            Controls.Add(companyLabel);
            Controls.Add(companyTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(requirementsLabel);
            Controls.Add(requirementsTextBox);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
        }
    }
}
