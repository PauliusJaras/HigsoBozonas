using HigsoBozonas.Models;
using HigsoBozonas.Sql;
using System.Data;

namespace HigsoBozonas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 248, 249, 250);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dataGridView.DefaultCellStyle.Font = new Font("Arial", 10);
            DataTable dt = SqlConnector.LoadTableData();
            RefreshGridTable(dt);
        }


        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form addDialog = new UpsertDialog();
            addDialog.ShowDialog();

            if (addDialog.DialogResult == DialogResult.OK)
            {
                DataTable dt = SqlConnector.LoadTableData();
                RefreshGridTable(dt, "New contact added");
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = 0;
            Contact editContact = new Contact();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    if (selectedRow == 2)
                    {
                        break;
                    }
                    else
                    {
                        selectedRow++;
                        editContact.Id = Convert.ToInt16(row.Cells[1].Value);
                        editContact.FullName = row.Cells[2].Value.ToString();
                        editContact.PhoneNumber = row.Cells[3].Value.ToString();
                        editContact.Birthday = DateTime.Parse(row.Cells[4].Value.ToString());
                    }
                }
            }
            if (selectedRow == 2 || selectedRow == 0)
            {
                MessageBox.Show("Please select one contact address you want to edit and try again");
            }
            else
            {
                Form editDialog = new UpsertDialog(editContact);
                editDialog.ShowDialog();
                if (editDialog.DialogResult == DialogResult.OK)
                {
                    DataTable dt = SqlConnector.LoadTableData();
                    RefreshGridTable(dt, "Contact successfully edited");
                }

            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            var ids = new List<int>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    var id = Convert.ToInt16(row.Cells[1].Value);
                    ids.Add(id);
                }
            }
            if (ids.Count > 0)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to delete selected contact"
                    + (ids.Count > 1 ? "s?" : "?"),
                         "Confirmatiom Needed!",
                         MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    foreach (int id in ids)
                    {
                        SqlConnector.RemoveItem(id);
                    }
                    DataTable dt = SqlConnector.LoadTableData();
                    RefreshGridTable(dt, "Selected Items Deleted");
                }
            }
            else
            {
                MessageBox.Show("Please select at least one contact address you want to delete and try again");
            }
        }

        public void RefreshGridTable(DataTable dt, string msg = "Content updated")
        {
            if (dt.Rows.Count > 0)
            {
                dataGridView.DataSource = dt;
                dataGridView.Columns["id"].Visible = false;
                dataGridView.Columns["full_name"].HeaderText = "Full Name";
                dataGridView.Columns["phone_number"].HeaderText = "Phone Number";
                dataGridView.Columns["birthday"].HeaderText = "Birthday";
                dataGridView.Refresh();
                ShowTimedMessaged(msg);
            }
            else
            {
                dataGridView.Hide();
            }

        }

        public async void ShowTimedMessaged(string msg)
        {
            var timer = new PeriodicTimer(TimeSpan.FromSeconds(5));
            messageLabel.Text = msg;
            messageLabel.Visible = true;

            while (await timer.WaitForNextTickAsync())
            {
                messageLabel.Visible = false;
            }
        }

    }
}