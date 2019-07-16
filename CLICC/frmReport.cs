using CLICDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLICC
{
    public partial class frmReport : Form
    {
        
        public frmReport()
        {
            InitializeComponent();
        }

        private void FrmReport_Load(object sender, EventArgs e)
        {
            lblAlert.Visible = false;
            lblAlert2.Visible = false;
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtReceive.Clear();
            txtClaim.Clear();
            txtClaimDesk.Clear();
            txtClaimLap.Clear();
            txtUnclaim.Clear();
            txtUnclaimDesk.Clear();
            txtUnclaimLap.Clear();
            txtDeny.Clear();
            dtpFrom.Text = "";
            dtpTo.Text = "";
            dtpFromP.Text = "";
            dtpToP.Text = "";
        }

        // Get the report with requested dates
        private void BtnGenerate_Click(object sender, EventArgs e)
        {            
            DateTime from = Convert.ToDateTime(dtpFrom.Text);
            DateTime to = Convert.ToDateTime(dtpTo.Text);

            if (from > to)
            {
                MessageBox.Show("The from date cannot be later than the to date.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                Report re = ReportDB.GetReport(from, to);
                txtReceive.Text = Convert.ToString(re.Received);
                txtClaim.Text = Convert.ToString(re.Claimed);
                txtClaimDesk.Text = Convert.ToString(re.ClaimedDesk);
                txtClaimLap.Text = Convert.ToString(re.ClaimedLap);
                txtUnclaim.Text = Convert.ToString(re.Unclaimed);
                txtUnclaimDesk.Text = Convert.ToString(re.UnclaimedDesk);
                txtUnclaimLap.Text = Convert.ToString(re.UnclaimedLap);
                txtDeny.Text = Convert.ToString(re.Denied);
                dtpFromP.Text = Convert.ToString(from);
                dtpToP.Text = Convert.ToString(to);
            }
            
        }

        // Get the report with picked up dates
        private void btnGivenOut_Click(object sender, EventArgs e)
        {
            DateTime from = Convert.ToDateTime(dtpFrom.Text);
            DateTime to = Convert.ToDateTime(dtpTo.Text);

            if (from > to)
            {
                MessageBox.Show("The from date cannot be later than the to date.", "Error", MessageBoxButtons.OK);
            }
            else
            {
                txtReceive.Clear();
                txtUnclaim.Clear();
                txtUnclaimDesk.Clear();
                txtUnclaimLap.Clear();
                txtDeny.Clear();
                Report report = ReportDB.GetClaimedOnPickUpDate(from, to);
                txtClaim.Text = Convert.ToString(report.Claimed);
                txtClaimDesk.Text = Convert.ToString(report.ClaimedDesk);
                txtClaimLap.Text = Convert.ToString(report.ClaimedLap);
                dtpFromP.Text = Convert.ToString(from);
                dtpToP.Text = Convert.ToString(to);
            }
        }
                            
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ShowControlImage(grpApp);
            lblAlert.Visible = true;
            lblAlert2.Visible = true;
        }
        private void ShowControlImage(Control ctl)
        {            
            using (Bitmap bm = GetControlImage(ctl))
            {
                PrintImage(bm);

                // Save the image to the desktop
                string outputFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Report.bmp");
                using (MemoryStream memory = new MemoryStream())
                {
                    using (FileStream fs = new FileStream(outputFileName, FileMode.Create, FileAccess.ReadWrite))
                    {
                        bm.Save(memory, ImageFormat.Bmp);
                        byte[] bytes = memory.ToArray();
                        fs.Write(bytes, 0, bytes.Length);
                    }
                }
            }            
        }

        // Return a Bitmap holding an image of the control.
        private Bitmap GetControlImage(Control ctl)
        {
            Bitmap bm = new Bitmap(ctl.Width, ctl.Height);
            ctl.DrawToBitmap(bm, new Rectangle(0, 0, ctl.Width, ctl.Height));
            return bm;
        }

        // Send the image to a PrintPreviewDialog.
        private Image ImageToPrint;
        private void PrintImage(Image image)
        {
            // Save a reference to the image to print.
            ImageToPrint = image;

            // Display the dialog.
            ppdForm.ShowDialog();
        }

        // Print the page.
        private void pdocForm_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Center the image.
            int cx = e.MarginBounds.X + e.MarginBounds.Width / 2;
            int cy = e.MarginBounds.Y + e.MarginBounds.Height / 2;
            Rectangle rect = new Rectangle(
                cx - ImageToPrint.Width / 2, cy - ImageToPrint.Height / 2,
                ImageToPrint.Width, ImageToPrint.Height);

            e.Graphics.InterpolationMode = InterpolationMode.High;
            e.Graphics.DrawImage(ImageToPrint, rect);
        }

        private void LblAlert_Click(object sender, EventArgs e)
        {
            string rptPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Report.bmp");
            Process.Start(rptPath);
        }
    }
}
