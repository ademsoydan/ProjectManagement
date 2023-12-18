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
    public static class PointRepository
    {
        public static BindingSource getPointByProjectId(int projectId)
        {
            BindingSource bindingSource = new BindingSource();

            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, durak_ismi, baslangic_tarihi, bitis_tarihi FROM Durak Where proje_id = @projectId";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@projectId", projectId);
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

        public static Entities.Point GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, durak_ismi, baslangic_tarihi, bitis_tarihi FROM Durak Where Id = @id";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Parametreyi belirle
                        command.Parameters.AddWithValue("@id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Entities.Point point = new Point();
                                point.Id = Convert.ToInt32(reader["Id"]);
                                point.PointName = reader["durak_ismi"].ToString();
                                point.BaslangicTarihi = Convert.ToDateTime(reader["baslangic_tarihi"]);
                                point.BitisTarihi = Convert.ToDateTime(reader["bitis_tarihi"]);
                                return point;
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

        public static void SavePoint(string durak_ismi, DateTime baslangic_tarihi, DateTime bitis_tarihi, int proje_id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Veritabanına ekleme sorgusu
                    string insertQuery = "INSERT INTO Durak (durak_ismi, baslangic_tarihi, bitis_tarihi, proje_id) " +
                                         "VALUES (@durak_ismi, @baslangic_tarihi, @bitis_tarihi , @proje_id)";

                    // SqlCommand ve SqlParameter kullanarak sorguyu hazırla
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Parametreleri belirle
                        command.Parameters.AddWithValue("@durak_ismi", durak_ismi);
                        command.Parameters.AddWithValue("@baslangic_tarihi", baslangic_tarihi);
                        command.Parameters.AddWithValue("@bitis_tarihi", bitis_tarihi);
                        command.Parameters.AddWithValue("@proje_id", proje_id);

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
        public static bool UpdatePoint(Entities.Point selectedPoint)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE Durak SET durak_ismi = @PointName, baslangic_tarihi = @baslangic_tarihi, bitis_tarihi = @bitis_tarihi WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Parametreleri belirle
                        command.Parameters.AddWithValue("@Id", selectedPoint.Id);
                        command.Parameters.AddWithValue("@PointName", selectedPoint.PointName);
                        command.Parameters.AddWithValue("@baslangic_tarihi", selectedPoint.BaslangicTarihi);
                        command.Parameters.AddWithValue("@bitis_tarihi", selectedPoint.BitisTarihi);
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

        public static void DeletePoint(int pointId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string deleteQuery = "Delete FROM Durak where Id = @Id";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Parametreleri belirle
                        command.Parameters.AddWithValue("@Id", pointId);
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri güncelleme hatası: " + ex.Message);
                }
            }
        }
    }
}
