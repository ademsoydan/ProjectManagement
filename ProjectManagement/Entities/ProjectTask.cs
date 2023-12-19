using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Entities
{
    public class ProjectTask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int Status { get; set; }
        public int employeeId { get; set; }
        public int pointId { get; set; }
    }
}
