using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRD_Game_translate_tool
{
    public partial class frmSettingTranslate : Form
    {
        private string duongdanDoc, settingPath1, settingPath2;

        private void cbxLangInput_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbLangInput.Text == "Tiếng Việt")
            {
                frmTranslate.langInputSetting = "0";
                frmTranslate.langInputOCR = 0;
                frmTranslate.langInputGG = 0;
                File.WriteAllText(settingPath1, "0");

                ChangeInputValue();
            }
            else if (cbbLangInput.Text == "Tiếng Anh")
            {
                frmTranslate.langInputSetting = "1";
                frmTranslate.langInputOCR = 9;
                frmTranslate.langInputGG = 1;
                File.WriteAllText(settingPath1, "1");

                ChangeInputValue();
            }
            else if (cbbLangInput.Text == "Tiếng Nhật")
            {
                frmTranslate.langInputSetting = "2";
                frmTranslate.langInputOCR = 17;
                frmTranslate.langInputGG = 2;
                File.WriteAllText(settingPath1, "2");

                ChangeInputValue();
            }
            else if (cbbLangInput.Text == "Tiếng Trung")
            {
                frmTranslate.langInputSetting = "3";
                frmTranslate.langInputOCR = 3;
                frmTranslate.langInputGG = 3;
                File.WriteAllText(settingPath1, "3");

                ChangeInputValue();
            }
        }

        private void cbxLangOutput_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbLangOutput.Text == "Tiếng Việt")
            {
                frmTranslate.langOutputSetting = "0";
                frmTranslate.langOutput = 0;
                File.WriteAllText(settingPath2, "0");

                ChangeOutputValue();
            }
            else if (cbbLangOutput.Text == "Tiếng Anh")
            {
                frmTranslate.langOutputSetting = "1";
                frmTranslate.langOutput = 1;
                File.WriteAllText(settingPath2, "1");

                ChangeOutputValue();
            }
            else if (cbbLangOutput.Text == "Tiếng Nhật")
            {
                frmTranslate.langOutputSetting = "2";
                frmTranslate.langOutput = 2;
                File.WriteAllText(settingPath2, "2");

                ChangeOutputValue();
            }
            else if (cbbLangOutput.Text == "Tiếng Trung")
            {
                frmTranslate.langOutputSetting = "3";
                frmTranslate.langOutput = 3;
                File.WriteAllText(settingPath2, "3");

                ChangeOutputValue();
            }
        }

        public void ChangeInputValue()
        {
            for (int i = 0; i < frmTranslate.langArrMini.Length; i++)
            {
                if (i == frmTranslate.langInputOCR)
                {
                    frmTranslate.langInOCR = frmTranslate.langArrMini[i];
                }
            }

            for (int i = 0; i < frmTranslate.langTranslateArr.Length; i++)
            {
                if (i == frmTranslate.langInputGG)
                {
                    frmTranslate.langInGG = frmTranslate.langTranslateArr[i];
                }
            }
        }

        public void ChangeOutputValue()
        {
            for (int i = 0; i < frmTranslate.langTranslateArr.Length; i++)
            {
                if (i == frmTranslate.langOutput)
                {
                    frmTranslate.langOut = frmTranslate.langTranslateArr[i];
                }
            }
        }

        private void frmSettingTranslate_Load(object sender, EventArgs e)
        {
            duongdanDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            settingPath1 = duongdanDoc + @"\PRDTranslateSetting\SettingValue1.txt";
            settingPath2 = duongdanDoc + @"\PRDTranslateSetting\SettingValue2.txt";

            string readFile1 = File.ReadAllText(settingPath1);
            string readFile2 = File.ReadAllText(settingPath2);

            if (readFile1 == "0")
            {
                cbbLangInput.SelectedIndex = 0;
                cbbLangInput.SelectedValue = "Tiếng Việt";
            }
            else if (readFile1 == "1")
            {
                cbbLangInput.SelectedIndex = 1;
                cbbLangInput.SelectedValue = "Tiếng Anh";
            }
            else if (readFile1 == "2")
            {
                cbbLangInput.SelectedIndex = 2;
                cbbLangInput.SelectedValue = "Tiếng Nhật";
            }
            else if (readFile1 == "3")
            {
                cbbLangInput.SelectedIndex = 3;
                cbbLangInput.SelectedValue = "Tiếng Trung";
            }


            if (readFile2 == "0")
            {
                cbbLangOutput.SelectedIndex = 0;
                cbbLangOutput.SelectedValue = "Tiếng Việt";
            }
            else if (readFile2 == "1")
            {
                cbbLangOutput.SelectedIndex = 1;
                cbbLangOutput.SelectedValue = "Tiếng Anh";
            }
            else if (readFile2 == "2")
            {
                cbbLangOutput.SelectedIndex = 2;
                cbbLangOutput.SelectedValue = "Tiếng Nhật";
            }
            else if (readFile2 == "3")
            {
                cbbLangOutput.SelectedIndex = 3;
                cbbLangOutput.SelectedValue = "Tiếng Trung";
            }
        }

        public frmSettingTranslate()
        {
            InitializeComponent();
        }
    }
}
