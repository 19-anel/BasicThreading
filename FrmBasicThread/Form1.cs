using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FrmBasicThread
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Running Threads...";

            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            ThreadA.Name = "Thread A";

            Thread ThreadB = new Thread(MyThreadClass.Thread1);
            ThreadB.Name = "Thread B";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            lblStatus.Text = "-End of Thread-";
        }
    }
}
