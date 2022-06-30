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
                string CTDate = CTcboxDateM2.SelectedItem.ToString() + " " + CTcboxDateD2.SelectedItem.ToString() + " " + CTcboxDateY2.SelectedItem.ToString();
                string CTRecord = TxtBoxQR.Text;

                StreamWriter SaveRecord = new StreamWriter(@"C:\Users\Santos\Documents\Records\" + CTDate + ".txt", true);
                SaveRecord.WriteLine(CTDate);
                SaveRecord.WriteLine(CTRecord);
                SaveRecord.Close();
                MessageBox.Show("File Saved");
            }
            catch
            {
                MessageBox.Show("Please input date.");
            }

            try
            {
                string Date = CTcboxDateM2.SelectedItem.ToString() + " " + CTcboxDateD2.SelectedItem.ToString() + " " + CTcboxDateY2.SelectedItem.ToString();
                StreamReader ReadRecord = new StreamReader(@"C:\Users\Santos\Documents\Records\" + Date + ".txt", true);
                ContactTracingF1.instance.list.Items.Add(ReadRecord.ReadLine());
                ReadRecord.Close();
            }
            catch 
            {
                
            }

        }
    }
}
