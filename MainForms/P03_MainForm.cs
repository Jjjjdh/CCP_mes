
using FormList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class P03_MainForm : Form
    {
        Thread thread_NowDate;

        public P03_MainForm()
        {
            InitializeComponent();
        }
        
        private void P03_MainForm_Load(object sender, EventArgs e)
        {
            ThreadStart StartThread = new ThreadStart(TimeShow);
            thread_NowDate = new Thread(StartThread);
            thread_NowDate.Start();
        }

        private void timNowDate_Tick(object sender, EventArgs e)
        {
            stsNowdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void TimeShow()
        {
            // 스레드가 실행 할 로직 
            while (true)
            {
                Thread.Sleep(1000);
                stsNowdate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void P03_MainForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show("프로그램을 종료 하시겠습니까?", "프로그램 종료", MessageBoxButtons.YesNo);
            if (Result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            DoFormVisible();
            MaterialControl Mc = new MaterialControl();
            Mc.TopLevel = false;
            panel1.Controls.Add(Mc);
            Mc.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            
           // Mc.WindowState = FormWindowState.Maximized;     // 최대 화면으로 키워서 나타내는 코드


        }

        // 메뉴를 클릭 했을때 이전에 연 메뉴들은 안 보이게 해주는 메서드 
        private void DoFormVisible()
        {
            if (panel1.Controls.Count != 0)
            {
                for (int i = 0; i < panel1.Controls.Count; i++)
                {
                    panel1.Controls[i].Visible = false;
                }
                panel1.Controls[0].Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DoFormVisible();
        }
    }
}
