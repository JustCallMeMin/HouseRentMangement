﻿using System;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace HouseRentManagement
{
    public partial class Admin : DevExpress.XtraEditors.XtraForm
    {
        private string username;
        private ReportFormAdmin reportFormAdmin;
        private PriceForm priceForm;
        private ExportAdmin exportAdmin;
        private ContractAdmin contractAdmin;
        private CondoAdmin condoAdmin;
        private Tenant residentCard;
        private bool isDragging = false;
        private Point startPoint;
        public Admin(string username)
        {
            InitializeComponent();
            this.username = username;
            var mdiClient = Controls.OfType<MdiClient>().FirstOrDefault();
            if (mdiClient != null)
                mdiClient.BackColor = Color.FromArgb(237, 234, 229);
        }
        bool menuExpand = true;
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
        private void ShowReportForm()
        {
            if (reportFormAdmin == null)
            {
                reportFormAdmin = new ReportFormAdmin();
                reportFormAdmin.FormClosed += reportFormAdmin_FormClosed;
                reportFormAdmin.MdiParent = this;
                reportFormAdmin.Dock = DockStyle.Fill;
                reportFormAdmin.Show();
            }
            else
            {
                reportFormAdmin.Activate();
            }
        }
        private void reportFormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportFormAdmin = null;
        }
        private void ShowPriceForm()
        {
            if (reportFormAdmin == null)
            {
                priceForm = new PriceForm();
                priceForm.FormClosed += priceForm_FormClosed;
                priceForm.MdiParent = this;
                priceForm.Dock = DockStyle.Fill;
                priceForm.Show();
            }
            else
            {
                priceForm.Activate();
            }
        }

        private void priceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            priceForm = null;
        }
        private void ShowExportAdmin()
        {
            if (exportAdmin == null)
            {
                exportAdmin = new ExportAdmin();
                exportAdmin.FormClosed += exportAdmin_FormClosed;
                exportAdmin.MdiParent = this;
                exportAdmin.Dock = DockStyle.Fill;
                exportAdmin.Show();
            }
            else
            {
                exportAdmin.Activate();
            }
        }
        private void exportAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            exportAdmin = null;
        }
        private void ShowContractAdmin()
        {
            if (contractAdmin == null)
            {
                contractAdmin = new ContractAdmin();
                contractAdmin.FormClosed += contractAdmin_FormClosed;
                contractAdmin.MdiParent = this;
                contractAdmin.Dock = DockStyle.Fill;
                contractAdmin.Show();
            }
            else
            {
                contractAdmin.Activate();
            }
        }


        private void contractAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            contractAdmin = null;
        }
        private void ShowCondoAdmin()
        {
            if (condoAdmin == null)
            {
                condoAdmin = new CondoAdmin();
                condoAdmin.FormClosed += condoAdmin_FormClosed;
                condoAdmin.MdiParent = this;
                condoAdmin.Dock = DockStyle.Fill;
                condoAdmin.Show();
            }
            else
            {
                condoAdmin.Activate();
            }
        }
        private void condoAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            condoAdmin = null;
        }
        private void ShowResidentCard()
        {
            if (residentCard == null)
            {
                residentCard = new Tenant();
                residentCard.FormClosed += residentCard_FormClosed;
                residentCard.MdiParent = this;
                residentCard.Dock = DockStyle.Fill;
                residentCard.Show();
            }
            else
            {
                residentCard.Activate();
            }
        }
        private void residentCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            residentCard = null;
        }
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                if (pnlProfileLoad.Height + 5 >= 540)
                {
                    pnlProfileLoad.Height = 540;
                    menuTransition.Stop();
                    menuExpand = false;
                }
                else
                {
                    pnlProfileLoad.Height += 5;
                }
            }
            else
            {
                if (pnlProfileLoad.Height - 5 <= 54)
                {
                    pnlProfileLoad.Height = 54;
                    menuTransition.Stop();
                    menuExpand = true;
                }
                else
                {
                    pnlProfileLoad.Height -= 5;
                }
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowReportForm();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            ShowPriceForm();
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point newPoint = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(newPoint.X - startPoint.X, newPoint.Y - startPoint.Y);
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ShowExportAdmin();
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            ShowContractAdmin();
        }

        private void btnCondo_Click(object sender, EventArgs e)
        {
            ShowCondoAdmin();
        }

        private void btnResidentCard_Click(object sender, EventArgs e)
        {
            ShowResidentCard();
        }
    }

}
