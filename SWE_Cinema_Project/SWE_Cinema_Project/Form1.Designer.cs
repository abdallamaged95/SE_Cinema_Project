namespace SWE_Cinema_Project
{
    partial class Main_Menu_Form
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
            this.Flow_Layout_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.Department_Employees_Button = new System.Windows.Forms.Button();
            this.Movie_Customers_Button = new System.Windows.Forms.Button();
            this.Crystal_Report_Button1 = new System.Windows.Forms.Button();
            this.Crystal_Report_Button_2 = new System.Windows.Forms.Button();
            this.Flow_Layout_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Flow_Layout_Panel
            // 
            this.Flow_Layout_Panel.AutoScroll = true;
            this.Flow_Layout_Panel.Controls.Add(this.Department_Employees_Button);
            this.Flow_Layout_Panel.Controls.Add(this.Movie_Customers_Button);
            this.Flow_Layout_Panel.Controls.Add(this.Crystal_Report_Button1);
            this.Flow_Layout_Panel.Controls.Add(this.Crystal_Report_Button_2);
            this.Flow_Layout_Panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Flow_Layout_Panel.Location = new System.Drawing.Point(166, 90);
            this.Flow_Layout_Panel.Name = "Flow_Layout_Panel";
            this.Flow_Layout_Panel.Padding = new System.Windows.Forms.Padding(140, 10, 140, 10);
            this.Flow_Layout_Panel.Size = new System.Drawing.Size(500, 250);
            this.Flow_Layout_Panel.TabIndex = 0;
            // 
            // Department_Employees_Button
            // 
            this.Department_Employees_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department_Employees_Button.Location = new System.Drawing.Point(143, 13);
            this.Department_Employees_Button.Name = "Department_Employees_Button";
            this.Department_Employees_Button.Size = new System.Drawing.Size(220, 50);
            this.Department_Employees_Button.TabIndex = 0;
            this.Department_Employees_Button.Text = "Department - Employees";
            this.Department_Employees_Button.UseVisualStyleBackColor = true;
            this.Department_Employees_Button.Click += new System.EventHandler(this.Department_Employees_Button_Click);
            // 
            // Movie_Customers_Button
            // 
            this.Movie_Customers_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movie_Customers_Button.Location = new System.Drawing.Point(143, 69);
            this.Movie_Customers_Button.Name = "Movie_Customers_Button";
            this.Movie_Customers_Button.Size = new System.Drawing.Size(220, 50);
            this.Movie_Customers_Button.TabIndex = 1;
            this.Movie_Customers_Button.Text = "Movie - Customers";
            this.Movie_Customers_Button.UseVisualStyleBackColor = true;
            this.Movie_Customers_Button.Click += new System.EventHandler(this.Movie_Customers_Button_Click);
            // 
            // Crystal_Report_Button1
            // 
            this.Crystal_Report_Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crystal_Report_Button1.Location = new System.Drawing.Point(143, 125);
            this.Crystal_Report_Button1.Name = "Crystal_Report_Button1";
            this.Crystal_Report_Button1.Size = new System.Drawing.Size(220, 50);
            this.Crystal_Report_Button1.TabIndex = 2;
            this.Crystal_Report_Button1.Text = "Crystal - Report 1";
            this.Crystal_Report_Button1.UseVisualStyleBackColor = true;
            // 
            // Crystal_Report_Button_2
            // 
            this.Crystal_Report_Button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crystal_Report_Button_2.Location = new System.Drawing.Point(143, 181);
            this.Crystal_Report_Button_2.Name = "Crystal_Report_Button_2";
            this.Crystal_Report_Button_2.Size = new System.Drawing.Size(220, 50);
            this.Crystal_Report_Button_2.TabIndex = 3;
            this.Crystal_Report_Button_2.Text = "Crystal - Report 2";
            this.Crystal_Report_Button_2.UseVisualStyleBackColor = true;
            // 
            // Main_Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Flow_Layout_Panel);
            this.Name = "Main_Menu_Form";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.Main_Menu_Form_Load);
            this.Flow_Layout_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flow_Layout_Panel;
        private System.Windows.Forms.Button Department_Employees_Button;
        private System.Windows.Forms.Button Movie_Customers_Button;
        private System.Windows.Forms.Button Crystal_Report_Button1;
        private System.Windows.Forms.Button Crystal_Report_Button_2;
    }
}

