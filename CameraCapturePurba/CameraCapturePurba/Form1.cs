using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Diagnostics.Tracing;

namespace CameraCapturePurba
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice videoSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo deviceList in captureDevice)
            {
                comboBoxCamera.Items.Add(deviceList.Name);
            }
            comboBoxCamera.SelectedIndex = 0;
            videoSource = new VideoCaptureDevice();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBoxCam.Image = null;
                pictureBoxCam.Invalidate();
            }
            videoSource = new VideoCaptureDevice(captureDevice[comboBoxCamera.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxCam.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void buttonCapture_Click(object sender, EventArgs e)
        {
            pictureBoxResult.Image = (Bitmap)pictureBoxCam.Image.Clone();
        }

        private void buttonSaveImg_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Save Image As";
            saveDialog.Filter = "Image files (*.jpg, *.png | *.jpg, *.png";
            ImageFormat imageFormat = ImageFormat.Png;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                }
                pictureBoxResult.Image.Save(saveDialog.FileName, imageFormat);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                pictureBoxCam.Image = null;
                pictureBoxCam.Invalidate();
                pictureBoxResult.Image = null;
                pictureBoxResult.Invalidate();
            }

            Application.Exit(null);
        }
    }
}