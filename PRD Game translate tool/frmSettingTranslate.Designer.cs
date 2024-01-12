
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingTranslate));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbLangInput = new System.Windows.Forms.ComboBox();
            this.cbbLangOutput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ngôn ngữ nhận diện:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngôn ngữ dịch:";
            // 
            // cbbLangInput
            // 
            this.cbbLangInput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbLangInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLangInput.FormattingEnabled = true;
            this.cbbLangInput.Items.AddRange(new object[] {
            "Tiếng Việt",
            "Tiếng Anh",
            "Tiếng Nhật"});
            this.cbbLangInput.Location = new System.Drawing.Point(264, 103);
            this.cbbLangInput.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLangInput.Name = "cbbLangInput";
            this.cbbLangInput.Size = new System.Drawing.Size(393, 21);
            this.cbbLangInput.TabIndex = 12;
            this.cbbLangInput.SelectedValueChanged += new System.EventHandler(this.cbxLangInput_SelectedValueChanged);
            // 
            // cbbLangOutput
            // 
            this.cbbLangOutput.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbbLangOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLangOutput.FormattingEnabled = true;
            this.cbbLangOutput.Items.AddRange(new object[] {
            "Tiếng Việt",
            "Tiếng Anh",
            "Tiếng Nhật"});
            this.cbbLangOutput.Location = new System.Drawing.Point(264, 227);
            this.cbbLangOutput.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLangOutput.Name = "cbbLangOutput";
            this.cbbLangOutput.Size = new System.Drawing.Size(393, 21);
            this.cbbLangOutput.TabIndex = 14;
            this.cbbLangOutput.SelectedValueChanged += new System.EventHandler(this.cbxLangOutput_SelectedValueChanged);
            // 
            // frmSettingTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 375);
            this.Controls.Add(this.cbbLangOutput);
            this.Controls.Add(this.cbbLangInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmSettingTranslate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài đặt ngôn ngữ";
            this.Load += new System.EventHandler(this.frmSettingTranslate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbLangInput;
        private System.Windows.Forms.ComboBox cbbLangOutput;
    }
}