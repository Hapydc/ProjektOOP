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
using System.Drawing.Printing;

namespace ProjektOOP
{
    
    public partial class GamesInfoForm : Form
    {
        private PrintDocument printDocument;
        DataService service = new DataService();
        public GamesInfoForm()
        {
            InitializeComponent();
            GetInfo();
        }

        public async void GetInfo()
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
            List<GamesInfo> gamesInfo = new List<GamesInfo>();

            var loadingForm = new LoadingForm();
            loadingForm.Show();
            await Task.Run(async () =>
            {
                gamesInfo = await service.GetGamesInfo();
            });
            loadingForm.Close();

            List<GamesInfo> sortedGamesInfo = gamesInfo.OrderBy(i => i.Visitors).Reverse().ToList();
            foreach (var info in sortedGamesInfo)
            {
                dataTable.Rows.Add(info.Location, info.Visitors, info.HomeTeam, info.AwayTeam);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument = new PrintDocument();
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.ShowDialog();
        }
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var x = e.MarginBounds.Left;
            var y = e.MarginBounds.Top;
            var bmp = new Bitmap(this.Size.Width, this.Size.Height);
  
            this.DrawToBitmap(bmp, new Rectangle
            {
                X = 0,
                Y = 0,
                Width = this.Size.Width,
                Height = this.Size.Height
            });
            e.Graphics.DrawImage(bmp, x, y);
        }
    }
}
