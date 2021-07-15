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
        public ApplicationSettingsService service = new ApplicationSettingsService();
        public ApplicationSettings applicationSettings = new ApplicationSettings();
        public SettingsForm()
        {
            InitializeComponent();
        }
      
        private void btnSubmit_Click(object sender, EventArgs e)
        {         
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
            this.Close();          
        }
        private void OnClose(object sender, FormClosedEventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
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
