using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Services
{
    public class ApplicationSettingsService
    {
        private string ApplicationSettingsFile = @"ApplicationSettings.txt";
        const string male = "Male";
        const string female = "Female";
        const string english = "English";
        const string croatian = "Croatian";

        public ApplicationSettings GetAplicationSettings()
        {
            ApplicationSettings applicationSettings = new ApplicationSettings();

            if (File.Exists(ApplicationSettingsFile))
            {
                string[] lines = File.ReadAllLines(ApplicationSettingsFile);
                if (lines[0] == male)
                {
                    applicationSettings.Championship = Championship.Male;
                }
                else
                {
                    applicationSettings.Championship = Championship.Female;
                }
                if (lines[1] == english)
                {
                    applicationSettings.Language = Language.English;
                }
                else
                {
                    applicationSettings.Language = Language.Croatian;
                }
                return applicationSettings;
            }
            else
            {
                return null;
            }
        }
        public bool SaveAplicationSettings(ApplicationSettings applicationSettings)
        {
            string championship;
            string language;
            if (applicationSettings.Championship == Championship.Male)
            {
                championship = male;
            }
            else
            {
                championship = female;
            }
            if (applicationSettings.Language == Language.English)
            {
                language = english;
            }
            else
            {
                language = croatian;
            }
            string[] lines =
            {
                championship,
                language
            };
            File.WriteAllLines(ApplicationSettingsFile, lines);
            return true;
        }
    }
}
