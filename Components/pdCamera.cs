using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsApp1.Components
{
    public partial class pdCamera : Form
    {
        public pdCamera()
        {
            InitializeComponent();
            load();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void load()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbCamera1.Items.Add(filterInfo.Name);
                cbCamera2.Items.Add(filterInfo.Name);
            }
            cbCamera1.SelectedIndex = 0;
            cbCamera2.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void BtnStart1_Click(object sender, EventArgs e)
        {
            try
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera1.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame1;
                videoCaptureDevice.Start();
            }
            catch
            {
                MessageBox.Show("Error!");
            }

        }

        private void BtnStop1_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();
        }

        private void BtnStart2_Click(object sender, EventArgs e)
        {
            try
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbCamera2.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame2;
                videoCaptureDevice.Start();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void BtnStop2_Click(object sender, EventArgs e)
        {
            videoCaptureDevice.Stop();
        }

        private void VideoCaptureDevice_NewFrame1(object sender, NewFrameEventArgs eventArgs)
        {
            pbCamera1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void VideoCaptureDevice_NewFrame2(object sender, NewFrameEventArgs eventArgs)
        {
            pbCamera2.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
