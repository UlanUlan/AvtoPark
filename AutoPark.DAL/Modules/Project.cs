using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark.Modules
{
    public class Project
    {
        public string Name { get; set; }
        public List<Machine> Machines = new List<Machine>();
    }
}
