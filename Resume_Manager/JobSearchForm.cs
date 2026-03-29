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
    public partial class JobSearchForm : Form
    {
        private JobSearchManager jobSearchManager;
        private Button createResumeButton;
        private Button addSkillButton;
        private Button addWorkExperienceButton;
        private Button addEducationButton;
        private Button displayResumeButton;
        private Button addJobListingButton;
        private Button searchJobListingsButton;

        public JobSearchForm()
        {
            Text = "Управление резюме и поиском работы";
            Width = 400;
            Height = 250;
            CreateControls();
            jobSearchManager = new JobSearchManager();
        }

        private void CreateControls()
        {
            createResumeButton = new Button
            {
                Location = new System.Drawing.Point(10, 20),
                Text = "Создать резюме",
                Size = new System.Drawing.Size(120, 25)
            };
            createResumeButton.Click += (sender, e) => jobSearchManager.CreateResume();

            addSkillButton = new Button
            {
                Location = new System.Drawing.Point(140, 20),
                Text = "Добавить навык",
                Size = new System.Drawing.Size(100, 25)
            };
            addSkillButton.Click += (sender, e) => jobSearchManager.AddSkillToResume();

            addWorkExperienceButton = new Button
            {
                Location = new System.Drawing.Point(250, 20),
                Text = "Добавить опыт",
                Size = new System.Drawing.Size(120, 25)
            };
            addWorkExperienceButton.Click += (sender, e) => jobSearchManager.AddWorkExperienceToResume();

            addEducationButton = new Button
            {
                Location = new System.Drawing.Point(10, 50),
                Text = "Добавить образование",
                Size = new System.Drawing.Size(120, 25)
            };
            addEducationButton.Click += (sender, e) => jobSearchManager.AddEducationToResume();

            displayResumeButton = new Button
            {
                Location = new System.Drawing.Point(140, 50),
                Text = "Показать резюме",
                Size = new System.Drawing.Size(100, 25)
            };
            displayResumeButton.Click += (sender, e) => jobSearchManager.DisplayResume();

            addJobListingButton = new Button
            {
                Location = new System.Drawing.Point(250, 50),
                Text = "Добавить вакансию",
                Size = new System.Drawing.Size(100, 25)
            };
            addJobListingButton.Click += (sender, e) => jobSearchManager.AddJobListing();

            searchJobListingsButton = new Button
            {
                Location = new System.Drawing.Point(10, 80),
                Text = "Поиск вакансий",
                Size = new System.Drawing.Size(120, 25)
            };
            searchJobListingsButton.Click += (sender, e) => jobSearchManager.SearchJobListings();

            this.Controls.Add(createResumeButton);
            this.Controls.Add(addSkillButton);
            this.Controls.Add(addWorkExperienceButton);
            this.Controls.Add(addEducationButton);
            this.Controls.Add(displayResumeButton);
            this.Controls.Add(addJobListingButton);
            this.Controls.Add(searchJobListingsButton);
        }
    }
}
