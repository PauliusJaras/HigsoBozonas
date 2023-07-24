namespace HigsoBozonas
{
    partial class UpsertDialog
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
            tableLayoutPanel = new TableLayoutPanel();
            headerLabel = new Label();
            panel = new Panel();
            cancelBtn = new Button();
            approveBtn = new Button();
            phoneNumberMaskedBox = new MaskedTextBox();
            birthdayDateTimePicker = new DateTimePicker();
            birthdayLabel = new Label();
            phoneNumberLabel = new Label();
            fullNameTextBox = new TextBox();
            fullNameLabel = new Label();
            tableLayoutPanel.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(headerLabel, 0, 0);
            tableLayoutPanel.Controls.Add(panel, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13.23101F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 86.76899F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel.Size = new Size(418, 346);
            tableLayoutPanel.TabIndex = 0;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Dock = DockStyle.Fill;
            headerLabel.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(3, 0);
            headerLabel.Name = "headerLabel";
            headerLabel.Padding = new Padding(25, 10, 0, 0);
            headerLabel.Size = new Size(412, 45);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Add New Contact";
            headerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel
            // 
            panel.Controls.Add(cancelBtn);
            panel.Controls.Add(approveBtn);
            panel.Controls.Add(phoneNumberMaskedBox);
            panel.Controls.Add(birthdayDateTimePicker);
            panel.Controls.Add(birthdayLabel);
            panel.Controls.Add(phoneNumberLabel);
            panel.Controls.Add(fullNameTextBox);
            panel.Controls.Add(fullNameLabel);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(3, 48);
            panel.Name = "panel";
            panel.Size = new Size(412, 295);
            panel.TabIndex = 1;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(220, 53, 69);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(298, 232);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 31);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += CancelBtn_Click;
            // 
            // approveBtn
            // 
            approveBtn.BackColor = Color.FromArgb(33, 37, 41);
            approveBtn.ForeColor = Color.White;
            approveBtn.Location = new Point(206, 232);
            approveBtn.Name = "approveBtn";
            approveBtn.Size = new Size(75, 31);
            approveBtn.TabIndex = 8;
            approveBtn.Text = "Ok";
            approveBtn.UseVisualStyleBackColor = false;
            approveBtn.Click += ApproveBtn_Click;
            // 
            // phoneNumberMaskedBox
            // 
            phoneNumberMaskedBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            phoneNumberMaskedBox.Location = new Point(30, 120);
            phoneNumberMaskedBox.Mask = "+000 000 00000";
            phoneNumberMaskedBox.Name = "phoneNumberMaskedBox";
            phoneNumberMaskedBox.Size = new Size(343, 22);
            phoneNumberMaskedBox.TabIndex = 5;
            phoneNumberMaskedBox.TextChanged += phoneNumberMaskedBox_TextChanged;
            // 
            // birthdayDateTimePicker
            // 
            birthdayDateTimePicker.CalendarFont = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            birthdayDateTimePicker.Format = DateTimePickerFormat.Short;
            birthdayDateTimePicker.Location = new Point(30, 188);
            birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            birthdayDateTimePicker.Size = new Size(343, 21);
            birthdayDateTimePicker.TabIndex = 7;
            birthdayDateTimePicker.Value = new DateTime(2023, 7, 23, 1, 38, 14, 0);
            birthdayDateTimePicker.ValueChanged += birthdayDateTimePicker_ValueChanged;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            birthdayLabel.Location = new Point(30, 165);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(60, 16);
            birthdayLabel.TabIndex = 6;
            birthdayLabel.Text = "Birthday";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            phoneNumberLabel.Location = new Point(30, 97);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(102, 16);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            fullNameTextBox.Location = new Point(30, 53);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(343, 22);
            fullNameTextBox.TabIndex = 3;
            fullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            fullNameLabel.Location = new Point(30, 29);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(72, 16);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Full Name";
            // 
            // UpsertDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(418, 346);
            Controls.Add(tableLayoutPanel);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(33, 37, 41);
            Name = "UpsertDialog";
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Label headerLabel;
        private Panel panel;
        private Label fullNameLabel;
        private TextBox fullNameTextBox;
        private Label phoneNumberLabel;
        private Label birthdayLabel;
        private MaskedTextBox phoneNumberMaskedBox;
        private DateTimePicker birthdayDateTimePicker;
        private Button cancelBtn;
        private Button approveBtn;
    }
}