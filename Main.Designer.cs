namespace SOPAGAV_Dashboard
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDeconnecter = new FontAwesome.Sharp.IconButton();
            this.btnBlacklist = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnBus = new FontAwesome.Sharp.IconButton();
            this.btnPromotion = new FontAwesome.Sharp.IconButton();
            this.btnVoyageur = new FontAwesome.Sharp.IconButton();
            this.btnReservation = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimise = new FontAwesome.Sharp.IconButton();
            this.btnMaximise = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildFrm = new System.Windows.Forms.Label();
            this.pctIconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pnlShadow = new System.Windows.Forms.Panel();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.pctBatterie = new FontAwesome.Sharp.IconPictureBox();
            this.lblBattery = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHeure = new System.Windows.Forms.Label();
            this.tmrChrono = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBatterie)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.pnlMenu.Controls.Add(this.btnDeconnecter);
            this.pnlMenu.Controls.Add(this.btnBlacklist);
            this.pnlMenu.Controls.Add(this.btnUser);
            this.pnlMenu.Controls.Add(this.btnBus);
            this.pnlMenu.Controls.Add(this.btnPromotion);
            this.pnlMenu.Controls.Add(this.btnVoyageur);
            this.pnlMenu.Controls.Add(this.btnReservation);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.panel3);
            resources.ApplyResources(this.pnlMenu, "pnlMenu");
            this.pnlMenu.Name = "pnlMenu";
            // 
            // btnDeconnecter
            // 
            resources.ApplyResources(this.btnDeconnecter, "btnDeconnecter");
            this.btnDeconnecter.FlatAppearance.BorderSize = 0;
            this.btnDeconnecter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDeconnecter.Icon = FontAwesome.Sharp.IconChar.SignOut;
            this.btnDeconnecter.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDeconnecter.IconSize = 26;
            this.btnDeconnecter.Name = "btnDeconnecter";
            this.btnDeconnecter.UseVisualStyleBackColor = true;
            // 
            // btnBlacklist
            // 
            resources.ApplyResources(this.btnBlacklist, "btnBlacklist");
            this.btnBlacklist.FlatAppearance.BorderSize = 0;
            this.btnBlacklist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBlacklist.Icon = FontAwesome.Sharp.IconChar.TrashO;
            this.btnBlacklist.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBlacklist.IconSize = 26;
            this.btnBlacklist.Name = "btnBlacklist";
            this.btnBlacklist.UseVisualStyleBackColor = true;
            this.btnBlacklist.Click += new System.EventHandler(this.btnBlacklist_Click);
            // 
            // btnUser
            // 
            resources.ApplyResources(this.btnUser, "btnUser");
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUser.Icon = FontAwesome.Sharp.IconChar.Users;
            this.btnUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUser.IconSize = 26;
            this.btnUser.Name = "btnUser";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnBus
            // 
            resources.ApplyResources(this.btnBus, "btnBus");
            this.btnBus.FlatAppearance.BorderSize = 0;
            this.btnBus.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBus.Icon = FontAwesome.Sharp.IconChar.Bus;
            this.btnBus.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBus.IconSize = 26;
            this.btnBus.Name = "btnBus";
            this.btnBus.UseVisualStyleBackColor = true;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // btnPromotion
            // 
            resources.ApplyResources(this.btnPromotion, "btnPromotion");
            this.btnPromotion.FlatAppearance.BorderSize = 0;
            this.btnPromotion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPromotion.Icon = FontAwesome.Sharp.IconChar.Diamond;
            this.btnPromotion.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPromotion.IconSize = 26;
            this.btnPromotion.Name = "btnPromotion";
            this.btnPromotion.UseVisualStyleBackColor = true;
            this.btnPromotion.Click += new System.EventHandler(this.btnPromotion_Click);
            // 
            // btnVoyageur
            // 
            resources.ApplyResources(this.btnVoyageur, "btnVoyageur");
            this.btnVoyageur.FlatAppearance.BorderSize = 0;
            this.btnVoyageur.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVoyageur.Icon = FontAwesome.Sharp.IconChar.SmileO;
            this.btnVoyageur.IconColor = System.Drawing.Color.Gainsboro;
            this.btnVoyageur.IconSize = 26;
            this.btnVoyageur.Name = "btnVoyageur";
            this.btnVoyageur.UseVisualStyleBackColor = true;
            this.btnVoyageur.Click += new System.EventHandler(this.btnVoyageur_Click);
            // 
            // btnReservation
            // 
            resources.ApplyResources(this.btnReservation, "btnReservation");
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReservation.Icon = FontAwesome.Sharp.IconChar.Ticket;
            this.btnReservation.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReservation.IconSize = 26;
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnDashboard
            // 
            resources.ApplyResources(this.btnDashboard, "btnDashboard");
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.Icon = FontAwesome.Sharp.IconChar.BarChart;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconSize = 26;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pctLogo);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // pctLogo
            // 
            resources.ApplyResources(this.pctLogo, "pctLogo");
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.TabStop = false;
            this.pctLogo.Click += new System.EventHandler(this.pctLogo_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.pnlHeader.Controls.Add(this.lblHeure);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.pnlTitleBar);
            resources.ApplyResources(this.pnlHeader, "pnlHeader");
            this.pnlHeader.Name = "pnlHeader";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.lblBattery);
            this.pnlTitleBar.Controls.Add(this.btnMinimise);
            this.pnlTitleBar.Controls.Add(this.btnMaximise);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblTitleChildFrm);
            this.pnlTitleBar.Controls.Add(this.pctBatterie);
            this.pnlTitleBar.Controls.Add(this.pctIconCurrentChildForm);
            resources.ApplyResources(this.pnlTitleBar, "pnlTitleBar");
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnMinimise
            // 
            resources.ApplyResources(this.btnMinimise, "btnMinimise");
            this.btnMinimise.FlatAppearance.BorderSize = 0;
            this.btnMinimise.Icon = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimise.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimise.IconSize = 30;
            this.btnMinimise.Name = "btnMinimise";
            this.btnMinimise.UseVisualStyleBackColor = true;
            this.btnMinimise.Click += new System.EventHandler(this.btnMinimise_Click);
            this.btnMinimise.MouseHover += new System.EventHandler(this.btnMinimise_MouseHover);
            // 
            // btnMaximise
            // 
            resources.ApplyResources(this.btnMaximise, "btnMaximise");
            this.btnMaximise.FlatAppearance.BorderSize = 0;
            this.btnMaximise.Icon = FontAwesome.Sharp.IconChar.SquareO;
            this.btnMaximise.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximise.IconSize = 30;
            this.btnMaximise.Name = "btnMaximise";
            this.btnMaximise.UseVisualStyleBackColor = true;
            this.btnMaximise.Click += new System.EventHandler(this.btnMaximise_Click);
            this.btnMaximise.MouseHover += new System.EventHandler(this.btnMaximise_MouseHover);
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Icon = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconSize = 30;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // lblTitleChildFrm
            // 
            resources.ApplyResources(this.lblTitleChildFrm, "lblTitleChildFrm");
            this.lblTitleChildFrm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildFrm.Name = "lblTitleChildFrm";
            // 
            // pctIconCurrentChildForm
            // 
            this.pctIconCurrentChildForm.ActiveColor = System.Drawing.Color.Black;
            this.pctIconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.pctIconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.pctIconCurrentChildForm.InActiveColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.pctIconCurrentChildForm, "pctIconCurrentChildForm");
            this.pctIconCurrentChildForm.Name = "pctIconCurrentChildForm";
            this.pctIconCurrentChildForm.TabStop = false;
            // 
            // pnlShadow
            // 
            this.pnlShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            resources.ApplyResources(this.pnlShadow, "pnlShadow");
            this.pnlShadow.Name = "pnlShadow";
            // 
            // pnlDisplay
            // 
            resources.ApplyResources(this.pnlDisplay, "pnlDisplay");
            this.pnlDisplay.Name = "pnlDisplay";
            // 
            // pctBatterie
            // 
            this.pctBatterie.ActiveColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pctBatterie, "pctBatterie");
            this.pctBatterie.BackColor = System.Drawing.Color.Transparent;
            this.pctBatterie.IconChar = FontAwesome.Sharp.IconChar.BatteryFull;
            this.pctBatterie.InActiveColor = System.Drawing.Color.Gainsboro;
            this.pctBatterie.Name = "pctBatterie";
            this.pctBatterie.TabStop = false;
            // 
            // lblBattery
            // 
            resources.ApplyResources(this.lblBattery, "lblBattery");
            this.lblBattery.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBattery.Name = "lblBattery";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Name = "lblDate";
            // 
            // lblHeure
            // 
            resources.ApplyResources(this.lblHeure, "lblHeure");
            this.lblHeure.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHeure.Name = "lblHeure";
            // 
            // tmrChrono
            // 
            this.tmrChrono.Enabled = true;
            this.tmrChrono.Tick += new System.EventHandler(this.tmrChrono_Tick);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.pnlShadow);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctIconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctBatterie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Panel pnlHeader;
        private FontAwesome.Sharp.IconButton btnDeconnecter;
        private FontAwesome.Sharp.IconButton btnBlacklist;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnBus;
        private FontAwesome.Sharp.IconButton btnPromotion;
        private FontAwesome.Sharp.IconButton btnVoyageur;
        private FontAwesome.Sharp.IconButton btnReservation;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitleChildFrm;
        private FontAwesome.Sharp.IconPictureBox pctIconCurrentChildForm;
        private System.Windows.Forms.Panel pnlShadow;
        private System.Windows.Forms.Panel pnlDisplay;
        private FontAwesome.Sharp.IconButton btnMinimise;
        private FontAwesome.Sharp.IconButton btnMaximise;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lblBattery;
        private FontAwesome.Sharp.IconPictureBox pctBatterie;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer tmrChrono;
    }
}

