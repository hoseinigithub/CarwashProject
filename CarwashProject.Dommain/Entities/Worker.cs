using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Domain.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }   //انعام 

        //RelationShips

        public ICollection<WorkerInService> WorkerInServices { get; set; }
    }
}
