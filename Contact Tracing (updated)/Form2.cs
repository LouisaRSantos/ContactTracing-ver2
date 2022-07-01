using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace Contact_Tracing__updated_
{
    public partial class ContactTracingF2 : Form
    {
        public static ContactTracingF2 instance;

        private FilterInfoCollection DeviceCamera;
        private VideoCaptureDevice VideoFrame;

        public ContactTracingF2()
        {
            InitializeComponent();
            instance = this;
        }

        private void ContactTracingF2_Load(object sender, EventArgs e)
        {
            DeviceCamera = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in DeviceCamera)
                CTcboxCamera.Items.Add(Device.Name);

            CTcboxCamera.SelectedIndex = 0;

            VideoFrame = new VideoCaptureDevice();
        }

        private void CTbtnScan_Click(object sender, EventArgs e)
        {
            VideoFrame = new VideoCaptureDevice(DeviceCamera[CTcboxCamera.SelectedIndex].MonikerString);
            VideoFrame.NewFrame += Final_Frame_NewFrame;
            VideoFrame.Start();
            CTtimer1.Start();
        }
        private void Final_Frame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            CTpicboxQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ContactTracingF2_Closing(object sender, FormClosingEventArgs e)
        {
            if (VideoFrame.IsRunning == true)
            {
                VideoFrame.Stop();
            }

        }

        private void CTtimer1_Tick(object sender, EventArgs e)
        {
            if (CTpicboxQR.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)CTpicboxQR.Image);
                if (result != null)
                {
                    TxtBoxQR.Text = result.ToString();
                }
            }
        }

        private void CTbtnOpen_Click(object sender, EventArgs e)
        {
            CTtimer1.Stop();
            VideoFrame.Stop();
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var reader = new BarcodeReader();
                var imgfile = Image.FromFile(dialog.FileName) as Bitmap;
                CTpicboxQR.Image = imgfile;
            }
            CTtimer1.Start();
        }

        private void CTbtnSave2_Click(object sender, EventArgs e)
        {
            try
            {
                string indivWord = TxtBoxQR.Text;
                string[] cutter = new string[] { " " };
                string[] word = indivWord.Split(cutter, StringSplitOptions.None);
                string FirstName = word[0];
                string MiddleName = word[1];
                string Surname = word[2];
                string Age = word[3];
                string Number = word[4];
                string Email = word[5];
                string Bplace = word[6];
                string CAddress = word[7];
                string MFirstName = word[8];
                string MMiddleName = word[9];
                string MSurname = word[10];
                string MNumber = word[11];
                string MCAddress = word[12];
                string FFirstName = word[13];
                string FMiddleName = word[14];
                string FSurname = word[15];
                string FNumber = word[16];
                string FCAddress = word[17];
                string P1Name = word[18];
                string P1Date = word[19];
                string P1Time = word[20];
                string P1Loc = word[21];
                string P2Name = word[22];
                string P2Date = word[23];
                string P2Time = word[24];
                string P2Loc = word[25];
                string P3Name = word[26];
                string P3Date = word[27];
                string P3Time = word[28];
                string P3Loc = word[29];
                string P4Name = word[30];
                string P4Date = word[31];
                string P4Time = word[32];
                string P4Loc = word[33];
                string P5Name = word[34];
                string P5Date = word[35];
                string P5Time = word[36];
                string P5Loc = word[37];

                ContactTracingF1.instance.FName.Text = FirstName;
                ContactTracingF1.instance.MName.Text = MiddleName;
                ContactTracingF1.instance.Surname.Text = Surname;
                ContactTracingF1.instance.Age.Text = Age;
                ContactTracingF1.instance.Number.Text = Number;
                ContactTracingF1.instance.Email.Text = Email;
                ContactTracingF1.instance.BPlace.Text = Bplace;
                ContactTracingF1.instance.CAddress.Text = CAddress;
                ContactTracingF1.instance.MFName.Text = MFirstName;
                ContactTracingF1.instance.MMName.Text = MMiddleName;
                ContactTracingF1.instance.MSurname.Text = MSurname;
                ContactTracingF1.instance.MNumber.Text = MNumber;
                ContactTracingF1.instance.MCAddress.Text = MCAddress;
                ContactTracingF1.instance.FFName.Text = FFirstName;
                ContactTracingF1.instance.FMName.Text = FMiddleName;
                ContactTracingF1.instance.FSurname.Text = FSurname;
                ContactTracingF1.instance.FNumber.Text = FNumber;
                ContactTracingF1.instance.FCAdress.Text = FCAddress;
                ContactTracingF1.instance.P1Name.Text = P1Name;
                ContactTracingF1.instance.P2Name.Text = P2Name;
                ContactTracingF1.instance.P3Name.Text = P3Name;
                ContactTracingF1.instance.P4Name.Text = P4Name;
                ContactTracingF1.instance.P5Name.Text = P5Name;
                ContactTracingF1.instance.P1Date.Text = P1Date;
                ContactTracingF1.instance.P2Date.Text = P2Date;
                ContactTracingF1.instance.P3Date.Text = P3Date;
                ContactTracingF1.instance.P4Date.Text = P4Date;
                ContactTracingF1.instance.P5Date.Text = P5Date;
                ContactTracingF1.instance.P1Time.Text = P1Time;
                ContactTracingF1.instance.P2Time.Text = P2Time;
                ContactTracingF1.instance.P3Time.Text = P3Time;
                ContactTracingF1.instance.P4Time.Text = P4Time;
                ContactTracingF1.instance.P5Time.Text = P5Time;
                ContactTracingF1.instance.P1Loc.Text = P1Loc;
                ContactTracingF1.instance.P2Loc.Text = P2Loc;
                ContactTracingF1.instance.P3Loc.Text = P3Loc;
                ContactTracingF1.instance.P4Loc.Text = P4Loc;
                ContactTracingF1.instance.P5Loc.Text = P5Loc;

                MessageBox.Show("Success");
                MessageBox.Show("Please fill the other information needed." + "\r\n" + "Thank You!");
            }
            catch 
            {
                MessageBox.Show("No QRCode detected.");
            }
            
        }
    }
}
