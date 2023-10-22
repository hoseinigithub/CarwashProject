﻿using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Workers.Queries.Delete;

public interface IDeleteWorkerService
{
   Task<ResultDto> Execute(int id);
}
