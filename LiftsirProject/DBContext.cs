using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiftsirProject
{
    class DBContext
    {
        string connectionstring = @"Server=DESKTOP-C9FMAFR;Database=UserDetails;Trusted_connection = True;";
        public void InsertlogsintoDB(DataTable dt)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string query = @"Insert into Log_2 (LogTime, EventDescription) values(@Time, @Log)";
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.InsertCommand = new SqlCommand(query, conn);
                        adapter.InsertCommand.Parameters.Add("@Time", SqlDbType.DateTime, 0, "LogTime");
                        adapter.InsertCommand.Parameters.Add("@Log", SqlDbType.NVarChar, 255, "EventDescription");
                        conn.Open();
                        adapter.Update(dt);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error saving into logs db " + ex.Message);

            }

        }
        public void LoadLogsFromDB(DataTable dt, DataGridView dataGridView1)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string query = @"Select LogTime, EventDescription from Log_2 order by LogTime desc";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        dt.Rows.Clear();
                        adapter.Fill(dt);
                        dataGridView1.Rows.Clear();
                        foreach (DataRow row in dt.Rows)
                        {
                            string currentTime = Convert.ToDateTime(row["LogTime"]).ToString("hh:mm:ss");
                            string events = row["EventDescription"].ToString();
                            dataGridView1.Rows.Add(currentTime, events);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs from DB: " + ex.Message);

            }
        }
        public void DeleteFromDB(DateTime logTime)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    string query = @"DELETE FROM Log_2 WHERE LogTime = @LogTime";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LogTime", logTime);  // Ensure this type matches the DB column
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Log deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Log not found or already deleted.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);  // Provide more readable error message
            }
        }



    }
}


        

