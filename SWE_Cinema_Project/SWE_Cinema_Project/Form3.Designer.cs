namespace SWE_Cinema_Project
{
    partial class Movie_Customer_Form
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
            this.Data_Grid_View = new System.Windows.Forms.DataGridView();
            this.Movies_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Customers_Radio_Button = new System.Windows.Forms.RadioButton();
            this.Load_Data = new System.Windows.Forms.Button();
            this.Save_New_Data = new System.Windows.Forms.Button();
            this.Selector_Text_Box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(12, 12);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(84, 30);
            this.Back_Button.TabIndex = 1;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Data_Grid_View
            // 
            this.Data_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Grid_View.Location = new System.Drawing.Point(136, 41);
            this.Data_Grid_View.Name = "Data_Grid_View";
            this.Data_Grid_View.RowHeadersWidth = 51;
            this.Data_Grid_View.RowTemplate.Height = 24;
            this.Data_Grid_View.Size = new System.Drawing.Size(550, 342);
            this.Data_Grid_View.TabIndex = 2;
            // 
            // Movies_Radio_Button
            // 
            this.Movies_Radio_Button.AutoSize = true;
            this.Movies_Radio_Button.Location = new System.Drawing.Point(276, 389);
            this.Movies_Radio_Button.Name = "Movies_Radio_Button";
            this.Movies_Radio_Button.Size = new System.Drawing.Size(72, 20);
            this.Movies_Radio_Button.TabIndex = 3;
            this.Movies_Radio_Button.TabStop = true;
            this.Movies_Radio_Button.Text = "Movies";
            this.Movies_Radio_Button.UseVisualStyleBackColor = true;
            // 
            // Customers_Radio_Button
            // 
            this.Customers_Radio_Button.AutoSize = true;
            this.Customers_Radio_Button.Location = new System.Drawing.Point(466, 389);
            this.Customers_Radio_Button.Name = "Customers_Radio_Button";
            this.Customers_Radio_Button.Size = new System.Drawing.Size(92, 20);
            this.Customers_Radio_Button.TabIndex = 4;
            this.Customers_Radio_Button.TabStop = true;
            this.Customers_Radio_Button.Text = "Customers";
            this.Customers_Radio_Button.UseVisualStyleBackColor = true;
            // 
            // Load_Data
            // 
            this.Load_Data.Location = new System.Drawing.Point(12, 379);
            this.Load_Data.Name = "Load_Data";
            this.Load_Data.Size = new System.Drawing.Size(84, 30);
            this.Load_Data.TabIndex = 5;
            this.Load_Data.Text = "Load";
            this.Load_Data.UseVisualStyleBackColor = true;
            this.Load_Data.Click += new System.EventHandler(this.Load_Data_Click);
            // 
            // Save_New_Data
            // 
            this.Save_New_Data.Location = new System.Drawing.Point(12, 415);
            this.Save_New_Data.Name = "Save_New_Data";
            this.Save_New_Data.Size = new System.Drawing.Size(84, 30);
            this.Save_New_Data.TabIndex = 6;
            this.Save_New_Data.Text = "Save";
            this.Save_New_Data.UseVisualStyleBackColor = true;
            this.Save_New_Data.Click += new System.EventHandler(this.Save_New_Data_Click);
            // 
            // Selector_Text_Box
            // 
            this.Selector_Text_Box.Location = new System.Drawing.Point(12, 351);
            this.Selector_Text_Box.Name = "Selector_Text_Box";
            this.Selector_Text_Box.Size = new System.Drawing.Size(84, 22);
            this.Selector_Text_Box.TabIndex = 7;
            // 
            // Movie_Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Selector_Text_Box);
            this.Controls.Add(this.Save_New_Data);
            this.Controls.Add(this.Load_Data);
            this.Controls.Add(this.Customers_Radio_Button);
            this.Controls.Add(this.Movies_Radio_Button);
            this.Controls.Add(this.Data_Grid_View);
            this.Controls.Add(this.Back_Button);
            this.Name = "Movie_Customer_Form";
            this.Text = "Movie - Customers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Movie_Customer_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.DataGridView Data_Grid_View;
        private System.Windows.Forms.RadioButton Movies_Radio_Button;
        private System.Windows.Forms.RadioButton Customers_Radio_Button;
        private System.Windows.Forms.Button Load_Data;
        private System.Windows.Forms.Button Save_New_Data;
        private System.Windows.Forms.TextBox Selector_Text_Box;
    }
}