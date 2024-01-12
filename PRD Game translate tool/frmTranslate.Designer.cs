
namespace PRD_Game_translate_tool
{
    partial class frmTranslate
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
            this.btnCapture = new System.Windows.Forms.Button();
            this.txtCapture = new System.Windows.Forms.TextBox();
            this.txtTranslate = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picloading = new System.Windows.Forms.PictureBox();
            this.pbxCapture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaNgônNgữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnStopAuto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picloading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCapture
            // 
            this.btnCapture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCapture.Location = new System.Drawing.Point(897, 190);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCapture.TabIndex = 0;
            this.btnCapture.Text = "Chụp hình";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // txtCapture
            // 
            this.txtCapture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapture.Location = new System.Drawing.Point(605, 63);
            this.txtCapture.Multiline = true;
            this.txtCapture.Name = "txtCapture";
            this.txtCapture.ReadOnly = true;
            this.txtCapture.Size = new System.Drawing.Size(367, 121);
            this.txtCapture.TabIndex = 1;
            // 
            // txtTranslate
            // 
            this.txtTranslate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTranslate.Location = new System.Drawing.Point(605, 247);
            this.txtTranslate.Multiline = true;
            this.txtTranslate.Name = "txtTranslate";
            this.txtTranslate.ReadOnly = true;
            this.txtTranslate.Size = new System.Drawing.Size(368, 121);
            this.txtTranslate.TabIndex = 3;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTranslate.Location = new System.Drawing.Point(897, 374);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 4;
            this.btnTranslate.Text = "Dịch";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kết quả chụp";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Văn bản nhận diện";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(604, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Văn bản dịch";
            // 
            // picloading
            // 
            this.picloading.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picloading.Image = global::PRD_Game_translate_tool.Properties.Resources.icon_chara_face_0001;
            this.picloading.Location = new System.Drawing.Point(766, 88);
            this.picloading.Margin = new System.Windows.Forms.Padding(4);
            this.picloading.Name = "picloading";
            this.picloading.Size = new System.Drawing.Size(69, 71);
            this.picloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picloading.TabIndex = 7;
            this.picloading.TabStop = false;
            this.picloading.Visible = false;
            // 
            // pbxCapture
            // 
            this.pbxCapture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbxCapture.Location = new System.Drawing.Point(0, 63);
            this.pbxCapture.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCapture.Name = "pbxCapture";
            this.pbxCapture.Size = new System.Drawing.Size(600, 200);
            this.pbxCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCapture.TabIndex = 2;
            this.pbxCapture.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐặtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chỉnhSửaNgônNgữToolStripMenuItem});
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.càiĐặtToolStripMenuItem.Text = "Cài đặt";
            // 
            // chỉnhSửaNgônNgữToolStripMenuItem
            // 
            this.chỉnhSửaNgônNgữToolStripMenuItem.Name = "chỉnhSửaNgônNgữToolStripMenuItem";
            this.chỉnhSửaNgônNgữToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.chỉnhSửaNgônNgữToolStripMenuItem.Text = "Chỉnh sửa ngôn ngữ";
            this.chỉnhSửaNgônNgữToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaNgônNgữToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAuto.Location = new System.Drawing.Point(12, 268);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(264, 76);
            this.btnAuto.TabIndex = 12;
            this.btnAuto.Text = "Tự động";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnStopAuto
            // 
            this.btnStopAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStopAuto.Location = new System.Drawing.Point(335, 268);
            this.btnStopAuto.Name = "btnStopAuto";
            this.btnStopAuto.Size = new System.Drawing.Size(264, 76);
            this.btnStopAuto.TabIndex = 13;
            this.btnStopAuto.Text = "Dừng tự động";
            this.btnStopAuto.UseVisualStyleBackColor = true;
            this.btnStopAuto.Click += new System.EventHandler(this.btnStopAuto_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "00:00:00";
            // 
            // frmTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 441);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStopAuto);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picloading);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtTranslate);
            this.Controls.Add(this.pbxCapture);
            this.Controls.Add(this.txtCapture);
            this.Controls.Add(this.btnCapture);
            this.Name = "frmTranslate";
            this.Text = "frmTranslate";
            this.Load += new System.EventHandler(this.frmTranslate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picloading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.TextBox txtCapture;
        private System.Windows.Forms.PictureBox pbxCapture;
        private System.Windows.Forms.TextBox txtTranslate;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.PictureBox picloading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaNgônNgữToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnStopAuto;
        private System.Windows.Forms.Label label4;
    }
}