using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Domain.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ManifacturingEnum Manifacturing { get; set; }

        public enum ManifacturingEnum
        {
            InsideIran,
            OutsideIran
        }
    }
}
