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
    public partial class frmWinningList : Form
    {
        public frmWinningList(string title,DataTable dt)
        {
            InitializeComponent();
            this.lblTitle.Text = title;
            dgv.DataSource = dt;
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
        }
    }
}
