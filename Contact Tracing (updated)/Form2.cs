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

        private FilterInfoCollection Capture_Device;
        private VideoCaptureDevice Final_Frame;

        public ContactTracingF2()
        {
            InitializeComponent();
        }

        private void ContactTracingF2_Load(object sender, EventArgs e)
        {
            Capture_Device = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in Capture_Device)
                CTcboxCamera.Items.Add(Device.Name);

            CTcboxCamera.SelectedIndex = 0;

            Final_Frame = new VideoCaptureDevice();
        }

        private void CTbtnScan_Click(object sender, EventArgs e)
        {
            Final_Frame = new VideoCaptureDevice(Capture_Device[CTcboxCamera.SelectedIndex].MonikerString);
            Final_Frame.NewFrame += Final_Frame_NewFrame;
            Final_Frame.Start();
            CTtimer1.Start();
        }
        private void Final_Frame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            CTpicboxQR.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void ContactTracingF2_Closing(object sender, FormClosingEventArgs e)
        {
            if (Final_Frame.IsRunning == true)
            {
                Final_Frame.Stop();
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
    }
}
