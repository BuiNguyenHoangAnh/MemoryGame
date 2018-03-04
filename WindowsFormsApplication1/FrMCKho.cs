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
    public partial class FrMCKho : Form
    {
        public FrMCKho()
        {
            InitializeComponent();
        }

        int[] a = new int[16];
        int time = 4;
        int t;

        private void btOK_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 1000;
            this.timer1.Enabled = true;
            this.label1.Visible = false;
            this.btOK.Visible = false;
            Random temp = new Random();
            for (int i = 0; i < 16; i++)
            {
                a[i] = temp.Next(0, 4);
            }
            this.No1.Text = a[0].ToString();
            this.No2.Text = a[1].ToString();
            this.No3.Text = a[2].ToString();
            this.No4.Text = a[3].ToString();
            this.No5.Text = a[4].ToString();
            this.No6.Text = a[5].ToString();
            this.No7.Text = a[6].ToString();
            this.No8.Text = a[7].ToString();
            this.No9.Text = a[8].ToString();
            this.No10.Text = a[9].ToString();
            this.No11.Text = a[10].ToString();
            this.No12.Text = a[11].ToString();
            this.No13.Text = a[12].ToString();
            this.No14.Text = a[13].ToString();
            this.No15.Text = a[14].ToString();
            this.No16.Text = a[15].ToString();
            this.No1.Visible = true;
            this.No2.Visible = true;
            this.No3.Visible = true;
            this.No4.Visible = true;
            this.No5.Visible = true;
            this.No6.Visible = true;
            this.No7.Visible = true;
            this.No8.Visible = true;
            this.No9.Visible = true;
            this.No10.Visible = true;
            this.No11.Visible = true;
            this.No12.Visible = true;
            this.No13.Visible = true;
            this.No14.Visible = true;
            this.No15.Visible = true;
            this.No16.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time < 0)
            {
                this.timer1.Enabled = false;
                this.No1.Visible = false;
                this.No2.Visible = false;
                this.No3.Visible = false;
                this.No4.Visible = false;
                this.No5.Visible = false;
                this.No6.Visible = false;
                this.No7.Visible = false;
                this.No8.Visible = false;
                this.No9.Visible = false;
                this.No10.Visible = false;
                this.No11.Visible = false;
                this.No12.Visible = false;
                this.No13.Visible = false;
                this.No14.Visible = false;
                this.No15.Visible = false;
                this.No16.Visible = false;
                this.tbDapan.Visible = true;
                this.btKtra.Visible = true;
                Random r = new Random();
                int temp = r.Next(0, 4);
                t = temp;
                this.lbQuest.Text = "Số " + temp.ToString() + " xuất hiện bao nhiêu lần trong ma trận?";
            }
        }

        private void btKtra_Click(object sender, EventArgs e)
        {
            if (this.tbDapan.Text == "")
            {
                DialogResult rp;
                rp = MessageBox.Show("Bạn chưa nhập đáp án", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rp == DialogResult.OK)
                    this.tbDapan.Text = "Nhập số";
            }
            else
            {
                int temp = Convert.ToInt32(this.tbDapan.Text);
                int dem = 0;
                for (int i = 0; i < 16; i++)
                {
                    if (a[i] == t)
                        dem++;
                }
                this.No1.Visible = true;
                this.No2.Visible = true;
                this.No3.Visible = true;
                this.No4.Visible = true;
                this.No5.Visible = true;
                this.No6.Visible = true;
                this.No7.Visible = true;
                this.No8.Visible = true;
                this.No9.Visible = true;
                this.No10.Visible = true;
                this.No11.Visible = true;
                this.No12.Visible = true;
                this.No13.Visible = true;
                this.No14.Visible = true;
                this.No15.Visible = true;
                this.No16.Visible = true;
                this.tbDapan.Visible = false;
                this.btKtra.Visible = false;
                if (dem == temp)
                {
                    this.pictureBox1.BackgroundImage = Properties.Resources._10517557_649456941830392_1261308117600986533_n;
                    this.pictureBox1.Visible = true;
                    this.lbQuest.Text = "Chúc mừng!!! Bạn đã chiến thắng ^^";
                }
                else
                {
                    this.pictureBox1.BackgroundImage = Properties.Resources._1924335_1485577925014613_3421491625676660010_n;
                    this.pictureBox1.Visible = true;
                    this.lbQuest.Text = "Bạn sai rồi :( Hãy cố gắng lên!!!";
                }
            }
        }
    }
}
