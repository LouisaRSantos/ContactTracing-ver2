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
            this.CTbtnOpen = new System.Windows.Forms.Button();
            this.TxtBoxQR = new System.Windows.Forms.TextBox();
            this.CTbtnSave2 = new System.Windows.Forms.Button();
            this.CTcboxYear2 = new System.Windows.Forms.ComboBox();
            this.CTcboxDateD2 = new System.Windows.Forms.ComboBox();
            this.CTcboxDateM2 = new System.Windows.Forms.ComboBox();
            this.CTbtnScan = new System.Windows.Forms.Button();
            this.CTpicboxQR = new System.Windows.Forms.PictureBox();
            this.CTcboxCamera = new System.Windows.Forms.ComboBox();
            this.CTLabelCamera = new System.Windows.Forms.Label();
            this.CTpicbox2 = new System.Windows.Forms.PictureBox();
            this.CTTitle3 = new System.Windows.Forms.Label();
            this.CTTitle4 = new System.Windows.Forms.Label();
            this.CTlabelAbout11 = new System.Windows.Forms.Label();
            this.CTLabelDate2 = new System.Windows.Forms.Label();
            this.CTtimer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CTpicboxQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTpicbox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CTbtnOpen
            // 
            this.CTbtnOpen.Location = new System.Drawing.Point(329, 133);
            this.CTbtnOpen.Name = "CTbtnOpen";
            this.CTbtnOpen.Size = new System.Drawing.Size(75, 25);
            this.CTbtnOpen.TabIndex = 22;
            this.CTbtnOpen.Text = "Open";
            this.CTbtnOpen.UseVisualStyleBackColor = true;
            this.CTbtnOpen.Click += new System.EventHandler(this.CTbtnOpen_Click);
            // 
            // TxtBoxQR
            // 
            this.TxtBoxQR.Location = new System.Drawing.Point(426, 223);
            this.TxtBoxQR.Multiline = true;
            this.TxtBoxQR.Name = "TxtBoxQR";
            this.TxtBoxQR.Size = new System.Drawing.Size(241, 301);
            this.TxtBoxQR.TabIndex = 21;
            // 
            // CTbtnSave2
            // 
            this.CTbtnSave2.Location = new System.Drawing.Point(593, 533);
            this.CTbtnSave2.Name = "CTbtnSave2";
            this.CTbtnSave2.Size = new System.Drawing.Size(75, 23);
            this.CTbtnSave2.TabIndex = 20;
            this.CTbtnSave2.Text = "SAVE";
            this.CTbtnSave2.UseVisualStyleBackColor = true;
            // 
            // CTcboxYear2
            // 
            this.CTcboxYear2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CTcboxYear2.FormattingEnabled = true;
            this.CTcboxYear2.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023"});
            this.CTcboxYear2.Location = new System.Drawing.Point(593, 135);
            this.CTcboxYear2.Name = "CTcboxYear2";
            this.CTcboxYear2.Size = new System.Drawing.Size(74, 21);
            this.CTcboxYear2.TabIndex = 19;
            // 
            // CTcboxDateD2
            // 
            this.CTcboxDateD2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CTcboxDateD2.FormattingEnabled = true;
            this.CTcboxDateD2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.CTcboxDateD2.Location = new System.Drawing.Point(509, 135);
            this.CTcboxDateD2.Name = "CTcboxDateD2";
            this.CTcboxDateD2.Size = new System.Drawing.Size(74, 21);
            this.CTcboxDateD2.TabIndex = 18;
            // 
            // CTcboxDateM2
            // 
            this.CTcboxDateM2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CTcboxDateM2.FormattingEnabled = true;
            this.CTcboxDateM2.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CTcboxDateM2.Location = new System.Drawing.Point(425, 135);
            this.CTcboxDateM2.Name = "CTcboxDateM2";
            this.CTcboxDateM2.Size = new System.Drawing.Size(74, 21);
            this.CTcboxDateM2.TabIndex = 17;
            // 
            // CTbtnScan
            // 
            this.CTbtnScan.Location = new System.Drawing.Point(426, 172);
            this.CTbtnScan.Name = "CTbtnScan";
            this.CTbtnScan.Size = new System.Drawing.Size(75, 25);
            this.CTbtnScan.TabIndex = 15;
            this.CTbtnScan.Text = "SCAN";
            this.CTbtnScan.UseVisualStyleBackColor = true;
            this.CTbtnScan.Click += new System.EventHandler(this.CTbtnScan_Click);
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
            this.CTLabelCamera.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTLabelCamera.Location = new System.Drawing.Point(26, 138);
            this.CTLabelCamera.Name = "CTLabelCamera";
            this.CTLabelCamera.Size = new System.Drawing.Size(55, 17);
            this.CTLabelCamera.TabIndex = 12;
            this.CTLabelCamera.Text = "Camera:";
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
            // CTlabelAbout11
            // 
            this.CTlabelAbout11.AutoSize = true;
            this.CTlabelAbout11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CTlabelAbout11.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTlabelAbout11.Location = new System.Drawing.Point(424, 204);
            this.CTlabelAbout11.Name = "CTlabelAbout11";
            this.CTlabelAbout11.Size = new System.Drawing.Size(153, 16);
            this.CTlabelAbout11.TabIndex = 256;
            this.CTlabelAbout11.Text = "Your record will display here:";
            // 
            // CTLabelDate2
            // 
            this.CTLabelDate2.AutoSize = true;
            this.CTLabelDate2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CTLabelDate2.Font = new System.Drawing.Font("Franklin Gothic Book", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTLabelDate2.Location = new System.Drawing.Point(424, 116);
            this.CTLabelDate2.Name = "CTLabelDate2";
            this.CTLabelDate2.Size = new System.Drawing.Size(35, 16);
            this.CTLabelDate2.TabIndex = 257;
            this.CTLabelDate2.Text = "Date:";
            // 
            // CTtimer1
            // 
            this.CTtimer1.Tick += new System.EventHandler(this.CTtimer1_Tick);
            // 
            // ContactTracingF2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 565);
            this.Controls.Add(this.CTLabelDate2);
            this.Controls.Add(this.CTlabelAbout11);
            this.Controls.Add(this.CTTitle4);
            this.Controls.Add(this.CTTitle3);
            this.Controls.Add(this.CTpicbox2);
            this.Controls.Add(this.CTbtnOpen);
            this.Controls.Add(this.TxtBoxQR);
            this.Controls.Add(this.CTbtnSave2);
            this.Controls.Add(this.CTcboxYear2);
            this.Controls.Add(this.CTcboxDateD2);
            this.Controls.Add(this.CTcboxDateM2);
            this.Controls.Add(this.CTbtnScan);
            this.Controls.Add(this.CTpicboxQR);
            this.Controls.Add(this.CTcboxCamera);
            this.Controls.Add(this.CTLabelCamera);
            this.Name = "ContactTracingF2";
            this.Text = "Contact Tracing Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactTracingF2_Closing);
            this.Load += new System.EventHandler(this.ContactTracingF2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CTpicboxQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTpicbox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CTbtnOpen;
        private System.Windows.Forms.TextBox TxtBoxQR;
        private System.Windows.Forms.Button CTbtnSave2;
        private System.Windows.Forms.ComboBox CTcboxYear2;
        private System.Windows.Forms.ComboBox CTcboxDateD2;
        private System.Windows.Forms.ComboBox CTcboxDateM2;
        private System.Windows.Forms.Button CTbtnScan;
        private System.Windows.Forms.PictureBox CTpicboxQR;
        private System.Windows.Forms.ComboBox CTcboxCamera;
        private System.Windows.Forms.Label CTLabelCamera;
        private System.Windows.Forms.PictureBox CTpicbox2;
        private System.Windows.Forms.Label CTTitle3;
        private System.Windows.Forms.Label CTTitle4;
        private System.Windows.Forms.Label CTlabelAbout11;
        private System.Windows.Forms.Label CTLabelDate2;
        private System.Windows.Forms.Timer CTtimer1;
    }
}