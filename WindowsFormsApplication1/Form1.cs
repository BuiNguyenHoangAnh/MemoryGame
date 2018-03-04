using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult rp;
            rp = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rp == DialogResult.Yes)
                Application.Exit();
        }

        private void btHuongdan_Click(object sender, EventArgs e)
        {
            this.btBatdau.Visible = false;
            this.btHuongdan.Visible = false;
            this.btThoat.Visible = false;
            this.lbNameofGame.Visible = false;
            this.lbHuongdan.Visible = true;
            this.btTroveHD.Visible = true;
        }

        private void btTroveHD_Click(object sender, EventArgs e)
        {
            this.btBatdau.Visible = true;
            this.btHuongdan.Visible = true;
            this.btThoat.Visible = true;
            this.lbNameofGame.Visible = true;
            this.lbHuongdan.Visible = false;
            this.btTroveHD.Visible = false;
        }

        private void btBatdau_Click(object sender, EventArgs e)
        {
            this.btBatdau.Visible = false;
            this.btHuongdan.Visible = false;
            this.btThoat.Visible = false;
            this.lbNameofGame.Visible = false;
            this.cbMucchoi.Visible = true;
            this.btTrolaiMC.Visible = true;
        }

        private void cbMucchoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbMucchoi.SelectedItem == "Dễ")
            {
                Form fr = new FrMCDe();
                fr.Show();
            }
            else
            {
                if (this.cbMucchoi.SelectedItem == "Bình thường")
                {
                    Form fr = new FrMCBT();
                    fr.Show();
                }
                else
                {
                    Form fr = new FrMCKho();
                    fr.Show();
                }
            }
        }

        private void btTrolaiMC_Click(object sender, EventArgs e)
        {
            this.btBatdau.Visible = true;
            this.btHuongdan.Visible = true;
            this.btThoat.Visible = true;
            this.lbNameofGame.Visible = true;
            this.cbMucchoi.Visible = false;
            this.btTrolaiMC.Visible = false;
        }
    }
}
