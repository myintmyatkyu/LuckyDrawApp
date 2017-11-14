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
    public partial class frmLuckyDraw : Form
    {
        public frmLuckyDraw()
        {
            InitializeComponent();
            lblTicketNo.Text = "";   
        }

        private void frmLuckyDraw_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.F1)
            {
                new frmInput().Show();
            }
        }

        private void frmLuckyDraw_Load(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length > 0)
            {
                Screen secondScreen = Screen.AllScreens.Where(i => i.Primary != true).ToList()[0];
                Rectangle bounds = secondScreen.Bounds;
                this.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                this.StartPosition = FormStartPosition.Manual;
            }
            panelFrame.BringToFront();
        }

        private void wmp_Enter(object sender, EventArgs e)
        {

        }
    }
}
