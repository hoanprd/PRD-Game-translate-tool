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

namespace PRD_Game_translate_tool
{
    public partial class frmTranslate : Form
    {
        static string[] langarr = { "Vietnamese", "Arabic", "Bulgarian", "Chinese(Simplified)", "Chinese(Traditional)", "Croatian", "Czech", "Danish", "Dutch", "English", "Finnish", "French", "German", "Greek", "Hungarian", "Korean", "Italian", "Japanese", "Polish", "Portuguese", "Russian", "Slovenian", "Spanish", "Swedish", "Turkish" };
        static string[] langarrmini = { "vie", "ara", "bul", "chs", "cht", "hrv", "cze", "dan", "dut", "eng", "fin", "fre", "ger", "gre", "hun", "kor", "ita", "jpn", "pol", "por", "rus", "slv", "spa", "swe", "tur" };
        //string pathTemp = null;
        string langOCR, langInput, langOutput;

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
            Console.WriteLine(width + "," + height + "," + stride);
            var memoryBlockPointer = Marshal.AllocHGlobal(height * stride);
            bitmapSource.CopyPixels(new Int32Rect(0, 0, width, height), memoryBlockPointer, height * stride, stride);
            var bitmap = new Bitmap(width, height, stride, PixelFormat.Format32bppArgb, memoryBlockPointer);
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
            /*this.Hide();
            Thread.Sleep(200);
            frmct.ShowDialog();
            Image tempImage = System.Windows.Forms.Clipboard.GetImage();
            pbxCapture.Image = tempImage;
            this.Show();

            if (pbxCapture.Image != null)
            {
                pbxCapture.Image.Save(pathTemp + "/abc.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            }*/

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

        private void chỉnhSửaNgônNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettingTranslate frmst = new frmSettingTranslate();
            frmst.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTranslate_Load(object sender, EventArgs e)
        {
            langInput = "auto";
            langOutput = "auto";
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            txtTranslate.Text = TranslateText(txtCapture.Text);
        }
    }
}
