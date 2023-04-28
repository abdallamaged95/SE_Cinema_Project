
namespace SWE_Cinema_Project
{
    partial class Movies_Profit
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
            this.Back_button = new System.Windows.Forms.Button();
            this.Generate_report = new System.Windows.Forms.Button();
            this.start_date = new System.Windows.Forms.TextBox();
            this.end_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(12, 12);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(86, 35);
            this.Back_button.TabIndex = 0;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Generate_report
            // 
            this.Generate_report.Location = new System.Drawing.Point(692, 12);
            this.Generate_report.Name = "Generate_report";
            this.Generate_report.Size = new System.Drawing.Size(96, 35);
            this.Generate_report.TabIndex = 1;
            this.Generate_report.Text = "Generate Report";
            this.Generate_report.UseVisualStyleBackColor = true;
            this.Generate_report.Click += new System.EventHandler(this.Generate_report_Click);
            // 
            // start_date
            // 
            this.start_date.Location = new System.Drawing.Point(234, 18);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(99, 22);
            this.start_date.TabIndex = 2;
            // 
            // end_date
            // 
            this.end_date.Location = new System.Drawing.Point(441, 18);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(100, 22);
            this.end_date.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "End Date";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 53);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1293, 686);
            this.crystalReportViewer1.TabIndex = 6;
            // 
            // Movies_Profit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 770);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.Generate_report);
            this.Controls.Add(this.Back_button);
            this.Name = "Movies_Profit";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Movies_Profit_FormClosed);
            this.Load += new System.EventHandler(this.report2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Generate_report;
        private System.Windows.Forms.TextBox start_date;
        private System.Windows.Forms.TextBox end_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}