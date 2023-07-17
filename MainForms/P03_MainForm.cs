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
    }
}
