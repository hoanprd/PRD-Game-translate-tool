using GI.Screenshot;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public static string[] langArr = { "Vietnamese", "Arabic", "Bulgarian", "Chinese(Simplified)", "Chinese(Traditional)", "Croatian", "Czech", "Danish", "Dutch", "English", "Finnish", "French", "German", "Greek", "Hungarian", "Korean", "Italian", "Japanese", "Polish", "Portuguese", "Russian", "Slovenian", "Spanish", "Swedish", "Turkish" };
        public static string[] langArrMini = { "vie", "ara", "bul", "chi_sim", "cht", "hrv", "cze", "dan", "dut", "eng", "fin", "fre", "ger", "gre", "hun", "kor", "ita", "jpn", "pol", "por", "rus", "slv", "spa", "swe", "tur" };
        public static string[] langTranslateArr = { "vi", "en", "ja", "zh-tw" };
        public static string langInputSetting, langOutputSetting;
        public static int langInputOCR, langInputGG, langOutput;
        public static string langInOCR, langInGG, langOut;
        private string duongdanDoc, settingPath1, settingPath2;
        bool auto, shrink;
        int autoCount;

        public frmTranslate()
        {
            InitializeComponent();
            //pathTemp = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }
        public string TranslateText(string input)
        {
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             langInGG, langOut, Uri.EscapeUriString(input));
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
            using (var engine = new TesseractEngine(@"tessdata", langInOCR, EngineMode.Default))
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
                        if (shrink)
                        {
                            txtShrink.Text = txtTranslate.Text;
                        }

                    }));
                    picloading.BeginInvoke(new Action(() =>
                    {
                        picloading.Visible = false;
                    }));

                });
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Đang ở chế độ auto, vui lòng tắt!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnScale_Click(object sender, EventArgs e)
        {
            if (shrink)
            {
                shrink = false;
                lbl4.Visible = false;
                txtShrink.Visible = false;
                btnScale.Visible = false;
                lbl1.Visible = true;
                lbl2.Visible = true;
                lbl3.Visible = true;
                pbxCapture.Visible = true;
                pbxAuto.Visible = true;
                //picloading.Visible = true;
                txtCapture.Visible = true;
                txtTranslate.Visible = true;
                btnAuto.Visible = true;
                btnStopAuto.Visible = true;
                btnCapture.Visible = true;
                btnTranslate.Visible = true;
                Size = new System.Drawing.Size(1000, 480);
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!auto)
            {
                pbxCapture.Image = null;
                txtCapture.Refresh();
                txtTranslate.Refresh();
                txtShrink.Refresh();
                txtCapture.Text = null;
                txtTranslate.Text = null;
                txtShrink.Text = null;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Đang ở chế độ auto, vui lòng tắt!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lưuÝToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaution frmc = new frmCaution();
            frmc.ShowDialog();
        }

        private void rútGọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!shrink)
            {
                shrink = true;
                lbl4.Visible = true;
                txtShrink.Visible = true;
                btnScale.Visible = true;
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                pbxCapture.Visible = false;
                pbxAuto.Visible = false;
                picloading.Visible = false;
                txtCapture.Visible = false;
                txtTranslate.Visible = false;
                btnAuto.Visible = false;
                btnStopAuto.Visible = false;
                btnCapture.Visible = false;
                btnTranslate.Visible = false;
                Size = new System.Drawing.Size(410, 270);
            }
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/hoan.nguyenduy.7967");
        }

        public static void TakeAutoTemplate(BitmapSource bitmapSource)
        {
            int mouseX = MousePosition.X;
            int mouseY = MousePosition.Y;
            autoRectLocationX = mouseX - bitmapSource.PixelWidth; ;
            autoRectLocationY = mouseY - bitmapSource.PixelHeight;
            //Console.WriteLine(autoRectLocationX + " " + autoRectLocationY);
            autoRectSizeX = bitmapSource.PixelWidth;
            autoRectSizeY = bitmapSource.PixelHeight;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (!auto)
            {
                auto = true;
                btnAuto.Enabled = false;
                this.WindowState = FormWindowState.Minimized;
                Thread.Sleep(500);
                TakeAutoTemplate(Screenshot.CaptureRegion());
                autoCount = 0;
                lblAuto.Text = "Auto: On";
                Thread.Sleep(500);
                this.WindowState = FormWindowState.Normal;
                btnStopAuto.Enabled = true;
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

        private void Tmr_Reset(object sender, EventArgs e)
        {
            return;
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
                autoCount += 1;
                if (autoCount % 2 != 0)
                {
                    pbxAuto.Visible = false;
                }
                else
                {
                    pbxAuto.Visible = true;
                }
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
                            if (shrink)
                            {
                                txtShrink.Text = txtTranslate.Text;
                            }
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
            btnStopAuto.Enabled = false;
            lblAuto.Text = "Auto: Off";
            pbxAuto.Visible = true;
            txtCapture.Refresh();
            txtTranslate.Refresh();
            txtShrink.Refresh();
            btnAuto.Enabled = true;
        }

        private void frmTranslate_Load(object sender, EventArgs e)
        {
            duongdanDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            settingPath1 = duongdanDoc + @"\PRDTranslateSetting\SettingValue1.txt";
            settingPath2 = duongdanDoc + @"\PRDTranslateSetting\SettingValue2.txt";

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/PRDTranslateSetting"));
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/PRDTranslateSetting");
            }

            if (!File.Exists(settingPath1))
            {
                using (FileStream fs = File.Create(settingPath1))
                {

                }
            }
            if (!File.Exists(settingPath2))
            {
                using (FileStream fs = File.Create(settingPath2))
                {

                }
            }

            string readFile1 = File.ReadAllText(settingPath1);
            string readFile2 = File.ReadAllText(settingPath2);

            if (string.IsNullOrEmpty(readFile1))
            {
                File.WriteAllText(settingPath1, "2");
                langInputSetting = "2";
            }
            else
            {
                langInputSetting = readFile1;
            }

            if (string.IsNullOrEmpty(readFile2))
            {
                File.WriteAllText(settingPath2, "0");
                langOutputSetting = "0";
            }
            else
            {
                langOutputSetting = readFile2;
            }

            if (langInputSetting == "0")
            {
                langInputOCR = 0;
                langInputGG = 0;
                ChangeInputValue();
            }
            else if (langInputSetting == "1")
            {
                langInputOCR = 9;
                langInputGG = 1;
                ChangeInputValue();
            }
            else if (langInputSetting == "2")
            {
                langInputOCR = 17;
                langInputGG = 2;
                ChangeInputValue();
            }
            else if (langInputSetting == "3")
            {
                langInputOCR = 3;
                langInputGG = 3;
                ChangeInputValue();
            }

            if (langOutputSetting == "0")
            {
                langOutput = 0;
                ChangeOutputValue();
            }
            else if (langOutputSetting == "1")
            {
                langOutput = 1;
                ChangeOutputValue();
            }
            else if (langOutputSetting == "2")
            {
                langOutput = 2;
                ChangeOutputValue();
            }
            else if (langOutputSetting == "3")
            {
                langOutput = 3;
                ChangeOutputValue();
            }
        }

        public void ChangeInputValue()
        {
            for (int i = 0; i < langArrMini.Length; i++)
            {
                if (i == langInputOCR)
                {
                    langInOCR = langArrMini[i];
                }
            }

            for (int i = 0; i < langTranslateArr.Length; i++)
            {
                if (i == langInputGG)
                {
                    langInGG = langTranslateArr[i];
                }
            }
        }

        public void ChangeOutputValue()
        {
            for (int i = 0; i < langTranslateArr.Length; i++)
            {
                if (i == langOutput)
                {
                    langOut = langTranslateArr[i];
                }
            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (!auto)
                txtTranslate.Text = TranslateText(txtCapture.Text);
            else
            {
                System.Windows.Forms.MessageBox.Show("Đang ở chế độ auto, vui lòng tắt!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
