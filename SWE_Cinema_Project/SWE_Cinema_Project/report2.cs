using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace SWE_Cinema_Project
{
    public partial class Movies_Profit : Form
    {
        private Crystal_2 cr;
        public Movies_Profit()
        {
            InitializeComponent();
        }

        Form CallingForm = null;
        public Movies_Profit(Form CallingForm)
        {
            InitializeComponent();
            this.CallingForm = CallingForm;
        }
        private void report2_Load(object sender, EventArgs e)
        {
            cr = new Crystal_2();
        }

        private void Movies_Profit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.CallingForm != null)
            {
                this.CallingForm.Show();
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Generate_report_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, Convert.ToDateTime(start_date.Text));
            cr.SetParameterValue(1, Convert.ToDateTime(end_date.Text));
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
