using CarwashProject.Common.Dto.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarwashProject.Application.Services.Calculations;

public interface ICalculations
{
   Task<ResultDto> Execute(int id);
}
