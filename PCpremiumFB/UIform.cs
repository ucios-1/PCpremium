using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using PCpremiumFB.Data;
using PCpremiumFB.HelpProg;

namespace PCpremiumFB
{
    public /*sealed*/ partial class UIform : Form
    {
        private bool Drag;
        private int MouseX;
        private int MouseY;

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
        [System.Runtime.InteropServices.DllImport("dwmapi.dll")]

        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW; return cp;
            }
        }
        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0; DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        }; DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                    }
                    break;
                default: break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT) m.Result = (IntPtr)HTCAPTION;
        }
        private void PanelMove_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            MouseX = Cursor.Position.X - this.Left;
            MouseY = Cursor.Position.Y - this.Top;
        }
        private void PanelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                this.Top = Cursor.Position.Y - MouseY;
                this.Left = Cursor.Position.X - MouseX;
            }
        }
        private void PanelMove_MouseUp(object sender, MouseEventArgs e) { Drag = false; }


        public Items it = new Items();
        Bitmap bmp;

        public UIform()
        {
            InitializeComponent();
        }

        private void getData() {
            ChekingClass ck = new ChekingClass();
            it.Klient = txtKlient.Text;
            it.Data = dtPicker.Text;
            it.Cena = txtCena.Text;
            it.Model = txtModel.Text;
            it.Obudowa = ck.comCase(this);
            it.Poj_Dysku1 = txtRozmiar.Text;
            it.Rodz_Dysku1 = ck.disc1Type(this);
            it.Stan_Dysku1 = ck.disc1Old(this);
            it.Poj_Dysku2 = txtRozmiar2.Text;
            it.Rodz_Dysku2 = ck.disc2Type(this);
            it.Stan_Dysku2 = ck.disc2Old(this);
            it.CD = ck.CD(this);
            it.System = ck.comSystem(this);
            it.SystemBit = ck.comSystemBit(this);
            it.SystemB = ck.comSystemB(this);
            it.System_Hm_Pr = ck.comSystemHmPr(this);
            it.System_Orig = ck.comSystemOrig(this);
            it.Uwagi = txtUwagi.Text;
            it.Karta_wideo = txtKGraficzna.Text;
            it.RAM = txtRAM.Text;
            it.Matryca = txtMatryca.Text;
            it.Klawiatura = txtKlawiatura.Text;
            it.Płatność = ck.order(this);
            it.Zamówione = ck.payment(this);
            it.Transport = txtTransport.Text;
            it.Instrukcje = txtInstrukcje.Text;
        }

        private bool checkFill() {
            if (it.Klient != null &&
                it.Obudowa != null &&
                it.Poj_Dysku1 != null &&
                it.Stan_Dysku1 != null &&
                //it.Poj_Dysku2 != null &&
                //it.Stan_Dysku2 != null &&
                it.CD != "" &&
                it.System != null &&
                it.SystemBit != null &&
                it.SystemB != null &&
                it.System_Hm_Pr != null &&
                it.System_Orig != null &&
                it.Płatność != null &&
                it.Zamówione != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void bttnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void bttnZapisz_Click_1(object sender, EventArgs e)
        {
            getData();
            if (checkFill())
            {
                Conn conn = new Conn();
                await conn.Insert(it);
                this.Close();
            }
            else
            {
                MessageBox.Show("Nie wypełniłeś wszystkich pól");
            }
        }

        private void bttnEdytuj_Click(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            getData();
            Task.Run(() => conn.Update(it, lblId.Text)).Wait();
            this.Close();
        }

        private void bttnUsun_Click(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            Task.Run(() => conn.Delete(this.lblId.Text)).Wait();
            this.Close();
        }

        private async void bttnZakoncz_Click(object sender, EventArgs e)
        {
            Conn conn = new Conn();
            getData();
            await conn.Insert(it, "Zamkniete/");
            Task.Run(() => conn.Delete(this.lblId.Text)).Wait();
            this.Close();
        }

        private void UIform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.ToString() == "P") {
                Graphics g = this.CreateGraphics();
                bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
                Graphics gm = Graphics.FromImage(bmp);
                gm.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }
    }
}
