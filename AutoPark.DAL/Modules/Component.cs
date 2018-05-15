using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark.Modules
{
    public enum  Parts { Engine = 1, KPP, Transmission}
    public class Component
    {
        public Component()
        {
             
        }
        public Parts name { get; set; }
        public int IdComponent { get; set; }
    }
}
