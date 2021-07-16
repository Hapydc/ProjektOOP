using DataLayer.Models;
using DataLayer.Services;
using System;
using System.Windows.Forms;

namespace ProjektOOP
{

    public partial class SettingsForm : Form
    {
        public ApplicationSettingsService service = new ApplicationSettingsService();
        public ApplicationSettings applicationSettings = new ApplicationSettings();
        public SettingsForm()
        {
            InitializeComponent();
            TranslateForm();
        }

        private void TranslateForm()
        {
            this.Text = TranslationService.GetTranslationByKey("settings");
            lblLanguage.Text = TranslationService.GetTranslationByKey("chooseLanguage");
            lblGender.Text = TranslationService.GetTranslationByKey("chooseGender");
            rbMaleChampionship.Text = TranslationService.GetTranslationByKey("maleChampionship");
            rbFemaleChampionship.Text = TranslationService.GetTranslationByKey("femaleChampionship");
            rbCroatian.Text = TranslationService.GetTranslationByKey("croatianLanguage");
            rbEnglish.Text = TranslationService.GetTranslationByKey("englishLanguage");
            btnSubmit.Text = TranslationService.GetTranslationByKey("submit");
            btnCancel.Text = TranslationService.GetTranslationByKey("cancel");
        }
      
        private void btnSubmit_Click(object sender, EventArgs e)
        {       
            if (!rbCroatian.Checked && !rbEnglish.Checked)
            {
                MessageBox.Show(TranslationService.GetTranslationByKey("languageIsMandatory"));

                return;
            }

            if (!rbMaleChampionship.Checked && !rbFemaleChampionship.Checked)
            {
                MessageBox.Show(TranslationService.GetTranslationByKey("genderIsMandatory"));

                return;
            }

            if (rbCroatian.Checked)
            {
                applicationSettings.Language = Language.Croatian;
            }
            else
            {
                applicationSettings.Language = Language.English;
            }
            if (rbMaleChampionship.Checked)
            {
                applicationSettings.Championship = Championship.Male;
            }
            else
            {
                applicationSettings.Championship = Championship.Female;
            }
            service.SaveAplicationSettings(applicationSettings);
            this.DialogResult = DialogResult.OK;
            this.Close();          
        }
        private void OnClose(object sender, FormClosedEventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ApplicationSettingsService applicationSettingsService = new ApplicationSettingsService();
            ApplicationSettings applicationSettings = applicationSettingsService.GetAplicationSettings();
            if (applicationSettings == null)
            {
                return;
            }
            else
            {
                if (applicationSettings.Championship == Championship.Male)
                {
                    rbMaleChampionship.Checked = true;
                }
                else
                {
                    rbFemaleChampionship.Checked = true;
                }
                if (applicationSettings.Language == Language.Croatian)
                {
                    rbCroatian.Checked = true;
                }
                else
                {
                    rbEnglish.Checked = true;
                }
            }
        }
    }
}
