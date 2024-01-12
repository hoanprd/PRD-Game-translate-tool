
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTranslate));
            this.btnCapture = new System.Windows.Forms.Button();
            this.txtCapture = new System.Windows.Forms.TextBox();
            this.txtTranslate = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.picloading = new System.Windows.Forms.PictureBox();
            this.pbxCapture = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaNgônNgữToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hỗTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnStopAuto = new System.Windows.Forms.Button();
            this.lblAuto = new System.Windows.Forms.Label();
            this.pbxAuto = new System.Windows.Forms.PictureBox();
            this.rútGọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtShrink = new System.Windows.Forms.TextBox();
            this.btnScale = new System.Windows.Forms.Button();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuÝToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picloading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuto)).BeginInit();
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
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(7, 36);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(151, 25);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "Kết quả chụp";
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(600, 36);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(210, 25);
            this.lbl2.TabIndex = 9;
            this.lbl2.Text = "Văn bản nhận diện";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(604, 219);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(150, 25);
            this.lbl3.TabIndex = 10;
            this.lbl3.Text = "Văn bản dịch";
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
            this.pbxCapture.Location = new System.Drawing.Point(11, 63);
            this.pbxCapture.Margin = new System.Windows.Forms.Padding(2);
            this.pbxCapture.Name = "pbxCapture";
            this.pbxCapture.Size = new System.Drawing.Size(589, 200);
            this.pbxCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCapture.TabIndex = 2;
            this.pbxCapture.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.càiĐặtToolStripMenuItem,
            this.rútGọnToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.lưuÝToolStripMenuItem,
            this.hỗTrợToolStripMenuItem,
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
            // hỗTrợToolStripMenuItem
            // 
            this.hỗTrợToolStripMenuItem.Name = "hỗTrợToolStripMenuItem";
            this.hỗTrợToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.hỗTrợToolStripMenuItem.Text = "Hỗ trợ";
            this.hỗTrợToolStripMenuItem.Click += new System.EventHandler(this.hỗTrợToolStripMenuItem_Click);
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
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnStopAuto.Enabled = false;
            this.btnStopAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopAuto.Location = new System.Drawing.Point(335, 268);
            this.btnStopAuto.Name = "btnStopAuto";
            this.btnStopAuto.Size = new System.Drawing.Size(264, 76);
            this.btnStopAuto.TabIndex = 13;
            this.btnStopAuto.Text = "Dừng tự động";
            this.btnStopAuto.UseVisualStyleBackColor = true;
            this.btnStopAuto.Click += new System.EventHandler(this.btnStopAuto_Click);
            // 
            // lblAuto
            // 
            this.lblAuto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAuto.AutoSize = true;
            this.lblAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuto.Location = new System.Drawing.Point(41, 347);
            this.lblAuto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuto.Name = "lblAuto";
            this.lblAuto.Size = new System.Drawing.Size(105, 25);
            this.lblAuto.TabIndex = 14;
            this.lblAuto.Text = "Auto: Off";
            // 
            // pbxAuto
            // 
            this.pbxAuto.BackColor = System.Drawing.Color.Red;
            this.pbxAuto.Location = new System.Drawing.Point(12, 347);
            this.pbxAuto.Name = "pbxAuto";
            this.pbxAuto.Size = new System.Drawing.Size(24, 22);
            this.pbxAuto.TabIndex = 15;
            this.pbxAuto.TabStop = false;
            // 
            // rútGọnToolStripMenuItem
            // 
            this.rútGọnToolStripMenuItem.Name = "rútGọnToolStripMenuItem";
            this.rútGọnToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.rútGọnToolStripMenuItem.Text = "Rút gọn";
            this.rútGọnToolStripMenuItem.Click += new System.EventHandler(this.rútGọnToolStripMenuItem_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(11, 35);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(150, 25);
            this.lbl4.TabIndex = 17;
            this.lbl4.Text = "Văn bản dịch";
            this.lbl4.Visible = false;
            // 
            // txtShrink
            // 
            this.txtShrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShrink.Location = new System.Drawing.Point(12, 63);
            this.txtShrink.Multiline = true;
            this.txtShrink.Name = "txtShrink";
            this.txtShrink.ReadOnly = true;
            this.txtShrink.Size = new System.Drawing.Size(368, 121);
            this.txtShrink.TabIndex = 16;
            this.txtShrink.Visible = false;
            // 
            // btnScale
            // 
            this.btnScale.Location = new System.Drawing.Point(305, 190);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(75, 23);
            this.btnScale.TabIndex = 18;
            this.btnScale.Text = "Phóng to";
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Visible = false;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // lưuÝToolStripMenuItem
            // 
            this.lưuÝToolStripMenuItem.Name = "lưuÝToolStripMenuItem";
            this.lưuÝToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.lưuÝToolStripMenuItem.Text = "Lưu ý";
            this.lưuÝToolStripMenuItem.Click += new System.EventHandler(this.lưuÝToolStripMenuItem_Click);
            // 
            // frmTranslate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 441);
            this.Controls.Add(this.btnScale);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtShrink);
            this.Controls.Add(this.pbxAuto);
            this.Controls.Add(this.lblAuto);
            this.Controls.Add(this.btnStopAuto);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.picloading);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtTranslate);
            this.Controls.Add(this.pbxCapture);
            this.Controls.Add(this.txtCapture);
            this.Controls.Add(this.btnCapture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTranslate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Màn hình chính";
            this.Load += new System.EventHandler(this.frmTranslate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picloading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCapture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAuto)).EndInit();
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
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaNgônNgữToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnStopAuto;
        private System.Windows.Forms.Label lblAuto;
        private System.Windows.Forms.PictureBox pbxAuto;
        private System.Windows.Forms.ToolStripMenuItem hỗTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rútGọnToolStripMenuItem;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtShrink;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuÝToolStripMenuItem;
    }
}