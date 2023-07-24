using HigsoBozonas.Models;
using HigsoBozonas.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HigsoBozonas
{
    public partial class UpsertDialog : Form
    {

        private Contact upsertContact = new Contact();
        public UpsertDialog(Contact mainContact = null)
        {
            InitializeComponent();
            if (mainContact != null)
            {
                headerLabel.Text = "Edit Selected Contact";
                fullNameTextBox.Text = mainContact.FullName;
                birthdayDateTimePicker.Text = mainContact.Birthday.ToString();
                phoneNumberMaskedBox.Text = mainContact.PhoneNumber;
                upsertContact = mainContact;
            }
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            if (upsertContact.FullName != null && upsertContact.PhoneNumber != null
                && upsertContact.PhoneNumber.Length == 14 && upsertContact.Birthday.Ticks > 0)
            {
                if (upsertContact.Id > 0)
                {
                    SqlConnector.EditItem(upsertContact);
                }
                else
                {
                    SqlConnector.AddItem(upsertContact);
                }
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please fill the empty fields and try again");
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            upsertContact.FullName = fullNameTextBox.Text;
        }

        private void phoneNumberMaskedBox_TextChanged(object sender, EventArgs e)
        {
            upsertContact.PhoneNumber = phoneNumberMaskedBox.Text;
        }

        private void birthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            upsertContact.Birthday = birthdayDateTimePicker.Value;
        }

    }
}
