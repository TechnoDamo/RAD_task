using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RAD_task.Models;

namespace RAD_task.Forms
{
    public partial class AddInvoiceForm : Form
    {
        public RentalInvoice Invoice { get; private set; }
        private List<RentalItem> availableItems;
        private List<RentalPoint> rentalPoints;

        public AddInvoiceForm(List<RentalItem> items, List<RentalPoint> points)
        {
            InitializeComponent();
            this.availableItems = items;
            this.rentalPoints = points;
            SetupForm();
        }

        private void SetupForm()
        {
            // Setup ComboBoxes
            cmbRentalPoint.DataSource = rentalPoints;
            cmbRentalPoint.DisplayMember = "Name";
            cmbRentalPoint.ValueMember = "Id";

            cmbItems.DataSource = availableItems;
            cmbItems.DisplayMember = "Name";
            cmbItems.ValueMember = "Id";

            // Setup DataGridView
            dgvSelectedItems.AutoGenerateColumns = false;
            dgvSelectedItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Наименование",
                DataPropertyName = "Name",
                ReadOnly = true
            });
            dgvSelectedItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "Количество",
                DataPropertyName = "Quantity"
            });
            dgvSelectedItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Цена",
                DataPropertyName = "Price",
                ReadOnly = true
            });

            // Set default dates
            dtpIssueDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(7);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedItem = (RentalItem)cmbItems.SelectedItem;
            var quantity = (int)numQuantity.Value;

            if (quantity <= 0 || quantity > selectedItem.AvailableQuantity)
            {
                MessageBox.Show("Недопустимое количество", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var invoiceItem = new RentalInvoiceItem
            {
                RentalItem = selectedItem,
                RentalItemId = selectedItem.Id,
                Quantity = quantity,
                Price = selectedItem.Price
            };

            // Add to grid
            dgvSelectedItems.Rows.Add(selectedItem.Name, quantity, selectedItem.Price);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Введите имя клиента", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Invoice = new RentalInvoice
            {
                CustomerName = txtCustomerName.Text,
                CustomerPhone = txtCustomerPhone.Text,
                IssueDate = dtpIssueDate.Value,
                DueDate = dtpDueDate.Value,
                RentalPointId = (int)cmbRentalPoint.SelectedValue,
                RentalPoint = (RentalPoint)cmbRentalPoint.SelectedItem
            };

            // Add selected items
            foreach (DataGridViewRow row in dgvSelectedItems.Rows)
            {
                if (!row.IsNewRow)
                {
                    var itemName = row.Cells["Name"].Value.ToString();
                    var item = availableItems.Find(i => i.Name == itemName);
                    var quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                    var price = Convert.ToDecimal(row.Cells["Price"].Value);

                    Invoice.Items.Add(new RentalInvoiceItem
                    {
                        RentalItem = item,
                        RentalItemId = item.Id,
                        Quantity = quantity,
                        Price = price
                    });

                    Invoice.TotalAmount += quantity * price;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
} 