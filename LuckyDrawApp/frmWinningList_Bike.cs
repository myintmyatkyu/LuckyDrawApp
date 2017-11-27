using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LuckyDrawApp
{
    public partial class frmWinningList_Bike : Form
    {
        string url = System.Configuration.ConfigurationManager.AppSettings["BikePath_WinnerList"].ToString();
        public frmWinningList_Bike(string title, DataSet ds)
        {
            InitializeComponent();
            //this.lblTitle.Text = title;
            dgv.DataSource = ds.Tables[0];
            dgv2.DataSource = ds.Tables[1];
        }

        private void frmWinningList_Load(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length > 0)
            {
                Screen secondScreen = Screen.AllScreens.Where(i => i.Primary != true).ToList()[0];
                Rectangle bounds = secondScreen.Bounds;
                this.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                this.StartPosition = FormStartPosition.Manual;
            }
            dgv.ClearSelection();
            dgv2.ClearSelection();
            wmPlayer.URL = url;
            this.wmPlayer.Dock = DockStyle.Fill;
        }

        private void frmWinningList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
