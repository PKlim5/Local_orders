namespace Local_orders
{
    partial class DBOrders
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBOrders));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblIntro = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.customerControl1 = new Local_orders.CustomerForm();
            this.homeForm1 = new Local_orders.HomeForm();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            resources.ApplyResources(this.lblTime, "lblTime");
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Name = "lblTime";
            // 
            // lblIntro
            // 
            this.lblIntro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lblIntro, "lblIntro");
            this.lblIntro.ForeColor = System.Drawing.Color.Silver;
            this.lblIntro.Name = "lblIntro";
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelSide.Controls.Add(this.panelBlue);
            this.panelSide.Controls.Add(this.labelTitle);
            this.panelSide.Controls.Add(this.pictureLogo);
            this.panelSide.Controls.Add(this.buttonExit);
            this.panelSide.Controls.Add(this.buttonClients);
            this.panelSide.Controls.Add(this.buttonHistory);
            this.panelSide.Controls.Add(this.buttonOrders);
            this.panelSide.Controls.Add(this.buttonHome);
            this.panelSide.Controls.Add(this.lblDay);
            this.panelSide.Controls.Add(this.lblDate);
            this.panelSide.Controls.Add(this.lblIntro);
            this.panelSide.Controls.Add(this.lblTime);
            resources.ApplyResources(this.panelSide, "panelSide");
            this.panelSide.Name = "panelSide";
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(160)))));
            resources.ApplyResources(this.panelBlue, "panelBlue");
            this.panelBlue.Name = "panelBlue";
            // 
            // labelTitle
            // 
            this.labelTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.labelTitle, "labelTitle");
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(160)))));
            this.labelTitle.Name = "labelTitle";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = global::Local_orders.Properties.Resources.logo;
            resources.ApplyResources(this.pictureLogo, "pictureLogo");
            this.pictureLogo.InitialImage = global::Local_orders.Properties.Resources.logo;
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonExit, "buttonExit");
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Image = global::Local_orders.Properties.Resources.exit;
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEnter);
            this.buttonExit.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // buttonClients
            // 
            this.buttonClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClients.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonClients, "buttonClients");
            this.buttonClients.ForeColor = System.Drawing.Color.White;
            this.buttonClients.Image = global::Local_orders.Properties.Resources.customer;
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            this.buttonClients.MouseEnter += new System.EventHandler(this.buttonClients_MouseEnter);
            this.buttonClients.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHistory.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonHistory, "buttonHistory");
            this.buttonHistory.ForeColor = System.Drawing.Color.White;
            this.buttonHistory.Image = global::Local_orders.Properties.Resources.history;
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            this.buttonHistory.MouseEnter += new System.EventHandler(this.buttonHistory_MouseEnter);
            this.buttonHistory.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // buttonOrders
            // 
            this.buttonOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOrders.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonOrders, "buttonOrders");
            this.buttonOrders.ForeColor = System.Drawing.Color.White;
            this.buttonOrders.Image = global::Local_orders.Properties.Resources.orders;
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            this.buttonOrders.MouseEnter += new System.EventHandler(this.buttonOrders_MouseEnter);
            this.buttonOrders.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // buttonHome
            // 
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonHome, "buttonHome");
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = global::Local_orders.Properties.Resources.home1;
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            this.buttonHome.MouseEnter += new System.EventHandler(this.buttonHome_MouseEnter);
            this.buttonHome.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // lblDay
            // 
            resources.ApplyResources(this.lblDay, "lblDay");
            this.lblDay.ForeColor = System.Drawing.Color.White;
            this.lblDay.Name = "lblDay";
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Name = "lblDate";
            // 
            // panelTop
            // 
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(160)))));
            this.panelTop.Name = "panelTop";
            // 
            // panelForms
            // 
            resources.ApplyResources(this.panelForms, "panelForms");
            this.panelForms.BackColor = System.Drawing.Color.Gainsboro;
            this.panelForms.Controls.Add(this.customerControl1);
            this.panelForms.Controls.Add(this.homeForm1);
            this.panelForms.Name = "panelForms";
            // 
            // customerControl1
            // 
            resources.ApplyResources(this.customerControl1, "customerControl1");
            this.customerControl1.Name = "customerControl1";
            // 
            // homeForm1
            // 
            resources.ApplyResources(this.homeForm1, "homeForm1");
            this.homeForm1.Name = "homeForm1";
            // 
            // DBOrders
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelSide);
            this.Name = "DBOrders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelForms.ResumeLayout(false);
            this.panelForms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelForms;
        private HomeForm homeForm1;
        private CustomerForm customerControl1;
    }
}

