using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Entities
{
    public  class TreeResponse
    {
        public Project Proje { get; set; }

        public Point Point { get; set; }

        public ProjectTask Task { get; set; }
    }
}
