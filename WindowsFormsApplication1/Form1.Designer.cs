namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btThoat = new System.Windows.Forms.Button();
            this.btBatdau = new System.Windows.Forms.Button();
            this.lbNameofGame = new System.Windows.Forms.Label();
            this.btHuongdan = new System.Windows.Forms.Button();
            this.lbHuongdan = new System.Windows.Forms.Label();
            this.btTroveHD = new System.Windows.Forms.Button();
            this.cbMucchoi = new System.Windows.Forms.ComboBox();
            this.btTrolaiMC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.AutoSize = true;
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(397, 12);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 30);
            this.btThoat.TabIndex = 0;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btBatdau
            // 
            this.btBatdau.AutoSize = true;
            this.btBatdau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBatdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBatdau.Location = new System.Drawing.Point(212, 12);
            this.btBatdau.Name = "btBatdau";
            this.btBatdau.Size = new System.Drawing.Size(82, 30);
            this.btBatdau.TabIndex = 1;
            this.btBatdau.Text = "Bắt đầu";
            this.btBatdau.UseVisualStyleBackColor = true;
            this.btBatdau.Click += new System.EventHandler(this.btBatdau_Click);
            // 
            // lbNameofGame
            // 
            this.lbNameofGame.AutoSize = true;
            this.lbNameofGame.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameofGame.ForeColor = System.Drawing.Color.Red;
            this.lbNameofGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbNameofGame.Location = new System.Drawing.Point(12, 75);
            this.lbNameofGame.Name = "lbNameofGame";
            this.lbNameofGame.Size = new System.Drawing.Size(462, 117);
            this.lbNameofGame.TabIndex = 2;
            this.lbNameofGame.Text = "Chinh Phục";
            // 
            // btHuongdan
            // 
            this.btHuongdan.AutoSize = true;
            this.btHuongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuongdan.Location = new System.Drawing.Point(12, 12);
            this.btHuongdan.Name = "btHuongdan";
            this.btHuongdan.Size = new System.Drawing.Size(107, 30);
            this.btHuongdan.TabIndex = 3;
            this.btHuongdan.Text = "Hướng dẫn";
            this.btHuongdan.UseVisualStyleBackColor = true;
            this.btHuongdan.Click += new System.EventHandler(this.btHuongdan_Click);
            // 
            // lbHuongdan
            // 
            this.lbHuongdan.AutoSize = true;
            this.lbHuongdan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHuongdan.Location = new System.Drawing.Point(76, 61);
            this.lbHuongdan.Name = "lbHuongdan";
            this.lbHuongdan.Size = new System.Drawing.Size(346, 120);
            this.lbHuongdan.TabIndex = 4;
            this.lbHuongdan.Text = resources.GetString("lbHuongdan.Text");
            this.lbHuongdan.Visible = false;
            // 
            // btTroveHD
            // 
            this.btTroveHD.AutoSize = true;
            this.btTroveHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTroveHD.Location = new System.Drawing.Point(13, 226);
            this.btTroveHD.Name = "btTroveHD";
            this.btTroveHD.Size = new System.Drawing.Size(75, 30);
            this.btTroveHD.TabIndex = 5;
            this.btTroveHD.Text = "Trở lại";
            this.btTroveHD.UseVisualStyleBackColor = true;
            this.btTroveHD.Visible = false;
            this.btTroveHD.Click += new System.EventHandler(this.btTroveHD_Click);
            // 
            // cbMucchoi
            // 
            this.cbMucchoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMucchoi.FormattingEnabled = true;
            this.cbMucchoi.Items.AddRange(new object[] {
            "Dễ",
            "Bình thường",
            "Khó"});
            this.cbMucchoi.Location = new System.Drawing.Point(156, 61);
            this.cbMucchoi.Name = "cbMucchoi";
            this.cbMucchoi.Size = new System.Drawing.Size(193, 28);
            this.cbMucchoi.TabIndex = 6;
            this.cbMucchoi.Text = "Lựa chọn cấp độ chơi";
            this.cbMucchoi.Visible = false;
            this.cbMucchoi.SelectedIndexChanged += new System.EventHandler(this.cbMucchoi_SelectedIndexChanged);
            // 
            // btTrolaiMC
            // 
            this.btTrolaiMC.AutoSize = true;
            this.btTrolaiMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTrolaiMC.Location = new System.Drawing.Point(13, 226);
            this.btTrolaiMC.Name = "btTrolaiMC";
            this.btTrolaiMC.Size = new System.Drawing.Size(75, 30);
            this.btTrolaiMC.TabIndex = 7;
            this.btTrolaiMC.Text = "Trở lại";
            this.btTrolaiMC.UseVisualStyleBackColor = true;
            this.btTrolaiMC.Visible = false;
            this.btTrolaiMC.Click += new System.EventHandler(this.btTrolaiMC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btTrolaiMC);
            this.Controls.Add(this.cbMucchoi);
            this.Controls.Add(this.btTroveHD);
            this.Controls.Add(this.lbHuongdan);
            this.Controls.Add(this.btHuongdan);
            this.Controls.Add(this.lbNameofGame);
            this.Controls.Add(this.btBatdau);
            this.Controls.Add(this.btThoat);
            this.Name = "Form1";
            this.Text = "Game Chinh Phục";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btBatdau;
        private System.Windows.Forms.Label lbNameofGame;
        private System.Windows.Forms.Button btHuongdan;
        private System.Windows.Forms.Label lbHuongdan;
        private System.Windows.Forms.Button btTroveHD;
        private System.Windows.Forms.ComboBox cbMucchoi;
        private System.Windows.Forms.Button btTrolaiMC;
    }
}

