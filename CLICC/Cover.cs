using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CLICC
{
    public partial class Cover : Form
    {
        public Cover()
        {
            InitializeComponent();
            
        }

        

        private void Cover_Load(object sender, EventArgs e)
        {           
            this.ControlBox = false;
        }

        private int Image = 1;

        private void loadimage()
        {
            if(Image == 6)
            {
                Image = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"SlideImage\{0}.jpg", Image);
            Image++;
        }

        private void TimerSlide_Tick(object sender, EventArgs e)
        {
            loadimage();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string rptPath = Path.Combine(Application.StartupPath, "Reports\\CLIC Management Software Manual.pdf");
            Process.Start(rptPath);
        }
    }
}
