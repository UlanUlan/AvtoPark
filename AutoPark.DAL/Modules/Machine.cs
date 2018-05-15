using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark.Modules
{
    public enum TypeMachine { Ecscovator = 1, Grader, Traktor }
    public class Machine
    {
        public string Model { get; set; }
        public DateTime GodVypuska { get; set; }
        public TypeMachine TypeMachine { get; set; }
        public int GosNomer { get; set; }
        public List<Component> Components = new List<Component>();
    }
}
