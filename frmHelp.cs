using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lara_Media
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            try
            {
                mplDemo.URL = @"F:\2-C# Database (ITSE-2338-1031)\Lara_Media\Media\Demo.mp4";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmHelp_FormClosing(object sender, FormClosingEventArgs e)
        {
            mplDemo.Dispose();
        }
    }
}
