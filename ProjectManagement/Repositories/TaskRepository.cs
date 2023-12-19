using DevExpress.XtraPrinting.HtmlExport.Native;
using ProjectManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectManagement.Repositories
{
    public static class TaskRepository
    {
        public static BindingSource GetTaskByPointId(int pointId)
        {
            BindingSource bindingSource = new BindingSource();

            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT T.Id, T.task_ismi, T.baslangic_tarihi, T.bitis_tarihi, T.durum, E.ad as ad\r\nFROM Task T Left join Employee E on T.employee_id = E.Id where durak_id = @point_id";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@point_id", pointId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // DataTable oluştur ve verileri yükle
                            System.Data.DataTable dataTable = new System.Data.DataTable();
                            dataTable.Load(reader);

                            // BindingSource'a DataTable'ı bağla
                            bindingSource.DataSource = dataTable;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri çekme hatası: " + ex.Message);
                }
            }

            return bindingSource;
        }

        public static ProjectTask GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, task_ismi, baslangic_tarihi, bitis_tarihi, durum, employee_id FROM Task Where Id = @id";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Parametreyi belirle
                        command.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ProjectTask task = new ProjectTask();
                                task.Id = Convert.ToInt32(reader["Id"]);
                                task.TaskName = reader["task_ismi"].ToString();
                                task.BaslangicTarihi = Convert.ToDateTime(reader["baslangic_tarihi"]);
                                task.BitisTarihi = Convert.ToDateTime(reader["bitis_tarihi"]);
                                task.Status = Convert.ToInt32(reader["durum"]);
                                task.employeeId = Convert.ToInt32(reader["employee_id"]);
                                return task;
                            }
                            else
                            {
                                MessageBox.Show("Employee not found with the specified Id.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri çekme hatası: " + ex.Message);
                }
                return null;
            }
        }

        public static void SaveTask(ProjectTask task)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Veritabanına ekleme sorgusu
                    string insertQuery = "INSERT INTO Task (task_ismi, baslangic_tarihi, bitis_tarihi, durum, durak_id, employee_id) " +
                                         "VALUES (@task_ismi, @baslangic_tarihi, @bitis_tarihi , @durum ,@durak_id, @employee_id)";

                    // SqlCommand ve SqlParameter kullanarak sorguyu hazırla
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Parametreleri belirle
                        command.Parameters.AddWithValue("@task_ismi", task.TaskName);
                        command.Parameters.AddWithValue("@baslangic_tarihi", task.BaslangicTarihi);
                        command.Parameters.AddWithValue("@bitis_tarihi", task.BitisTarihi);
                        command.Parameters.AddWithValue("@durum", task.Status);
                        command.Parameters.AddWithValue("@durak_id", task.pointId);
                        command.Parameters.AddWithValue("@employee_id", task.employeeId);

                        // Sorguyu çalıştır
                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Veri başarıyla eklendi!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri eklenirken hata oluştu: " + ex.Message);
                }
            }
        }
        public static bool UpdateTask(ProjectTask task)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE Task SET task_ismi = @task_ismi, baslangic_tarihi = @baslangic_tarihi, bitis_tarihi = @bitis_tarihi, durum = @durum employee_id = @employee_id WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Parametreleri belirle
                        command.Parameters.AddWithValue("@task_ismi", task.TaskName);
                        command.Parameters.AddWithValue("@baslangic_tarihi", task.BaslangicTarihi);
                        command.Parameters.AddWithValue("@bitis_tarihi", task.BitisTarihi);
                        command.Parameters.AddWithValue("@durum", task.Status);
                        command.Parameters.AddWithValue("@employee_id", task.employeeId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee updated successfully.");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Employee not found with the specified Id.");
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
            }

            return false;
        }
        public static void DeleteTask(int taskId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string deleteQuery = "Delete FROM Task where Id = @Id";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Parametreleri belirle
                        command.Parameters.AddWithValue("@Id", taskId);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri silme hatası: " + ex.Message);
                }
            }
        }

    }
}
