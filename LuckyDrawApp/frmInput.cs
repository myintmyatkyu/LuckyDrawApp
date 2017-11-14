﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using System.Threading;
using System.Configuration;
using System.IO;

namespace LuckyDrawApp
{
    public partial class frmInput : Form
    {
        public frmLuckyDraw frmVideo;
       
        IWMPControls3 player;
        string url = System.Configuration.ConfigurationManager.AppSettings["VideoPath"].ToString();
        int carSeriaNo = 0;
        int bikeSerialNo = 0;
        int phoneSerialNo = 0;

        public frmInput()
        {
            InitializeComponent();
            frmVideo = new frmLuckyDraw();
            player= (IWMPControls3)frmVideo.wmp.Ctlcontrols;
            if(File.Exists("Cars.csv"))
            {
               String[] lines= File.ReadAllLines("Cars.csv");
               carSeriaNo = lines.Count();
               foreach(string s in lines)
               {
                   lbWinningNos.Items.Add(s);
               }
            }

            if (File.Exists("Bikes.csv"))
            {
                String[] lines = File.ReadAllLines("Bikes.csv");
                bikeSerialNo = lines.Count();
                foreach (string s in lines)
                {
                    lbMotorCycles.Items.Add(s);
                }
            }

            if (File.Exists("Phones.csv"))
            {
                String[] lines = File.ReadAllLines("Phones.csv");
                phoneSerialNo = lines.Count();
                foreach (string s in lines)
                {
                    lbIphones.Items.Add(s);
                }
            }
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            //frmVideo.panelFrame.Show();
            //player.stop();
            //frmVideo.panelFrame.BringToFront();
            //frmVideo.lblTicketNo.Text = txtTicketNo.Text;
            //frmVideo.lblTicketNo.Focus();
            frmCars.frmCar.RefreshNumber(1, txtCar_1.Text);

            
        }

        frmCars frmCar= new frmCars();
        private void cmdStart_Click(object sender, EventArgs e)
        {
            FormCollection frms = Application.OpenForms;
            foreach (Form f in frms)
            {
                if (f.Name == frmCar.Name)
                {
                    frmCar =(frmCars) f;
                }
                
            }
            if(frmCar.IsDisposed)
            {
                frmCar = new frmCars();
            }
            frmCar.Show();
            
        }


        private void frmInput_Load(object sender, EventArgs e)
        {
            //frmVideo.Refresh();
            //player.stop();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdAddToCars_Click(object sender, EventArgs e)
        {
            try
            {
                BackEnd.Save(currentNo,"car");
                lbWinningNos.Items.Add(currentNo);

                String[] lines= File.ReadAllLines("Cars.csv");
                carSeriaNo = lines.Count();

                frmCars.frmCar.AddToWinningList(currentNo, carSeriaNo);
                MessageBox.Show("Successfully save to winning list");
                cmdClear.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occurs when saving... \n" + ex.Message);
            }

        }

        List<string> bikes = new List<string>();
        private void cmdGenerateMotorCycles_Click(object sender, EventArgs e)
        {
            lbMotorCycles.Items.Clear();
            bikes = new List<string>();
            Random r = new Random();
            for(int i=0;i<30;i++)
            {
                int rInt = r.Next(1, 8000000); //for ints
                lbMotorCycles.Items.Add(FormatNumbers( rInt));
                bikes.Add(FormatNumbers(rInt));
            }
        }

        public string FormatNumbers(int i)
        {
            string no = i.ToString();
            while(no.Length<8)
            {
                no = "0" + no;
            }

            return no;
        }

        private void cmdGenerateIphones_Click(object sender, EventArgs e)
        {
            lbIphones.Items.Clear();
            Random r = new Random();
            for (int i = 0; i < 50; i++)
            {
                int rInt = r.Next(1, 8000000); //for ints
                lbIphones.Items.Add(FormatNumbers(rInt));
            }
        }

        private void txtCar_TextChanged(object sender, EventArgs e)
        {
            if (sender == txtCar_1)
            {
                frmCars.frmCar.RefreshNumber(1, txtCar_1.Text);
            }
            if (sender == txtCar_2)
            {
                frmCars.frmCar.RefreshNumber(2, txtCar_2.Text);
            }
            if (sender == txtCar_3)
            {
                frmCars.frmCar.RefreshNumber(3, txtCar_3.Text);
            }
            if (sender == txtCar_4)
            {
                frmCars.frmCar.RefreshNumber(4, txtCar_4.Text);
            }
            if (sender == txtCar_5)
            {
                frmCars.frmCar.RefreshNumber(5, txtCar_5.Text);
            }
            if (sender == txtCar_6)
            {
                frmCars.frmCar.RefreshNumber(6, txtCar_6.Text);
            }
            if (sender == txtCar_7)
            {
                frmCars.frmCar.RefreshNumber(7, txtCar_7.Text);
            }
        }

        private void txtBike_TextChanged(object sender, EventArgs e)
        {
            if (sender == txtBike1)
            {
                frmBikes.frmBike.RefreshNumber(1, txtBike1.Text);
            }
            if (sender == txtBike2)
            {
                frmBikes.frmBike.RefreshNumber(2, txtBike2.Text);
            }
            if (sender == txtBike3)
            {
                frmBikes.frmBike.RefreshNumber(3, txtBike3.Text);
            }
            if (sender == txtBike4)
            {
                frmBikes.frmBike.RefreshNumber(4, txtBike4.Text);
            }
            if (sender == txtBike5)
            {
                frmBikes.frmBike.RefreshNumber(5, txtBike5.Text);
            }
            if (sender == txtBike6)
            {
                frmBikes.frmBike.RefreshNumber(6, txtBike6.Text);
            }
            if (sender == txtBike7)
            {
                frmBikes.frmBike.RefreshNumber(7, txtBike7.Text);
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (sender == txtPh1)
            {
                frmPhones.frmPhone.RefreshNumber(1, txtPh1.Text);
            }
            if (sender == txtPh2)
            {
                frmPhones.frmPhone.RefreshNumber(2, txtPh2.Text);
            }
            if (sender == txtPh3)
            {
                frmPhones.frmPhone.RefreshNumber(3, txtPh3.Text);
            }
            if (sender == txtPh4)
            {
                frmPhones.frmPhone.RefreshNumber(4, txtPh4.Text);
            }
            if (sender == txtPh5)
            {
                frmPhones.frmPhone.RefreshNumber(5, txtPh5.Text);
            }
            if (sender == txtPh6)
            {
                frmPhones.frmPhone.RefreshNumber(6, txtPh6.Text);
            }
            if (sender == txtPh7)
            {
                frmPhones.frmPhone.RefreshNumber(7, txtPh7.Text);
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtCar_1.Clear();
            txtCar_2.Clear();
            txtCar_3.Clear();
            txtCar_4.Clear();
            txtCar_5.Clear();
            txtCar_6.Clear();
            txtCar_7.Clear();

            cmdAddToCars.Enabled = false;
            frmCars.frmCar.ClearText();
        }
        string currentNo = "";
        string currentType = "";
        private void cmdCheck_Click(object sender, EventArgs e)
        {
            currentNo = txtCar_1.Text.Trim() + txtCar_2.Text.Trim() + txtCar_3.Text.Trim() + txtCar_4.Text.Trim()+ txtCar_5.Text.Trim() + txtCar_6.Text.Trim() + txtCar_7.Text.Trim();
            cmdAddToCars.Enabled = false;
            currentType = "car";
            bgw.RunWorkerAsync();
        }
        bool isValid = false;
        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            isValid = BackEnd.isValid(currentNo);
            
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (isValid)
            {
                MessageBox.Show("The Winning No is Valid. Click Add to WinningNos to save");
                if(currentType=="car")
                {
                    cmdAddToCars.Enabled = true;
                    frmCars.frmCar.ShowCorect();
                }
                else if (currentType=="bike")
                {
                    cmdBikeAdd.Enabled = true;
                    frmBikes.frmBike.ShowCorect();
                }
                else if (currentType == "phone")
                {
                    cmdAddPhone.Enabled = true;
                    frmPhones.frmPhone.ShowCorect();
                }
                
                
            }
            else
            {
                MessageBox.Show("The Winning No is invalid. Please Clear and Redraw the ticket again.");
                if(currentType=="car")
                {
                    cmdAddToCars.Enabled = false;
                    frmCars.frmCar.ShowIncorrect();
                }
                else if (currentType=="bike")
                {
                    cmdBikeAdd.Enabled = false;
                    frmBikes.frmBike.ShowIncorrect();
                }
                else if (currentType == "phone")
                {
                    cmdAddPhone.Enabled = false;
                    frmPhones.frmPhone.ShowIncorrect();
                }
                
            }
        }

        string currentNo_Bike = "";
        frmBikes frmBike = new frmBikes();
        private void cmdStartBike_Click(object sender, EventArgs e)
        {
            FormCollection frms = Application.OpenForms;
            foreach (Form f in frms)
            {
                if (f.Name == frmBike.Name)
                {
                    frmBike = (frmBikes)f;
                }

            }
            if(frmBike.IsDisposed)
            {
                frmBike=new frmBikes();
            }
            frmBike.Show();
        }

        private void cmdBike_Check_Click(object sender, EventArgs e)
        {
            currentNo_Bike = txtBike1.Text.Trim() + txtBike2.Text.Trim() + txtBike3.Text.Trim() + txtBike4.Text.Trim() + txtBike5.Text.Trim() + txtBike6.Text.Trim() + txtBike7.Text.Trim();
            currentNo = currentNo_Bike;
            cmdBikeAdd.Enabled = false;
            currentType = "bike";
            bgw.RunWorkerAsync();
        }

        private void cmdBikeAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BackEnd.Save(currentNo, "bike");
                lbMotorCycles.Items.Add(currentNo);

                String[] lines = File.ReadAllLines("Bikes.csv");
                bikeSerialNo = lines.Count();

                frmBikes.frmBike.AddToWinningList(currentNo, bikeSerialNo);
                MessageBox.Show("Successfully save to winning list");
                cmdBikeClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs when saving... \n" + ex.Message);
            }
        }

        private void cmdBikeClear_Click(object sender, EventArgs e)
        {
            txtBike1.Clear();
            txtBike2.Clear();
            txtBike3.Clear();
            txtBike4.Clear();
            txtBike5.Clear();
            txtBike6.Clear();
            txtBike7.Clear();

            cmdBikeAdd.Enabled = false;
            frmBikes.frmBike.ClearText();
        }

        string currentNo_Phone = "";
        frmPhones frmPhone = new frmPhones();
        private void cmdStartPhone_Click(object sender, EventArgs e)
        {
            FormCollection frms = Application.OpenForms;
            foreach (Form f in frms)
            {
                if (f.Name == frmPhone.Name)
                {
                    frmPhone = (frmPhones)f;
                }

            }
            if(frmPhone.IsDisposed)
            {
                frmPhone = new frmPhones();
            }
            frmPhone.Show();
        }

        private void cmdCheckPhone_Click(object sender, EventArgs e)
        {
            currentNo_Phone = txtPh1.Text.Trim() + txtPh2.Text.Trim() + txtPh3.Text.Trim() + txtPh4.Text.Trim() + txtPh5.Text.Trim() + txtPh6.Text.Trim() + txtPh7.Text.Trim();
            currentNo = currentNo_Phone;
            cmdAddPhone.Enabled = false;
            currentType = "phone";
            bgw.RunWorkerAsync();
        }

        private void cmdAddPhone_Click(object sender, EventArgs e)
        {
            try
            {
                BackEnd.Save(currentNo_Phone, "phone");
                lbIphones.Items.Add(currentNo_Phone);

                String[] lines = File.ReadAllLines("Phones.csv");
                phoneSerialNo = lines.Count();

                frmPhones.frmPhone.AddToWinningList(currentNo, phoneSerialNo);
                MessageBox.Show("Successfully save to winning list");
                cmdPhoneClear.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs when saving... \n" + ex.Message);
            }
        }

        private void cmdPhoneClear_Click(object sender, EventArgs e)
        {
            txtPh1.Clear();
            txtPh2.Clear();
            txtPh3.Clear();
            txtPh4.Clear();
            txtPh5.Clear();
            txtPh6.Clear();
            txtPh7.Clear();

            cmdAddPhone.Enabled = false;
            frmPhones.frmPhone.ClearText();
        }

        private void cmdClose_Car_Click(object sender, EventArgs e)
        {
            frmCar.Close();
        }

        private void cmdClose_Bike_Click(object sender, EventArgs e)
        {
            frmBike.Close();
        }

        private void cmdClose_Phone_Click(object sender, EventArgs e)
        {
            frmPhone.Close();
        }

    }
}