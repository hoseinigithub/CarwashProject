using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Domain.Entities;

public class WorkerInService
{
    public int Id { get; set; }

    //RelationShipsWorker

    public int WorkerId { get; set; }
    public Worker Worker { get; set; }

    //RelationShipsService

    public int ServiceId { get; set; }
    public Service Services { get; set; }
};