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
    public partial class GamesInfoForm : Form
    {
        DataService service = new DataService();
        public GamesInfoForm()
        {
            InitializeComponent();
            GetInfo();
        }

        public void GetInfo()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(
                new DataColumn[4]
                {
                    new DataColumn("Lokacija",typeof(string)),
                    new DataColumn("Broj posjetitelja",typeof(string)),
                    new DataColumn("Domaci tim",typeof(string)),
                    new DataColumn("Gostujuci tim",typeof(string))
                }
                );
            dataGridView1.DataSource = dataTable;

            List<GamesInfo> gamesInfo = service.GetGamesInfo();
            List<GamesInfo> sortedGamesInfo = gamesInfo.OrderBy(i => i.Visitors).Reverse().ToList();
            foreach (var info in sortedGamesInfo)
            {
                dataTable.Rows.Add(info.Location, info.Visitors, info.HomeTeam, info.AwayTeam);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
