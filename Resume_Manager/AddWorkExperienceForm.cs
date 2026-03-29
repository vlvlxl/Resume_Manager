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
    public partial class AddWorkExperienceForm : Form
    {
        public string Position { get; private set; }
        public string Company { get; private set; }
        public string Period { get; private set; }
        public string Description { get; private set; }

        public AddWorkExperienceForm()
        {
            Text = "Добавить опыт работы";
            Width = 300;
            Height = 250;

            var positionLabel = new Label
            {
                Text = "Должность:",
                Location = new System.Drawing.Point(10, 10)
            };
            var positionTextBox = new TextBox
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

            var periodLabel = new Label
            {
                Text = "Период:",
                Location = new System.Drawing.Point(10, 90)
            };
            var periodTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 110),
                Width = 260
            };

            var descriptionLabel = new Label
            {
                Text = "Описание:",
                Location = new System.Drawing.Point(10, 130)
            };
            var descriptionTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 150),
                Width = 260
            };

            var okButton = new Button
            {
                Text = "OK",
                Location = new System.Drawing.Point(10, 180),
                Width = 80
            };
            var cancelButton = new Button
            {
                Text = "Отмена",
                Location = new System.Drawing.Point(100, 180),
                Width = 80
            };

            okButton.Click += (sender, e) =>
            {
                Position = positionTextBox.Text;
                Company = companyTextBox.Text;
                Period = periodTextBox.Text;
                Description = descriptionTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            };

            cancelButton.Click += (sender, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };

            Controls.Add(positionLabel);
            Controls.Add(positionTextBox);
            Controls.Add(companyLabel);
            Controls.Add(companyTextBox);
            Controls.Add(periodLabel);
            Controls.Add(periodTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(descriptionTextBox);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
        }
    }
}
