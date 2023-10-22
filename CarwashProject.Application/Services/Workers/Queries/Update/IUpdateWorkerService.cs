using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Workers.Queries.Update;

public interface IUpdateWorkerService
{
   Task<ResultDto<UpdateWorkerDto>> Execute(UpdateWorkerDto updateWorkerDto);
}
