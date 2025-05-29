using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RAD_task.Models;
using RAD_task.Forms;
using System.IO;

namespace RAD_task
{
    public partial class Form1 : Form
    {
        private List<RentalItem> items = new List<RentalItem>();
        private List<RentalPoint> rentalPoints = new List<RentalPoint>();
        private List<RentalInvoice> invoices = new List<RentalInvoice>();

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            SetupDataGridViews();
            SetupEventHandlers();
        }

        private void InitializeData()
        {
            // Временные данные для демонстрации
            rentalPoints.Add(new RentalPoint { Id = 1, Name = "Центральный", Address = "ул. Ленина 1", Phone = "123-456" });
            rentalPoints.Add(new RentalPoint { Id = 2, Name = "Северный", Address = "ул. Гагарина 10", Phone = "456-789" });

            items.Add(new RentalItem { Id = 1, Name = "Лыжи", Price = 1000, TotalQuantity = 10, AvailableQuantity = 10 });
            items.Add(new RentalItem { Id = 2, Name = "Коньки", Price = 800, TotalQuantity = 15, AvailableQuantity = 15 });
            items.Add(new RentalItem { Id = 3, Name = "Сноуборд", Price = 1500, TotalQuantity = 5, AvailableQuantity = 5 });

            cmbRentalPoint.DataSource = rentalPoints;
            cmbRentalPoint.DisplayMember = "Name";
            cmbRentalPoint.ValueMember = "Id";
        }

        private void SetupDataGridViews()
        {
            // Настройка таблицы накладных
            dgvInvoices.AutoGenerateColumns = false;
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IssueDate",
                HeaderText = "Дата выдачи",
                DataPropertyName = "IssueDate"
            });
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DueDate",
                HeaderText = "Срок возврата",
                DataPropertyName = "DueDate"
            });
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CustomerName",
                HeaderText = "Клиент",
                DataPropertyName = "CustomerName"
            });
            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalAmount",
                HeaderText = "Сумма",
                DataPropertyName = "TotalAmount"
            });
            dgvInvoices.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "IsLost",
                HeaderText = "Утерян",
                DataPropertyName = "IsLost"
            });
            dgvInvoices.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "IsPaid",
                HeaderText = "Оплачен",
                DataPropertyName = "IsPaid"
            });

            // Настройка таблицы товаров
            dgvItems.AutoGenerateColumns = false;
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "Наименование",
                DataPropertyName = "Name"
            });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "Цена",
                DataPropertyName = "Price"
            });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TotalQuantity",
                HeaderText = "Всего",
                DataPropertyName = "TotalQuantity"
            });
            dgvItems.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AvailableQuantity",
                HeaderText = "Доступно",
                DataPropertyName = "AvailableQuantity"
            });

            UpdateDataGrids();
        }

        private void SetupEventHandlers()
        {
            btnAddInvoice.Click += BtnAddInvoice_Click;
            btnExportToWord.Click += BtnExportToWord_Click;
            btnGenerateReport.Click += BtnGenerateReport_Click;
            btnExportToExcel.Click += BtnExportToExcel_Click;
        }

        private void UpdateDataGrids()
        {
            dgvItems.DataSource = null;
            dgvItems.DataSource = items.ToList();

            dgvInvoices.DataSource = null;
            dgvInvoices.DataSource = invoices.ToList();
        }

        private void BtnAddInvoice_Click(object sender, EventArgs e)
        {
            using (var form = new AddInvoiceForm(items, rentalPoints))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    invoices.Add(form.Invoice);
                    UpdateDataGrids();
                }
            }
        }

        private void BtnExportToWord_Click(object sender, EventArgs e)
        {
            if (dgvInvoices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите накладную для экспорта", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var invoice = (RentalInvoice)dgvInvoices.SelectedRows[0].DataBoundItem;
            ExportToHTML(invoice);
        }

        private void ExportToHTML(RentalInvoice invoice)
        {
            string tempFile = Path.Combine(Path.GetTempPath(), "invoice.html");

            var html = new StringBuilder();
            html.AppendLine("<!DOCTYPE html>");
            html.AppendLine("<html>");
            html.AppendLine("<head>");
            html.AppendLine("<meta charset='utf-8'>");
            html.AppendLine("<title>Накладная</title>");
            html.AppendLine("<style>");
            html.AppendLine("body { font-family: Arial, sans-serif; margin: 20px; }");
            html.AppendLine("h1 { text-align: center; color: #333; }");
            html.AppendLine("table { border-collapse: collapse; width: 100%; margin: 20px 0; }");
            html.AppendLine("th, td { border: 1px solid #ddd; padding: 8px; text-align: left; }");
            html.AppendLine("th { background-color: #f2f2f2; }");
            html.AppendLine(".total { font-weight: bold; font-size: 18px; }");
            html.AppendLine("</style>");
            html.AppendLine("</head>");
            html.AppendLine("<body>");

            // Заголовок
            html.AppendLine($"<h1>НАКЛАДНАЯ №{invoice.Id}</h1>");

            // Информация о клиенте
            html.AppendLine("<div>");
            html.AppendLine($"<p><strong>Дата выдачи:</strong> {invoice.IssueDate:dd.MM.yyyy}</p>");
            html.AppendLine($"<p><strong>Срок возврата:</strong> {invoice.DueDate:dd.MM.yyyy}</p>");
            html.AppendLine($"<p><strong>Клиент:</strong> {invoice.CustomerName}</p>");
            html.AppendLine($"<p><strong>Телефон:</strong> {invoice.CustomerPhone}</p>");
            html.AppendLine($"<p><strong>Пункт проката:</strong> {invoice.RentalPoint.Name}</p>");
            html.AppendLine("</div>");

            // Таблица товаров
            html.AppendLine("<table>");
            html.AppendLine("<tr>");
            html.AppendLine("<th>Наименование</th>");
            html.AppendLine("<th>Количество</th>");
            html.AppendLine("<th>Цена</th>");
            html.AppendLine("<th>Сумма</th>");
            html.AppendLine("</tr>");

            foreach (var item in invoice.Items)
            {
                html.AppendLine("<tr>");
                html.AppendLine($"<td>{item.RentalItem.Name}</td>");
                html.AppendLine($"<td>{item.Quantity}</td>");
                html.AppendLine($"<td>{item.Price:C}</td>");
                html.AppendLine($"<td>{item.Price * item.Quantity:C}</td>");
                html.AppendLine("</tr>");
            }

            html.AppendLine("</table>");

            // Итоговая сумма
            html.AppendLine($"<p class='total'>Итого: {invoice.TotalAmount:C}</p>");

            html.AppendLine("</body>");
            html.AppendLine("</html>");

            try
            {
                File.WriteAllText(tempFile, html.ToString(), Encoding.UTF8);
                System.Diagnostics.Process.Start(tempFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при экспорте: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGenerateReport_Click(object sender, EventArgs e)
        {
            var selectedPoint = (RentalPoint)cmbRentalPoint.SelectedItem;
            var date = dtpReportDate.Value.Date;

            var report = GenerateReport(date, selectedPoint.Id);
            ExportToCSV(report);
        }

        private List<ReportItem> GenerateReport(DateTime date, int rentalPointId)
        {
            var report = new List<ReportItem>();

            foreach (var invoice in invoices.Where(i => i.RentalPointId == rentalPointId))
            {
                foreach (var item in invoice.Items)
                {
                    var isOverdue = !invoice.ReturnDate.HasValue && invoice.DueDate < date;
                    var status = invoice.IsLost ? "Утерян" :
                               !invoice.ReturnDate.HasValue ? (isOverdue ? "Просрочен" : "В прокате") :
                               "Возвращен";

                    report.Add(new ReportItem
                    {
                        ItemName = item.RentalItem.Name,
                        Quantity = item.Quantity,
                        Amount = item.Price * item.Quantity,
                        Status = status,
                        DueDate = invoice.DueDate,
                        CustomerName = invoice.CustomerName
                    });
                }
            }

            return report;
        }

        private void ExportToCSV(List<ReportItem> report)
        {
            string tempFile = Path.Combine(Path.GetTempPath(), "report.csv");

            try
            {
                using (var writer = new StreamWriter(tempFile, false, Encoding.UTF8))
                {
                    // Заголовки
                    writer.WriteLine("Наименование;Количество;Сумма;Статус;Срок возврата;Клиент");

                    // Данные
                    foreach (var item in report)
                    {
                        writer.WriteLine($"{item.ItemName};{item.Quantity};{item.Amount:C};{item.Status};{item.DueDate:dd.MM.yyyy};{item.CustomerName}");
                    }
                }

                System.Diagnostics.Process.Start(tempFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при экспорте в CSV: " + ex.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExportToExcel_Click(object sender, EventArgs e)
        {
            var selectedPoint = (RentalPoint)cmbRentalPoint.SelectedItem;
            var date = dtpReportDate.Value.Date;

            var report = GenerateReport(date, selectedPoint.Id);
            ExportToCSV(report);
        }
    }

    public class ReportItem
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public string CustomerName { get; set; }
    }
}
