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

namespace ProjetoPI
{
    public partial class frmLogin: Form
    {
        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
            InitializeComponent();
        }
        public void SplashScreen()
        {
            Application.Run(new frmSplash());
        }
    }
}
