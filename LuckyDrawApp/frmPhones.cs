using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LuckyDrawApp
{
    public partial class frmPhones : Form
    {
        string url = System.Configuration.ConfigurationManager.AppSettings["PhoneVideoPath"].ToString();
        public static frmPhones frmPhone;
        Image bgImage = global::LuckyDrawApp.Properties.Resources.star;
        Image correctImage = global::LuckyDrawApp.Properties.Resources.Correct;
        Image incorrectImage = global::LuckyDrawApp.Properties.Resources.Incorrect;
        public frmPhones()
        {
            InitializeComponent();
            frmPhone = this;
            foreach (Control c in this.Controls)
            { 
                if(c.Name.IndexOf("lblWin")>=0)
                {
                    c.Visible = false;
                }
            }
            panelStatus.BackgroundImage = null;
            
        }

        private void frmCars_Load(object sender, EventArgs e)
        {
            ClearText();
            if (Screen.AllScreens.Length > 0)
            {
                Screen secondScreen = Screen.AllScreens.Where(i => i.Primary == true).ToList()[0];
                Rectangle bounds = secondScreen.Bounds;
                this.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                this.StartPosition = FormStartPosition.Manual;
            }
            this.wmPlayer.URL = url;
            this.wmPlayer.Dock = DockStyle.Fill;

            if(File.Exists("Phones.csv"))
            {
                String[] lines = File.ReadAllLines("Phones.csv");
                int no = 1;
                foreach (string s in lines)
                {
                    this.AddToWinningList(s, no);
                    no++;
                }
            }  
        }

        public void RefreshNumber(int textboxNumber, string value)
        {
            if (textboxNumber == 1)
            {
                lblNo_1.Text = value;
                if (value == "")
                {
                    this.p1.BackgroundImage = bgImage;
                }
                else
                {
                    p1.BackgroundImage = null;
                }
                lblNo_1.Visible = true;
            }

            if (textboxNumber == 2)
            {
                lblNo_2.Text = value;
                if (value == "")
                {
                    this.p2.BackgroundImage = bgImage;
                }
                else
                {
                    p2.BackgroundImage = null;
                }
                lblNo_2.Visible = true;
            }

            if (textboxNumber == 3)
            {
                lblNo_3.Text = value;
                if (value == "")
                {
                    this.p3.BackgroundImage = bgImage;
                }
                else
                {
                    p3.BackgroundImage = null;
                }
                lblNo_3.Visible = true;
            }


            if (textboxNumber == 4)
            {
                lblNo_4.Text = value;
                if (value == "")
                {
                    this.p4.BackgroundImage = bgImage;
                }
                else
                {
                    p4.BackgroundImage = null;
                }
                lblNo_4.Visible = true;
            }

            if (textboxNumber == 5)
            {
                lblNo_5.Text = value;
                if (value == "")
                {
                    this.p5.BackgroundImage = bgImage;
                }
                else
                {
                    p5.BackgroundImage = null;
                }
                lblNo_5.Visible = true;
            }

            if (textboxNumber == 6)
            {
                lblNo_6.Text = value;
                if (value == "")
                {
                    this.p6.BackgroundImage = bgImage;
                }
                else
                {
                    p6.BackgroundImage = null;
                }
                lblNo_6.Visible = true;
            }

            if (textboxNumber == 7)
            {
                lblNo_7.Text = value;
                if (value == "")
                {
                    this.p7.BackgroundImage = bgImage;
                }
                else
                {
                    p7.BackgroundImage = null;
                }
                lblNo_7.Visible = true;
            }

        }

        public void AddToWinningList(string winningNo,int serialNo)
        {
            var css= this.Controls.Find("lblWin" + serialNo.ToString(),false);
            foreach(Control c in css)
            {
                c.Text = winningNo;
                c.Visible = true;
            }
            ClearText();
        }

        public void ShowCorect()
        {
            panelStatus.BackgroundImage = correctImage;
        }

        public void ShowIncorrect()
        {
            panelStatus.BackgroundImage = incorrectImage;
        }
        public void ClearText()
        {
            lblNo_1.Text = "";
            lblNo_2.Text = "";
            lblNo_3.Text = "";
            lblNo_4.Text = "";
            lblNo_5.Text = "";
            lblNo_6.Text = "";
            lblNo_7.Text = "";

            p1.BackgroundImage = bgImage;
            p2.BackgroundImage = bgImage;
            p3.BackgroundImage = bgImage;
            p4.BackgroundImage = bgImage;
            p5.BackgroundImage = bgImage;
            p6.BackgroundImage = bgImage;
            p7.BackgroundImage = bgImage;
            panelStatus.BackgroundImage = null;
        }

    }
}
