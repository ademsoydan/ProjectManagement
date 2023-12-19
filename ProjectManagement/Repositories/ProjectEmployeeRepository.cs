using ProjectManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.Repositories
{
    public static class ProjectEmployeeReposityory
    {
        public static void SaveEmployeesInProject(int projectId, List<int> employeeIds)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Veritabanına ekleme sorgusu
                    string insertQuery = "INSERT INTO EmployeeProject (EmployeeId,ProjectId) " +
                                         "VALUES (@EmployeeId, @ProjectId)";
                    for (int i = 0; i < employeeIds.Count; i++)
                    {
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            // Parametreleri oluştur
                            SqlParameter projectIdParam = new SqlParameter("@ProjectId", SqlDbType.Int);
                            SqlParameter employeeIdParam = new SqlParameter("@EmployeeId", SqlDbType.Int);

                            // Parametreleri ekle
                            command.Parameters.Add(projectIdParam);
                            command.Parameters.Add(employeeIdParam);

                            // Parametre değerlerini ata
                            projectIdParam.Value = projectId;
                            employeeIdParam.Value = employeeIds[i];

                            // ExecuteNonQuery çağır
                            command.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Veri başarı ile eklendi:");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ekip eklenirken hata oluştu: " + ex.Message);
                }
            }
        }
        public static List<int> GetEmployeeIdsByProjectId(int projectId)
        {
            List<int> employeeIds = new List<int>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT EmployeeId FROM EmployeeProject WHERE ProjectId = @ProjectId;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ProjectId", projectId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int employeeId = Convert.ToInt32(reader["EmployeeId"]);
                                employeeIds.Add(employeeId);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            return employeeIds;
        }
        public static void UpdateEmployeeProject(int projectId, List<int> newEmployeeIds)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                connection.Open();

                // Önce belirli bir projectId'ye sahip olan tüm satırları sil
                string deleteQuery = "DELETE FROM EmployeeProject WHERE ProjectId = @ProjectId";

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@ProjectId", projectId);

                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        Console.WriteLine("Existing EmployeeProject records deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error deleting existing EmployeeProject records: " + ex.Message);
                        return; // Hata durumunda işlemi sonlandır
                    }
                }

                // Ardından yeni employeeId değerlerini ekleyerek insert işlemi gerçekleştir
                string insertQuery = "INSERT INTO EmployeeProject (ProjectId, EmployeeId) " +
                                     "VALUES (@ProjectId, @EmployeeId)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@projeId", projectId);

                    foreach (int employeeId in newEmployeeIds)
                    {
                        insertCommand.Parameters.Clear(); // Önceki parametreleri temizle

                        insertCommand.Parameters.AddWithValue("@ProjectId", projectId);
                        insertCommand.Parameters.AddWithValue("@EmployeeId", employeeId);

                        try
                        {
                            insertCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error inserting EmployeeProject record: " + ex.Message);
                            // Hata durumunda işlemi sonlandırabilir veya loglayabilirsiniz.
                        }
                    }

                    Console.WriteLine("EmployeeProject records updated successfully.");
                }
            }
        }

        public static void DeleteProject(int projectId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                connection.Open();

                // Önce belirli bir projectId'ye sahip olan tüm satırları sil
                string deleteQuery = "DELETE FROM EmployeeProject WHERE ProjectId = @ProjectId";

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@ProjectId", projectId);

                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        Console.WriteLine("Existing EmployeeProject records deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error deleting existing EmployeeProject records: " + ex.Message);
                        return; // Hata durumunda işlemi sonlandır
                    }
                }

                // Ardından yeni employeeId değerlerini ekleyerek insert işlemi gerçekleştir
                string insertQuery = "DELETE FROM Proje WHERE id = @ProjectId;";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@ProjectId", projectId);
                    try
                    {
                        insertCommand.ExecuteNonQuery();
                        Console.WriteLine("Existing EmployeeProject records deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error deleting existing EmployeeProject records: " + ex.Message);
                        return; // Hata durumunda işlemi sonlandır
                    }

                    Console.WriteLine("EmployeeProject records updated successfully.");
                }
            }
        }
        public static void DeleteEmployee(int EmployeeId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                connection.Open();

                // Önce belirli bir projectId'ye sahip olan tüm satırları sil
                string deleteQuery = "DELETE FROM EmployeeProject WHERE EmployeeId = @EmployeeId";

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@EmployeeId", EmployeeId);

                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        Console.WriteLine("Existing EmployeeProject records deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error deleting existing EmployeeProject records: " + ex.Message);
                        return; // Hata durumunda işlemi sonlandır
                    }
                }

                // Ardından yeni employeeId değerlerini ekleyerek insert işlemi gerçekleştir
                string insertQuery = "DELETE FROM Employee WHERE Id = @EmployeeId;";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@EmployeeId", EmployeeId);
                    try
                    {
                        insertCommand.ExecuteNonQuery();
                        Console.WriteLine("Existing EmployeeProject records deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bu Çalışan aktif olarak bir projeden veya tasktan sorumlu, Bu işlemi yapamazsınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Hata durumunda işlemi sonlandır
                    }

                    Console.WriteLine("EmployeeProject records updated successfully.");
                }
            }
        }
    }

}
