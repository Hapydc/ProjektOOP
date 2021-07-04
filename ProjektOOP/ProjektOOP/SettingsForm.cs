using DataLayer.Models;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektOOP
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void rbMaleChampionship_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemaleChampionship_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCroatian_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbEnglish_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ApplicationSettings applicationSettings = new ApplicationSettings();
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
             ApplicationSettingsService service = new ApplicationSettingsService();
            service.SaveAplicationSettings(applicationSettings);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            ApplicationSettingsService applicationSettingsService = new ApplicationSettingsService();
            ApplicationSettings applicationSettings =applicationSettingsService.GetAplicationSettings();
            if (applicationSettings == null)
            {
                return;
            }
            else
            {        
            if (applicationSettings.Championship==Championship.Male)
            {
                rbMaleChampionship.Checked=true;
            }
            else
            {
                rbFemaleChampionship.Checked = true;
            }
            if (applicationSettings.Language==Language.Croatian)
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
