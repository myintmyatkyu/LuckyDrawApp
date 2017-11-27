namespace LuckyDrawApp
{
    partial class frmInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdStart = new System.Windows.Forms.Button();
            this.txtCar_1 = new System.Windows.Forms.TextBox();
            this.cmdCheck = new System.Windows.Forms.Button();
            this.cmdAddToCars = new System.Windows.Forms.Button();
            this.lbWinningNos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblPhoneCurrent = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdClose_Phone = new System.Windows.Forms.Button();
            this.cmdPhoneClear = new System.Windows.Forms.Button();
            this.cmdAddPhone = new System.Windows.Forms.Button();
            this.cmdCheckPhone = new System.Windows.Forms.Button();
            this.txtPh7 = new System.Windows.Forms.TextBox();
            this.txtPh6 = new System.Windows.Forms.TextBox();
            this.cmdStartPhone = new System.Windows.Forms.Button();
            this.txtPh5 = new System.Windows.Forms.TextBox();
            this.cmdGenerateIphones = new System.Windows.Forms.Button();
            this.txtPh4 = new System.Windows.Forms.TextBox();
            this.cmdShowList_Phones = new System.Windows.Forms.Button();
            this.txtPh3 = new System.Windows.Forms.TextBox();
            this.lbIphones = new System.Windows.Forms.ListBox();
            this.txtPh2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPh1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblBikeCurrent = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdClose_Bike = new System.Windows.Forms.Button();
            this.txtBike7 = new System.Windows.Forms.TextBox();
            this.txtBike6 = new System.Windows.Forms.TextBox();
            this.txtBike5 = new System.Windows.Forms.TextBox();
            this.txtBike4 = new System.Windows.Forms.TextBox();
            this.txtBike3 = new System.Windows.Forms.TextBox();
            this.txtBike2 = new System.Windows.Forms.TextBox();
            this.txtBike1 = new System.Windows.Forms.TextBox();
            this.cmdBikeClear = new System.Windows.Forms.Button();
            this.cmdBikeAdd = new System.Windows.Forms.Button();
            this.cmdStartBike = new System.Windows.Forms.Button();
            this.cmdBike_Check = new System.Windows.Forms.Button();
            this.cmdGenerateBikes = new System.Windows.Forms.Button();
            this.cmdShowList_Bikes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMotorCycles = new System.Windows.Forms.ListBox();
            this.lblControl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCar_Current = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdShowList_Car = new System.Windows.Forms.Button();
            this.cmdClose_Car = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.txtCar_7 = new System.Windows.Forms.TextBox();
            this.txtCar_6 = new System.Windows.Forms.TextBox();
            this.txtCar_5 = new System.Windows.Forms.TextBox();
            this.txtCar_4 = new System.Windows.Forms.TextBox();
            this.txtCar_3 = new System.Windows.Forms.TextBox();
            this.txtCar_2 = new System.Windows.Forms.TextBox();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.BackColor = System.Drawing.Color.LightGreen;
            this.cmdStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStart.Location = new System.Drawing.Point(16, 24);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(79, 34);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = false;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // txtCar_1
            // 
            this.txtCar_1.Location = new System.Drawing.Point(16, 65);
            this.txtCar_1.MaxLength = 1;
            this.txtCar_1.Name = "txtCar_1";
            this.txtCar_1.Size = new System.Drawing.Size(36, 25);
            this.txtCar_1.TabIndex = 2;
            this.txtCar_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_1.TextChanged += new System.EventHandler(this.txtCar_TextChanged);
            this.txtCar_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // cmdCheck
            // 
            this.cmdCheck.BackColor = System.Drawing.Color.LightGreen;
            this.cmdCheck.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCheck.Location = new System.Drawing.Point(16, 96);
            this.cmdCheck.Name = "cmdCheck";
            this.cmdCheck.Size = new System.Drawing.Size(99, 34);
            this.cmdCheck.TabIndex = 9;
            this.cmdCheck.Text = "Check";
            this.cmdCheck.UseVisualStyleBackColor = false;
            this.cmdCheck.Click += new System.EventHandler(this.cmdCheck_Click);
            // 
            // cmdAddToCars
            // 
            this.cmdAddToCars.BackColor = System.Drawing.Color.LightGreen;
            this.cmdAddToCars.Enabled = false;
            this.cmdAddToCars.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdAddToCars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddToCars.Location = new System.Drawing.Point(129, 96);
            this.cmdAddToCars.Name = "cmdAddToCars";
            this.cmdAddToCars.Size = new System.Drawing.Size(119, 34);
            this.cmdAddToCars.TabIndex = 10;
            this.cmdAddToCars.Text = "Add to winning Nos";
            this.cmdAddToCars.UseVisualStyleBackColor = false;
            this.cmdAddToCars.Click += new System.EventHandler(this.cmdAddToCars_Click);
            // 
            // lbWinningNos
            // 
            this.lbWinningNos.FormattingEnabled = true;
            this.lbWinningNos.ItemHeight = 17;
            this.lbWinningNos.Location = new System.Drawing.Point(16, 156);
            this.lbWinningNos.Name = "lbWinningNos";
            this.lbWinningNos.Size = new System.Drawing.Size(330, 123);
            this.lbWinningNos.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Car Winning Nos :";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmdExit);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lblControl);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 741);
            this.panel1.TabIndex = 0;
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExit.BackColor = System.Drawing.Color.LightGreen;
            this.cmdExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Location = new System.Drawing.Point(705, 702);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(145, 34);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.lblPhoneCurrent);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmdClose_Phone);
            this.groupBox3.Controls.Add(this.cmdPhoneClear);
            this.groupBox3.Controls.Add(this.cmdAddPhone);
            this.groupBox3.Controls.Add(this.cmdCheckPhone);
            this.groupBox3.Controls.Add(this.txtPh7);
            this.groupBox3.Controls.Add(this.txtPh6);
            this.groupBox3.Controls.Add(this.cmdStartPhone);
            this.groupBox3.Controls.Add(this.txtPh5);
            this.groupBox3.Controls.Add(this.cmdGenerateIphones);
            this.groupBox3.Controls.Add(this.txtPh4);
            this.groupBox3.Controls.Add(this.cmdShowList_Phones);
            this.groupBox3.Controls.Add(this.txtPh3);
            this.groupBox3.Controls.Add(this.lbIphones);
            this.groupBox3.Controls.Add(this.txtPh2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtPh1);
            this.groupBox3.Location = new System.Drawing.Point(492, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 656);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IPhones";
            // 
            // lblPhoneCurrent
            // 
            this.lblPhoneCurrent.AutoSize = true;
            this.lblPhoneCurrent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneCurrent.Location = new System.Drawing.Point(331, 133);
            this.lblPhoneCurrent.Name = "lblPhoneCurrent";
            this.lblPhoneCurrent.Size = new System.Drawing.Size(15, 17);
            this.lblPhoneCurrent.TabIndex = 15;
            this.lblPhoneCurrent.Text = "0";
            this.lblPhoneCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(264, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Current :";
            // 
            // cmdClose_Phone
            // 
            this.cmdClose_Phone.BackColor = System.Drawing.Color.LightGreen;
            this.cmdClose_Phone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdClose_Phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose_Phone.Location = new System.Drawing.Point(267, 24);
            this.cmdClose_Phone.Name = "cmdClose_Phone";
            this.cmdClose_Phone.Size = new System.Drawing.Size(79, 34);
            this.cmdClose_Phone.TabIndex = 2;
            this.cmdClose_Phone.Text = "Close";
            this.cmdClose_Phone.UseVisualStyleBackColor = false;
            this.cmdClose_Phone.Click += new System.EventHandler(this.cmdClose_Phone_Click);
            // 
            // cmdPhoneClear
            // 
            this.cmdPhoneClear.BackColor = System.Drawing.Color.LightGreen;
            this.cmdPhoneClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdPhoneClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPhoneClear.Location = new System.Drawing.Point(267, 96);
            this.cmdPhoneClear.Name = "cmdPhoneClear";
            this.cmdPhoneClear.Size = new System.Drawing.Size(79, 34);
            this.cmdPhoneClear.TabIndex = 12;
            this.cmdPhoneClear.Text = "Clear";
            this.cmdPhoneClear.UseVisualStyleBackColor = false;
            this.cmdPhoneClear.Click += new System.EventHandler(this.cmdPhoneClear_Click);
            // 
            // cmdAddPhone
            // 
            this.cmdAddPhone.BackColor = System.Drawing.Color.LightGreen;
            this.cmdAddPhone.Enabled = false;
            this.cmdAddPhone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdAddPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddPhone.Location = new System.Drawing.Point(129, 96);
            this.cmdAddPhone.Name = "cmdAddPhone";
            this.cmdAddPhone.Size = new System.Drawing.Size(119, 34);
            this.cmdAddPhone.TabIndex = 11;
            this.cmdAddPhone.Text = "Add to winning Nos";
            this.cmdAddPhone.UseVisualStyleBackColor = false;
            this.cmdAddPhone.Click += new System.EventHandler(this.cmdAddPhone_Click);
            // 
            // cmdCheckPhone
            // 
            this.cmdCheckPhone.BackColor = System.Drawing.Color.LightGreen;
            this.cmdCheckPhone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdCheckPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCheckPhone.Location = new System.Drawing.Point(16, 96);
            this.cmdCheckPhone.Name = "cmdCheckPhone";
            this.cmdCheckPhone.Size = new System.Drawing.Size(99, 34);
            this.cmdCheckPhone.TabIndex = 10;
            this.cmdCheckPhone.Text = "Check";
            this.cmdCheckPhone.UseVisualStyleBackColor = false;
            this.cmdCheckPhone.Click += new System.EventHandler(this.cmdCheckPhone_Click);
            // 
            // txtPh7
            // 
            this.txtPh7.Location = new System.Drawing.Point(310, 64);
            this.txtPh7.MaxLength = 1;
            this.txtPh7.Name = "txtPh7";
            this.txtPh7.Size = new System.Drawing.Size(36, 25);
            this.txtPh7.TabIndex = 9;
            this.txtPh7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPh7.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPh7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // txtPh6
            // 
            this.txtPh6.Location = new System.Drawing.Point(261, 64);
            this.txtPh6.MaxLength = 1;
            this.txtPh6.Name = "txtPh6";
            this.txtPh6.Size = new System.Drawing.Size(36, 25);
            this.txtPh6.TabIndex = 8;
            this.txtPh6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPh6.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPh6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // cmdStartPhone
            // 
            this.cmdStartPhone.BackColor = System.Drawing.Color.LightGreen;
            this.cmdStartPhone.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdStartPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStartPhone.Location = new System.Drawing.Point(16, 24);
            this.cmdStartPhone.Name = "cmdStartPhone";
            this.cmdStartPhone.Size = new System.Drawing.Size(79, 34);
            this.cmdStartPhone.TabIndex = 0;
            this.cmdStartPhone.Text = "Start";
            this.cmdStartPhone.UseVisualStyleBackColor = false;
            this.cmdStartPhone.Click += new System.EventHandler(this.cmdStartPhone_Click);
            // 
            // txtPh5
            // 
            this.txtPh5.Location = new System.Drawing.Point(212, 64);
            this.txtPh5.MaxLength = 1;
            this.txtPh5.Name = "txtPh5";
            this.txtPh5.Size = new System.Drawing.Size(36, 25);
            this.txtPh5.TabIndex = 7;
            this.txtPh5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPh5.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPh5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // cmdGenerateIphones
            // 
            this.cmdGenerateIphones.BackColor = System.Drawing.Color.LightGreen;
            this.cmdGenerateIphones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdGenerateIphones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGenerateIphones.Location = new System.Drawing.Point(154, 24);
            this.cmdGenerateIphones.Name = "cmdGenerateIphones";
            this.cmdGenerateIphones.Size = new System.Drawing.Size(45, 34);
            this.cmdGenerateIphones.TabIndex = 1;
            this.cmdGenerateIphones.Text = "Generate Winning Nos";
            this.cmdGenerateIphones.UseVisualStyleBackColor = false;
            this.cmdGenerateIphones.Visible = false;
            this.cmdGenerateIphones.Click += new System.EventHandler(this.cmdGenerateIphones_Click);
            // 
            // txtPh4
            // 
            this.txtPh4.Location = new System.Drawing.Point(163, 64);
            this.txtPh4.MaxLength = 1;
            this.txtPh4.Name = "txtPh4";
            this.txtPh4.Size = new System.Drawing.Size(36, 25);
            this.txtPh4.TabIndex = 6;
            this.txtPh4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPh4.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPh4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // cmdShowList_Phones
            // 
            this.cmdShowList_Phones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdShowList_Phones.BackColor = System.Drawing.Color.LightGreen;
            this.cmdShowList_Phones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdShowList_Phones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdShowList_Phones.Location = new System.Drawing.Point(16, 605);
            this.cmdShowList_Phones.Name = "cmdShowList_Phones";
            this.cmdShowList_Phones.Size = new System.Drawing.Size(145, 34);
            this.cmdShowList_Phones.TabIndex = 17;
            this.cmdShowList_Phones.Text = "Show List";
            this.cmdShowList_Phones.UseVisualStyleBackColor = false;
            this.cmdShowList_Phones.Click += new System.EventHandler(this.cmdShowList_Phones_Click);
            // 
            // txtPh3
            // 
            this.txtPh3.Location = new System.Drawing.Point(114, 64);
            this.txtPh3.MaxLength = 1;
            this.txtPh3.Name = "txtPh3";
            this.txtPh3.Size = new System.Drawing.Size(36, 25);
            this.txtPh3.TabIndex = 5;
            this.txtPh3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPh3.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPh3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // lbIphones
            // 
            this.lbIphones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbIphones.FormattingEnabled = true;
            this.lbIphones.ItemHeight = 17;
            this.lbIphones.Location = new System.Drawing.Point(16, 156);
            this.lbIphones.Name = "lbIphones";
            this.lbIphones.Size = new System.Drawing.Size(330, 446);
            this.lbIphones.TabIndex = 16;
            // 
            // txtPh2
            // 
            this.txtPh2.Location = new System.Drawing.Point(65, 64);
            this.txtPh2.MaxLength = 1;
            this.txtPh2.Name = "txtPh2";
            this.txtPh2.Size = new System.Drawing.Size(36, 25);
            this.txtPh2.TabIndex = 4;
            this.txtPh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPh2.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPh2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "IPhone Winning Nos :";
            // 
            // txtPh1
            // 
            this.txtPh1.Location = new System.Drawing.Point(16, 64);
            this.txtPh1.MaxLength = 1;
            this.txtPh1.Name = "txtPh1";
            this.txtPh1.Size = new System.Drawing.Size(36, 25);
            this.txtPh1.TabIndex = 3;
            this.txtPh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPh1.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPh1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.lblBikeCurrent);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmdClose_Bike);
            this.groupBox2.Controls.Add(this.txtBike7);
            this.groupBox2.Controls.Add(this.txtBike6);
            this.groupBox2.Controls.Add(this.txtBike5);
            this.groupBox2.Controls.Add(this.txtBike4);
            this.groupBox2.Controls.Add(this.txtBike3);
            this.groupBox2.Controls.Add(this.txtBike2);
            this.groupBox2.Controls.Add(this.txtBike1);
            this.groupBox2.Controls.Add(this.cmdBikeClear);
            this.groupBox2.Controls.Add(this.cmdBikeAdd);
            this.groupBox2.Controls.Add(this.cmdStartBike);
            this.groupBox2.Controls.Add(this.cmdBike_Check);
            this.groupBox2.Controls.Add(this.cmdGenerateBikes);
            this.groupBox2.Controls.Add(this.cmdShowList_Bikes);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbMotorCycles);
            this.groupBox2.Location = new System.Drawing.Point(66, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 335);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motor Bikes";
            // 
            // lblBikeCurrent
            // 
            this.lblBikeCurrent.AutoSize = true;
            this.lblBikeCurrent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBikeCurrent.Location = new System.Drawing.Point(331, 135);
            this.lblBikeCurrent.Name = "lblBikeCurrent";
            this.lblBikeCurrent.Size = new System.Drawing.Size(15, 17);
            this.lblBikeCurrent.TabIndex = 15;
            this.lblBikeCurrent.Text = "0";
            this.lblBikeCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(264, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Current :";
            // 
            // cmdClose_Bike
            // 
            this.cmdClose_Bike.BackColor = System.Drawing.Color.LightGreen;
            this.cmdClose_Bike.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdClose_Bike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose_Bike.Location = new System.Drawing.Point(267, 24);
            this.cmdClose_Bike.Name = "cmdClose_Bike";
            this.cmdClose_Bike.Size = new System.Drawing.Size(79, 34);
            this.cmdClose_Bike.TabIndex = 2;
            this.cmdClose_Bike.Text = "Close";
            this.cmdClose_Bike.UseVisualStyleBackColor = false;
            this.cmdClose_Bike.Click += new System.EventHandler(this.cmdClose_Bike_Click);
            // 
            // txtBike7
            // 
            this.txtBike7.Location = new System.Drawing.Point(310, 67);
            this.txtBike7.MaxLength = 1;
            this.txtBike7.Name = "txtBike7";
            this.txtBike7.Size = new System.Drawing.Size(36, 25);
            this.txtBike7.TabIndex = 9;
            this.txtBike7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBike7.TextChanged += new System.EventHandler(this.txtBike_TextChanged);
            this.txtBike7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // txtBike6
            // 
            this.txtBike6.Location = new System.Drawing.Point(261, 67);
            this.txtBike6.MaxLength = 1;
            this.txtBike6.Name = "txtBike6";
            this.txtBike6.Size = new System.Drawing.Size(36, 25);
            this.txtBike6.TabIndex = 8;
            this.txtBike6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBike6.TextChanged += new System.EventHandler(this.txtBike_TextChanged);
            this.txtBike6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // txtBike5
            // 
            this.txtBike5.Location = new System.Drawing.Point(212, 67);
            this.txtBike5.MaxLength = 1;
            this.txtBike5.Name = "txtBike5";
            this.txtBike5.Size = new System.Drawing.Size(36, 25);
            this.txtBike5.TabIndex = 7;
            this.txtBike5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBike5.TextChanged += new System.EventHandler(this.txtBike_TextChanged);
            this.txtBike5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // txtBike4
            // 
            this.txtBike4.Location = new System.Drawing.Point(163, 67);
            this.txtBike4.MaxLength = 1;
            this.txtBike4.Name = "txtBike4";
            this.txtBike4.Size = new System.Drawing.Size(36, 25);
            this.txtBike4.TabIndex = 6;
            this.txtBike4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBike4.TextChanged += new System.EventHandler(this.txtBike_TextChanged);
            this.txtBike4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // txtBike3
            // 
            this.txtBike3.Location = new System.Drawing.Point(114, 67);
            this.txtBike3.MaxLength = 1;
            this.txtBike3.Name = "txtBike3";
            this.txtBike3.Size = new System.Drawing.Size(36, 25);
            this.txtBike3.TabIndex = 5;
            this.txtBike3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBike3.TextChanged += new System.EventHandler(this.txtBike_TextChanged);
            this.txtBike3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // txtBike2
            // 
            this.txtBike2.Location = new System.Drawing.Point(65, 67);
            this.txtBike2.MaxLength = 1;
            this.txtBike2.Name = "txtBike2";
            this.txtBike2.Size = new System.Drawing.Size(36, 25);
            this.txtBike2.TabIndex = 4;
            this.txtBike2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBike2.TextChanged += new System.EventHandler(this.txtBike_TextChanged);
            this.txtBike2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // txtBike1
            // 
            this.txtBike1.Location = new System.Drawing.Point(16, 67);
            this.txtBike1.MaxLength = 1;
            this.txtBike1.Name = "txtBike1";
            this.txtBike1.Size = new System.Drawing.Size(36, 25);
            this.txtBike1.TabIndex = 3;
            this.txtBike1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBike1.TextChanged += new System.EventHandler(this.txtBike_TextChanged);
            this.txtBike1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // cmdBikeClear
            // 
            this.cmdBikeClear.BackColor = System.Drawing.Color.LightGreen;
            this.cmdBikeClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdBikeClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBikeClear.Location = new System.Drawing.Point(267, 98);
            this.cmdBikeClear.Name = "cmdBikeClear";
            this.cmdBikeClear.Size = new System.Drawing.Size(79, 34);
            this.cmdBikeClear.TabIndex = 12;
            this.cmdBikeClear.Text = "Clear";
            this.cmdBikeClear.UseVisualStyleBackColor = false;
            this.cmdBikeClear.Click += new System.EventHandler(this.cmdBikeClear_Click);
            // 
            // cmdBikeAdd
            // 
            this.cmdBikeAdd.BackColor = System.Drawing.Color.LightGreen;
            this.cmdBikeAdd.Enabled = false;
            this.cmdBikeAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdBikeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBikeAdd.Location = new System.Drawing.Point(129, 98);
            this.cmdBikeAdd.Name = "cmdBikeAdd";
            this.cmdBikeAdd.Size = new System.Drawing.Size(119, 34);
            this.cmdBikeAdd.TabIndex = 11;
            this.cmdBikeAdd.Text = "Add to winning Nos";
            this.cmdBikeAdd.UseVisualStyleBackColor = false;
            this.cmdBikeAdd.Click += new System.EventHandler(this.cmdBikeAdd_Click);
            // 
            // cmdStartBike
            // 
            this.cmdStartBike.BackColor = System.Drawing.Color.LightGreen;
            this.cmdStartBike.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdStartBike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdStartBike.Location = new System.Drawing.Point(16, 24);
            this.cmdStartBike.Name = "cmdStartBike";
            this.cmdStartBike.Size = new System.Drawing.Size(79, 34);
            this.cmdStartBike.TabIndex = 0;
            this.cmdStartBike.Text = "Start";
            this.cmdStartBike.UseVisualStyleBackColor = false;
            this.cmdStartBike.Click += new System.EventHandler(this.cmdStartBike_Click);
            // 
            // cmdBike_Check
            // 
            this.cmdBike_Check.BackColor = System.Drawing.Color.LightGreen;
            this.cmdBike_Check.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdBike_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBike_Check.Location = new System.Drawing.Point(16, 98);
            this.cmdBike_Check.Name = "cmdBike_Check";
            this.cmdBike_Check.Size = new System.Drawing.Size(99, 34);
            this.cmdBike_Check.TabIndex = 10;
            this.cmdBike_Check.Text = "Check";
            this.cmdBike_Check.UseVisualStyleBackColor = false;
            this.cmdBike_Check.Click += new System.EventHandler(this.cmdBike_Check_Click);
            // 
            // cmdGenerateBikes
            // 
            this.cmdGenerateBikes.BackColor = System.Drawing.Color.LightGreen;
            this.cmdGenerateBikes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdGenerateBikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGenerateBikes.Location = new System.Drawing.Point(129, 24);
            this.cmdGenerateBikes.Name = "cmdGenerateBikes";
            this.cmdGenerateBikes.Size = new System.Drawing.Size(49, 34);
            this.cmdGenerateBikes.TabIndex = 1;
            this.cmdGenerateBikes.Text = "Generate Winning Nos";
            this.cmdGenerateBikes.UseVisualStyleBackColor = false;
            this.cmdGenerateBikes.Visible = false;
            this.cmdGenerateBikes.Click += new System.EventHandler(this.cmdGenerateMotorCycles_Click);
            // 
            // cmdShowList_Bikes
            // 
            this.cmdShowList_Bikes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdShowList_Bikes.BackColor = System.Drawing.Color.LightGreen;
            this.cmdShowList_Bikes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdShowList_Bikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdShowList_Bikes.Location = new System.Drawing.Point(16, 284);
            this.cmdShowList_Bikes.Name = "cmdShowList_Bikes";
            this.cmdShowList_Bikes.Size = new System.Drawing.Size(145, 34);
            this.cmdShowList_Bikes.TabIndex = 17;
            this.cmdShowList_Bikes.Text = "Show List";
            this.cmdShowList_Bikes.UseVisualStyleBackColor = false;
            this.cmdShowList_Bikes.Click += new System.EventHandler(this.cmdShowList_Bikes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mortor Bikes Winning Nos :";
            // 
            // lbMotorCycles
            // 
            this.lbMotorCycles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMotorCycles.FormattingEnabled = true;
            this.lbMotorCycles.ItemHeight = 17;
            this.lbMotorCycles.Location = new System.Drawing.Point(16, 155);
            this.lbMotorCycles.Name = "lbMotorCycles";
            this.lbMotorCycles.Size = new System.Drawing.Size(330, 123);
            this.lbMotorCycles.TabIndex = 16;
            // 
            // lblControl
            // 
            this.lblControl.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblControl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.ForeColor = System.Drawing.Color.Black;
            this.lblControl.Location = new System.Drawing.Point(0, 0);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(914, 40);
            this.lblControl.TabIndex = 0;
            this.lblControl.Text = "Control Panel";
            this.lblControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.lblCar_Current);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmdShowList_Car);
            this.groupBox1.Controls.Add(this.cmdClose_Car);
            this.groupBox1.Controls.Add(this.cmdClear);
            this.groupBox1.Controls.Add(this.txtCar_7);
            this.groupBox1.Controls.Add(this.txtCar_6);
            this.groupBox1.Controls.Add(this.txtCar_5);
            this.groupBox1.Controls.Add(this.txtCar_4);
            this.groupBox1.Controls.Add(this.txtCar_3);
            this.groupBox1.Controls.Add(this.txtCar_2);
            this.groupBox1.Controls.Add(this.cmdStart);
            this.groupBox1.Controls.Add(this.cmdAddToCars);
            this.groupBox1.Controls.Add(this.cmdCheck);
            this.groupBox1.Controls.Add(this.txtCar_1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbWinningNos);
            this.groupBox1.Location = new System.Drawing.Point(66, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cars";
            // 
            // lblCar_Current
            // 
            this.lblCar_Current.AutoSize = true;
            this.lblCar_Current.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar_Current.Location = new System.Drawing.Point(331, 133);
            this.lblCar_Current.Name = "lblCar_Current";
            this.lblCar_Current.Size = new System.Drawing.Size(15, 17);
            this.lblCar_Current.TabIndex = 14;
            this.lblCar_Current.Text = "0";
            this.lblCar_Current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Current :";
            // 
            // cmdShowList_Car
            // 
            this.cmdShowList_Car.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdShowList_Car.BackColor = System.Drawing.Color.LightGreen;
            this.cmdShowList_Car.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdShowList_Car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdShowList_Car.Location = new System.Drawing.Point(16, 284);
            this.cmdShowList_Car.Name = "cmdShowList_Car";
            this.cmdShowList_Car.Size = new System.Drawing.Size(145, 34);
            this.cmdShowList_Car.TabIndex = 16;
            this.cmdShowList_Car.Text = "Show List";
            this.cmdShowList_Car.UseVisualStyleBackColor = false;
            this.cmdShowList_Car.Click += new System.EventHandler(this.cmdShowList_Car_Click);
            // 
            // cmdClose_Car
            // 
            this.cmdClose_Car.BackColor = System.Drawing.Color.LightGreen;
            this.cmdClose_Car.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdClose_Car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose_Car.Location = new System.Drawing.Point(267, 24);
            this.cmdClose_Car.Name = "cmdClose_Car";
            this.cmdClose_Car.Size = new System.Drawing.Size(79, 34);
            this.cmdClose_Car.TabIndex = 1;
            this.cmdClose_Car.Text = "Close";
            this.cmdClose_Car.UseVisualStyleBackColor = false;
            this.cmdClose_Car.Click += new System.EventHandler(this.cmdClose_Car_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.BackColor = System.Drawing.Color.LightGreen;
            this.cmdClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClear.Location = new System.Drawing.Point(267, 96);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(79, 34);
            this.cmdClear.TabIndex = 11;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = false;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // txtCar_7
            // 
            this.txtCar_7.Location = new System.Drawing.Point(310, 65);
            this.txtCar_7.MaxLength = 1;
            this.txtCar_7.Name = "txtCar_7";
            this.txtCar_7.Size = new System.Drawing.Size(36, 25);
            this.txtCar_7.TabIndex = 8;
            this.txtCar_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_7.TextChanged += new System.EventHandler(this.txtCar_TextChanged);
            this.txtCar_7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // txtCar_6
            // 
            this.txtCar_6.Location = new System.Drawing.Point(261, 65);
            this.txtCar_6.MaxLength = 1;
            this.txtCar_6.Name = "txtCar_6";
            this.txtCar_6.Size = new System.Drawing.Size(36, 25);
            this.txtCar_6.TabIndex = 7;
            this.txtCar_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_6.TextChanged += new System.EventHandler(this.txtCar_TextChanged);
            this.txtCar_6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // txtCar_5
            // 
            this.txtCar_5.Location = new System.Drawing.Point(212, 65);
            this.txtCar_5.MaxLength = 1;
            this.txtCar_5.Name = "txtCar_5";
            this.txtCar_5.Size = new System.Drawing.Size(36, 25);
            this.txtCar_5.TabIndex = 6;
            this.txtCar_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_5.TextChanged += new System.EventHandler(this.txtCar_TextChanged);
            this.txtCar_5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // txtCar_4
            // 
            this.txtCar_4.Location = new System.Drawing.Point(163, 65);
            this.txtCar_4.MaxLength = 1;
            this.txtCar_4.Name = "txtCar_4";
            this.txtCar_4.Size = new System.Drawing.Size(36, 25);
            this.txtCar_4.TabIndex = 5;
            this.txtCar_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_4.TextChanged += new System.EventHandler(this.txtCar_TextChanged);
            this.txtCar_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // txtCar_3
            // 
            this.txtCar_3.Location = new System.Drawing.Point(114, 65);
            this.txtCar_3.MaxLength = 1;
            this.txtCar_3.Name = "txtCar_3";
            this.txtCar_3.Size = new System.Drawing.Size(36, 25);
            this.txtCar_3.TabIndex = 4;
            this.txtCar_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_3.TextChanged += new System.EventHandler(this.txtCar_TextChanged);
            this.txtCar_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // txtCar_2
            // 
            this.txtCar_2.Location = new System.Drawing.Point(65, 65);
            this.txtCar_2.MaxLength = 1;
            this.txtCar_2.Name = "txtCar_2";
            this.txtCar_2.Size = new System.Drawing.Size(36, 25);
            this.txtCar_2.TabIndex = 3;
            this.txtCar_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCar_2.TextChanged += new System.EventHandler(this.txtCar_TextChanged);
            this.txtCar_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCar_KeyDown);
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // frmInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 741);
            this.Controls.Add(this.panel1);
            this.Name = "frmInput";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInput_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.TextBox txtCar_1;
        private System.Windows.Forms.Button cmdCheck;
        private System.Windows.Forms.Button cmdAddToCars;
        private System.Windows.Forms.ListBox lbWinningNos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbMotorCycles;
        private System.Windows.Forms.ListBox lbIphones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdStartBike;
        private System.Windows.Forms.Button cmdGenerateBikes;
        private System.Windows.Forms.Button cmdShowList_Bikes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdGenerateIphones;
        private System.Windows.Forms.Button cmdShowList_Phones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdStartPhone;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.TextBox txtCar_7;
        private System.Windows.Forms.TextBox txtCar_6;
        private System.Windows.Forms.TextBox txtCar_5;
        private System.Windows.Forms.TextBox txtCar_4;
        private System.Windows.Forms.TextBox txtCar_3;
        private System.Windows.Forms.TextBox txtCar_2;
        private System.Windows.Forms.Button cmdClear;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.TextBox txtBike7;
        private System.Windows.Forms.TextBox txtBike6;
        private System.Windows.Forms.TextBox txtBike5;
        private System.Windows.Forms.TextBox txtBike4;
        private System.Windows.Forms.TextBox txtBike3;
        private System.Windows.Forms.TextBox txtBike2;
        private System.Windows.Forms.TextBox txtBike1;
        private System.Windows.Forms.Button cmdBikeClear;
        private System.Windows.Forms.Button cmdBikeAdd;
        private System.Windows.Forms.Button cmdBike_Check;
        private System.Windows.Forms.Button cmdPhoneClear;
        private System.Windows.Forms.Button cmdAddPhone;
        private System.Windows.Forms.Button cmdCheckPhone;
        private System.Windows.Forms.TextBox txtPh7;
        private System.Windows.Forms.TextBox txtPh6;
        private System.Windows.Forms.TextBox txtPh5;
        private System.Windows.Forms.TextBox txtPh4;
        private System.Windows.Forms.TextBox txtPh3;
        private System.Windows.Forms.TextBox txtPh2;
        private System.Windows.Forms.TextBox txtPh1;
        private System.Windows.Forms.Button cmdClose_Car;
        private System.Windows.Forms.Button cmdClose_Bike;
        private System.Windows.Forms.Button cmdClose_Phone;
        private System.Windows.Forms.Button cmdShowList_Car;
        private System.Windows.Forms.Label lblCar_Current;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPhoneCurrent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblBikeCurrent;
        private System.Windows.Forms.Label label6;
    }
}