
namespace PRD_Game_translate_tool
{
    partial class frmSettingTranslate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLangOCR = new System.Windows.Forms.ComboBox();
            this.cbxLangInput = new System.Windows.Forms.ComboBox();
            this.cbxLangOutput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ngôn ngữ nhận diện:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ngôn ngữ đầu vào:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngôn ngữ đầu ra:";
            // 
            // cbxLangOCR
            // 
            this.cbxLangOCR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLangOCR.FormattingEnabled = true;
            this.cbxLangOCR.Items.AddRange(new object[] {
            "Tiếng Việt",
            "Tiếng Anh",
            "Tiếng Nhật"});
            this.cbxLangOCR.Location = new System.Drawing.Point(349, 50);
            this.cbxLangOCR.Name = "cbxLangOCR";
            this.cbxLangOCR.Size = new System.Drawing.Size(523, 24);
            this.cbxLangOCR.TabIndex = 12;
            // 
            // cbxLangInput
            // 
            this.cbxLangInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLangInput.FormattingEnabled = true;
            this.cbxLangInput.Items.AddRange(new object[] {
            "Tiếng Việt",
            "Tiếng Anh",
            "Tiếng Nhật"});
            this.cbxLangInput.Location = new System.Drawing.Point(349, 157);
            this.cbxLangInput.Name = "cbxLangInput";
            this.cbxLangInput.Size = new System.Drawing.Size(523, 24);
            this.cbxLangInput.TabIndex = 13;
            // 
            // cbxLangOutput
            // 
            this.cbxLangOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLangOutput.FormattingEnabled = true;
            this.cbxLangOutput.Items.AddRange(new object[] {
            "Tiếng Việt",
            "Tiếng Anh",
            "Tiếng Nhật"});
            this.cbxLangOutput.Location = new System.Drawing.Point(349, 277);
            this.cbxLangOutput.Name = "cbxLangOutput";
            this.cbxLangOutput.Size = new System.Drawing.Size(523, 24);
            this.cbxLangOutput.TabIndex = 14;
            // 
            // frmSettingTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.cbxLangOutput);
            this.Controls.Add(this.cbxLangInput);
            this.Controls.Add(this.cbxLangOCR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSettingTranslate";
            this.Text = "frmSettingTranslate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLangOCR;
        private System.Windows.Forms.ComboBox cbxLangInput;
        private System.Windows.Forms.ComboBox cbxLangOutput;
    }
}