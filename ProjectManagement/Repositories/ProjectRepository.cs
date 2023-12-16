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
    public static class ProjectRepository
    {
        public static int SaveProject(
            string proje_ismi,
            string stratejik_etki,
            int proje_yurutucu,
            string amac,
            string problem_tanimi,
            string kapsam,
            DateTime kayit_tarihi,
            DateTime baslangic_tarihi,
            DateTime bitis_tarihi,
            DateTime bitis_tahmini,
            DateTime baslangic_tahmini,
            int proje_durumu,
            decimal parasal_getiri,
            int parasal_getiri_tipi,
            int proje_tipi

            )
        {
            int insertedId = -1;
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Proje " +
                                     "(proje_ismi, stratejik_etki, proje_yurutucu, amac, problem_tanimi, " +
                                     "kapsam, kayit_tarihi, baslangic_tarihi, bitis_tarihi, bitis_tahmini, " +
                                     "baslangic_tahmini, proje_durumu, parasal_getiri, parasal_getiri_tipi, proje_tipi) " +
                                     "VALUES (@proje_ismi, @stratejik_etki, @proje_yurutucu, @amac, @problem_tanimi, " +
                                     "@kapsam, @kayit_tarihi, @baslangic_tarihi, @bitis_tarihi, @bitis_tahmini, " +
                                     "@baslangic_tahmini, @proje_durumu, @parasal_getiri, @parasal_getiri_tipi, @proje_tipi); SELECT SCOPE_IDENTITY();";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    // Parametre değerlerini belirleyin (örnek olarak TextBox'lardan alındığını varsayalım)
                    command.Parameters.AddWithValue("@proje_ismi", proje_ismi);
                    command.Parameters.AddWithValue("@stratejik_etki", stratejik_etki);
                    command.Parameters.AddWithValue("@proje_yurutucu", proje_yurutucu);
                    command.Parameters.AddWithValue("@amac", amac);
                    command.Parameters.AddWithValue("@problem_tanimi", problem_tanimi);
                    command.Parameters.AddWithValue("@kapsam", kapsam);
                    command.Parameters.AddWithValue("@kayit_tarihi", kayit_tarihi);
                    command.Parameters.AddWithValue("@baslangic_tarihi", baslangic_tarihi);
                    command.Parameters.AddWithValue("@bitis_tarihi", bitis_tarihi);
                    command.Parameters.AddWithValue("@bitis_tahmini", bitis_tahmini);
                    command.Parameters.AddWithValue("@baslangic_tahmini", baslangic_tahmini);
                    command.Parameters.AddWithValue("@proje_durumu", proje_durumu);
                    command.Parameters.AddWithValue("@parasal_getiri", parasal_getiri); // Örnek olarak decimal bir tür kullanıldı
                    command.Parameters.AddWithValue("@parasal_getiri_tipi", parasal_getiri_tipi);
                    command.Parameters.AddWithValue("@proje_tipi", proje_tipi);

                    try
                    {
                        insertedId = Convert.ToInt32(command.ExecuteScalar());
                        Console.WriteLine("Inserted ID: " + insertedId);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata oluştu: " + ex.Message);
                    }


                }
            }
            return insertedId;
        }

        public static void UpdateProject(
    int id,
    string proje_ismi,
    string stratejik_etki,
    int proje_yurutucu,
    string amac,
    string problem_tanimi,
    string kapsam,
    DateTime kayit_tarihi,
    DateTime baslangic_tarihi,
    DateTime bitis_tarihi,
    DateTime bitis_tahmini,
    DateTime baslangic_tahmini,
    int proje_durumu,
    decimal parasal_getiri,
    int parasal_getiri_tipi,
    int proje_tipi)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Proje " +
                                     "SET proje_ismi = @proje_ismi, " +
                                     "stratejik_etki = @stratejik_etki, " +
                                     "proje_yurutucu = @proje_yurutucu, " +
                                     "amac = @amac, " +
                                     "problem_tanimi = @problem_tanimi, " +
                                     "kapsam = @kapsam, " +
                                     "kayit_tarihi = @kayit_tarihi, " +
                                     "baslangic_tarihi = @baslangic_tarihi, " +
                                     "bitis_tarihi = @bitis_tarihi, " +
                                     "bitis_tahmini = @bitis_tahmini, " +
                                     "baslangic_tahmini = @baslangic_tahmini, " +
                                     "proje_durumu = @proje_durumu, " +
                                     "parasal_getiri = @parasal_getiri, " +
                                     "parasal_getiri_tipi = @parasal_getiri_tipi, " +
                                     "proje_tipi = @proje_tipi " +
                                     "WHERE id = @id;";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@proje_ismi", proje_ismi);
                    command.Parameters.AddWithValue("@stratejik_etki", stratejik_etki);
                    command.Parameters.AddWithValue("@proje_yurutucu", proje_yurutucu);
                    command.Parameters.AddWithValue("@amac", amac);
                    command.Parameters.AddWithValue("@problem_tanimi", problem_tanimi);
                    command.Parameters.AddWithValue("@kapsam", kapsam);
                    command.Parameters.AddWithValue("@kayit_tarihi", kayit_tarihi);
                    command.Parameters.AddWithValue("@baslangic_tarihi", baslangic_tarihi);
                    command.Parameters.AddWithValue("@bitis_tarihi", bitis_tarihi);
                    command.Parameters.AddWithValue("@bitis_tahmini", bitis_tahmini);
                    command.Parameters.AddWithValue("@baslangic_tahmini", baslangic_tahmini);
                    command.Parameters.AddWithValue("@proje_durumu", proje_durumu);
                    command.Parameters.AddWithValue("@parasal_getiri", parasal_getiri);
                    command.Parameters.AddWithValue("@parasal_getiri_tipi", parasal_getiri_tipi);
                    command.Parameters.AddWithValue("@proje_tipi", proje_tipi);

                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Project updated successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error updating project: " + ex.Message);
                    }
                }
            }
        }

        public static Project GetProjectById(int id)
        {
            Project proje = new Project();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
                {
                    connection.Open();

                    string query = @"SELECT *
                                FROM 
                                    Proje
                                WHERE 
                                    [id] = @Id;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                proje.Id = Convert.ToInt32(reader["id"]);
                                proje.ProjeIsmi = reader["proje_ismi"].ToString();
                                proje.StratejikEtki = reader["stratejik_etki"].ToString();
                                proje.ProjeYurutucu = Convert.ToInt32(reader["proje_yurutucu"]);
                                proje.Amac = reader["amac"].ToString();
                                proje.ProblemTanimi = reader["problem_tanimi"].ToString();
                                proje.Kapsam = reader["kapsam"].ToString();
                                proje.KayitTarihi = Convert.ToDateTime(reader["kayit_tarihi"]);
                                proje.BaslangicTarihi = Convert.ToDateTime(reader["baslangic_tarihi"]);
                                proje.BitisTarihi = Convert.ToDateTime(reader["bitis_tarihi"]);
                                proje.BitisTahmini = Convert.ToDateTime(reader["bitis_tahmini"]);
                                proje.BaslangicTahmini = Convert.ToDateTime(reader["baslangic_tahmini"]);
                                proje.ProjeDurumu = Convert.ToInt32(reader["proje_durumu"]);
                                proje.ParasalGetiri = Convert.ToDecimal(reader["parasal_getiri"]);
                                proje.ParasalGetiriTipi = Convert.ToInt32(reader["parasal_getiri_tipi"]);
                                proje.ProjeTipi = Convert.ToInt32(reader["proje_tipi"]);
                                proje.ProjeNo = reader["proje_no"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata oluştu: " + ex.Message);
            }

            return proje;
        }

        public static DataTable getProjectWithManagerName()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Project ve Manager tablolarını birleştiren SQL sorgusu
                    string query = "SELECT P.id , P.proje_ismi, P.proje_no, P.baslangic_tarihi , " +
                        "P.bitis_tarihi, P.parasal_getiri , E.ad " +
                                   "FROM Proje P " +
                                   "INNER JOIN Employee E ON P.proje_yurutucu = E.Id";

                    // SqlCommand ve SqlDataAdapter kullanarak sorguyu çalıştır ve sonucu bir DataTable'a doldur
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata oluştu: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;
        }
    }
}
