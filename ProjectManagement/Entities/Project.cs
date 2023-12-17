using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string ProjeIsmi { get; set; }
        public string ProjeNo { get; set; }
        public int ProjeYurutucu { get; set; }
        public string Amac { get; set; }
        public string StratejikEtki { get; set; }
        public string ProblemTanimi { get; set; }
        public string Kapsam { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public DateTime BaslangicTahmini { get; set; }
        public DateTime BitisTahmini { get; set; }
        public int ProjeDurumu { get; set; }
        public int ProjeTipi { get; set; }

        public decimal ParasalGetiri { get; set; }
        public int ParasalGetiriTipi { get; set; }

        public Project() { }

       
    }


}
