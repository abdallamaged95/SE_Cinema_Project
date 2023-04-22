namespace SWE_Cinema_Project
{
    partial class Department_Employees_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Back_Button = new System.Windows.Forms.Button();
            this.Department_ID_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Department_ID_Label = new System.Windows.Forms.Label();
            this.Department_Name_Text_Box = new System.Windows.Forms.TextBox();
            this.Department_Name_Label = new System.Windows.Forms.Label();
            this.Department_Label = new System.Windows.Forms.Label();
            this.Employees_Label = new System.Windows.Forms.Label();
            this.Employees_ID_Combo_Box = new System.Windows.Forms.ComboBox();
            this.Employee_ID_Label = new System.Windows.Forms.Label();
            this.Employee_Name_Text_Box = new System.Windows.Forms.TextBox();
            this.Employee_Name_Label = new System.Windows.Forms.Label();
            this.Employee_Salary_Text_Box = new System.Windows.Forms.TextBox();
            this.Employee_Salary_Label = new System.Windows.Forms.Label();
            this.Employee_Male_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Employee_Female_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Employee_Gender_Label = new System.Windows.Forms.Label();
            this.Insert_Department_Data_Button = new System.Windows.Forms.Button();
            this.Update_Department_Data_Button = new System.Windows.Forms.Button();
            this.Delete_Employee_Data_Button = new System.Windows.Forms.Button();
            this.Insert_Employee_Data_Button = new System.Windows.Forms.Button();
            this.Controllers_Flow_Layout_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Update_Employee_Data_Department = new System.Windows.Forms.Button();
            this.Total_Sales_Text_Box = new System.Windows.Forms.TextBox();
            this.Total_Sales_Label = new System.Windows.Forms.Label();
            this.Total_Sales_Button = new System.Windows.Forms.Button();
            this.Sales_Label = new System.Windows.Forms.Label();
            this.Controllers_Flow_Layout_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(12, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(84, 30);
            this.Back_Button.TabIndex = 2;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click_1);
            // 
            // Department_ID_Combo_Box
            // 
            this.Department_ID_Combo_Box.FormattingEnabled = true;
            this.Department_ID_Combo_Box.Location = new System.Drawing.Point(144, 151);
            this.Department_ID_Combo_Box.Name = "Department_ID_Combo_Box";
            this.Department_ID_Combo_Box.Size = new System.Drawing.Size(218, 24);
            this.Department_ID_Combo_Box.TabIndex = 3;
            this.Department_ID_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Department_ID_Combo_Box_SelectedIndexChanged);
            // 
            // Department_ID_Label
            // 
            this.Department_ID_Label.AutoSize = true;
            this.Department_ID_Label.Location = new System.Drawing.Point(9, 154);
            this.Department_ID_Label.Name = "Department_ID_Label";
            this.Department_ID_Label.Size = new System.Drawing.Size(93, 16);
            this.Department_ID_Label.TabIndex = 4;
            this.Department_ID_Label.Text = "Department ID";
            // 
            // Department_Name_Text_Box
            // 
            this.Department_Name_Text_Box.Location = new System.Drawing.Point(144, 206);
            this.Department_Name_Text_Box.Name = "Department_Name_Text_Box";
            this.Department_Name_Text_Box.Size = new System.Drawing.Size(218, 22);
            this.Department_Name_Text_Box.TabIndex = 5;
            // 
            // Department_Name_Label
            // 
            this.Department_Name_Label.AutoSize = true;
            this.Department_Name_Label.Location = new System.Drawing.Point(9, 209);
            this.Department_Name_Label.Name = "Department_Name_Label";
            this.Department_Name_Label.Size = new System.Drawing.Size(117, 16);
            this.Department_Name_Label.TabIndex = 6;
            this.Department_Name_Label.Text = "Department Name";
            // 
            // Department_Label
            // 
            this.Department_Label.AutoSize = true;
            this.Department_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_Label.Location = new System.Drawing.Point(161, 95);
            this.Department_Label.Name = "Department_Label";
            this.Department_Label.Size = new System.Drawing.Size(107, 20);
            this.Department_Label.TabIndex = 7;
            this.Department_Label.Text = "Department";
            // 
            // Employees_Label
            // 
            this.Employees_Label.AutoSize = true;
            this.Employees_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employees_Label.Location = new System.Drawing.Point(548, 95);
            this.Employees_Label.Name = "Employees_Label";
            this.Employees_Label.Size = new System.Drawing.Size(100, 20);
            this.Employees_Label.TabIndex = 8;
            this.Employees_Label.Text = "Employees";
            // 
            // Employees_ID_Combo_Box
            // 
            this.Employees_ID_Combo_Box.FormattingEnabled = true;
            this.Employees_ID_Combo_Box.Location = new System.Drawing.Point(513, 151);
            this.Employees_ID_Combo_Box.Name = "Employees_ID_Combo_Box";
            this.Employees_ID_Combo_Box.Size = new System.Drawing.Size(212, 24);
            this.Employees_ID_Combo_Box.TabIndex = 9;
            this.Employees_ID_Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Employees_ID_Combo_Box_SelectedIndexChanged);
            // 
            // Employee_ID_Label
            // 
            this.Employee_ID_Label.AutoSize = true;
            this.Employee_ID_Label.Location = new System.Drawing.Point(398, 154);
            this.Employee_ID_Label.Name = "Employee_ID_Label";
            this.Employee_ID_Label.Size = new System.Drawing.Size(85, 16);
            this.Employee_ID_Label.TabIndex = 10;
            this.Employee_ID_Label.Text = "Employee ID";
            // 
            // Employee_Name_Text_Box
            // 
            this.Employee_Name_Text_Box.Location = new System.Drawing.Point(513, 206);
            this.Employee_Name_Text_Box.Name = "Employee_Name_Text_Box";
            this.Employee_Name_Text_Box.Size = new System.Drawing.Size(212, 22);
            this.Employee_Name_Text_Box.TabIndex = 11;
            // 
            // Employee_Name_Label
            // 
            this.Employee_Name_Label.AutoSize = true;
            this.Employee_Name_Label.Location = new System.Drawing.Point(398, 209);
            this.Employee_Name_Label.Name = "Employee_Name_Label";
            this.Employee_Name_Label.Size = new System.Drawing.Size(109, 16);
            this.Employee_Name_Label.TabIndex = 12;
            this.Employee_Name_Label.Text = "Employee Name";
            // 
            // Employee_Salary_Text_Box
            // 
            this.Employee_Salary_Text_Box.Location = new System.Drawing.Point(513, 259);
            this.Employee_Salary_Text_Box.Name = "Employee_Salary_Text_Box";
            this.Employee_Salary_Text_Box.Size = new System.Drawing.Size(212, 22);
            this.Employee_Salary_Text_Box.TabIndex = 13;
            // 
            // Employee_Salary_Label
            // 
            this.Employee_Salary_Label.AutoSize = true;
            this.Employee_Salary_Label.Location = new System.Drawing.Point(398, 262);
            this.Employee_Salary_Label.Name = "Employee_Salary_Label";
            this.Employee_Salary_Label.Size = new System.Drawing.Size(111, 16);
            this.Employee_Salary_Label.TabIndex = 14;
            this.Employee_Salary_Label.Text = "Employee Salary";
            // 
            // Employee_Male_Radio_Button
            // 
            this.Employee_Male_Radio_Button.AutoSize = true;
            this.Employee_Male_Radio_Button.Location = new System.Drawing.Point(552, 314);
            this.Employee_Male_Radio_Button.Name = "Employee_Male_Radio_Button";
            this.Employee_Male_Radio_Button.Size = new System.Drawing.Size(58, 20);
            this.Employee_Male_Radio_Button.TabIndex = 15;
            this.Employee_Male_Radio_Button.Text = "Male";
            this.Employee_Male_Radio_Button.UseVisualStyleBackColor = true;
            // 
            // Employee_Female_Radio_Button
            // 
            this.Employee_Female_Radio_Button.AutoSize = true;
            this.Employee_Female_Radio_Button.Location = new System.Drawing.Point(627, 314);
            this.Employee_Female_Radio_Button.Name = "Employee_Female_Radio_Button";
            this.Employee_Female_Radio_Button.Size = new System.Drawing.Size(74, 20);
            this.Employee_Female_Radio_Button.TabIndex = 16;
            this.Employee_Female_Radio_Button.Text = "Female";
            this.Employee_Female_Radio_Button.UseVisualStyleBackColor = true;
            // 
            // Employee_Gender_Label
            // 
            this.Employee_Gender_Label.AutoSize = true;
            this.Employee_Gender_Label.Location = new System.Drawing.Point(398, 316);
            this.Employee_Gender_Label.Name = "Employee_Gender_Label";
            this.Employee_Gender_Label.Size = new System.Drawing.Size(117, 16);
            this.Employee_Gender_Label.TabIndex = 17;
            this.Employee_Gender_Label.Text = "Employee Gender";
            // 
            // Insert_Department_Data_Button
            // 
            this.Insert_Department_Data_Button.Location = new System.Drawing.Point(5, 3);
            this.Insert_Department_Data_Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Insert_Department_Data_Button.Name = "Insert_Department_Data_Button";
            this.Insert_Department_Data_Button.Size = new System.Drawing.Size(150, 26);
            this.Insert_Department_Data_Button.TabIndex = 20;
            this.Insert_Department_Data_Button.Text = "Insert Dept";
            this.Insert_Department_Data_Button.UseVisualStyleBackColor = true;
            this.Insert_Department_Data_Button.Click += new System.EventHandler(this.Insert_Department_Data_Button_Click);
            // 
            // Update_Department_Data_Button
            // 
            this.Update_Department_Data_Button.Location = new System.Drawing.Point(165, 3);
            this.Update_Department_Data_Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Update_Department_Data_Button.Name = "Update_Department_Data_Button";
            this.Update_Department_Data_Button.Size = new System.Drawing.Size(150, 26);
            this.Update_Department_Data_Button.TabIndex = 21;
            this.Update_Department_Data_Button.Text = "Update Dept";
            this.Update_Department_Data_Button.UseVisualStyleBackColor = true;
            this.Update_Department_Data_Button.Click += new System.EventHandler(this.Update_Department_Data_Button_Click);
            // 
            // Delete_Employee_Data_Button
            // 
            this.Delete_Employee_Data_Button.Location = new System.Drawing.Point(645, 3);
            this.Delete_Employee_Data_Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Delete_Employee_Data_Button.Name = "Delete_Employee_Data_Button";
            this.Delete_Employee_Data_Button.Size = new System.Drawing.Size(150, 26);
            this.Delete_Employee_Data_Button.TabIndex = 22;
            this.Delete_Employee_Data_Button.Text = "Delete Emp";
            this.Delete_Employee_Data_Button.UseVisualStyleBackColor = true;
            this.Delete_Employee_Data_Button.Click += new System.EventHandler(this.Delete_Employee_Data_Button_Click);
            // 
            // Insert_Employee_Data_Button
            // 
            this.Insert_Employee_Data_Button.Location = new System.Drawing.Point(325, 3);
            this.Insert_Employee_Data_Button.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Insert_Employee_Data_Button.Name = "Insert_Employee_Data_Button";
            this.Insert_Employee_Data_Button.Size = new System.Drawing.Size(150, 26);
            this.Insert_Employee_Data_Button.TabIndex = 23;
            this.Insert_Employee_Data_Button.Text = "Insert Emp";
            this.Insert_Employee_Data_Button.UseVisualStyleBackColor = true;
            this.Insert_Employee_Data_Button.Click += new System.EventHandler(this.Insert_Employee_Data_Button_Click);
            // 
            // Controllers_Flow_Layout_Panel
            // 
            this.Controllers_Flow_Layout_Panel.Controls.Add(this.Insert_Department_Data_Button);
            this.Controllers_Flow_Layout_Panel.Controls.Add(this.Update_Department_Data_Button);
            this.Controllers_Flow_Layout_Panel.Controls.Add(this.Insert_Employee_Data_Button);
            this.Controllers_Flow_Layout_Panel.Controls.Add(this.Update_Employee_Data_Department);
            this.Controllers_Flow_Layout_Panel.Controls.Add(this.Delete_Employee_Data_Button);
            this.Controllers_Flow_Layout_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Controllers_Flow_Layout_Panel.Location = new System.Drawing.Point(0, 414);
            this.Controllers_Flow_Layout_Panel.Name = "Controllers_Flow_Layout_Panel";
            this.Controllers_Flow_Layout_Panel.Size = new System.Drawing.Size(800, 36);
            this.Controllers_Flow_Layout_Panel.TabIndex = 18;
            // 
            // Update_Employee_Data_Department
            // 
            this.Update_Employee_Data_Department.Location = new System.Drawing.Point(485, 3);
            this.Update_Employee_Data_Department.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Update_Employee_Data_Department.Name = "Update_Employee_Data_Department";
            this.Update_Employee_Data_Department.Size = new System.Drawing.Size(150, 26);
            this.Update_Employee_Data_Department.TabIndex = 24;
            this.Update_Employee_Data_Department.Text = "Update Emp";
            this.Update_Employee_Data_Department.UseVisualStyleBackColor = true;
            this.Update_Employee_Data_Department.Click += new System.EventHandler(this.Update_Employee_Data_Department_Click);
            // 
            // Total_Sales_Text_Box
            // 
            this.Total_Sales_Text_Box.Location = new System.Drawing.Point(131, 310);
            this.Total_Sales_Text_Box.Name = "Total_Sales_Text_Box";
            this.Total_Sales_Text_Box.Size = new System.Drawing.Size(148, 22);
            this.Total_Sales_Text_Box.TabIndex = 19;
            // 
            // Total_Sales_Label
            // 
            this.Total_Sales_Label.AutoSize = true;
            this.Total_Sales_Label.Location = new System.Drawing.Point(9, 313);
            this.Total_Sales_Label.Name = "Total_Sales_Label";
            this.Total_Sales_Label.Size = new System.Drawing.Size(76, 16);
            this.Total_Sales_Label.TabIndex = 20;
            this.Total_Sales_Label.Text = "Total Sales";
            // 
            // Total_Sales_Button
            // 
            this.Total_Sales_Button.Location = new System.Drawing.Point(285, 309);
            this.Total_Sales_Button.Name = "Total_Sales_Button";
            this.Total_Sales_Button.Size = new System.Drawing.Size(77, 23);
            this.Total_Sales_Button.TabIndex = 21;
            this.Total_Sales_Button.Text = "Load";
            this.Total_Sales_Button.UseVisualStyleBackColor = true;
            this.Total_Sales_Button.Click += new System.EventHandler(this.Total_Sales_Button_Click);
            // 
            // Sales_Label
            // 
            this.Sales_Label.AutoSize = true;
            this.Sales_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales_Label.Location = new System.Drawing.Point(161, 262);
            this.Sales_Label.Name = "Sales_Label";
            this.Sales_Label.Size = new System.Drawing.Size(56, 20);
            this.Sales_Label.TabIndex = 22;
            this.Sales_Label.Text = "Sales";
            // 
            // Department_Employees_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sales_Label);
            this.Controls.Add(this.Total_Sales_Button);
            this.Controls.Add(this.Total_Sales_Label);
            this.Controls.Add(this.Total_Sales_Text_Box);
            this.Controls.Add(this.Controllers_Flow_Layout_Panel);
            this.Controls.Add(this.Employee_Gender_Label);
            this.Controls.Add(this.Employee_Female_Radio_Button);
            this.Controls.Add(this.Employee_Male_Radio_Button);
            this.Controls.Add(this.Employee_Salary_Label);
            this.Controls.Add(this.Employee_Salary_Text_Box);
            this.Controls.Add(this.Employee_Name_Label);
            this.Controls.Add(this.Employee_Name_Text_Box);
            this.Controls.Add(this.Employee_ID_Label);
            this.Controls.Add(this.Employees_ID_Combo_Box);
            this.Controls.Add(this.Employees_Label);
            this.Controls.Add(this.Department_Label);
            this.Controls.Add(this.Department_Name_Label);
            this.Controls.Add(this.Department_Name_Text_Box);
            this.Controls.Add(this.Department_ID_Label);
            this.Controls.Add(this.Department_ID_Combo_Box);
            this.Controls.Add(this.Back_Button);
            this.Name = "Department_Employees_Form";
            this.Text = "Department - Employees";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Department_Employees_Form_FormClosing);
            this.Load += new System.EventHandler(this.Department_Employees_Form_Load);
            this.Controllers_Flow_Layout_Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.ComboBox Department_ID_Combo_Box;
        private System.Windows.Forms.Label Department_ID_Label;
        private System.Windows.Forms.TextBox Department_Name_Text_Box;
        private System.Windows.Forms.Label Department_Name_Label;
        private System.Windows.Forms.Label Department_Label;
        private System.Windows.Forms.Label Employees_Label;
        private System.Windows.Forms.ComboBox Employees_ID_Combo_Box;
        private System.Windows.Forms.Label Employee_ID_Label;
        private System.Windows.Forms.TextBox Employee_Name_Text_Box;
        private System.Windows.Forms.Label Employee_Name_Label;
        private System.Windows.Forms.TextBox Employee_Salary_Text_Box;
        private System.Windows.Forms.Label Employee_Salary_Label;
        private System.Windows.Forms.RadioButton Employee_Male_Radio_Button;
        private System.Windows.Forms.RadioButton Employee_Female_Radio_Button;
        private System.Windows.Forms.Label Employee_Gender_Label;
        private System.Windows.Forms.Button Insert_Department_Data_Button;
        private System.Windows.Forms.Button Update_Department_Data_Button;
        private System.Windows.Forms.Button Delete_Employee_Data_Button;
        private System.Windows.Forms.Button Insert_Employee_Data_Button;
        private System.Windows.Forms.FlowLayoutPanel Controllers_Flow_Layout_Panel;
        private System.Windows.Forms.Button Update_Employee_Data_Department;
        private System.Windows.Forms.TextBox Total_Sales_Text_Box;
        private System.Windows.Forms.Label Total_Sales_Label;
        private System.Windows.Forms.Button Total_Sales_Button;
        private System.Windows.Forms.Label Sales_Label;
    }
}