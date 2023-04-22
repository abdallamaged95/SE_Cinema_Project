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
    public partial class Department_Employees_Form : Form
    {
        string ordb = Program.getORDB();
        OracleConnection connection;
        public Department_Employees_Form()
        {
            InitializeComponent();
        }

        private Form CallingForm = null;
        public Department_Employees_Form(Form CallingForm)
        {
            InitializeComponent();
            this.CallingForm = CallingForm;
        }

        private void Department_Employees_Form_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(ordb);
            connection.Open();

            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "select dep_id from department";
            command.CommandType = CommandType.Text;

            OracleDataReader dr = command.ExecuteReader();

            Department_ID_Combo_Box.Items.Clear();
            while (dr.Read())
            {
                Department_ID_Combo_Box.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void Back_Button_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Department_Employees_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.CallingForm != null)
            {
                this.CallingForm.Show();
            }
        }

        private void Department_ID_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "select dep_name from department where dep_id=:id";
            command.CommandType = CommandType.Text;

            command.Parameters.Add("id", Department_ID_Combo_Box.SelectedItem.ToString());
            OracleDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                Department_Name_Text_Box.Text = dr[0].ToString();
                Get_Employees_IDS(command.Parameters["id"].Value.ToString());
            }
            dr.Close();
        }

        private void Get_Employees_IDS(string dept_id)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "STAFF_IDS";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("id", Convert.ToInt32(dept_id));
            command.Parameters.Add("emp_ids", OracleDbType.RefCursor, ParameterDirection.Output);

            OracleDataReader dr = command.ExecuteReader();

            Employees_ID_Combo_Box.Items.Clear();
            while (dr.Read())
            {
                Employees_ID_Combo_Box.Items.Add(dr[0].ToString());
            }
            dr.Close();
        }

        private void Get_Employee_Salary(string emp_id)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "STAFF_SALARY";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("id", Convert.ToInt32(emp_id));
            command.Parameters.Add("salary", OracleDbType.Int32, ParameterDirection.Output);

            command.ExecuteNonQuery();
            Employee_Salary_Text_Box.Text = command.Parameters["salary"].Value.ToString();
        }

        private void Get_Employee_Name(string emp_id)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "select emp_name from staff where emp_id=:id";
            command.CommandType = CommandType.Text;

            command.Parameters.Add("id", emp_id);

            OracleDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                Employee_Name_Text_Box.Text = dr[0].ToString();
            }
            dr.Close();
        }

        private void Get_Employee_Gender(string emp_id)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "select gender from staff where emp_id=:id";
            command.CommandType = CommandType.Text;

            command.Parameters.Add("id", emp_id);

            OracleDataReader dr = command.ExecuteReader();
            if(dr.Read())
            {
                if (dr[0].ToString() == "M")
                {
                    Employee_Male_Radio_Button.Checked = true;
                }
                else if (dr[0].ToString() == "F")
                {
                    Employee_Female_Radio_Button.Checked= true;
                }
            }
        }

        private void Employees_ID_Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            Get_Employee_Name(Employees_ID_Combo_Box.SelectedItem.ToString());
            Get_Employee_Salary(Employees_ID_Combo_Box.SelectedItem.ToString());
            Get_Employee_Gender(Employees_ID_Combo_Box.SelectedItem.ToString());
        }

        private void Insert_Department_Data_Button_Click(object sender, EventArgs e)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "insert into department values(:dep_id,:dep_name)";
            command.CommandType = CommandType.Text;

            command.Parameters.Add("dep_id", Department_ID_Combo_Box.Text);
            command.Parameters.Add("dep_name", Department_Name_Text_Box.Text);

            try
            {
                command.ExecuteNonQuery();
                Department_ID_Combo_Box.Items.Add(Department_ID_Combo_Box.Text);
                MessageBox.Show("New Department Data has been added successfully.");
            }
            catch
            {
                MessageBox.Show("Please insert Department ID or Name / Please Choose another Department ID!");
            }
            
        }

        private void Insert_Employee_Data_Button_Click(object sender, EventArgs e)
        {
            int max_id;
            OracleCommand commandEmployeeMaxID = new OracleCommand();
            commandEmployeeMaxID.Connection = connection;
            commandEmployeeMaxID.CommandText = "select max(emp_id) from staff";
            commandEmployeeMaxID.CommandType = CommandType.Text;

            OracleDataReader dr = commandEmployeeMaxID.ExecuteReader();

            try
            {
                dr.Read();
                max_id = Convert.ToInt32(dr[0].ToString());
                max_id++;
            }
            catch
            {
                max_id = 1;
            }

            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "insert into staff values(:emp_id,:emp_name,:emp_salary,:emp_gender,:dep_id)";
            command.CommandType = CommandType.Text;

            command.Parameters.Add("emp_id", max_id.ToString());
            command.Parameters.Add("emp_name", Employee_Name_Text_Box.Text);
            command.Parameters.Add("emp_salary", Employee_Salary_Text_Box.Text);
            command.Parameters.Add("emp_gender", (Employee_Male_Radio_Button.Checked) ? "M" : "F");
            command.Parameters.Add("dep_id", Department_ID_Combo_Box.Text);

            try
            {
                command.ExecuteNonQuery();
                Employees_ID_Combo_Box.Items.Add(Employees_ID_Combo_Box.Text);
                MessageBox.Show("New Employee Data has been added successfully.");
            }
            catch
            {
                MessageBox.Show("Please insert Employee or Department Data!");
            }
        }

        private void Update_Department_Data_Button_Click(object sender, EventArgs e)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "update department set dep_name=:new_dep_name where dep_id=:id";
            command.CommandType = CommandType.Text;

            try
            {
                command.Parameters.Add("new_dep_name", Department_Name_Text_Box.Text);
                command.Parameters.Add("id", Department_ID_Combo_Box.SelectedItem.ToString());
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Department Name Changed successfully.");
                }
                catch
                {
                    MessageBox.Show("Failed to change Department name.");
                }
            }
            catch
            {
                MessageBox.Show("Please Select Department Id.");
            }
        }

        private void Update_Employee_Data_Department_Click(object sender, EventArgs e)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "update staff set salary=:new_salary,dep_id=:new_dep_id where emp_id=:id";
            command.CommandType = CommandType.Text;

            try
            {
                command.Parameters.Add("new_salary", Employee_Salary_Text_Box.Text);
                command.Parameters.Add("new_dep_id", Department_ID_Combo_Box.Text);
                command.Parameters.Add("id", Employees_ID_Combo_Box.SelectedItem.ToString());
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee Data Changed Successfully.");
                }
                catch
                {
                    MessageBox.Show("Failed to change Employee Data.");
                }
            }
            catch
            {
                MessageBox.Show("Please Select Employee / Department ID.");
            }
            
        }

        private void Delete_Employee_Data_Button_Click(object sender, EventArgs e)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "delete from staff where emp_id=:id";
            command.CommandType = CommandType.Text;

            try
            {
                command.Parameters.Add("id", Employees_ID_Combo_Box.SelectedItem.ToString());
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Employee Data Deleted successfully.");
                }
                catch
                {
                    MessageBox.Show("Failed to delete Employee data.");
                }
            }
            catch
            {
                MessageBox.Show("Please Select Employee ID.");
            }
        }

        private void Total_Sales_Button_Click(object sender, EventArgs e)
        {
            OracleCommand command = new OracleCommand();
            command.Connection = connection;
            command.CommandText = "CALCULATE_PROFIT";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("sales", OracleDbType.Int32, ParameterDirection.Output);
            command.ExecuteNonQuery();
            Total_Sales_Text_Box.Text = command.Parameters["sales"].Value.ToString();
        }
    }
}