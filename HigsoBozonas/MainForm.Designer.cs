namespace HigsoBozonas
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel = new TableLayoutPanel();
            headerLabel = new Label();
            dataGridView = new DataGridView();
            Checkbox = new DataGridViewCheckBoxColumn();
            flowLayoutPanel = new FlowLayoutPanel();
            addBtn = new Button();
            editBtn = new Button();
            removeBtn = new Button();
            messageLabel = new Label();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel.Controls.Add(headerLabel, 0, 0);
            tableLayoutPanel.Controls.Add(dataGridView, 0, 1);
            tableLayoutPanel.Controls.Add(flowLayoutPanel, 0, 2);
            tableLayoutPanel.Controls.Add(messageLabel, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13.38583F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 86.6141739F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel.Size = new Size(800, 450);
            tableLayoutPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.FromArgb(33, 37, 41);
            headerLabel.Location = new Point(3, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Padding = new Padding(25, 10, 0, 0);
            headerLabel.Size = new Size(544, 53);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Your Contacts";
            headerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeight = 30;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Checkbox });
            tableLayoutPanel.SetColumnSpan(dataGridView, 2);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(52, 58, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.GridColor = Color.White;
            dataGridView.Location = new Point(25, 63);
            dataGridView.Margin = new Padding(25, 10, 25, 10);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 30;
            dataGridView.Size = new Size(750, 326);
            dataGridView.TabIndex = 1;
            // 
            // Checkbox
            // 
            Checkbox.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Checkbox.HeaderText = "";
            Checkbox.Name = "Checkbox";
            Checkbox.Width = 5;
            // 
            // flowLayoutPanel
            // 
            tableLayoutPanel.SetColumnSpan(flowLayoutPanel, 2);
            flowLayoutPanel.Controls.Add(addBtn);
            flowLayoutPanel.Controls.Add(editBtn);
            flowLayoutPanel.Controls.Add(removeBtn);
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(3, 402);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(25, 0, 0, 0);
            flowLayoutPanel.Size = new Size(794, 45);
            flowLayoutPanel.TabIndex = 2;
            // 
            // addBtn
            // 
            addBtn.AutoSize = true;
            addBtn.BackColor = Color.FromArgb(0, 123, 255);
            addBtn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(25, 3);
            addBtn.Margin = new Padding(0, 3, 3, 3);
            addBtn.Name = "addBtn";
            addBtn.Padding = new Padding(8, 0, 8, 0);
            addBtn.Size = new Size(134, 32);
            addBtn.TabIndex = 0;
            addBtn.Text = "Add New Contact";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += AddBtn_Click;
            // 
            // editBtn
            // 
            editBtn.AutoSize = true;
            editBtn.BackColor = Color.FromArgb(33, 37, 41);
            editBtn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            editBtn.ForeColor = Color.White;
            editBtn.Location = new Point(165, 3);
            editBtn.Name = "editBtn";
            editBtn.Padding = new Padding(8, 0, 8, 0);
            editBtn.Size = new Size(160, 32);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit Selected Contact";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += EditBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.AutoSize = true;
            removeBtn.BackColor = Color.FromArgb(220, 53, 69);
            removeBtn.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            removeBtn.ForeColor = Color.White;
            removeBtn.Location = new Point(331, 3);
            removeBtn.Name = "removeBtn";
            removeBtn.Padding = new Padding(8, 0, 8, 0);
            removeBtn.Size = new Size(183, 32);
            removeBtn.TabIndex = 2;
            removeBtn.Text = "Remove Selected Contact";
            removeBtn.UseVisualStyleBackColor = false;
            removeBtn.Click += RemoveBtn_Click;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.BackColor = Color.White;
            messageLabel.Dock = DockStyle.Fill;
            messageLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            messageLabel.ForeColor = Color.FromArgb(0, 123, 255);
            messageLabel.Location = new Point(553, 0);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(244, 53);
            messageLabel.TabIndex = 3;
            messageLabel.Text = "messageText";
            messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            messageLabel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(33, 37, 41);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contacts";
            Load += MainForm_Load;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel;
        private Label headerLabel;
        private DataGridView dataGridView;
        private FlowLayoutPanel flowLayoutPanel;
        private Button addBtn;
        private Button editBtn;
        private Button removeBtn;
        private DataGridViewCheckBoxColumn Checkbox;
        private Label messageLabel;
    }
}