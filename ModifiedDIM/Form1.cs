using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBLibrary;
using Point = System.Drawing.Point;

namespace ModifiedDIM
{
    public partial class DIMForm : Form
    {
        public DIMForm()
        {
            InitializeComponent();
            //ApiHelper.InitializeClient();
        }

        private void DIMForm_Load(object sender, EventArgs e)
        {   
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            WindowState = FormWindowState.Maximized;
            lblAuth.Left = (this.ClientSize.Width - lblAuth.Width) / 2;
            lblAuth2.Width = (this.ClientSize.Width - 100);
            lblAuth2.Left = (this.ClientSize.Width - lblAuth2.Width) / 2;
            btnAuth.Left = (this.ClientSize.Width - btnAuth.Width) / 2;
        }
        
        private void btnAuth_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm formOAuth = new SearchForm();
            formOAuth.ShowDialog();
            this.Close();
        }

        //Code for title bar button functionality and 
        //hover mechanics on minimize, maximize(window), and close buttons 
        //Click to expand
                        
        private void min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void winBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                imgResize.Visible = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                imgResize.Visible = true;
            }
            lblAuth2.Width = (this.ClientSize.Width - 100);
            lblAuth2.Left = (this.ClientSize.Width - lblAuth2.Width) / 2;
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.Image = ((System.Drawing.Image)(Properties.Resources.closeNorm));
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.Image = ((System.Drawing.Image)(Properties.Resources.closeHover));
            closeBtn.BringToFront();
        }

        private void windowBtn_MouseEnter(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                windowBtn.Image = (System.Drawing.Image)(Properties.Resources.winMaxHover);
            }
            else
            {
                windowBtn.Image = ((System.Drawing.Image)(Properties.Resources.winHover));
            }
            windowBtn.BringToFront();
        }

        private void windowBtn_MouseLeave(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                windowBtn.Image = (System.Drawing.Image)(Properties.Resources.winMaxNorm);
            }
            else
            {
                windowBtn.Image = ((System.Drawing.Image)(Properties.Resources.winNorm));
            }
        }

        private void minBtn_MouseEnter(object sender, EventArgs e)
        {
            minBtn.Image = ((System.Drawing.Image)(Properties.Resources.minHover));
            minBtn.BringToFront();
        }

        private void minBtn_MouseLeave(object sender, EventArgs e)
        {
            minBtn.Image = ((System.Drawing.Image)(Properties.Resources.minNorm));
        }


        //Code for making the window moveable and resizeable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void pnlTitleBar1_OnMouseDown(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
    }
}
