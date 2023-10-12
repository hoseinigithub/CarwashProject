﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Domain.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }

        //RelationShips
        public ICollection<WorkerInService> WorkerInServices { get; set; }
    }
}