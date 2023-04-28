using Oracle.DataAccess.Client;
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
    public partial class Movie_Customer_Form : Form
    {
        string ordb = Program.getORDB();
        OracleDataAdapter dataAdapter;
        OracleCommandBuilder commandbuilder;
        DataSet ds;
        public Movie_Customer_Form()
        {
            InitializeComponent();
        }

        private Form CallingForm = null;
        public Movie_Customer_Form(Form CallingForm)
        {
            InitializeComponent();
            this.CallingForm = CallingForm;
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Movie_Customer_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.CallingForm != null)
            {
                this.CallingForm.Show();
            }
        }

        private void Load_Data_Click(object sender, EventArgs e)
        {
            string command = "";
            string condition = Selector_Text_Box.Text;

            if (Movies_Radio_Button.Checked)
            {
                command = "select * from movies";

            }
            else if (Customers_Radio_Button.Checked)
            {
                if(condition != "")
                {
                    command = $"select * from customer where ticket_id={condition}";
                }
                else
                {
                    command = "select * from customer";
                }
            }

            dataAdapter = new OracleDataAdapter(command, ordb);
            ds = new DataSet();
            dataAdapter.Fill(ds);
            Data_Grid_View.DataSource = ds.Tables[0];
        }

        private void Save_New_Data_Click(object sender, EventArgs e)
        {
            commandbuilder = new OracleCommandBuilder(dataAdapter);
            dataAdapter.Update(ds.Tables[0]);
        }

        private void Data_Grid_View_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}