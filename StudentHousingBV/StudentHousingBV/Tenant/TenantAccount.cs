﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingBV
{
    public partial class TenantAccount : Form
    {
        Tenant currentTenant;
        public TenantAccount()
        {
            InitializeComponent();

        }

        private void TenantAccount_Load(object sender, EventArgs e)
        {
            TenantHome home = (TenantHome)Application.OpenForms["TenantHome"];
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];

            currentTenant = home.getTenant();
            this.lblReports.Text = currentTenant.getReports() + " reports.";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            TenantHome home = (TenantHome)Application.OpenForms["TenantHome"];
            this.Close();
            home.Close();
            LogInScreen login = (LogInScreen)Application.OpenForms["LogInScreen"];
            login.Show();
        }
    }
}
