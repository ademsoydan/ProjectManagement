using Microsoft.Data.SqlClient;
using ProjectManagement.Entities;
using ProjectManagement.UserControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectManagement.Repositories
{
    public static class PersonRepository
    {
         
        public static void SavePerson(string ad, string soyad, string email, string telefon,string adres, DateTime dogumTarihi,string fotograf, string password)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Veritabanına ekleme sorgusu
                    string insertQuery = "INSERT INTO Employee (ad, soyad, email, telefon_numarasi, adres, dogum_tarihi, fotograf, password) " +
                                         "VALUES (@Ad, @Soyad, @Email, @TelefonNumarasi, @Adres, @DogumTarihi, @Fotograf, @Password)";

                    // SqlCommand ve SqlParameter kullanarak sorguyu hazırla
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Parametreleri belirle
                        command.Parameters.AddWithValue("@Ad", ad);
                        command.Parameters.AddWithValue("@Soyad", soyad);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@TelefonNumarasi", telefon);
                        command.Parameters.AddWithValue("@Adres", adres);
                        command.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                        command.Parameters.AddWithValue("@Fotograf", fotograf);
                        command.Parameters.AddWithValue("@Password", password);

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

        public static Employee FindById(int targetId)
        {
            
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT Id, ad, soyad, email, telefon_numarasi, adres,dogum_tarihi, fotograf, password FROM Employee WHERE Id = @TargetId";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Parametreyi belirle
                        command.Parameters.AddWithValue("@TargetId", targetId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Employee employee = new Employee()
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Ad = reader["Ad"].ToString(),
                                    Soyad = reader["Soyad"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    TelefonNumarasi = reader["telefon_numarasi"].ToString(),
                                    Adres = reader["Adres"].ToString(),
                                    DogumTarihi = Convert.ToDateTime(reader["dogum_tarihi"]),
                                    Fotograf = reader["fotograf"].ToString(),
                                    Password = reader["Password"].ToString()
                                };

                                return employee;
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

        public static BindingSource GetEmployeeList()
        {
            BindingSource bindingSource = new BindingSource();

            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM Employee";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
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

        public static bool UpdateEmployee(Employee updatedEmployee)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "UPDATE Employee SET Ad = @Ad, Soyad = @Soyad, Email = @Email, telefon_numarasi = @TelefonNumarasi, Adres = @Adres, Dogum_Tarihi = @DogumTarihi, Fotograf = @Fotograf, Password = @Password WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Parametreleri belirle
                        command.Parameters.AddWithValue("@Id", updatedEmployee.Id);
                        command.Parameters.AddWithValue("@Ad", updatedEmployee.Ad);
                        command.Parameters.AddWithValue("@Soyad", updatedEmployee.Soyad);
                        command.Parameters.AddWithValue("@Email", updatedEmployee.Email);
                        command.Parameters.AddWithValue("@TelefonNumarasi", updatedEmployee.TelefonNumarasi);
                        command.Parameters.AddWithValue("@Adres", updatedEmployee.Adres);
                        command.Parameters.AddWithValue("@DogumTarihi", updatedEmployee.DogumTarihi);
                        command.Parameters.AddWithValue("@Fotograf", updatedEmployee.Fotograf);
                        command.Parameters.AddWithValue("@Password", updatedEmployee.Password);

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

        public static bool DeleteById(int targetId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                try
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Employee WHERE Id = @TargetId";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Parametreyi belirle
                        command.Parameters.AddWithValue("@TargetId", targetId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Employee deleted successfully.");
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
                    MessageBox.Show("Veri silme hatası: " + ex.Message);
                }
            }

            return false;
        }

        public static Dictionary<int, string> GetEmployeeData()
        {
            Dictionary<int, string> employeeData = new Dictionary<int, string>();

            string query = "SELECT Id, ad FROM Employee";

            using (SqlConnection connection = new SqlConnection(ConnectionUtil.ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int employeeID = reader.GetInt32(0);
                            string employeeName = reader.GetString(1);

                            employeeData.Add(employeeID, employeeName);
                        }
                    }
                }
            }

            return employeeData;
        }
        #region
        //    private static List<Person> persons = new List<Person>();
        //    private static int id = 0;
        //    public static void MergePerson(Person person)
        //    {
        //        Person dbPerson = persons.FirstOrDefault(x => x.Id == person.Id);
        //        if (dbPerson == null)
        //        {
        //            person.Id = id;
        //            id++;
        //            persons.Add(person);
        //        }
        //        else
        //        {
        //            persons.Remove(dbPerson);
        //            persons.Add(person);
        //        }
        //    }
        //    public static List<Person> getAllPersons()
        //    {
        //        return persons;
        //    }
        //    public static void deleteperson(person person)
        //    {
        //        person dbperson = persons.firstordefault(x => x.ıd == person.ıd);
        //        if (dbperson == null)
        //        {
        //            return;
        //        }
        //        else
        //        {
        //            persons.remove(dbperson);
        //        }
        //    }
        #endregion
    }
}
