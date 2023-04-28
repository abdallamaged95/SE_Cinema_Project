using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Cinema_Project
{
    public partial class Movies_Actors : Form
    {
        private Crystal_1 cr;
        public Movies_Actors()
        {
            InitializeComponent();
        }
        Form CallingForm = null;
        public Movies_Actors(Form CallingForm)
        {
            InitializeComponent();
            this.CallingForm = CallingForm;
        }
        
        private void Movies_Actors_Load(object sender, EventArgs e)
        {
            cr = new Crystal_1();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Movies_Actors_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.CallingForm != null)
            {
                this.CallingForm.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
