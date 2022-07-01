namespace Contact_Tracing__updated_
{
    partial class ContactTracingF2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTracingF2));
            this.CTtimer1 = new System.Windows.Forms.Timer(this.components);
            this.CTbtnScan = new System.Windows.Forms.Button();
            this.CTasterterisk6 = new System.Windows.Forms.Label();
            this.CTasterterisk5 = new System.Windows.Forms.Label();
            this.CTlabelAbout12 = new System.Windows.Forms.Label();
            this.CTlabelAbout11 = new System.Windows.Forms.Label();
            this.CTTitle4 = new System.Windows.Forms.Label();
            this.CTTitle3 = new System.Windows.Forms.Label();
            this.CTpicbox2 = new System.Windows.Forms.PictureBox();
            this.CTbtnOpen = new System.Windows.Forms.Button();
            this.TxtBoxQR = new System.Windows.Forms.TextBox();
            this.CTbtnNext2 = new System.Windows.Forms.Button();
            this.CTpicboxQR = new System.Windows.Forms.PictureBox();
            this.CTcboxCamera = new System.Windows.Forms.ComboBox();
            this.CTLabelCamera = new System.Windows.Forms.Label();
            this.CTpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CTpicbox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTpicboxQR)).BeginInit();
            this.CTpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CTtimer1
            // 
            this.CTtimer1.Tick += new System.EventHandler(this.CTtimer1_Tick);
            // 
            // CTbtnScan
            // 
            this.CTbtnScan.Location = new System.Drawing.Point(427, 134);
            this.CTbtnScan.Name = "CTbtnScan";
            this.CTbtnScan.Size = new System.Drawing.Size(75, 25);
            this.CTbtnScan.TabIndex = 15;
            this.CTbtnScan.Text = "SCAN";
            this.CTbtnScan.UseVisualStyleBackColor = true;
            this.CTbtnScan.Click += new System.EventHandler(this.CTbtnScan_Click);
            // 
            // CTasterterisk6
            // 
            this.CTasterterisk6.AutoSize = true;
            this.CTasterterisk6.BackColor = System.Drawing.Color.Transparent;
            this.CTasterterisk6.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTasterterisk6.ForeColor = System.Drawing.Color.Red;
            this.CTasterterisk6.Location = new System.Drawing.Point(438, 540);
            this.CTasterterisk6.Name = "CTasterterisk6";
            this.CTasterterisk6.Size = new System.Drawing.Size(15, 16);
            this.CTasterterisk6.TabIndex = 260;
            this.CTasterterisk6.Text = "*";
            // 
            // CTasterterisk5
            // 
            this.CTasterterisk5.AutoSize = true;
            this.CTasterterisk5.BackColor = System.Drawing.Color.Transparent;
            this.CTasterterisk5.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTasterterisk5.ForeColor = System.Drawing.Color.Red;
            this.CTasterterisk5.Location = new System.Drawing.Point(14, 540);
            this.CTasterterisk5.Name = "CTasterterisk5";
            this.CTasterterisk5.Size = new System.Drawing.Size(15, 16);
            this.CTasterterisk5.TabIndex = 259;
            this.CTasterterisk5.Text = "*";
            // 
            // CTlabelAbout12
            // 
            this.CTlabelAbout12.AutoSize = true;
            this.CTlabelAbout12.BackColor = System.Drawing.Color.Transparent;
            this.CTlabelAbout12.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTlabelAbout12.Location = new System.Drawing.Point(26, 540);
            this.CTlabelAbout12.Name = "CTlabelAbout12";
            this.CTlabelAbout12.Size = new System.Drawing.Size(415, 16);
            this.CTlabelAbout12.TabIndex = 258;
            this.CTlabelAbout12.Text = "Note: If the scanner cannot detect your QRCode, use the \"Open\" option instead.";
            // 
            // CTlabelAbout11
            // 
            this.CTlabelAbout11.AutoSize = true;
            this.CTlabelAbout11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CTlabelAbout11.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTlabelAbout11.Location = new System.Drawing.Point(424, 172);
            this.CTlabelAbout11.Name = "CTlabelAbout11";
            this.CTlabelAbout11.Size = new System.Drawing.Size(153, 16);
            this.CTlabelAbout11.TabIndex = 256;
            this.CTlabelAbout11.Text = "Your record will display here:";
            // 
            // CTTitle4
            // 
            this.CTTitle4.AutoSize = true;
            this.CTTitle4.BackColor = System.Drawing.Color.Transparent;
            this.CTTitle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTitle4.Location = new System.Drawing.Point(136, 69);
            this.CTTitle4.Name = "CTTitle4";
            this.CTTitle4.Size = new System.Drawing.Size(531, 32);
            this.CTTitle4.TabIndex = 25;
            this.CTTitle4.Text = "Instructions: You have the option of either opening or scanning your QRCode. \r\nWa" +
    "it for the application to read it after clicking the \"Scan\" or \"Open\" button.";
            // 
            // CTTitle3
            // 
            this.CTTitle3.AutoSize = true;
            this.CTTitle3.BackColor = System.Drawing.Color.Transparent;
            this.CTTitle3.Font = new System.Drawing.Font("Franklin Gothic Book", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTTitle3.Location = new System.Drawing.Point(132, 24);
            this.CTTitle3.Name = "CTTitle3";
            this.CTTitle3.Size = new System.Drawing.Size(445, 37);
            this.CTTitle3.TabIndex = 24;
            this.CTTitle3.Text = "COVID-19 Contract Tracing Form";
            // 
            // CTpicbox2
            // 
            this.CTpicbox2.BackColor = System.Drawing.Color.Transparent;
            this.CTpicbox2.Image = ((System.Drawing.Image)(resources.GetObject("CTpicbox2.Image")));
            this.CTpicbox2.Location = new System.Drawing.Point(12, 11);
            this.CTpicbox2.Name = "CTpicbox2";
            this.CTpicbox2.Size = new System.Drawing.Size(108, 102);
            this.CTpicbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CTpicbox2.TabIndex = 23;
            this.CTpicbox2.TabStop = false;
            // 
            // CTbtnOpen
            // 
            this.CTbtnOpen.Location = new System.Drawing.Point(329, 133);
            this.CTbtnOpen.Name = "CTbtnOpen";
            this.CTbtnOpen.Size = new System.Drawing.Size(75, 25);
            this.CTbtnOpen.TabIndex = 22;
            this.CTbtnOpen.Text = "OPEN";
            this.CTbtnOpen.UseVisualStyleBackColor = true;
            this.CTbtnOpen.Click += new System.EventHandler(this.CTbtnOpen_Click);
            // 
            // TxtBoxQR
            // 
            this.TxtBoxQR.Location = new System.Drawing.Point(427, 191);
            this.TxtBoxQR.Multiline = true;
            this.TxtBoxQR.Name = "TxtBoxQR";
            this.TxtBoxQR.Size = new System.Drawing.Size(241, 333);
            this.TxtBoxQR.TabIndex = 21;
            // 
            // CTbtnNext2
            // 
            this.CTbtnNext2.Location = new System.Drawing.Point(593, 536);
            this.CTbtnNext2.Name = "CTbtnNext2";
            this.CTbtnNext2.Size = new System.Drawing.Size(75, 23);
            this.CTbtnNext2.TabIndex = 20;
            this.CTbtnNext2.Text = "Next";
            this.CTbtnNext2.UseVisualStyleBackColor = true;
            this.CTbtnNext2.Click += new System.EventHandler(this.CTbtnSave2_Click);
            // 
            // CTpicboxQR
            // 
            this.CTpicboxQR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CTpicboxQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CTpicboxQR.Location = new System.Drawing.Point(25, 172);
            this.CTpicboxQR.Name = "CTpicboxQR";
            this.CTpicboxQR.Size = new System.Drawing.Size(379, 352);
            this.CTpicboxQR.TabIndex = 14;
            this.CTpicboxQR.TabStop = false;
            // 
            // CTcboxCamera
            // 
            this.CTcboxCamera.FormattingEnabled = true;
            this.CTcboxCamera.Location = new System.Drawing.Point(87, 135);
            this.CTcboxCamera.Name = "CTcboxCamera";
            this.CTcboxCamera.Size = new System.Drawing.Size(231, 21);
            this.CTcboxCamera.TabIndex = 13;
            // 
            // CTLabelCamera
            // 
            this.CTLabelCamera.AutoSize = true;
            this.CTLabelCamera.BackColor = System.Drawing.Color.Transparent;
            this.CTLabelCamera.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTLabelCamera.Location = new System.Drawing.Point(26, 138);
            this.CTLabelCamera.Name = "CTLabelCamera";
            this.CTLabelCamera.Size = new System.Drawing.Size(55, 17);
            this.CTLabelCamera.TabIndex = 12;
            this.CTLabelCamera.Text = "Camera:";
            // 
            // CTpanel
            // 
            this.CTpanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CTpanel.BackgroundImage")));
            this.CTpanel.Controls.Add(this.CTLabelCamera);
            this.CTpanel.Controls.Add(this.CTcboxCamera);
            this.CTpanel.Controls.Add(this.CTpicboxQR);
            this.CTpanel.Controls.Add(this.CTbtnNext2);
            this.CTpanel.Controls.Add(this.TxtBoxQR);
            this.CTpanel.Controls.Add(this.CTbtnOpen);
            this.CTpanel.Controls.Add(this.CTpicbox2);
            this.CTpanel.Controls.Add(this.CTTitle3);
            this.CTpanel.Controls.Add(this.CTTitle4);
            this.CTpanel.Controls.Add(this.CTlabelAbout11);
            this.CTpanel.Controls.Add(this.CTlabelAbout12);
            this.CTpanel.Controls.Add(this.CTasterterisk5);
            this.CTpanel.Controls.Add(this.CTasterterisk6);
            this.CTpanel.Controls.Add(this.CTbtnScan);
            this.CTpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTpanel.Location = new System.Drawing.Point(0, 0);
            this.CTpanel.Name = "CTpanel";
            this.CTpanel.Size = new System.Drawing.Size(690, 571);
            this.CTpanel.TabIndex = 261;
            // 
            // ContactTracingF2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 571);
            this.Controls.Add(this.CTpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactTracingF2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactTracingF2_Closing);
            this.Load += new System.EventHandler(this.ContactTracingF2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CTpicbox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTpicboxQR)).EndInit();
            this.CTpanel.ResumeLayout(false);
            this.CTpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer CTtimer1;
        private System.Windows.Forms.Button CTbtnScan;
        private System.Windows.Forms.Label CTasterterisk6;
        private System.Windows.Forms.Label CTasterterisk5;
        private System.Windows.Forms.Label CTlabelAbout12;
        private System.Windows.Forms.Label CTlabelAbout11;
        private System.Windows.Forms.Label CTTitle4;
        private System.Windows.Forms.Label CTTitle3;
        private System.Windows.Forms.PictureBox CTpicbox2;
        private System.Windows.Forms.Button CTbtnOpen;
        private System.Windows.Forms.TextBox TxtBoxQR;
        private System.Windows.Forms.Button CTbtnNext2;
        private System.Windows.Forms.PictureBox CTpicboxQR;
        private System.Windows.Forms.ComboBox CTcboxCamera;
        private System.Windows.Forms.Label CTLabelCamera;
        private System.Windows.Forms.Panel CTpanel;
    }
}