using ProjectManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

                    string selectQuery = "SELECT * FROM Durak Where proje_id = @projectId";

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
    }
}
