namespace LuckyDrawApp
{
    partial class frmLuckyDraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLuckyDraw));
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelFrame = new System.Windows.Forms.Panel();
            this.lblTicketNo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.panelFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmp
            // 
            this.wmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 0);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(705, 648);
            this.wmp.TabIndex = 0;
            this.wmp.Enter += new System.EventHandler(this.wmp_Enter);
            // 
            // panelFrame
            // 
            this.panelFrame.BackgroundImage = global::LuckyDrawApp.Properties.Resources.WinningNoFrame;
            this.panelFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFrame.Controls.Add(this.lblTicketNo);
            this.panelFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFrame.Location = new System.Drawing.Point(0, 0);
            this.panelFrame.Name = "panelFrame";
            this.panelFrame.Size = new System.Drawing.Size(705, 648);
            this.panelFrame.TabIndex = 2;
            // 
            // lblTicketNo
            // 
            this.lblTicketNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTicketNo.AutoSize = true;
            this.lblTicketNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTicketNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblTicketNo.Location = new System.Drawing.Point(177, 236);
            this.lblTicketNo.Name = "lblTicketNo";
            this.lblTicketNo.Size = new System.Drawing.Size(370, 79);
            this.lblTicketNo.TabIndex = 1;
            this.lblTicketNo.Text = "99999999";
            this.lblTicketNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLuckyDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(705, 648);
            this.Controls.Add(this.panelFrame);
            this.Controls.Add(this.wmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmLuckyDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lucky Draw App";
            this.Load += new System.EventHandler(this.frmLuckyDraw_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLuckyDraw_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.panelFrame.ResumeLayout(false);
            this.panelFrame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public AxWMPLib.AxWindowsMediaPlayer wmp;
        public System.Windows.Forms.Label lblTicketNo;
        public System.Windows.Forms.Panel panelFrame;
    }
}

