namespace RAD_task.Forms
{
    partial class AddInvoiceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRentalPoint = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvSelectedItems = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedItems)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvSelectedItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRentalPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Name = "AddInvoiceForm";
            this.Text = "Новая накладная";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            // Labels
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.Text = "ФИО клиента:";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.Text = "Телефон:";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.Text = "Пункт проката:";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.Text = "Товар:";

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.Text = "Количество:";

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.Text = "Дата выдачи:";

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 171);
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.Text = "Срок возврата:";

            // Controls
            this.txtCustomerName.Location = new System.Drawing.Point(118, 12);
            this.txtCustomerName.Size = new System.Drawing.Size(200, 20);

            this.txtCustomerPhone.Location = new System.Drawing.Point(118, 38);
            this.txtCustomerPhone.Size = new System.Drawing.Size(200, 20);

            this.cmbRentalPoint.Location = new System.Drawing.Point(118, 64);
            this.cmbRentalPoint.Size = new System.Drawing.Size(200, 21);
            this.cmbRentalPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cmbItems.Location = new System.Drawing.Point(118, 90);
            this.cmbItems.Size = new System.Drawing.Size(200, 21);
            this.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.numQuantity.Location = new System.Drawing.Point(118, 117);
            this.numQuantity.Size = new System.Drawing.Size(120, 20);
            this.numQuantity.Minimum = 1;
            this.numQuantity.Maximum = 100;
            this.numQuantity.Value = 1;

            this.dtpIssueDate.Location = new System.Drawing.Point(118, 143);
            this.dtpIssueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.dtpDueDate.Location = new System.Drawing.Point(118, 169);
            this.dtpDueDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.btnAdd.Location = new System.Drawing.Point(324, 115);
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.dgvSelectedItems.Location = new System.Drawing.Point(12, 195);
            this.dgvSelectedItems.Size = new System.Drawing.Size(560, 200);
            this.dgvSelectedItems.AllowUserToAddRows = false;
            this.dgvSelectedItems.AllowUserToDeleteRows = false;
            this.dgvSelectedItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.btnSave.Location = new System.Drawing.Point(416, 401);
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnCancel.Location = new System.Drawing.Point(497, 401);
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRentalPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvSelectedItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
} 