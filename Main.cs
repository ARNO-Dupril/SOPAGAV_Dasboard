using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace SOPAGAV_Dashboard
{
    public partial class Main : Form
    {
        //fields
        private IconButton currentBtn;
        private Form currentChildForm;

        //constructeur
        public Main()
        {
            InitializeComponent();
            //formulaire
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tmrChrono.Start();
            DateHeure();
            PourcentageBatterie();
        }

        //methodes
        private void BtnActif(object senderBtn)
        {
            if(senderBtn != null)
            {
                //on desactive d'abord le bouton precedent
                BtnInactif();
                //bouton courants
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(197, 2, 2);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
                currentBtn.Font = new Font(currentBtn.Font,FontStyle.Bold);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //icone du formulaire courant
                pctIconCurrentChildForm.IconChar = currentBtn.Icon;
                lblTitleChildFrm.Text = currentBtn.Text;
            }
        }

        private void BtnInactif()
        {
            if (currentBtn != null)
            {
                //bouton courants
                currentBtn.BackColor = Color.FromArgb(20, 0, 42);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.Font = new Font(currentBtn.Font, FontStyle.Regular);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void Ouvrir(Form childForm)
        {
            if(currentChildForm != null)
            {
                //ouvrir le formulaire seul
                currentChildForm.Close(); 
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDisplay.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void PourcentageBatterie()
        {
            PowerStatus statut = SystemInformation.PowerStatus;
            int pourcentage = (int)(statut.BatteryLifePercent * 100);
            if(pourcentage >= 90)
            {
                pctBatterie.IconChar = IconChar.BatteryFull;
            }
            else if((pourcentage < 90) && (pourcentage >= 60))
            {
                pctBatterie.IconChar = IconChar.BatteryThreeQuarters;
            }
            else if ((pourcentage < 60) && (pourcentage >= 40))
            {
                pctBatterie.IconChar = IconChar.BatteryHalf;
            }
            else if ((pourcentage < 40) && (pourcentage >= 10))
            {
                pctBatterie.IconChar = IconChar.BatteryQuarter;
            }
            else if ((pourcentage < 10) && (pourcentage >= 0))
            {
                pctBatterie.IconChar = IconChar.BatteryEmpty;
                pctBatterie.InActiveColor = Color.FromArgb(197, 2, 2);
                lblBattery.ForeColor = Color.FromArgb(197, 2, 2);
            }
            lblBattery.Text = $"{pourcentage}%";
        }

        private void DateHeure()
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblHeure.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            BtnActif(sender);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            BtnActif(sender);
        }

        private void btnVoyageur_Click(object sender, EventArgs e)
        {
            BtnActif(sender);
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            BtnActif(sender);
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            BtnActif(sender);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            BtnActif(sender);
        }

        private void btnBlacklist_Click(object sender, EventArgs e)
        {
            BtnActif(sender);
        }

        private void pctLogo_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            BtnInactif();
            pctIconCurrentChildForm.IconChar = IconChar.Home;
            lblTitleChildFrm.Text = "Acceuil";
        }


        //deplacement du formulaire
        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int  wMsg, int wParam, int lParam);
        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,  0x112, 0xf012, 0);
        }

        private void btnMinimise_MouseHover(object sender, EventArgs e)
        {
            btnMinimise.IconColor = Color.White;
        }

        private void btnMaximise_MouseHover(object sender, EventArgs e)
        {
            btnMaximise.IconColor = Color.White;
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.IconColor = Color.FromArgb(197,2,2);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximise_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void tmrChrono_Tick(object sender, EventArgs e)
        {
            DateHeure();
            PourcentageBatterie();
            tmrChrono.Start();
        }
    }
}
