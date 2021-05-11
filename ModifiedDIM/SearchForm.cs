using System;
using System.Drawing;
using System.Windows.Forms;
using VBLibrary;

//This is the form I'm working on, the other form doesn't matter and doesn't show
namespace ModifiedDIM
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }

        private void FormOAuthBrowser_Load(object sender, EventArgs e)
        {
            label1.Hide();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
            if (this.WindowState != FormWindowState.Maximized)
            {
                windowBtn.Image = (System.Drawing.Image)(Properties.Resources.winMaxNorm);
            }
            else
            {
                windowBtn.Image = ((System.Drawing.Image)(Properties.Resources.winNorm));
            }
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
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
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

        public static string output = "";

        public void btnSearch_Click(object sender, EventArgs e)
        {
            string text = tbSearch.Text;
            int i = 0;
            count = 0;

            if (Member.CharacterList.Count != i)
            {
                pnlHead.Controls.Clear();
                pnlBody.Controls.Clear();
                while (i < Member.CharacterList.Count)
                {
                    Member.CharacterList[i].ItemList.Clear();
                    Member.CharacterList[i].OddList.Clear();
                    i++;
                }
                Member.CharacterList.Clear();
            }
            
            try
            {
                if (text != "")
                {
                    label1.Show();
                    pnlBody.Visible = false;
                    MemberProcessor.SearchDestinyPlayer(text);
                    InventoryProcessor.GetItems();

                    Character();
                    //btnApi.Visible = true;
                }
                else
                {
                    var lbl = new Label();
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = Color.WhiteSmoke;
                    lbl.Font = new Font(new FontFamily("Arial"), 24, FontStyle.Bold);
                    lbl.Location = new Point(530, 150);
                    lbl.AutoSize = true;
                    lbl.Tag = "lblError";
                    lbl.Text = "Please enter a player";
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    pnlBody.Controls.Add(lbl);
                }
                label1.Hide();
                pnlBody.Visible = true;
            }
            catch (Exception)
            {
                var lbl = new Label();
                lbl.BackColor = Color.Transparent;
                lbl.ForeColor = Color.WhiteSmoke;
                lbl.Font = new Font(new FontFamily("Arial"), 24, FontStyle.Bold);
                lbl.Location = new Point(400, 150);
                lbl.AutoSize = true;
                lbl.Tag = "lblError";
                lbl.Text = "We weren't able to find this player,\n please try again.";
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                pnlBody.Controls.Add(lbl);
            }
        }
        public int count = 0;
        private void Character()
        {
            int pbLocX = 12, lbl1LocX = 93, lbl2LocX = 93, lbl3LocX = 382, lbl4LocX = 372;
            foreach (var character in Member.CharacterList)
            {
                var lbl1 = new Label();
                lbl1.Location = new Point(lbl1LocX, 6);
                lbl1.AutoSize = true;
                lbl1.Font = new Font(new FontFamily("Arial"), 15, FontStyle.Bold);
                lbl1.ForeColor = Color.White;
                lbl1.Tag = "lblClass" + count;
                lbl1.Text = MemberProcessor.LabelClassType(character.Info.Class);
                pnlHead.Controls.Add(lbl1);

                var lbl2 = new Label();
                lbl2.Location = new Point(lbl2LocX, 37);
                lbl2.AutoSize = true;
                lbl2.Font = new Font(new FontFamily("Arial"), 12);
                lbl2.ForeColor = Color.Silver;
                lbl2.Tag = "lblRace" + count;
                lbl2.Text = MemberProcessor.LabelRaceType(character.Info.Race);
                pnlHead.Controls.Add(lbl2);

                var lbl3 = new Label();
                lbl3.Location = new Point(lbl3LocX, 3);
                lbl3.AutoSize = true;
                lbl3.Font = new Font(new FontFamily("Microsoft Sans Serif"), 22, FontStyle.Bold);
                lbl3.ForeColor = Color.FromArgb(225, 214, 0);
                lbl3.Tag = "lblLight" + count;
                lbl3.Text = character.Info.Light.ToString();
                pnlHead.Controls.Add(lbl3);

                var lbl4 = new Label();
                lbl4.Location = new Point(lbl4LocX, 6);
                lbl4.AutoSize = true;
                lbl4.Font = new Font(new FontFamily("Microsoft Sans Serif"), 9, FontStyle.Bold);
                lbl4.ForeColor = Color.FromArgb(225, 214, 0);
                lbl4.Tag = "lblSym" + count;
                lbl4.Text = "✧";
                pnlHead.Controls.Add(lbl4);

                var pb = new PictureBox();
                pb.Location = new Point(pbLocX, 0);
                pb.Size = new Size(480, 100);
                pb.Tag = "pbChar" + count;
                pb.ImageLocation = character.Info.EmblemBG;
                //pb.Click += (sender, _) => { var id = ((Control)sender).Tag; /*...do stuff with i...*/  };
                pnlHead.Controls.Add(pb);

                lbl4.Location = pb.PointToClient(lbl4.Parent.PointToScreen(lbl4.Location));
                lbl4.Parent = pb;
                lbl1.Location = pb.PointToClient(lbl1.Parent.PointToScreen(lbl1.Location));
                lbl1.Parent = pb;
                lbl2.Location = pb.PointToClient(lbl2.Parent.PointToScreen(lbl2.Location));
                lbl2.Parent = pb;
                lbl3.Location = pb.PointToClient(lbl3.Parent.PointToScreen(lbl3.Location));
                lbl3.Parent = pb;

                pbLocX += 490;
                lbl1LocX += 490;
                lbl2LocX += 490;
                lbl3LocX += 490;
                lbl4LocX += 490;
                Items();
                count++;
            }
        }

        public void Items()
        {
            var pnl = new Panel();
            pnl.Location = new Point(490 * count, 0);
            pnl.Size = new Size(486, pnlBody.Height);
            pnl.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
            pnl.Tag = "pnlHolder" + count;
            pnl.BackColor = Color.Transparent;
            pnlBody.Controls.Add(pnl);

            var pnl1 = new Panel();
            pnl1.Dock = DockStyle.Fill;
            pnl1.AutoScroll = true;
            pnl1.Tag = "pnlScroll" + count;
            pnl1.BackColor = Color.Transparent;
            pnl.Controls.Add(pnl1);

            int count1 = Member.CharacterList[count].ItemList.Count - 1;

            while (count1 >= 0 )
            {
                var pnl2 = new Panel();
                pnl2.Dock = DockStyle.Top;
                pnl2.Tag = "pnlItem" + count1 + "x" + count;
                pnl2.BackColor = Color.Transparent;
                if (count1 == 0 || count1 == 3 || count1 == 8) { pnl2.Size = new Size(465, 156); }
                else { pnl2.Size = new Size(465, 105); }
                pnl1.Controls.Add(pnl2);

                var pb = new PictureBox();
                if (count1 == 0 || count1 == 3 || count1 == 8) { pb.Location = new Point(12, 52); }
                else { pb.Location = new Point(12, 0); }
                pb.Size = new Size(96, 96);
                pb.Tag = "pbItem" + count1 + "x" + count;
                pb.ImageLocation = Member.CharacterList[count].ItemList[count1].itemInfo.ItemIcon;
                pnl2.Controls.Add(pb);

                if (Member.CharacterList[count].ItemList[count1].itemInfo.IconWM != "none")
                {
                    var pb1 = new PictureBox();
                    if (count1 == 0 || count1 == 3 || count1 == 8) { pb1.Location = new Point(12, 52); }
                    else { pb1.Location = new Point(12, 0); }
                    pb1.Size = new Size(96, 96);
                    pb1.Tag = "pbItemWM" + count1 + "x" + count;
                    pb1.ImageLocation = Member.CharacterList[count].ItemList[count1].itemInfo.IconWM;
                    pnl2.Controls.Add(pb1);

                    pb1.Location = pb.PointToClient(pb1.Parent.PointToScreen(pb1.Location));
                    pb1.Parent = pb;
                }

                if (count1 == 0 || count1 == 3 || count1 == 8)
                {
                    var lbl = new Label();
                    lbl.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    lbl.BackColor = Color.Black;
                    lbl.ForeColor = Color.WhiteSmoke;
                    lbl.Font = new Font(new FontFamily("Arial"), 16, FontStyle.Bold);
                    lbl.Location = new Point(12, 0);
                    if (count1 == 8) { lbl.Size = new Size(465, 43); }
                    else { lbl.Size = new Size(465, 43);}
                    lbl.AutoSize = false;
                    lbl.Tag = "lblHeader" + count1 + "x" + count;
                    if (count1 == 0) { lbl.Text = "Weapons"; }
                    else if (count1 == 3) { lbl.Text = "Armor"; }
                    else if (count1 == 8) { lbl.Text = "Other"; }
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    pnl2.Controls.Add(lbl);
                }

                var lbl1 = new Label();
                lbl1.ForeColor = Color.WhiteSmoke;
                lbl1.AutoSize = true;
                lbl1.Font = new Font("Microsoft Sans Serif", 12);
                if (count1 == 0 || count1 == 3 || count1 == 8) { lbl1.Location = new Point(114, 52); }
                else { lbl1.Location = new Point(114, 0); }
                lbl1.Tag = "lblName" + count1 + "x" + count;
                lbl1.Text = Member.CharacterList[count].ItemList[count1].itemInfo.ItemName;
                pnl2.Controls.Add(lbl1);

                var lbl2 = new Label();
                lbl2.ForeColor = Color.Silver;
                lbl2.AutoSize = true;
                lbl2.Font = new Font("Microsoft Sans Serif", 10);
                if (count1 == 0 || count1 == 3 || count1 == 8) { lbl2.Location = new Point(115, 77); }
                else { lbl2.Location = new Point(115, 25); }
                lbl2.Tag = "lblType" + count1 + "x" + count;
                lbl2.Text = Member.CharacterList[count].ItemList[count1].itemInfo.ItemType;
                pnl2.Controls.Add(lbl2);

                var lbl3 = new Label();
                lbl3.ForeColor = Color.Gray;
                lbl3.MaximumSize = new Size(346, 56);
                lbl3.AutoSize = true;
                lbl3.Font = new Font("Microsoft Sans Serif", 9);
                if (count1 == 0 || count1 == 3 || count1 == 8) { lbl3.Location = new Point(116, 98); }
                else { lbl3.Location = new Point(116, 48); }
                lbl3.Tag = "lblDesc" + count1 + "x" + count;
                lbl3.Text = Member.CharacterList[count].ItemList[count1].itemInfo.ItemDesc;
                pnl2.Controls.Add(lbl3);
                count1--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ConsoleForm console = new ConsoleForm();
            //console.ShowDialog();
        }
    }
}
