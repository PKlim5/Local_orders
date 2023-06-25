using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_orders
{
    public partial class DBOrders : Form
    {
        CultureInfo culture = new CultureInfo("pl-PL");
        
        //blue side panel
        int panelBlueHeight;
        int panelBlueTop;

        public DBOrders()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDay.Text = "Dziś jest " +culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek) + ",";
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            panelBlueHeight = buttonHome.Height;
            panelBlueTop = buttonHome.Top;
            homeForm1.Visible=true;
            customerControl1.Visible = false;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelBlue.Height = buttonHome.Height;
            panelBlue.Top = buttonHome.Top;
            panelBlueHeight = buttonHome.Height;
            panelBlueTop = buttonHome.Top;
            homeForm1.BringToFront();
            homeForm1.Visible = true;
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            panelBlue.Height = buttonOrders.Height;
            panelBlue.Top = buttonOrders.Top;
            panelBlueHeight = buttonOrders.Height;
            panelBlueTop = buttonOrders.Top;
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            panelBlue.Height = buttonClients.Height;
            panelBlue.Top = buttonClients.Top;
            panelBlueHeight = buttonClients.Height;
            panelBlueTop = buttonClients.Top;
            customerControl1.Visible = true;
            homeForm1.Visible = false;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            panelBlue.Height = buttonHistory.Height;
            panelBlue.Top = buttonHistory.Top;
            panelBlueHeight = buttonHistory.Height;
            panelBlueTop = buttonHistory.Top;
        }


        private void buttonHome_MouseEnter(object sender, EventArgs e)
        {
            panelBlue.Height = buttonHome.Height;
            panelBlue.Top = buttonHome.Top;
        }

        private void buttonOrders_MouseEnter(object sender, EventArgs e)
        {
            panelBlue.Height = buttonOrders.Height;
            panelBlue.Top = buttonOrders.Top;
        }

        private void buttonClients_MouseEnter(object sender, EventArgs e)
        {
            panelBlue.Height = buttonClients.Height;
            panelBlue.Top = buttonClients.Top;
        }

        private void buttonHistory_MouseEnter(object sender, EventArgs e)
        {
            panelBlue.Height = buttonHistory.Height;
            panelBlue.Top = buttonHistory.Top;
        }

        private void buttonExit_MouseEnter(object sender, EventArgs e)
        {
            panelBlue.Height = buttonExit.Height;
            panelBlue.Top = buttonExit.Top;
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            panelBlue.Height = panelBlueHeight;
            panelBlue.Top = panelBlueTop;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
