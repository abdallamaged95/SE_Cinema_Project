using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace SWE_Cinema_Project
{
    public partial class Main_Menu_Form : Form
    {
        
        string ordb = Program.getORDB();
        OracleConnection connection;
        public Main_Menu_Form()
        {
            InitializeComponent();
        }

        private void Main_Menu_Form_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(ordb);
            connection.Open();
        }

        private void Department_Employees_Button_Click(object sender, EventArgs e)
        {
            Department_Employees_Form deForm = new Department_Employees_Form(this);
            deForm.Show();
            this.Hide();
        }

        private void Movie_Customers_Button_Click(object sender, EventArgs e)
        {
            Movie_Customer_Form mcForm = new Movie_Customer_Form(this);
            mcForm.Show();
            this.Hide();
        }
    }
}