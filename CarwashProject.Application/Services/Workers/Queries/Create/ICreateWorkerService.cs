using CarwashProject.Application.Services.Workers.Queries.Create;
using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Workers.Queries.CreateWorker;

public interface ICreateWorkerService
{
   Task<ResultDto<CreateWorkerDto>> Execute(CreateWorkerDto worker);
}
