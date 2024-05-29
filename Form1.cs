using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Webcam_Capture_1
{
    public partial class MainForm : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        public MainForm()
        {
            InitializeComponent();
            InitializeVideoDevices();
        }

        private void InitializeVideoDevices()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in videoDevices)
            {
                WebcamsList.Items.Add(device.Name);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopVideoSource();
        }

        private void WebcamsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopVideoSource();

            var selectedDevice = videoDevices[WebcamsList.SelectedIndex];
            videoSource = new VideoCaptureDevice(selectedDevice.MonikerString);
            videoSource.NewFrame += OnNewFrame;
            videoSource.Start();
        }

        private void OnNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            WebcamView.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void StopVideoSource()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
        private string GetFormattedFileName()
        {
            var pc = new PersianCalendar();
            var now = DateTime.Now;
            return $"frame_{pc.GetYear(now)}_{pc.GetMonth(now)}_{pc.GetDayOfMonth(now)}_{pc.GetHour(now)}_{pc.GetMinute(now)}.jpg";
        }
        private void CaptureFrame(int width, int height)
        {
            if (WebcamView.Image != null)
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "JPEG Image|*.jpg";
                    saveDialog.Title = "ذخیره تصویر لحظه ای";
                    saveDialog.FileName =  GetFormattedFileName();
                    Bitmap frameToSave = new Bitmap(WebcamView.Image, new Size(width, height));
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        frameToSave.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        MessageBox.Show("تصویر ذخیره شد!");
                    }
                }
            }
            else
            {
                MessageBox.Show("No frame captured.");
            }
        }

        private void Capture01_Click(object sender, EventArgs e)
        {
            CaptureFrame(320, 240);
        }

        private void Capture02_Click(object sender, EventArgs e)
        {
            CaptureFrame(640, 480);
        }

        private void Capture03_Click(object sender, EventArgs e)
        {
            CaptureFrame(800, 600);
        }
    }
}