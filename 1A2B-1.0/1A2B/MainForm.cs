using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1A2B
{
    public partial class MainForm : Form
    {
        PictureBox[] mypic;
        private MANB test;
        private int cnt;
        private string str;
        private Point mouseOffset;        //记录鼠标指针的坐标  
        private bool isMouseDown ; //记录鼠标按键是否按下
        private TimeSpan ts ;
        private static TimeSpan one = new TimeSpan(0, 0, 1);
       
        public MainForm()
        {
            InitializeComponent();
            mypic = new PictureBox[10];
            mypic[0] = picBox0; mypic[1] = picBox1; mypic[2] = picBox2; mypic[3] = picBox3; mypic[4] = picBox4;
            mypic[5] = picBox5; mypic[6] = picBox6; mypic[7] = picBox7; mypic[8] = picBox8; mypic[9] = picBox9;
            test = new MANB();
            cnt = 0;
            str = null;
            isMouseDown = false; //记录鼠标按键是否按下
            ts = new TimeSpan(0, 0, 0);
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                //xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                //yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                xOffset = -e.X;
                yOffset = -e.Y;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            // 修改鼠标状态isMouseDown的值
            // 确保只有鼠标左键按下并移动时，才移动窗体
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            //MessageBox.Show(test.STR);
            string str = txtBox.Text + "------>" + test.check(txtBox.Text);
            lstBox.Items.Add(str);
            if (test.verify(txtBox.Text))
            {
                MessageBox.Show("Congratulations!!!");
            }
            txtBox.Text = "";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label.Visible = true;
            int used = ts.Minutes * 60 + ts.Seconds;
            label.Text = "已用"+ used + "秒";
            ts = ts.Add(one);
            if(ts.TotalSeconds>300.0)
            {
               timer.Enabled=false;
               MessageBox.Show("OVER TIME！");
            }
        }

        private void butnRestart_Click(object sender, EventArgs e)
        {
            test.STR = test.produce();
            lstBox.Items.Clear();
            txtBox.Text = "";
            //timer.Enabled = true;
            ts = new TimeSpan(0, 0, 0);
            label.Text = "已用0秒";
            cnt = 0;
            for (int i = 0; i < 10; ++i)
            {
                mypic[i].Enabled = true;
                mypic[i].BackColor = Color.FromKnownColor(KnownColor.Control);
            }
            str = null;
        }

        private void GiveCheck()
        {
            if (cnt == 4)
            {
                string temp = str + "--->" + test.check(str);
                lstBox.Items.Add(temp);
                if (test.verify(str))
                {
                    MessageBox.Show("Congratulations!!!");
                }
                cnt = 0;
                for (int i = 0; i < 10; ++i)
                {
                    mypic[i].Enabled = true;
                    mypic[i].BackColor = Color.FromKnownColor(KnownColor.Control);
                }
                str = null;
                txtBox.Text = "";
            }
        }

        private void picBox0_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ++cnt;
            str += "" + 0;
            txtBox.Text = str;
            mypic[0].Enabled = false;
            mypic[0].BackColor = Color.Black;
            GiveCheck();
        }

        private void picBox1_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ++cnt;
            str += "" + 1;
            txtBox.Text = str;
            mypic[1].Enabled = false;
            mypic[1].BackColor = Color.Black;
            GiveCheck();
        }

        private void picBox2_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ++cnt;
            str += "" + 2;
            txtBox.Text = str;
            mypic[2].Enabled = false;
            mypic[2].BackColor = Color.Black;
            GiveCheck();
        }

        private void picBox3_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ++cnt;
            str += "" + 3;
            txtBox.Text = str;
            mypic[3].Enabled = false;
            mypic[3].BackColor = Color.Black;
            GiveCheck();
        }

        private void picBox4_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ++cnt;
            str += "" + 4;
            txtBox.Text = str;
            mypic[4].Enabled = false;
            mypic[4].BackColor = Color.Black;
            GiveCheck();
        }

        private void picBox5_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ++cnt;
            str += "" + 5;
            txtBox.Text = str;
            mypic[5].Enabled = false;
            mypic[5].BackColor = Color.Black;
            GiveCheck();
        }

        private void picBox6_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ++cnt;
            str += "" + 6;
            txtBox.Text = str;
            mypic[6].Enabled = false;
            mypic[6].BackColor = Color.Black;
            GiveCheck();
        }

        private void picBox7_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ++cnt;
            str += "" + 7;
            txtBox.Text = str;
            mypic[7].Enabled = false;
            mypic[7].BackColor = Color.Black;
            GiveCheck();
        }

        private void picBox8_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ++cnt;
            str += "" + 8;
            txtBox.Text = str;
            mypic[8].Enabled = false;
            mypic[8].BackColor = Color.Black;
            GiveCheck();
        }

        private void picBox9_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            ++cnt;
            str += "" + 9;
            txtBox.Text = str;
            mypic[9].Enabled = false;
            mypic[9].BackColor = Color.Black;
            GiveCheck();
        }



    
    }
}
