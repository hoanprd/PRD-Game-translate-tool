using GI.Screenshot;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Tesseract;
using Timer = System.Windows.Forms.Timer;

namespace PRD_Game_translate_tool
{
    public partial class frmTranslate : Form
    {
        static string[] langarr = { "Vietnamese", "Arabic", "Bulgarian", "Chinese(Simplified)", "Chinese(Traditional)", "Croatian", "Czech", "Danish", "Dutch", "English", "Finnish", "French", "German", "Greek", "Hungarian", "Korean", "Italian", "Japanese", "Polish", "Portuguese", "Russian", "Slovenian", "Spanish", "Swedish", "Turkish" };
        static string[] langarrmini = { "vie", "ara", "bul", "chs", "cht", "hrv", "cze", "dan", "dut", "eng", "fin", "fre", "ger", "gre", "hun", "kor", "ita", "jpn", "pol", "por", "rus", "slv", "spa", "swe", "tur" };
        //string pathTemp = null;
        string langOCR, langInput, langOutput;
        bool auto;

        public frmTranslate()
        {
            InitializeComponent();
            //pathTemp = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }
        public string TranslateText(string input)
        {
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             "ja", "vi", Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);
            var translationItems = jsonData[0];
            string translation = "";
            foreach (object item in translationItems)
            {
                IEnumerable translationLineObject = item as IEnumerable;
                IEnumerator translationLineString = translationLineObject.GetEnumerator();
                translationLineString.MoveNext();
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }
            if (translation.Length > 1) { translation = translation.Substring(1); };
            return translation;
        }

        public static Bitmap ConvertToBitmap(BitmapSource bitmapSource)
        {
            var width = bitmapSource.PixelWidth;
            var height = bitmapSource.PixelHeight;
            var stride = width * ((bitmapSource.Format.BitsPerPixel + 7) / 8);
            var memoryBlockPointer = Marshal.AllocHGlobal(height * stride);
            bitmapSource.CopyPixels(new Int32Rect(0, 0, width, height), memoryBlockPointer, height * stride, stride);
            var bitmap = new Bitmap(width, height, stride, PixelFormat.Format32bppArgb, memoryBlockPointer);

            return bitmap;
        }

        public static Bitmap ConvertToBitmapAuto(BitmapSource bitmapSource, System.Windows.Rect rc)
        {
            var stride = rc.Width * ((bitmapSource.Format.BitsPerPixel + 7) / 8);
            var memoryBlockPointer = Marshal.AllocHGlobal((int)(rc.Height * stride));
            bitmapSource.CopyPixels(new Int32Rect(0, 0, (int)rc.Width, (int)rc.Height), (IntPtr)memoryBlockPointer, (int)(rc.Width * stride), (int)stride);
            var bitmap = new Bitmap((int)rc.Width, (int)rc.Height, (int)stride, PixelFormat.Format32bppArgb, memoryBlockPointer);

            return bitmap;
        }

        private string OCR(Bitmap b)
        {
            string res = "";
            using (var engine = new TesseractEngine(@"tessdata", "jpn", EngineMode.Default))
            {
                using (var page = engine.Process(b, PageSegMode.AutoOnly))
                    res = page.GetText();
            }
            return res;
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (!auto)
            {
                this.WindowState = FormWindowState.Minimized;
                Thread.Sleep(500);
                pbxCapture.Image = (Image)ConvertToBitmap(Screenshot.CaptureRegion());
                this.WindowState = FormWindowState.Normal;

                txtCapture.Text = "";
                string result = "";
                Task.Factory.StartNew(() => {
                    picloading.BeginInvoke(new Action(() =>
                    {
                        picloading.Visible = true;
                    }));

                    result = OCR((Bitmap)pbxCapture.Image);
                    txtCapture.BeginInvoke(new Action(() => {

                        txtCapture.Text = result;

                    }));
                    picloading.BeginInvoke(new Action(() =>
                    {
                        picloading.Visible = false;
                    }));

                });
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Đang ở chế độ auto, vui lòng tắt!");
            }
            /*this.WindowState = FormWindowState.Minimized;
            Thread.Sleep(500);
            //pbxCapture.Image = (Image)ConvertToBitmap(Screenshot.CaptureRegion());
            System.Windows.Rect myRect = new System.Windows.Rect();
            //myRect.Location = new System.Windows.Point(510, 800);
            //myRect.Size = new System.Windows.Size(1000, 180);
            myRect.Location = new System.Windows.Point(510, 800);
            myRect.Size = new System.Windows.Size(950, 160);
            pbxCapture.Image = (Image)ConvertToBitmap(Screenshot.CaptureRegion(myRect), myRect);
            this.WindowState = FormWindowState.Normal;

            txtCapture.Text = "";
            string result = "";
            Task.Factory.StartNew(() => {
                picloading.BeginInvoke(new Action(() =>
                {
                    picloading.Visible = true;
                }));

                result = OCR((Bitmap)pbxCapture.Image);
                txtCapture.BeginInvoke(new Action(() => {

                    txtCapture.Text = result;

                }));
                picloading.BeginInvoke(new Action(() =>
                {
                    picloading.Visible = false;
                }));

            });*/
        }

        private void chỉnhSửaNgônNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettingTranslate frmst = new frmSettingTranslate();
            frmst.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        Timer tmr = new Timer();
        static int autoRectLocationX, autoRectLocationY, autoRectSizeX, autoRectSizeY;

        public static void TakeAutoTemplate(BitmapSource bitmapSource)
        {
            int mouseX = MousePosition.X;
            int mouseY = MousePosition.Y;
            autoRectLocationX = mouseX - bitmapSource.PixelWidth; ;
            autoRectLocationY = mouseY - bitmapSource.PixelHeight;
            Console.WriteLine(autoRectLocationX + " " + autoRectLocationY);
            autoRectSizeX = bitmapSource.PixelWidth;
            autoRectSizeY = bitmapSource.PixelHeight;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (!auto)
            {
                auto = true;
                this.WindowState = FormWindowState.Minimized;
                TakeAutoTemplate(Screenshot.CaptureRegion());
                this.WindowState = FormWindowState.Normal;
            }

            if (auto)
            {
                tmr.Interval = 1000;
                tmr.Tick += Tmr_Tick;
                tmr.Start();
            }
            else
            {
                tmr.Stop();
            }
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            //Thread.Sleep(500);
            //System.Windows.Rect myRect = new System.Windows.Rect();
            //myRect.Location = new System.Windows.Point(510, 800);
            //myRect.Size = new System.Windows.Size(950, 160);
            //pbxCapture.Image = (Image)ConvertToBitmap(Screenshot.CaptureRegion(myRect), myRect);

            try
            {
                System.Windows.Rect myRect = new System.Windows.Rect();
                myRect.Location = new System.Windows.Point(autoRectLocationX, autoRectLocationY);
                myRect.Size = new System.Windows.Size(autoRectSizeX, autoRectSizeY);
                pbxCapture.Image = (Image)ConvertToBitmapAuto(Screenshot.CaptureRegion(myRect), myRect);

                txtCapture.Text = "";
                string result = "";
                Task.Factory.StartNew(() => {
                    picloading.BeginInvoke(new Action(() =>
                    {
                        //picloading.Visible = true;
                    }));

                    result = OCR((Bitmap)pbxCapture.Image);
                    txtCapture.BeginInvoke(new Action(() => {

                        if (!String.IsNullOrEmpty(result) && !String.IsNullOrWhiteSpace(result))
                        {
                            txtCapture.Text = result;
                            txtTranslate.Text = TranslateText(txtCapture.Text);
                        }
                    }));
                    picloading.BeginInvoke(new Action(() =>
                    {
                        //picloading.Visible = false;
                    }));

                });
            }
            catch
            {

            }
        }

        private void btnStopAuto_Click(object sender, EventArgs e)
        {
            tmr.Stop();
            auto = false;
            txtCapture.Refresh();
            txtTranslate.Refresh();
        }

        private void frmTranslate_Load(object sender, EventArgs e)
        {
            langInput = "auto";
            langOutput = "auto";
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (!auto)
                txtTranslate.Text = TranslateText(txtCapture.Text);
            else
            {
                System.Windows.Forms.MessageBox.Show("Đang ở chế độ auto, vui lòng tắt!");
            }
        }
    }
}
