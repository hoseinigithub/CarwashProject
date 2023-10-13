using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Domain.Entities;

public class WorkerInKhadamat
{
    public int Id { get; set; }

    //RelationShipsWorker

    public int WorkerId { get; set; }
    public Worker Worker { get; set; }

    //RelationShipsService

    public int KhadamatId { get; set; }
    public Khadamat Khadamat { get; set; }
};