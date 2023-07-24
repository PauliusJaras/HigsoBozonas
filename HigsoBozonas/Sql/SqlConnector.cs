using HigsoBozonas.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigsoBozonas.Sql
{
    static class SqlConnector
    {
        private static readonly string conStr = ConfigurationManager.ConnectionStrings["MainConnection"].ConnectionString;
        private static readonly SqlConnection con = new SqlConnection(conStr);

        public static DataTable LoadTableData()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SelectContacts", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataAdapter sdr = new SqlDataAdapter(cmd);
                    sdr.Fill(dt);
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage();
                Logger.WriteLog(ex.ToString());
            }
            return dt;

        }

        public static void RemoveItem(int id)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("DeleteContact", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage();
                Logger.WriteLog(ex.ToString());
            }

        }

        public static void EditItem(Contact editContact)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("EditContact", con))
                {
                    cmd.Parameters.AddWithValue("@id", editContact.Id);
                    cmd.Parameters.AddWithValue("@full_name", editContact.FullName);
                    cmd.Parameters.AddWithValue("@phone_number", editContact.PhoneNumber);
                    cmd.Parameters.AddWithValue("@birthday", editContact.Birthday);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage();
                Logger.WriteLog(ex.ToString());
            }

        }

        public static void AddItem(Contact addContact)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("AddContact", con))
                {
                    cmd.Parameters.AddWithValue("@full_name", addContact.FullName);
                    cmd.Parameters.AddWithValue("@phone_number", addContact.PhoneNumber);
                    cmd.Parameters.AddWithValue("@birthday", addContact.Birthday);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                ShowErrorMessage();
                Logger.WriteLog(ex.ToString());
            }
        }

        public static void ShowErrorMessage()
        {
            MessageBox.Show("An error occured while " +
            "connecting to the database. Check logs for more information");
        }
    }
}
