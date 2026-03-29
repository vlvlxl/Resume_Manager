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
    public partial class AddSkillForm : Form
    {
        public string Skill { get; private set; }

        public AddSkillForm()
        {
            Text = "Добавить навык";
            Width = 300;
            Height = 120;

            var skillLabel = new Label
            {
                Text = "Навык:",
                Location = new System.Drawing.Point(10, 10)
            };
            var skillTextBox = new TextBox
            {
                Location = new System.Drawing.Point(10, 30),
                Width = 260
            };

            var okButton = new Button
            {
                Text = "OK",
                Location = new System.Drawing.Point(10, 60),
                Width = 80
            };
            var cancelButton = new Button
            {
                Text = "Отмена",
                Location = new System.Drawing.Point(100, 60),
                Width = 80
            };

            okButton.Click += (sender, e) =>
            {
                Skill = skillTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            };

            cancelButton.Click += (sender, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };

            Controls.Add(skillLabel);
            Controls.Add(skillTextBox);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
        }
    }
}
