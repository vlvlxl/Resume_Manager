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
    public partial class CreateResumeForm : Form
    {
        public string Name { get; private set; }
        public string ContactInfo { get; private set; }
        public string Objective { get; private set; }

        public CreateResumeForm()
        {
            Text = "Создать резюме";
            Width = 300;
            Height = 200;

            var nameLabel = new Label
            {
                Text = "Имя:",
                Location = new System.Drawing.Point(10, 10)
            };
            var nameTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 30),
                Width = 260
            };

            var contactLabel = new Label
            {
                Text = "Контактная информация:",
                Location = new System.Drawing.Point(10, 50)
            };
            var contactTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 70),
                Width = 260
            };

            var objectiveLabel = new Label
            {
                Text = "Цель:",
                Location = new System.Drawing.Point(10, 90)
            };
            var objectiveTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 110),
                Width = 260
            };

            var okButton = new Button
            {
                Text = "OK",
                Location = new System.Drawing.Point(10, 140),
                Width = 80
            };
            var cancelButton = new Button
            {
                Text = "Отмена",
                Location = new System.Drawing.Point(100, 140),
                Width = 80
            };

            okButton.Click += (sender, e) =>
            {
                Name = nameTextBox.Text;
                ContactInfo = contactTextBox.Text;
                Objective = objectiveTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            };

            cancelButton.Click += (sender, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };

            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(contactLabel);
            Controls.Add(contactTextBox);
            Controls.Add(objectiveLabel);
            Controls.Add(objectiveTextBox);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
        }
    }
}
