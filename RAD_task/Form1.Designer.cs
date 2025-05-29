namespace RAD_task
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnAddInvoice = new System.Windows.Forms.Button();
            this.btnExportToWord = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRentalPoint = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpReportDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpReportDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbRentalPoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnExportToWord);
            this.Controls.Add(this.btnAddInvoice);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.dgvInvoices);
            this.Name = "Form1";
            this.Text = "Система проката";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Labels
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.Text = "Накладные";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 15);
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.Text = "Товары";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 280);
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.Text = "Пункт проката:";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 280);
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.Text = "Дата:";

            // DataGridViews
            this.dgvInvoices.Location = new System.Drawing.Point(12, 31);
            this.dgvInvoices.Size = new System.Drawing.Size(484, 240);
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvItems.Location = new System.Drawing.Point(502, 31);
            this.dgvItems.Size = new System.Drawing.Size(470, 240);
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Buttons
            this.btnAddInvoice.Location = new System.Drawing.Point(12, 320);
            this.btnAddInvoice.Size = new System.Drawing.Size(120, 23);
            this.btnAddInvoice.Text = "Новая накладная";

            this.btnExportToWord.Location = new System.Drawing.Point(138, 320);
            this.btnExportToWord.Size = new System.Drawing.Size(120, 23);
            this.btnExportToWord.Text = "Экспорт в Word";

            this.btnGenerateReport.Location = new System.Drawing.Point(264, 320);
            this.btnGenerateReport.Size = new System.Drawing.Size(120, 23);
            this.btnGenerateReport.Text = "Сформировать отчет";

            this.btnExportToExcel.Location = new System.Drawing.Point(390, 320);
            this.btnExportToExcel.Size = new System.Drawing.Size(120, 23);
            this.btnExportToExcel.Text = "Экспорт в Excel";

            // ComboBox and DateTimePicker
            this.cmbRentalPoint.Location = new System.Drawing.Point(94, 277);
            this.cmbRentalPoint.Size = new System.Drawing.Size(100, 21);
            this.cmbRentalPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.dtpReportDate.Location = new System.Drawing.Point(242, 277);
            this.dtpReportDate.Size = new System.Drawing.Size(100, 20);
            this.dtpReportDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnAddInvoice;
        private System.Windows.Forms.Button btnExportToWord;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRentalPoint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpReportDate;
        private System.Windows.Forms.Label label4;
    }
}

