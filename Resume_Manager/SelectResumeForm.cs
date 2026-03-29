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
    public partial class SelectResumeForm : Form
    {
        public List<Resume> Resumes { get; set; }
        public Resume SelectedResume { get; private set; }

        public SelectResumeForm()
        {
            Text = "Выбрать резюме";
            Width = 300;
            Height = 200;

            var resumesListBox = new ListBox
            {
                Location = new System.Drawing.Point(10, 10),
                Width = 260,
                Height = 150
            };

            var okButton = new Button
            {
                Text = "OK",
                Location = new System.Drawing.Point(10, 170),
                Width = 80
            };
            var cancelButton = new Button
            {
                Text = "Отмена",
                Location = new System.Drawing.Point(100, 170),
                Width = 80
            };

            okButton.Click += (sender, e) =>
            {
                if (resumesListBox.SelectedItem != null)
                {
                    SelectedResume = (Resume)resumesListBox.SelectedItem;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            };

            cancelButton.Click += (sender, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };

            Controls.Add(resumesListBox);
            Controls.Add(okButton);
            Controls.Add(cancelButton);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Resumes != null)
            {
                foreach (var resume in Resumes)
                {
                    ((ListBox)Controls[0]).Items.Add(resume);
                }
            }
        }
    }
}
