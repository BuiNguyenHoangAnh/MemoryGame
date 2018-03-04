namespace WindowsFormsApplication1
{
    partial class FrMCDe
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btOK = new System.Windows.Forms.Button();
            this.No1 = new System.Windows.Forms.Label();
            this.No2 = new System.Windows.Forms.Label();
            this.No3 = new System.Windows.Forms.Label();
            this.No4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbQuest = new System.Windows.Forms.Label();
            this.tbDapan = new System.Windows.Forms.TextBox();
            this.btKtra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn đã sẵn sàng?";
            // 
            // btOK
            // 
            this.btOK.AutoSize = true;
            this.btOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOK.Location = new System.Drawing.Point(225, 104);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(66, 30);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // No1
            // 
            this.No1.AutoSize = true;
            this.No1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No1.Location = new System.Drawing.Point(183, 44);
            this.No1.Name = "No1";
            this.No1.Size = new System.Drawing.Size(0, 20);
            this.No1.TabIndex = 2;
            this.No1.Visible = false;
            // 
            // No2
            // 
            this.No2.AutoSize = true;
            this.No2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No2.Location = new System.Drawing.Point(234, 44);
            this.No2.Name = "No2";
            this.No2.Size = new System.Drawing.Size(0, 20);
            this.No2.TabIndex = 3;
            this.No2.Visible = false;
            // 
            // No3
            // 
            this.No3.AutoSize = true;
            this.No3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No3.Location = new System.Drawing.Point(234, 81);
            this.No3.Name = "No3";
            this.No3.Size = new System.Drawing.Size(0, 20);
            this.No3.TabIndex = 4;
            this.No3.Visible = false;
            // 
            // No4
            // 
            this.No4.AutoSize = true;
            this.No4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No4.Location = new System.Drawing.Point(183, 81);
            this.No4.Name = "No4";
            this.No4.Size = new System.Drawing.Size(0, 20);
            this.No4.TabIndex = 5;
            this.No4.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbQuest
            // 
            this.lbQuest.AutoSize = true;
            this.lbQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuest.Location = new System.Drawing.Point(12, 162);
            this.lbQuest.Name = "lbQuest";
            this.lbQuest.Size = new System.Drawing.Size(0, 16);
            this.lbQuest.TabIndex = 6;
            // 
            // tbDapan
            // 
            this.tbDapan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDapan.Location = new System.Drawing.Point(15, 214);
            this.tbDapan.Name = "tbDapan";
            this.tbDapan.Size = new System.Drawing.Size(100, 26);
            this.tbDapan.TabIndex = 7;
            this.tbDapan.Visible = false;
            // 
            // btKtra
            // 
            this.btKtra.AutoSize = true;
            this.btKtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKtra.Location = new System.Drawing.Point(149, 210);
            this.btKtra.Name = "btKtra";
            this.btKtra.Size = new System.Drawing.Size(85, 30);
            this.btKtra.TabIndex = 8;
            this.btKtra.Text = "Kiểm tra";
            this.btKtra.UseVisualStyleBackColor = true;
            this.btKtra.Visible = false;
            this.btKtra.Click += new System.EventHandler(this.btKtra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(315, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 102);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // FrMCDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btKtra);
            this.Controls.Add(this.tbDapan);
            this.Controls.Add(this.lbQuest);
            this.Controls.Add(this.No4);
            this.Controls.Add(this.No3);
            this.Controls.Add(this.No2);
            this.Controls.Add(this.No1);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.label1);
            this.Name = "FrMCDe";
            this.Text = "Mức chơi dễ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label No1;
        private System.Windows.Forms.Label No2;
        private System.Windows.Forms.Label No3;
        private System.Windows.Forms.Label No4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbQuest;
        private System.Windows.Forms.TextBox tbDapan;
        private System.Windows.Forms.Button btKtra;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}