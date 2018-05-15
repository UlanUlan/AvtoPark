using AvtoPark.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvtoPark
{
    public class Generator
    {
        private Random rand = new Random();
        public bool GenerProject(ref List<Project> Projects, out string message)
        {
            try
            {
                if (Projects == null)
                    Projects = new List<Project>();
                Projects.Add(new Project() { Name = "Варваринский ГОК" });
                Projects[0].Machines = GenerMachine(out message);
                Projects.Add(new Project() { Name = "Карагандинская шахта" });
                Projects[1].Machines = GenerMachine(out message);
                Projects.Add(new Project() { Name = "СС ГОК" });
                Projects[2].Machines = GenerMachine(out message);

                message = "Проекты добавлены";
                return true;
            }
            catch (Exception ex)
            {

                message = ex.Message;
                return false;
            }
        }
        public List<Machine> GenerMachine(out string message)
        {
            List<Machine> Machines = new List<Machine>();
            for (int i = 0; i < 5; i++)
            {
                Machine machine = new Machine();
                machine.GodVypuska = DateTime.Now.AddMonths(rand.Next(10, 200) * -1);
                machine.GosNomer = rand.Next(1000, 9999);
                machine.Model = "Model" + rand.Next(1, 10);
                machine.TypeMachine = (TypeMachine)rand.Next(1, 3);
                machine.Components = GenerComponents(out message);
                Machines.Add(machine);
            }
            message = "Машина сгенерирована удачно";
            return Machines;
        }
        public List<Machine> GenerComponents(out string message)
        {
            List<Component> components = new List<Component>();
            for (int i = 0; i < 3; i++)
            {
                Component component = new Component();
                component.IdComponent = rand.Next();
                component.name = (Parts)rand.Next(1, 4);
                components.Add(component);
            }

    }
}
